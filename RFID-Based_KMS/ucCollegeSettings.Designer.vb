<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCollegeSettings
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.DGVCOLLEGESETTINGS = New System.Windows.Forms.DataGridView()
        Me.CollegeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcollegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCOLLEGEID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOCollegeStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCOLLEGE = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Tbl_collegeTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_collegeTableAdapter()
        Me.PNLSettings.SuspendLayout()
        CType(Me.DGVCOLLEGESETTINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcollegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(78, 26)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(212, 20)
        Me.TXTSEARCH.TabIndex = 50
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(28, 13)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(77, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "COLLEGE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.DGVCOLLEGESETTINGS)
        Me.PNLSettings.Controls.Add(Me.TXTSEARCH)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(309, 48)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 52
        '
        'DGVCOLLEGESETTINGS
        '
        Me.DGVCOLLEGESETTINGS.AllowUserToAddRows = False
        Me.DGVCOLLEGESETTINGS.AllowUserToDeleteRows = False
        Me.DGVCOLLEGESETTINGS.AutoGenerateColumns = False
        Me.DGVCOLLEGESETTINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCOLLEGESETTINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CollegeidDataGridViewTextBoxColumn, Me.CollegenameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVCOLLEGESETTINGS.DataSource = Me.TblcollegeBindingSource
        Me.DGVCOLLEGESETTINGS.Location = New System.Drawing.Point(15, 61)
        Me.DGVCOLLEGESETTINGS.Name = "DGVCOLLEGESETTINGS"
        Me.DGVCOLLEGESETTINGS.ReadOnly = True
        Me.DGVCOLLEGESETTINGS.Size = New System.Drawing.Size(283, 268)
        Me.DGVCOLLEGESETTINGS.TabIndex = 51
        '
        'CollegeidDataGridViewTextBoxColumn
        '
        Me.CollegeidDataGridViewTextBoxColumn.DataPropertyName = "collegeid"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.CollegeidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CollegeidDataGridViewTextBoxColumn.HeaderText = "College ID"
        Me.CollegeidDataGridViewTextBoxColumn.Name = "CollegeidDataGridViewTextBoxColumn"
        Me.CollegeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CollegeidDataGridViewTextBoxColumn.Width = 80
        '
        'CollegenameDataGridViewTextBoxColumn
        '
        Me.CollegenameDataGridViewTextBoxColumn.DataPropertyName = "collegename"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.CollegenameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CollegenameDataGridViewTextBoxColumn.HeaderText = "College Name"
        Me.CollegenameDataGridViewTextBoxColumn.Name = "CollegenameDataGridViewTextBoxColumn"
        Me.CollegenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CollegenameDataGridViewTextBoxColumn.Width = 150
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblcollegeBindingSource
        '
        Me.TblcollegeBindingSource.DataMember = "tbl_college"
        Me.TblcollegeBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(16, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "College Name"
        '
        'TXTCOLLEGEID
        '
        Me.TXTCOLLEGEID.Enabled = False
        Me.TXTCOLLEGEID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOLLEGEID.Location = New System.Drawing.Point(114, 56)
        Me.TXTCOLLEGEID.Name = "TXTCOLLEGEID"
        Me.TXTCOLLEGEID.Size = New System.Drawing.Size(151, 22)
        Me.TXTCOLLEGEID.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "College ID"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOCollegeStatus)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TXTCOLLEGE)
        Me.Panel4.Controls.Add(Me.TXTCOLLEGEID)
        Me.Panel4.Location = New System.Drawing.Point(21, 160)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 232)
        Me.Panel4.TabIndex = 53
        '
        'CBOCollegeStatus
        '
        Me.CBOCollegeStatus.Enabled = False
        Me.CBOCollegeStatus.FormattingEnabled = True
        Me.CBOCollegeStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOCollegeStatus.Location = New System.Drawing.Point(114, 157)
        Me.CBOCollegeStatus.Name = "CBOCollegeStatus"
        Me.CBOCollegeStatus.Size = New System.Drawing.Size(151, 21)
        Me.CBOCollegeStatus.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(19, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Status"
        '
        'TXTCOLLEGE
        '
        Me.TXTCOLLEGE.Enabled = False
        Me.TXTCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOLLEGE.Location = New System.Drawing.Point(114, 111)
        Me.TXTCOLLEGE.Name = "TXTCOLLEGE"
        Me.TXTCOLLEGE.Size = New System.Drawing.Size(151, 22)
        Me.TXTCOLLEGE.TabIndex = 53
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(22, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 106)
        Me.Panel5.TabIndex = 59
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
        'Tbl_collegeTableAdapter
        '
        Me.Tbl_collegeTableAdapter.ClearBeforeFill = True
        '
        'ucCollegeSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PNLSettings)
        Me.Name = "ucCollegeSettings"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        CType(Me.DGVCOLLEGESETTINGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcollegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTCOLLEGEID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TXTCOLLEGE As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents DGVCOLLEGESETTINGS As System.Windows.Forms.DataGridView
    Friend WithEvents TblcollegeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents CBOCollegeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_collegeTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_collegeTableAdapter
    Friend WithEvents CollegeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
