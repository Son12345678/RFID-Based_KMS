<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAdminMenu
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
        Me.LblUsertype = New System.Windows.Forms.Label()
        Me.lblHead1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DEFAULTLOGO = New System.Windows.Forms.PictureBox()
        Me.COBLOGO = New System.Windows.Forms.PictureBox()
        Me.COALOGO = New System.Windows.Forms.PictureBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.CCSLOGO = New System.Windows.Forms.PictureBox()
        Me.URS = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAcountName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbld = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.BTNItemTransaction = New System.Windows.Forms.Button()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.TbluseraccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_useraccTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_useraccTableAdapter()
        Me.TbluseraccBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.DEFAULTLOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COBLOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COALOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCSLOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.URS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluseraccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluseraccBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsertype
        '
        Me.LblUsertype.AutoSize = True
        Me.LblUsertype.BackColor = System.Drawing.Color.Transparent
        Me.LblUsertype.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsertype.ForeColor = System.Drawing.Color.White
        Me.LblUsertype.Location = New System.Drawing.Point(10, 65)
        Me.LblUsertype.Name = "LblUsertype"
        Me.LblUsertype.Size = New System.Drawing.Size(53, 22)
        Me.LblUsertype.TabIndex = 68
        Me.LblUsertype.Text = "USER"
        '
        'lblHead1
        '
        Me.lblHead1.AutoSize = True
        Me.lblHead1.BackColor = System.Drawing.Color.Transparent
        Me.lblHead1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead1.ForeColor = System.Drawing.Color.White
        Me.lblHead1.Location = New System.Drawing.Point(105, 9)
        Me.lblHead1.Name = "lblHead1"
        Me.lblHead1.Size = New System.Drawing.Size(375, 23)
        Me.lblHead1.TabIndex = 66
        Me.lblHead1.Text = "University of Rizal System - Binangonan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(105, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(322, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "RFID-BASED KEY MONITORING SYSTEM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.DEFAULTLOGO)
        Me.Panel3.Controls.Add(Me.COBLOGO)
        Me.Panel3.Controls.Add(Me.COALOGO)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblClose)
        Me.Panel3.Controls.Add(Me.CCSLOGO)
        Me.Panel3.Controls.Add(Me.URS)
        Me.Panel3.Controls.Add(Me.lblHead1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1078, 62)
        Me.Panel3.TabIndex = 4
        '
        'DEFAULTLOGO
        '
        Me.DEFAULTLOGO.Image = Global.RFID_Based_KMS.My.Resources.Resources.URSBfinal
        Me.DEFAULTLOGO.Location = New System.Drawing.Point(44, 6)
        Me.DEFAULTLOGO.Name = "DEFAULTLOGO"
        Me.DEFAULTLOGO.Size = New System.Drawing.Size(64, 51)
        Me.DEFAULTLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DEFAULTLOGO.TabIndex = 71
        Me.DEFAULTLOGO.TabStop = False
        Me.DEFAULTLOGO.Visible = False
        '
        'COBLOGO
        '
        Me.COBLOGO.Image = Global.RFID_Based_KMS.My.Resources.Resources.COB
        Me.COBLOGO.Location = New System.Drawing.Point(52, 9)
        Me.COBLOGO.Name = "COBLOGO"
        Me.COBLOGO.Size = New System.Drawing.Size(46, 46)
        Me.COBLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.COBLOGO.TabIndex = 70
        Me.COBLOGO.TabStop = False
        Me.COBLOGO.Visible = False
        '
        'COALOGO
        '
        Me.COALOGO.BackColor = System.Drawing.Color.Transparent
        Me.COALOGO.Image = Global.RFID_Based_KMS.My.Resources.Resources.COA
        Me.COALOGO.Location = New System.Drawing.Point(54, 8)
        Me.COALOGO.Name = "COALOGO"
        Me.COALOGO.Size = New System.Drawing.Size(46, 46)
        Me.COALOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.COALOGO.TabIndex = 0
        Me.COALOGO.TabStop = False
        Me.COALOGO.Visible = False
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
        'CCSLOGO
        '
        Me.CCSLOGO.Image = Global.RFID_Based_KMS.My.Resources.Resources.CCS_final
        Me.CCSLOGO.Location = New System.Drawing.Point(53, 8)
        Me.CCSLOGO.Name = "CCSLOGO"
        Me.CCSLOGO.Size = New System.Drawing.Size(46, 46)
        Me.CCSLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CCSLOGO.TabIndex = 0
        Me.CCSLOGO.TabStop = False
        Me.CCSLOGO.Visible = False
        '
        'URS
        '
        Me.URS.Image = Global.RFID_Based_KMS.My.Resources.Resources.URS
        Me.URS.Location = New System.Drawing.Point(3, 5)
        Me.URS.Name = "URS"
        Me.URS.Size = New System.Drawing.Size(54, 53)
        Me.URS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.URS.TabIndex = 0
        Me.URS.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblAcountName)
        Me.Panel1.Controls.Add(Me.LblUsertype)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 93)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.user2
        Me.PictureBox1.Location = New System.Drawing.Point(650, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(685, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Welcome"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAcountName
        '
        Me.lblAcountName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcountName.ForeColor = System.Drawing.Color.White
        Me.lblAcountName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAcountName.Location = New System.Drawing.Point(768, 65)
        Me.lblAcountName.Name = "lblAcountName"
        Me.lblAcountName.Size = New System.Drawing.Size(288, 23)
        Me.lblAcountName.TabIndex = 10
        Me.lblAcountName.Text = "Account Name"
        Me.lblAcountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlmain.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlmain.Location = New System.Drawing.Point(180, 106)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(876, 509)
        Me.pnlmain.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnSettings)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.BTNItemTransaction)
        Me.Panel2.Controls.Add(Me.btnTrans)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnAccount)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 585)
        Me.Panel2.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.lbld)
        Me.Panel5.Controls.Add(Me.lbltime)
        Me.Panel5.Controls.Add(Me.lbly)
        Me.Panel5.Controls.Add(Me.lblm)
        Me.Panel5.Location = New System.Drawing.Point(5, 447)
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
        Me.btnLogout.Location = New System.Drawing.Point(0, 400)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(161, 36)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "   LOG OUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.RFID_Based_KMS.My.Resources.Resources.SETTINGS
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 354)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(161, 36)
        Me.btnSettings.TabIndex = 14
        Me.btnSettings.Text = "   SETTINGS"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
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
        Me.btnReports.Location = New System.Drawing.Point(0, 309)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(161, 36)
        Me.btnReports.TabIndex = 14
        Me.btnReports.Text = "   REPORTS"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'BTNItemTransaction
        '
        Me.BTNItemTransaction.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNItemTransaction.FlatAppearance.BorderSize = 0
        Me.BTNItemTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNItemTransaction.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNItemTransaction.ForeColor = System.Drawing.Color.White
        Me.BTNItemTransaction.Image = Global.RFID_Based_KMS.My.Resources.Resources.item
        Me.BTNItemTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNItemTransaction.Location = New System.Drawing.Point(0, 216)
        Me.BTNItemTransaction.Name = "BTNItemTransaction"
        Me.BTNItemTransaction.Size = New System.Drawing.Size(161, 36)
        Me.BTNItemTransaction.TabIndex = 14
        Me.BTNItemTransaction.Text = "  ITEM TRANSACTION"
        Me.BTNItemTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNItemTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNItemTransaction.UseVisualStyleBackColor = False
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
        Me.btnTrans.Location = New System.Drawing.Point(0, 169)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(161, 36)
        Me.btnTrans.TabIndex = 14
        Me.btnTrans.Text = "  KEY TRANSACTION"
        Me.btnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTrans.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Image = Global.RFID_Based_KMS.My.Resources.Resources.profile
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.Location = New System.Drawing.Point(0, 124)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(161, 36)
        Me.btnProfile.TabIndex = 14
        Me.btnProfile.Text = "   PROFILE"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.Image = Global.RFID_Based_KMS.My.Resources.Resources.admin
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(0, 263)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(161, 36)
        Me.btnAccount.TabIndex = 14
        Me.btnAccount.Text = "   ACCOUNT"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = False
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
        Me.btnHome.Location = New System.Drawing.Point(0, 79)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(161, 36)
        Me.btnHome.TabIndex = 14
        Me.btnHome.Text = "   DASHBOARD"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(492, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Label5"
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbluseraccBindingSource
        '
        Me.TbluseraccBindingSource.DataMember = "tbl_useracc"
        Me.TbluseraccBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Tbl_useraccTableAdapter
        '
        Me.Tbl_useraccTableAdapter.ClearBeforeFill = True
        '
        'TbluseraccBindingSource1
        '
        Me.TbluseraccBindingSource1.DataMember = "tbl_useracc"
        Me.TbluseraccBindingSource1.DataSource = Me.Db_kmsDataSet
        '
        'FRMAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 632)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FRMAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DEFAULTLOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COBLOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COALOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCSLOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.URS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluseraccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluseraccBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsertype As System.Windows.Forms.Label
    Friend WithEvents lblHead1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlmain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents lblAcountName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents URS As System.Windows.Forms.PictureBox
    Friend WithEvents CCSLOGO As System.Windows.Forms.PictureBox
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbld As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents BTNItemTransaction As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents TbluseraccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_useraccTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_useraccTableAdapter
    Friend WithEvents TbluseraccBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COALOGO As System.Windows.Forms.PictureBox
    Friend WithEvents COBLOGO As System.Windows.Forms.PictureBox
    Friend WithEvents DEFAULTLOGO As System.Windows.Forms.PictureBox

End Class
