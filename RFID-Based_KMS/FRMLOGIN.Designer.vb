<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTUN = New System.Windows.Forms.TextBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.CHKSHOWPASS = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNEXIT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER LOGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(125, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Username"
        '
        'TXTUN
        '
        Me.TXTUN.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUN.Location = New System.Drawing.Point(200, 72)
        Me.TXTUN.Name = "TXTUN"
        Me.TXTUN.Size = New System.Drawing.Size(165, 22)
        Me.TXTUN.TabIndex = 21
        '
        'TXTPASS
        '
        Me.TXTPASS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.Location = New System.Drawing.Point(200, 111)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(165, 22)
        Me.TXTPASS.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(126, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Password"
        '
        'BTNLogin
        '
        Me.BTNLogin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNLogin.FlatAppearance.BorderSize = 0
        Me.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.ForeColor = System.Drawing.Color.White
        Me.BTNLogin.Location = New System.Drawing.Point(200, 174)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(165, 22)
        Me.BTNLogin.TabIndex = 26
        Me.BTNLogin.Text = "LOG IN"
        Me.BTNLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNLogin.UseVisualStyleBackColor = False
        '
        'CHKSHOWPASS
        '
        Me.CHKSHOWPASS.AutoSize = True
        Me.CHKSHOWPASS.BackColor = System.Drawing.Color.Transparent
        Me.CHKSHOWPASS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSHOWPASS.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CHKSHOWPASS.Location = New System.Drawing.Point(229, 136)
        Me.CHKSHOWPASS.Name = "CHKSHOWPASS"
        Me.CHKSHOWPASS.Size = New System.Drawing.Size(111, 20)
        Me.CHKSHOWPASS.TabIndex = 27
        Me.CHKSHOWPASS.Text = "Show Password"
        Me.CHKSHOWPASS.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.login2
        Me.PictureBox1.Location = New System.Drawing.Point(25, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'BTNEXIT
        '
        Me.BTNEXIT.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNEXIT.FlatAppearance.BorderSize = 0
        Me.BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEXIT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXIT.ForeColor = System.Drawing.Color.White
        Me.BTNEXIT.Location = New System.Drawing.Point(27, 174)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.Size = New System.Drawing.Size(165, 22)
        Me.BTNEXIT.TabIndex = 26
        Me.BTNEXIT.Text = "EXIT"
        Me.BTNEXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNEXIT.UseVisualStyleBackColor = False
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CHKSHOWPASS)
        Me.Controls.Add(Me.BTNEXIT)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTUN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTUN As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNLogin As System.Windows.Forms.Button
    Friend WithEvents CHKSHOWPASS As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNEXIT As System.Windows.Forms.Button
End Class
