<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSectionSettings
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSECTION = New System.Windows.Forms.TextBox()
        Me.TXTSECTIONID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.TXTsearchsection = New System.Windows.Forms.TextBox()
        Me.DGVSECTIONSETTINGS = New System.Windows.Forms.DataGridView()
        Me.SectionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblsectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOcourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOSectionStatus = New System.Windows.Forms.ComboBox()
        Me.CBOCOLLEGE = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Tbl_sectionTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_sectionTableAdapter()
        Me.Panel5.SuspendLayout()
        Me.PNLSettings.SuspendLayout()
        CType(Me.DGVSECTIONSETTINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel5.TabIndex = 74
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Section"
        '
        'TXTSECTION
        '
        Me.TXTSECTION.Enabled = False
        Me.TXTSECTION.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSECTION.Location = New System.Drawing.Point(94, 66)
        Me.TXTSECTION.Name = "TXTSECTION"
        Me.TXTSECTION.Size = New System.Drawing.Size(169, 22)
        Me.TXTSECTION.TabIndex = 53
        '
        'TXTSECTIONID
        '
        Me.TXTSECTIONID.Enabled = False
        Me.TXTSECTIONID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSECTIONID.Location = New System.Drawing.Point(94, 35)
        Me.TXTSECTIONID.Name = "TXTSECTIONID"
        Me.TXTSECTIONID.Size = New System.Drawing.Size(169, 22)
        Me.TXTSECTIONID.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Section ID"
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
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.TXTsearchsection)
        Me.PNLSettings.Controls.Add(Me.DGVSECTIONSETTINGS)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(308, 48)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 72
        '
        'TXTsearchsection
        '
        Me.TXTsearchsection.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTsearchsection.Location = New System.Drawing.Point(78, 26)
        Me.TXTsearchsection.Name = "TXTsearchsection"
        Me.TXTsearchsection.Size = New System.Drawing.Size(215, 22)
        Me.TXTsearchsection.TabIndex = 53
        '
        'DGVSECTIONSETTINGS
        '
        Me.DGVSECTIONSETTINGS.AllowUserToAddRows = False
        Me.DGVSECTIONSETTINGS.AllowUserToDeleteRows = False
        Me.DGVSECTIONSETTINGS.AutoGenerateColumns = False
        Me.DGVSECTIONSETTINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSECTIONSETTINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectionidDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVSECTIONSETTINGS.DataSource = Me.TblsectionBindingSource
        Me.DGVSECTIONSETTINGS.Location = New System.Drawing.Point(23, 55)
        Me.DGVSECTIONSETTINGS.Name = "DGVSECTIONSETTINGS"
        Me.DGVSECTIONSETTINGS.ReadOnly = True
        Me.DGVSECTIONSETTINGS.Size = New System.Drawing.Size(272, 266)
        Me.DGVSECTIONSETTINGS.TabIndex = 50
        '
        'SectionidDataGridViewTextBoxColumn
        '
        Me.SectionidDataGridViewTextBoxColumn.DataPropertyName = "sectionid"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.SectionidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SectionidDataGridViewTextBoxColumn.HeaderText = "Section ID"
        Me.SectionidDataGridViewTextBoxColumn.Name = "SectionidDataGridViewTextBoxColumn"
        Me.SectionidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectionidDataGridViewTextBoxColumn.Width = 95
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "section"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.SectionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "course"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.CourseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseDataGridViewTextBoxColumn.Width = 150
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.CollegeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CollegeDataGridViewTextBoxColumn.Width = 150
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblsectionBindingSource
        '
        Me.TblsectionBindingSource.DataMember = "tbl_section"
        Me.TblsectionBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOcourse)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.CBOSectionStatus)
        Me.Panel4.Controls.Add(Me.CBOCOLLEGE)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTSECTION)
        Me.Panel4.Controls.Add(Me.TXTSECTIONID)
        Me.Panel4.Location = New System.Drawing.Point(20, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 226)
        Me.Panel4.TabIndex = 73
        '
        'CBOcourse
        '
        Me.CBOcourse.Enabled = False
        Me.CBOcourse.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOcourse.FormattingEnabled = True
        Me.CBOcourse.Location = New System.Drawing.Point(94, 131)
        Me.CBOcourse.Name = "CBOcourse"
        Me.CBOcourse.Size = New System.Drawing.Size(169, 25)
        Me.CBOcourse.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(11, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Status"
        '
        'CBOSectionStatus
        '
        Me.CBOSectionStatus.Enabled = False
        Me.CBOSectionStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOSectionStatus.FormattingEnabled = True
        Me.CBOSectionStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSectionStatus.Location = New System.Drawing.Point(94, 165)
        Me.CBOSectionStatus.Name = "CBOSectionStatus"
        Me.CBOSectionStatus.Size = New System.Drawing.Size(169, 25)
        Me.CBOSectionStatus.TabIndex = 63
        '
        'CBOCOLLEGE
        '
        Me.CBOCOLLEGE.Enabled = False
        Me.CBOCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCOLLEGE.FormattingEnabled = True
        Me.CBOCOLLEGE.Location = New System.Drawing.Point(94, 97)
        Me.CBOCOLLEGE.Name = "CBOCOLLEGE"
        Me.CBOCOLLEGE.Size = New System.Drawing.Size(169, 25)
        Me.CBOCOLLEGE.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(11, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "College"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Course"
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(22, 17)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(73, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "SECTION"
        '
        'Tbl_sectionTableAdapter
        '
        Me.Tbl_sectionTableAdapter.ClearBeforeFill = True
        '
        'ucSectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PNLSettings)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "ucSectionSettings"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.Panel5.ResumeLayout(False)
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        CType(Me.DGVSECTIONSETTINGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTSECTION As System.Windows.Forms.TextBox
    Friend WithEvents TXTSECTIONID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLLEGE As System.Windows.Forms.ComboBox
    Friend WithEvents DGVSECTIONSETTINGS As System.Windows.Forms.DataGridView
    Friend WithEvents TblsectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOSectionStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_sectionTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_sectionTableAdapter
    Friend WithEvents SectionidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTsearchsection As System.Windows.Forms.TextBox
    Friend WithEvents CBOcourse As System.Windows.Forms.ComboBox

End Class
