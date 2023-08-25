<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMGUARDMENU
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblutype = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGuardAcountName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblHead1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbld = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlguardmain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.lblutype)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblGuardAcountName)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 93)
        Me.Panel1.TabIndex = 7
        '
        'lblutype
        '
        Me.lblutype.BackColor = System.Drawing.Color.Transparent
        Me.lblutype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblutype.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutype.ForeColor = System.Drawing.Color.White
        Me.lblutype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblutype.Location = New System.Drawing.Point(12, 65)
        Me.lblutype.Name = "lblutype"
        Me.lblutype.Size = New System.Drawing.Size(112, 23)
        Me.lblutype.TabIndex = 11
        Me.lblutype.Text = "Welcome"
        Me.lblutype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.user2
        Me.PictureBox1.Location = New System.Drawing.Point(479, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(513, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Welcome"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGuardAcountName
        '
        Me.lblGuardAcountName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardAcountName.ForeColor = System.Drawing.Color.White
        Me.lblGuardAcountName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblGuardAcountName.Location = New System.Drawing.Point(585, 64)
        Me.lblGuardAcountName.Name = "lblGuardAcountName"
        Me.lblGuardAcountName.Size = New System.Drawing.Size(234, 23)
        Me.lblGuardAcountName.TabIndex = 10
        Me.lblGuardAcountName.Text = "Account Name"
        Me.lblGuardAcountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblClose)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.lblHead1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(815, 61)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RFID_Based_KMS.My.Resources.Resources.URSBfinal
        Me.PictureBox3.Location = New System.Drawing.Point(46, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(786, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 22)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(115, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(322, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "RFID-BASED KEY MONITORING SYSTEM"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1043, 12)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(23, 22)
        Me.lblClose.TabIndex = 69
        Me.lblClose.Text = "X"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RFID_Based_KMS.My.Resources.Resources.URS
        Me.PictureBox2.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lblHead1
        '
        Me.lblHead1.AutoSize = True
        Me.lblHead1.BackColor = System.Drawing.Color.Transparent
        Me.lblHead1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead1.ForeColor = System.Drawing.Color.White
        Me.lblHead1.Location = New System.Drawing.Point(115, 9)
        Me.lblHead1.Name = "lblHead1"
        Me.lblHead1.Size = New System.Drawing.Size(375, 23)
        Me.lblHead1.TabIndex = 66
        Me.lblHead1.Text = "University of Rizal System - Binangonan"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(481, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(507, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "COLLEGE NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIVERSITY OF RIZAL SYSTEM BINANGONAN  -"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.btnTrans)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 359)
        Me.Panel2.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.lbld)
        Me.Panel5.Controls.Add(Me.lbltime)
        Me.Panel5.Controls.Add(Me.lbly)
        Me.Panel5.Controls.Add(Me.lblm)
        Me.Panel5.Location = New System.Drawing.Point(6, 216)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(146, 120)
        Me.Panel5.TabIndex = 16
        '
        'lbld
        '
        Me.lbld.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld.ForeColor = System.Drawing.Color.White
        Me.lbld.Location = New System.Drawing.Point(8, 29)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(130, 37)
        Me.lbld.TabIndex = 11
        Me.lbld.Text = "00"
        Me.lbld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltime
        '
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(8, 89)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(130, 23)
        Me.lbltime.TabIndex = 12
        Me.lbltime.Text = "HH:MM:SS"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbly
        '
        Me.lbly.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbly.ForeColor = System.Drawing.Color.White
        Me.lbly.Location = New System.Drawing.Point(8, 60)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(130, 23)
        Me.lbly.TabIndex = 13
        Me.lbly.Text = "2021"
        Me.lbly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblm
        '
        Me.lblm.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.ForeColor = System.Drawing.Color.White
        Me.lblm.Location = New System.Drawing.Point(8, 10)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(130, 23)
        Me.lblm.TabIndex = 14
        Me.lblm.Text = "January "
        Me.lblm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.RFID_Based_KMS.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-1, 154)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(161, 36)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "   LOG OUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.RFID_Based_KMS.My.Resources.Resources.reports
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 107)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(161, 36)
        Me.btnReports.TabIndex = 14
        Me.btnReports.Text = "   REPORTS"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnTrans
        '
        Me.btnTrans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTrans.FlatAppearance.BorderSize = 0
        Me.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrans.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrans.ForeColor = System.Drawing.Color.White
        Me.btnTrans.Image = Global.RFID_Based_KMS.My.Resources.Resources.transaction
        Me.btnTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrans.Location = New System.Drawing.Point(0, 63)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(161, 36)
        Me.btnTrans.TabIndex = 14
        Me.btnTrans.Text = "  KEY TRANSACTION"
        Me.btnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTrans.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.RFID_Based_KMS.My.Resources.Resources.home
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 20)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(161, 36)
        Me.btnHome.TabIndex = 14
        Me.btnHome.Text = "   HOME"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(590, 3)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(326, 36)
        Me.lbldate.TabIndex = 13
        Me.lbldate.Text = "Date"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label3.Location = New System.Drawing.Point(822, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "You are login as"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(675, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "USERNAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlguardmain
        '
        Me.pnlguardmain.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlguardmain.Location = New System.Drawing.Point(166, 99)
        Me.pnlguardmain.Name = "pnlguardmain"
        Me.pnlguardmain.Size = New System.Drawing.Size(637, 341)
        Me.pnlguardmain.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FRMGUARDMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlguardmain)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMGUARDMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGuardAcountName As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHead1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbld As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlguardmain As System.Windows.Forms.Panel
    Friend WithEvents lblutype As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
