<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRoomCatSettings
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
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.DGVROOMCAT = New System.Windows.Forms.DataGridView()
        Me.CategorynumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblroomcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCATEGORYNAME = New System.Windows.Forms.TextBox()
        Me.TXTCATEGORYNO = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Tbl_roomcategoryTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_roomcategoryTableAdapter()
        Me.PNLSettings.SuspendLayout()
        CType(Me.DGVROOMCAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblroomcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(19, 14)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(146, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ROOM CATEGORY"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(74, 26)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(212, 20)
        Me.TXTSEARCH.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(18, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Search:"
        '
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.DGVROOMCAT)
        Me.PNLSettings.Controls.Add(Me.TXTSEARCH)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(308, 47)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 60
        '
        'DGVROOMCAT
        '
        Me.DGVROOMCAT.AllowUserToAddRows = False
        Me.DGVROOMCAT.AllowUserToDeleteRows = False
        Me.DGVROOMCAT.AutoGenerateColumns = False
        Me.DGVROOMCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVROOMCAT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategorynumberDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.DGVROOMCAT.DataSource = Me.TblroomcategoryBindingSource
        Me.DGVROOMCAT.Location = New System.Drawing.Point(36, 51)
        Me.DGVROOMCAT.Name = "DGVROOMCAT"
        Me.DGVROOMCAT.ReadOnly = True
        Me.DGVROOMCAT.Size = New System.Drawing.Size(249, 275)
        Me.DGVROOMCAT.TabIndex = 51
        '
        'CategorynumberDataGridViewTextBoxColumn
        '
        Me.CategorynumberDataGridViewTextBoxColumn.DataPropertyName = "categorynumber"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.CategorynumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CategorynumberDataGridViewTextBoxColumn.HeaderText = "Category No."
        Me.CategorynumberDataGridViewTextBoxColumn.Name = "CategorynumberDataGridViewTextBoxColumn"
        Me.CategorynumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorynumberDataGridViewTextBoxColumn.Width = 95
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "categoryname"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.CategorynameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Category Name"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorynameDataGridViewTextBoxColumn.Width = 150
        '
        'TblroomcategoryBindingSource
        '
        Me.TblroomcategoryBindingSource.DataMember = "tbl_roomcategory"
        Me.TblroomcategoryBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Category Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(11, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Category Name"
        '
        'TXTCATEGORYNAME
        '
        Me.TXTCATEGORYNAME.Enabled = False
        Me.TXTCATEGORYNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATEGORYNAME.Location = New System.Drawing.Point(127, 119)
        Me.TXTCATEGORYNAME.Name = "TXTCATEGORYNAME"
        Me.TXTCATEGORYNAME.Size = New System.Drawing.Size(136, 22)
        Me.TXTCATEGORYNAME.TabIndex = 53
        '
        'TXTCATEGORYNO
        '
        Me.TXTCATEGORYNO.Enabled = False
        Me.TXTCATEGORYNO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATEGORYNO.Location = New System.Drawing.Point(127, 77)
        Me.TXTCATEGORYNO.Name = "TXTCATEGORYNO"
        Me.TXTCATEGORYNO.Size = New System.Drawing.Size(136, 22)
        Me.TXTCATEGORYNO.TabIndex = 52
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTCATEGORYNAME)
        Me.Panel4.Controls.Add(Me.TXTCATEGORYNO)
        Me.Panel4.Location = New System.Drawing.Point(20, 164)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 226)
        Me.Panel4.TabIndex = 61
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(21, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 106)
        Me.Panel5.TabIndex = 62
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
        'Tbl_roomcategoryTableAdapter
        '
        Me.Tbl_roomcategoryTableAdapter.ClearBeforeFill = True
        '
        'ucRoomCatSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.PNLSettings)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "ucRoomCatSettings"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        CType(Me.DGVROOMCAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblroomcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTCATEGORYNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTCATEGORYNO As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVROOMCAT As System.Windows.Forms.DataGridView
    Friend WithEvents TblroomcategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents Tbl_roomcategoryTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_roomcategoryTableAdapter
    Friend WithEvents CategorynumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
