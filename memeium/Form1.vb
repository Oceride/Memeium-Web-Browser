Imports System.Threading
Imports DotNetBrowser
Imports DotNetBrowser.WinForms

Public Class Form1
    '---------------------------
    '---------------------------


    Private Sub txbAdress_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbAdress.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim txtCheck = Mid(txbAdress.Text, 1, 7)
            If WinFormsBrowserView1.Visible = False Then
                WinFormsBrowserView1.Visible = True
            End If
            If txtCheck = "http://" Or txtCheck = "https:/" Then
                WinFormsBrowserView1.URL = txbAdress.Text
            Else
                If My.Settings.SE = "Google" Then
                    WinFormsBrowserView1.URL = (My.Settings.Google + txbAdress.Text)
                ElseIf My.Settings.SE = "Memeium" Then
                    WinFormsBrowserView1.URL = (My.Settings.Memium + txbAdress.Text + "&se=Search")
                End If
            End If
            txbAdress.Text = WinFormsBrowserView1.URL.ToString
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        WinFormsBrowserView1.BackForwardNavigator.Back()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WinFormsBrowserView1.BackForwardNavigator.Forward()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WinFormsBrowserView1.Refresh()
    End Sub



    Private Sub txbAdress_TextChanged(sender As Object, e As EventArgs) Handles txbAdress.Click
        If txbAdress.Text = "Search" Then
            txbAdress.Text = ""
        End If
        txbAdress.SelectionLength = Len(txbAdress.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        Dim txtCheck = Mid(WinFormsBrowserView1.URL.ToString, 1, 5)
        If txtCheck = "https" Then
            Label2.ForeColor = Color.MediumSeaGreen
        Else
            Label2.ForeColor = Color.Red
        End If
    End Sub

    Dim r As Integer = 0
    Dim g As Integer = 0
    Dim b As Integer = 0
    Dim Counter1 As Integer = 0
    Dim tf As Boolean = True
    Private Sub ColorChange_Tick(sender As Object, e As EventArgs) Handles ColorChange.Tick
        If Counter1 = 240 Then
            tf = False
        ElseIf Counter1 = 0 Then
            tf = True
        End If
        If tf = True Then
            r = r + 7
            g = g + 4
            b = b + 12
            Counter1 = Counter1 + 12
        ElseIf tf = False Then
            r = r - 7
            g = g - 4
            b = b - 12
            Counter1 = Counter1 - 12
        End If
        Button1.ForeColor = Color.FromArgb(r, g, b)
        Button2.ForeColor = Color.FromArgb(g, b, b)
        Button3.ForeColor = Color.FromArgb(b, g, g)
        Button5.ForeColor = Color.FromArgb(b, r, b)
        Button6.ForeColor = Color.FromArgb(b, r, g)
    End Sub


    Dim MaxMin As Boolean = True
    Private Sub barMax_Click(sender As Object, e As EventArgs) Handles barMax.Click
        If MaxMin = True Then
            barMax.Text = "🗗"
            MaxMin = False
            Me.WindowState = FormWindowState.Maximized
        ElseIf MaxMin = False Then
            barMax.Text = "⬜"
            MaxMin = True
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub barExit_Click(sender As Object, e As EventArgs) Handles barExit.Click
        Me.Close()
    End Sub

    Private Sub barMin_Click(sender As Object, e As EventArgs) Handles barMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    '________________________
    Dim inMenu As Boolean = True



    'Private Sub AddTab(pageUrl As String)
    'Dim tabPage1 As New TabPage()
    'Dim webBr As New WinForms.WinFormsBrowserView()

    'tabPage1.Text = pageUrl
    'TabControl1.TabPages.Add(tabPage1)
    'webBr.URL = txbAdress.Text
    'webBr.Parent = tabPage1
    'webBr.Dock = DockStyle.Fill

    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'AddTab(txbAdress.Text)
        'TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
    End Sub

    '________________________
End Class
