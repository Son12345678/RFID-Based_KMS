<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRoomSettings
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.DGVROOMSETTINGS = New System.Windows.Forms.DataGridView()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomownershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblroomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOROOMCAT = New System.Windows.Forms.ComboBox()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.CBOROOMOWNERSHIP = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTROOMNO = New System.Windows.Forms.TextBox()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Tbl_roomTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_roomTableAdapter()
        Me.PNLSettings.SuspendLayout()
        CType(Me.DGVROOMSETTINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblroomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Room Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(10, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Room Ownership"
        '
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.DGVROOMSETTINGS)
        Me.PNLSettings.Controls.Add(Me.TXTSEARCH)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(308, 48)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 68
        '
        'DGVROOMSETTINGS
        '
        Me.DGVROOMSETTINGS.AllowUserToAddRows = False
        Me.DGVROOMSETTINGS.AllowUserToDeleteRows = False
        Me.DGVROOMSETTINGS.AutoGenerateColumns = False
        Me.DGVROOMSETTINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVROOMSETTINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomnumberDataGridViewTextBoxColumn, Me.RoomcategoryDataGridViewTextBoxColumn, Me.RoomownershipDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVROOMSETTINGS.DataSource = Me.TblroomBindingSource
        Me.DGVROOMSETTINGS.Location = New System.Drawing.Point(21, 56)
        Me.DGVROOMSETTINGS.Name = "DGVROOMSETTINGS"
        Me.DGVROOMSETTINGS.ReadOnly = True
        Me.DGVROOMSETTINGS.Size = New System.Drawing.Size(277, 273)
        Me.DGVROOMSETTINGS.TabIndex = 51
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "roomnumber"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.RoomnumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "Room No."
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        Me.RoomnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomnumberDataGridViewTextBoxColumn.Width = 95
        '
        'RoomcategoryDataGridViewTextBoxColumn
        '
        Me.RoomcategoryDataGridViewTextBoxColumn.DataPropertyName = "roomcategory"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.RoomcategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RoomcategoryDataGridViewTextBoxColumn.HeaderText = "Room Category"
        Me.RoomcategoryDataGridViewTextBoxColumn.Name = "RoomcategoryDataGridViewTextBoxColumn"
        Me.RoomcategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomcategoryDataGridViewTextBoxColumn.Width = 150
        '
        'RoomownershipDataGridViewTextBoxColumn
        '
        Me.RoomownershipDataGridViewTextBoxColumn.DataPropertyName = "roomownership"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.RoomownershipDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.RoomownershipDataGridViewTextBoxColumn.HeaderText = "Room Ownership"
        Me.RoomownershipDataGridViewTextBoxColumn.Name = "RoomownershipDataGridViewTextBoxColumn"
        Me.RoomownershipDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomownershipDataGridViewTextBoxColumn.Width = 150
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblroomBindingSource
        '
        Me.TblroomBindingSource.DataMember = "tbl_room"
        Me.TblroomBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(86, 25)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(212, 20)
        Me.TXTSEARCH.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(20, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Search:"
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.FlatAppearance.BorderSize = 0
        Me.BTNSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(160, 15)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(102, 29)
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
        Me.BTNADD.Location = New System.Drawing.Point(19, 15)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(102, 29)
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(160, 62)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(102, 29)
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
        Me.BTNEDIT.Location = New System.Drawing.Point(18, 61)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(102, 29)
        Me.BTNEDIT.TabIndex = 4
        Me.BTNEDIT.Text = "EDIT"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOROOMCAT)
        Me.Panel4.Controls.Add(Me.CBOSTATUS)
        Me.Panel4.Controls.Add(Me.CBOROOMOWNERSHIP)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTROOMNO)
        Me.Panel4.Location = New System.Drawing.Point(20, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 226)
        Me.Panel4.TabIndex = 69
        '
        'CBOROOMCAT
        '
        Me.CBOROOMCAT.Enabled = False
        Me.CBOROOMCAT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOROOMCAT.FormattingEnabled = True
        Me.CBOROOMCAT.Location = New System.Drawing.Point(127, 79)
        Me.CBOROOMCAT.Name = "CBOROOMCAT"
        Me.CBOROOMCAT.Size = New System.Drawing.Size(136, 25)
        Me.CBOROOMCAT.TabIndex = 62
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.Enabled = False
        Me.CBOSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(127, 154)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(136, 25)
        Me.CBOSTATUS.TabIndex = 61
        '
        'CBOROOMOWNERSHIP
        '
        Me.CBOROOMOWNERSHIP.Enabled = False
        Me.CBOROOMOWNERSHIP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOROOMOWNERSHIP.FormattingEnabled = True
        Me.CBOROOMOWNERSHIP.Location = New System.Drawing.Point(127, 117)
        Me.CBOROOMOWNERSHIP.Name = "CBOROOMOWNERSHIP"
        Me.CBOROOMOWNERSHIP.Size = New System.Drawing.Size(136, 25)
        Me.CBOROOMOWNERSHIP.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(10, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(11, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Room Category"
        '
        'TXTROOMNO
        '
        Me.TXTROOMNO.Enabled = False
        Me.TXTROOMNO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTROOMNO.Location = New System.Drawing.Point(127, 49)
        Me.TXTROOMNO.Name = "TXTROOMNO"
        Me.TXTROOMNO.Size = New System.Drawing.Size(136, 22)
        Me.TXTROOMNO.TabIndex = 53
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(28, 16)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(58, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ROOM"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(21, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 106)
        Me.Panel5.TabIndex = 70
        '
        'Tbl_roomTableAdapter
        '
        Me.Tbl_roomTableAdapter.ClearBeforeFill = True
        '
        'ucRoomSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.PNLSettings)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "ucRoomSettings"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        CType(Me.DGVROOMSETTINGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblroomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTROOMNO As System.Windows.Forms.TextBox
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CBOSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents CBOROOMOWNERSHIP As System.Windows.Forms.ComboBox
    Friend WithEvents CBOROOMCAT As System.Windows.Forms.ComboBox
    Friend WithEvents DGVROOMSETTINGS As System.Windows.Forms.DataGridView
    Friend WithEvents TblroomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents Tbl_roomTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_roomTableAdapter
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomcategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomownershipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
