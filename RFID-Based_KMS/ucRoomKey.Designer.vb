<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRoomKey
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
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PicFar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTKEYTAG = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVROOMKEYS = New System.Windows.Forms.DataGridView()
        Me.KeytagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyownershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeytypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblkeyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOROOMNUMBER = New System.Windows.Forms.ComboBox()
        Me.CBOKEYOWNERSHIP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.CBOKEYTYPE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOROOMCAT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.TXTRKBLANK = New System.Windows.Forms.TextBox()
        Me.MSGROOMKEY = New System.Windows.Forms.Timer(Me.components)
        Me.TblkeyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_keyTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keyTableAdapter()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVROOMKEYS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkeyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.TblkeyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.FlatAppearance.BorderSize = 0
        Me.BTNSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(89, 14)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(75, 40)
        Me.BTNSAVE.TabIndex = 5
        Me.BTNSAVE.Text = "SAVE"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNCANCEL.Enabled = False
        Me.BTNCANCEL.FlatAppearance.BorderSize = 0
        Me.BTNCANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(249, 14)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(75, 40)
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
        Me.BTNEDIT.Location = New System.Drawing.Point(169, 14)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(75, 40)
        Me.BTNEDIT.TabIndex = 4
        Me.BTNEDIT.Text = "EDIT"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'BTNADD
        '
        Me.BTNADD.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNADD.FlatAppearance.BorderSize = 0
        Me.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNADD.ForeColor = System.Drawing.Color.White
        Me.BTNADD.Location = New System.Drawing.Point(8, 14)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(75, 40)
        Me.BTNADD.TabIndex = 3
        Me.BTNADD.Text = "ADD"
        Me.BTNADD.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(17, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 65)
        Me.Panel5.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TXTKEYTAG)
        Me.Panel2.Location = New System.Drawing.Point(17, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 117)
        Me.Panel2.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(137, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tap the Key Tag"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel6.Controls.Add(Me.PicClose)
        Me.Panel6.Controls.Add(Me.PicFar)
        Me.Panel6.Location = New System.Drawing.Point(9, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(116, 88)
        Me.Panel6.TabIndex = 50
        '
        'PicClose
        '
        Me.PicClose.Image = Global.RFID_Based_KMS.My.Resources.Resources.keyclose
        Me.PicClose.Location = New System.Drawing.Point(4, -1)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(108, 81)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicClose.TabIndex = 1
        Me.PicClose.TabStop = False
        Me.PicClose.Visible = False
        '
        'PicFar
        '
        Me.PicFar.Image = Global.RFID_Based_KMS.My.Resources.Resources.keyfar
        Me.PicFar.Location = New System.Drawing.Point(4, -1)
        Me.PicFar.Name = "PicFar"
        Me.PicFar.Size = New System.Drawing.Size(108, 81)
        Me.PicFar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFar.TabIndex = 0
        Me.PicFar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(196, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Key Tag"
        '
        'TXTKEYTAG
        '
        Me.TXTKEYTAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTKEYTAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTKEYTAG.Enabled = False
        Me.TXTKEYTAG.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKEYTAG.Location = New System.Drawing.Point(134, 48)
        Me.TXTKEYTAG.Name = "TXTKEYTAG"
        Me.TXTKEYTAG.Size = New System.Drawing.Size(188, 33)
        Me.TXTKEYTAG.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.DGVROOMKEYS)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TXTSEARCH)
        Me.Panel3.Location = New System.Drawing.Point(354, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(274, 358)
        Me.Panel3.TabIndex = 47
        '
        'DGVROOMKEYS
        '
        Me.DGVROOMKEYS.AllowUserToAddRows = False
        Me.DGVROOMKEYS.AllowUserToDeleteRows = False
        Me.DGVROOMKEYS.AutoGenerateColumns = False
        Me.DGVROOMKEYS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVROOMKEYS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeytagDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.RoomcategoryDataGridViewTextBoxColumn, Me.KeyownershipDataGridViewTextBoxColumn, Me.KeytypeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVROOMKEYS.DataSource = Me.TblkeyBindingSource1
        Me.DGVROOMKEYS.Location = New System.Drawing.Point(11, 40)
        Me.DGVROOMKEYS.Name = "DGVROOMKEYS"
        Me.DGVROOMKEYS.ReadOnly = True
        Me.DGVROOMKEYS.Size = New System.Drawing.Size(247, 305)
        Me.DGVROOMKEYS.TabIndex = 35
        '
        'KeytagDataGridViewTextBoxColumn
        '
        Me.KeytagDataGridViewTextBoxColumn.DataPropertyName = "keytag"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.KeytagDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.KeytagDataGridViewTextBoxColumn.HeaderText = "Key Tag"
        Me.KeytagDataGridViewTextBoxColumn.Name = "KeytagDataGridViewTextBoxColumn"
        Me.KeytagDataGridViewTextBoxColumn.ReadOnly = True
        Me.KeytagDataGridViewTextBoxColumn.Width = 95
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "roomnumber"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.RoomnumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "Room No."
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        Me.RoomnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomnumberDataGridViewTextBoxColumn.Width = 95
        '
        'RoomcategoryDataGridViewTextBoxColumn
        '
        Me.RoomcategoryDataGridViewTextBoxColumn.DataPropertyName = "roomcategory"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.RoomcategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.RoomcategoryDataGridViewTextBoxColumn.HeaderText = "Room Category"
        Me.RoomcategoryDataGridViewTextBoxColumn.Name = "RoomcategoryDataGridViewTextBoxColumn"
        Me.RoomcategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomcategoryDataGridViewTextBoxColumn.Width = 150
        '
        'KeyownershipDataGridViewTextBoxColumn
        '
        Me.KeyownershipDataGridViewTextBoxColumn.DataPropertyName = "keyownership"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.KeyownershipDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.KeyownershipDataGridViewTextBoxColumn.HeaderText = "Key Ownership"
        Me.KeyownershipDataGridViewTextBoxColumn.Name = "KeyownershipDataGridViewTextBoxColumn"
        Me.KeyownershipDataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyownershipDataGridViewTextBoxColumn.Width = 150
        '
        'KeytypeDataGridViewTextBoxColumn
        '
        Me.KeytypeDataGridViewTextBoxColumn.DataPropertyName = "keytype"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.KeytypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.KeytypeDataGridViewTextBoxColumn.HeaderText = "Key Type"
        Me.KeytypeDataGridViewTextBoxColumn.Name = "KeytypeDataGridViewTextBoxColumn"
        Me.KeytypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblkeyBindingSource1
        '
        Me.TblkeyBindingSource1.DataMember = "tbl_key"
        Me.TblkeyBindingSource1.DataSource = Me.Db_kmsDataSet
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
        Me.Label8.Location = New System.Drawing.Point(15, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Search:"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(72, 14)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(180, 20)
        Me.TXTSEARCH.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOROOMNUMBER)
        Me.Panel4.Controls.Add(Me.CBOKEYOWNERSHIP)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.CBOSTATUS)
        Me.Panel4.Controls.Add(Me.CBOKEYTYPE)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.CBOROOMCAT)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(17, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(331, 166)
        Me.Panel4.TabIndex = 46
        '
        'CBOROOMNUMBER
        '
        Me.CBOROOMNUMBER.Enabled = False
        Me.CBOROOMNUMBER.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOROOMNUMBER.FormattingEnabled = True
        Me.CBOROOMNUMBER.Location = New System.Drawing.Point(136, 41)
        Me.CBOROOMNUMBER.Name = "CBOROOMNUMBER"
        Me.CBOROOMNUMBER.Size = New System.Drawing.Size(171, 25)
        Me.CBOROOMNUMBER.TabIndex = 38
        '
        'CBOKEYOWNERSHIP
        '
        Me.CBOKEYOWNERSHIP.Enabled = False
        Me.CBOKEYOWNERSHIP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOKEYOWNERSHIP.FormattingEnabled = True
        Me.CBOKEYOWNERSHIP.Items.AddRange(New Object() {"General Services Office"})
        Me.CBOKEYOWNERSHIP.Location = New System.Drawing.Point(136, 71)
        Me.CBOKEYOWNERSHIP.Name = "CBOKEYOWNERSHIP"
        Me.CBOKEYOWNERSHIP.Size = New System.Drawing.Size(171, 25)
        Me.CBOKEYOWNERSHIP.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(22, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Status"
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.Enabled = False
        Me.CBOSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(136, 134)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(171, 25)
        Me.CBOSTATUS.TabIndex = 35
        '
        'CBOKEYTYPE
        '
        Me.CBOKEYTYPE.Enabled = False
        Me.CBOKEYTYPE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOKEYTYPE.FormattingEnabled = True
        Me.CBOKEYTYPE.Items.AddRange(New Object() {"Original", "Duplicate"})
        Me.CBOKEYTYPE.Location = New System.Drawing.Point(136, 103)
        Me.CBOKEYTYPE.Name = "CBOKEYTYPE"
        Me.CBOKEYTYPE.Size = New System.Drawing.Size(171, 25)
        Me.CBOKEYTYPE.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(23, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Key Type"
        '
        'CBOROOMCAT
        '
        Me.CBOROOMCAT.Enabled = False
        Me.CBOROOMCAT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOROOMCAT.FormattingEnabled = True
        Me.CBOROOMCAT.Location = New System.Drawing.Point(136, 11)
        Me.CBOROOMCAT.Name = "CBOROOMCAT"
        Me.CBOROOMCAT.Size = New System.Drawing.Size(171, 25)
        Me.CBOROOMCAT.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Room Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(22, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Key Ownership"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(22, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Room Category"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(13, 12)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(90, 19)
        Me.lblHead2.TabIndex = 69
        Me.lblHead2.Text = "ROOM KEY"
        '
        'TXTRKBLANK
        '
        Me.TXTRKBLANK.Location = New System.Drawing.Point(248, 36)
        Me.TXTRKBLANK.Name = "TXTRKBLANK"
        Me.TXTRKBLANK.Size = New System.Drawing.Size(100, 20)
        Me.TXTRKBLANK.TabIndex = 70
        '
        'MSGROOMKEY
        '
        Me.MSGROOMKEY.Enabled = True
        Me.MSGROOMKEY.Interval = 50
        '
        'TblkeyBindingSource
        '
        Me.TblkeyBindingSource.DataMember = "tbl_key"
        Me.TblkeyBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Tbl_keyTableAdapter
        '
        Me.Tbl_keyTableAdapter.ClearBeforeFill = True
        '
        'ucRoomKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TXTRKBLANK)
        Me.Name = "ucRoomKey"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVROOMKEYS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkeyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TblkeyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTKEYTAG As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOROOMCAT As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PicClose As System.Windows.Forms.PictureBox
    Friend WithEvents PicFar As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOKEYTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents TXTRKBLANK As System.Windows.Forms.TextBox
    Friend WithEvents MSGROOMKEY As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents TblkeyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents CBOKEYOWNERSHIP As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_keyTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keyTableAdapter
    Friend WithEvents DGVROOMKEYS As System.Windows.Forms.DataGridView
    Friend WithEvents TblkeyBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KeytagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomcategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyownershipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeytypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBOROOMNUMBER As System.Windows.Forms.ComboBox

End Class
