<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txbAdress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.ColorChange = New System.Windows.Forms.Timer(Me.components)
        Me.WinFormsBrowserView1 = New DotNetBrowser.WinForms.WinFormsBrowserView()
        Me.barMax = New System.Windows.Forms.Button()
        Me.barExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.barMin = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbAdress
        '
        Me.txbAdress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbAdress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAdress.ForeColor = System.Drawing.Color.Gray
        Me.txbAdress.Location = New System.Drawing.Point(170, 14)
        Me.txbAdress.Name = "txbAdress"
        Me.txbAdress.Size = New System.Drawing.Size(717, 28)
        Me.txbAdress.TabIndex = 1
        Me.txbAdress.Text = "Search"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(93, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "⟳"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(47, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 46)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "👉 "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(914, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 46)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "✲"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 9
        '
        'tmrStatus
        '
        Me.tmrStatus.Enabled = True
        '
        'ColorChange
        '
        Me.ColorChange.Enabled = True
        '
        'WinFormsBrowserView1
        '
        Me.WinFormsBrowserView1.AcceptLanguage = Nothing
        Me.WinFormsBrowserView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WinFormsBrowserView1.AudioMuted = Nothing
        Me.WinFormsBrowserView1.BrowserType = DotNetBrowser.BrowserType.HEAVYWEIGHT
        Me.WinFormsBrowserView1.InitialFocusOwner = True
        Me.WinFormsBrowserView1.Location = New System.Drawing.Point(1, 81)
        Me.WinFormsBrowserView1.Name = "WinFormsBrowserView1"
        Me.WinFormsBrowserView1.Preferences = Nothing
        Me.WinFormsBrowserView1.Size = New System.Drawing.Size(999, 519)
        Me.WinFormsBrowserView1.TabIndex = 10
        Me.WinFormsBrowserView1.URL = Nothing
        Me.WinFormsBrowserView1.ZoomLevel = Nothing
        '
        'barMax
        '
        Me.barMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.barMax.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barMax.ForeColor = System.Drawing.Color.White
        Me.barMax.Location = New System.Drawing.Point(929, -1)
        Me.barMax.Name = "barMax"
        Me.barMax.Size = New System.Drawing.Size(35, 35)
        Me.barMax.TabIndex = 15
        Me.barMax.Text = "⬜"
        Me.barMax.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.barMax.UseVisualStyleBackColor = False
        '
        'barExit
        '
        Me.barExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.barExit.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barExit.ForeColor = System.Drawing.Color.White
        Me.barExit.Location = New System.Drawing.Point(965, -1)
        Me.barExit.Name = "barExit"
        Me.barExit.Size = New System.Drawing.Size(35, 35)
        Me.barExit.TabIndex = 14
        Me.barExit.Text = "X"
        Me.barExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.barExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "🌐"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(952, 30)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 45)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "☰ "
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 46)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "👈"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'barMin
        '
        Me.barMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.barMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.barMin.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barMin.ForeColor = System.Drawing.Color.White
        Me.barMin.Location = New System.Drawing.Point(893, -1)
        Me.barMin.Name = "barMin"
        Me.barMin.Size = New System.Drawing.Size(35, 35)
        Me.barMin.TabIndex = 16
        Me.barMin.Text = "⬜"
        Me.barMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.barMin.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(878, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.barExit)
        Me.Controls.Add(Me.barMax)
        Me.Controls.Add(Me.barMin)
        Me.Controls.Add(Me.txbAdress)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WinFormsBrowserView1)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Form1"
        Me.Text = "Memeium Beta V 0.7.7.8"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbAdress As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrStatus As Timer
    Friend WithEvents ColorChange As Timer
    Friend WithEvents WinFormsBrowserView1 As DotNetBrowser.WinForms.WinFormsBrowserView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents barMax As Button
    Friend WithEvents barExit As Button
    Friend WithEvents barMin As Button
    Friend WithEvents Button4 As Button
End Class
