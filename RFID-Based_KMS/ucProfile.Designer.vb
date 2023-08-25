<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProfile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOCOURSEANDSEC = New System.Windows.Forms.ComboBox()
        Me.CBOCOLLEGE = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCONTACT = New System.Windows.Forms.TextBox()
        Me.TXTFNAME = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.CBOBORROWERSTYPE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTLNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTMNAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PicFar = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTIDTAG = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVPROFILE = New System.Windows.Forms.DataGridView()
        Me.IdtagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerstypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseandsectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilepictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblborrowersprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TXTPBLANK = New System.Windows.Forms.TextBox()
        Me.TIMERMSG = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBrowsePic = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Tbl_borrowersprofileTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_borrowersprofileTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVPROFILE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblborrowersprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.lblHead2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 38)
        Me.Panel1.TabIndex = 49
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(842, 8)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(23, 22)
        Me.lblClose.TabIndex = 68
        Me.lblClose.Text = "X"
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.White
        Me.lblHead2.Location = New System.Drawing.Point(48, 8)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(83, 22)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "PROFILE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(544, 63)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(284, 140)
        Me.Panel5.TabIndex = 53
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.FlatAppearance.BorderSize = 0
        Me.BTNSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(149, 24)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(120, 40)
        Me.BTNSAVE.TabIndex = 5
        Me.BTNSAVE.Text = "SAVE"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'BTNADD
        '
        Me.BTNADD.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNADD.FlatAppearance.BorderSize = 0
        Me.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNADD.ForeColor = System.Drawing.Color.White
        Me.BTNADD.Location = New System.Drawing.Point(19, 24)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(120, 40)
        Me.BTNADD.TabIndex = 3
        Me.BTNADD.Text = "ADD"
        Me.BTNADD.UseVisualStyleBackColor = False
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNCANCEL.Enabled = False
        Me.BTNCANCEL.FlatAppearance.BorderSize = 0
        Me.BTNCANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(149, 74)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(120, 40)
        Me.BTNCANCEL.TabIndex = 7
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'BTNEDIT
        '
        Me.BTNEDIT.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNEDIT.FlatAppearance.BorderSize = 0
        Me.BTNEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.BTNEDIT.Location = New System.Drawing.Point(20, 74)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(120, 40)
        Me.BTNEDIT.TabIndex = 4
        Me.BTNEDIT.Text = "EDIT"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOCOURSEANDSEC)
        Me.Panel4.Controls.Add(Me.CBOCOLLEGE)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TXTCONTACT)
        Me.Panel4.Controls.Add(Me.TXTFNAME)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.CBOSTATUS)
        Me.Panel4.Controls.Add(Me.CBOBORROWERSTYPE)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TXTLNAME)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTMNAME)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(39, 175)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(348, 284)
        Me.Panel4.TabIndex = 50
        '
        'CBOCOURSEANDSEC
        '
        Me.CBOCOURSEANDSEC.Enabled = False
        Me.CBOCOURSEANDSEC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCOURSEANDSEC.FormattingEnabled = True
        Me.CBOCOURSEANDSEC.Location = New System.Drawing.Point(151, 179)
        Me.CBOCOURSEANDSEC.Name = "CBOCOURSEANDSEC"
        Me.CBOCOURSEANDSEC.Size = New System.Drawing.Size(171, 25)
        Me.CBOCOURSEANDSEC.TabIndex = 47
        '
        'CBOCOLLEGE
        '
        Me.CBOCOLLEGE.Enabled = False
        Me.CBOCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCOLLEGE.FormattingEnabled = True
        Me.CBOCOLLEGE.Location = New System.Drawing.Point(151, 146)
        Me.CBOCOLLEGE.Name = "CBOCOLLEGE"
        Me.CBOCOLLEGE.Size = New System.Drawing.Size(171, 25)
        Me.CBOCOLLEGE.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(21, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Contact Number"
        '
        'TXTCONTACT
        '
        Me.TXTCONTACT.Enabled = False
        Me.TXTCONTACT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCONTACT.Location = New System.Drawing.Point(151, 210)
        Me.TXTCONTACT.Name = "TXTCONTACT"
        Me.TXTCONTACT.Size = New System.Drawing.Size(171, 22)
        Me.TXTCONTACT.TabIndex = 44
        '
        'TXTFNAME
        '
        Me.TXTFNAME.Enabled = False
        Me.TXTFNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFNAME.Location = New System.Drawing.Point(151, 18)
        Me.TXTFNAME.Name = "TXTFNAME"
        Me.TXTFNAME.Size = New System.Drawing.Size(171, 22)
        Me.TXTFNAME.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(21, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Course and Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(23, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Status"
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.Enabled = False
        Me.CBOSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(151, 239)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(171, 25)
        Me.CBOSTATUS.TabIndex = 38
        '
        'CBOBORROWERSTYPE
        '
        Me.CBOBORROWERSTYPE.Enabled = False
        Me.CBOBORROWERSTYPE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOBORROWERSTYPE.FormattingEnabled = True
        Me.CBOBORROWERSTYPE.Items.AddRange(New Object() {"Faculty", "Staff", "Student"})
        Me.CBOBORROWERSTYPE.Location = New System.Drawing.Point(151, 113)
        Me.CBOBORROWERSTYPE.Name = "CBOBORROWERSTYPE"
        Me.CBOBORROWERSTYPE.Size = New System.Drawing.Size(171, 25)
        Me.CBOBORROWERSTYPE.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(21, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "College"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(23, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Borrowers Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(21, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Last Name"
        '
        'TXTLNAME
        '
        Me.TXTLNAME.Enabled = False
        Me.TXTLNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLNAME.Location = New System.Drawing.Point(151, 83)
        Me.TXTLNAME.Name = "TXTLNAME"
        Me.TXTLNAME.Size = New System.Drawing.Size(171, 22)
        Me.TXTLNAME.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Middle Name"
        '
        'TXTMNAME
        '
        Me.TXTMNAME.Enabled = False
        Me.TXTMNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMNAME.Location = New System.Drawing.Point(151, 53)
        Me.TXTMNAME.Name = "TXTMNAME"
        Me.TXTMNAME.Size = New System.Drawing.Size(171, 22)
        Me.TXTMNAME.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "First Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TXTIDTAG)
        Me.Panel2.Location = New System.Drawing.Point(39, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 105)
        Me.Panel2.TabIndex = 51
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel6.Controls.Add(Me.PicClose)
        Me.Panel6.Controls.Add(Me.PicFar)
        Me.Panel6.Location = New System.Drawing.Point(13, 9)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(116, 88)
        Me.Panel6.TabIndex = 49
        '
        'PicClose
        '
        Me.PicClose.Image = Global.RFID_Based_KMS.My.Resources.Resources.transclose
        Me.PicClose.Location = New System.Drawing.Point(4, -4)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(108, 81)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicClose.TabIndex = 1
        Me.PicClose.TabStop = False
        Me.PicClose.Visible = False
        '
        'PicFar
        '
        Me.PicFar.Image = Global.RFID_Based_KMS.My.Resources.Resources.transfar
        Me.PicFar.Location = New System.Drawing.Point(4, -4)
        Me.PicFar.Name = "PicFar"
        Me.PicFar.Size = New System.Drawing.Size(108, 81)
        Me.PicFar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFar.TabIndex = 0
        Me.PicFar.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(144, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Tap your Smart Card"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(210, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ID Tag"
        '
        'TXTIDTAG
        '
        Me.TXTIDTAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTIDTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTIDTAG.Enabled = False
        Me.TXTIDTAG.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIDTAG.Location = New System.Drawing.Point(138, 40)
        Me.TXTIDTAG.Name = "TXTIDTAG"
        Me.TXTIDTAG.Size = New System.Drawing.Size(188, 33)
        Me.TXTIDTAG.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.DGVPROFILE)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TXTSEARCH)
        Me.Panel3.Location = New System.Drawing.Point(393, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 249)
        Me.Panel3.TabIndex = 52
        '
        'DGVPROFILE
        '
        Me.DGVPROFILE.AllowUserToAddRows = False
        Me.DGVPROFILE.AllowUserToDeleteRows = False
        Me.DGVPROFILE.AutoGenerateColumns = False
        Me.DGVPROFILE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPROFILE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtagDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.BorrowerstypeDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.CourseandsectionDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ProfilepictureDataGridViewImageColumn})
        Me.DGVPROFILE.DataSource = Me.TblborrowersprofileBindingSource
        Me.DGVPROFILE.Location = New System.Drawing.Point(16, 49)
        Me.DGVPROFILE.Name = "DGVPROFILE"
        Me.DGVPROFILE.ReadOnly = True
        Me.DGVPROFILE.Size = New System.Drawing.Size(404, 184)
        Me.DGVPROFILE.TabIndex = 35
        '
        'IdtagDataGridViewTextBoxColumn
        '
        Me.IdtagDataGridViewTextBoxColumn.DataPropertyName = "idtag"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.IdtagDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdtagDataGridViewTextBoxColumn.HeaderText = "ID Tag"
        Me.IdtagDataGridViewTextBoxColumn.Name = "IdtagDataGridViewTextBoxColumn"
        Me.IdtagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.FirstnameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.MiddlenameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.LastnameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowerstypeDataGridViewTextBoxColumn
        '
        Me.BorrowerstypeDataGridViewTextBoxColumn.DataPropertyName = "borrowerstype"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.BorrowerstypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BorrowerstypeDataGridViewTextBoxColumn.HeaderText = "Borrower Type"
        Me.BorrowerstypeDataGridViewTextBoxColumn.Name = "BorrowerstypeDataGridViewTextBoxColumn"
        Me.BorrowerstypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.CollegeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseandsectionDataGridViewTextBoxColumn
        '
        Me.CourseandsectionDataGridViewTextBoxColumn.DataPropertyName = "courseandsection"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.CourseandsectionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.CourseandsectionDataGridViewTextBoxColumn.HeaderText = "Course & Section"
        Me.CourseandsectionDataGridViewTextBoxColumn.Name = "CourseandsectionDataGridViewTextBoxColumn"
        Me.CourseandsectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "contactno"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.ContactnoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "Contact No."
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProfilepictureDataGridViewImageColumn
        '
        Me.ProfilepictureDataGridViewImageColumn.DataPropertyName = "profilepicture"
        Me.ProfilepictureDataGridViewImageColumn.HeaderText = "Profile Picture"
        Me.ProfilepictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ProfilepictureDataGridViewImageColumn.Name = "ProfilepictureDataGridViewImageColumn"
        Me.ProfilepictureDataGridViewImageColumn.ReadOnly = True
        Me.ProfilepictureDataGridViewImageColumn.Width = 50
        '
        'TblborrowersprofileBindingSource
        '
        Me.TblborrowersprofileBindingSource.DataMember = "tbl_borrowersprofile"
        Me.TblborrowersprofileBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(16, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Search:"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(74, 19)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(344, 20)
        Me.TXTSEARCH.TabIndex = 34
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'TXTPBLANK
        '
        Me.TXTPBLANK.Location = New System.Drawing.Point(266, 68)
        Me.TXTPBLANK.Name = "TXTPBLANK"
        Me.TXTPBLANK.Size = New System.Drawing.Size(100, 20)
        Me.TXTPBLANK.TabIndex = 54
        '
        'TIMERMSG
        '
        Me.TIMERMSG.Enabled = True
        Me.TIMERMSG.Interval = 50
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.MintCream
        Me.Panel7.Controls.Add(Me.btnBrowsePic)
        Me.Panel7.Controls.Add(Me.picProfile)
        Me.Panel7.Location = New System.Drawing.Point(393, 63)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(145, 140)
        Me.Panel7.TabIndex = 55
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBrowsePic.Enabled = False
        Me.btnBrowsePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowsePic.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePic.ForeColor = System.Drawing.Color.White
        Me.btnBrowsePic.Location = New System.Drawing.Point(11, 111)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(126, 26)
        Me.btnBrowsePic.TabIndex = 135
        Me.btnBrowsePic.Text = "Browse Picture"
        Me.btnBrowsePic.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.DimGray
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(19, 5)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(107, 103)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 134
        Me.picProfile.TabStop = False
        '
        'Tbl_borrowersprofileTableAdapter
        '
        Me.Tbl_borrowersprofileTableAdapter.ClearBeforeFill = True
        '
        'ucProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXTPBLANK)
        Me.Name = "ucProfile"
        Me.Size = New System.Drawing.Size(876, 509)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVPROFILE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblborrowersprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBOSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents CBOBORROWERSTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTLNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTMNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTIDTAG As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents TXTFNAME As System.Windows.Forms.TextBox
    Friend WithEvents PicFar As System.Windows.Forms.PictureBox
    Friend WithEvents PicClose As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTCONTACT As System.Windows.Forms.TextBox
    Friend WithEvents TXTPBLANK As System.Windows.Forms.TextBox
    Friend WithEvents TIMERMSG As System.Windows.Forms.Timer
    Friend WithEvents DGVPROFILE As System.Windows.Forms.DataGridView
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents CBOCOLLEGE As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCOURSEANDSEC As System.Windows.Forms.ComboBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnBrowsePic As System.Windows.Forms.Button
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents TblborrowersprofileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_borrowersprofileTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_borrowersprofileTableAdapter
    Friend WithEvents IdtagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerstypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseandsectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfilepictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn

End Class
