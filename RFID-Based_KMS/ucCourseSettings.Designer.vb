<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCourseSettings
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
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOCourseStatus = New System.Windows.Forms.ComboBox()
        Me.TXTCOURSE = New System.Windows.Forms.TextBox()
        Me.CBOCOLLEGE = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCOURSEID = New System.Windows.Forms.TextBox()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.DGVCOURSESETTINGS = New System.Windows.Forms.DataGridView()
        Me.CourseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Tbl_courseTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_courseTableAdapter()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PNLSettings.SuspendLayout()
        CType(Me.DGVCOURSESETTINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel5.TabIndex = 58
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.CBOCourseStatus)
        Me.Panel4.Controls.Add(Me.TXTCOURSE)
        Me.Panel4.Controls.Add(Me.CBOCOLLEGE)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTCOURSEID)
        Me.Panel4.Location = New System.Drawing.Point(20, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 226)
        Me.Panel4.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(17, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Status"
        '
        'CBOCourseStatus
        '
        Me.CBOCourseStatus.Enabled = False
        Me.CBOCourseStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCourseStatus.FormattingEnabled = True
        Me.CBOCourseStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOCourseStatus.Location = New System.Drawing.Point(88, 175)
        Me.CBOCourseStatus.Name = "CBOCourseStatus"
        Me.CBOCourseStatus.Size = New System.Drawing.Size(175, 25)
        Me.CBOCourseStatus.TabIndex = 60
        '
        'TXTCOURSE
        '
        Me.TXTCOURSE.Enabled = False
        Me.TXTCOURSE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOURSE.Location = New System.Drawing.Point(88, 94)
        Me.TXTCOURSE.Name = "TXTCOURSE"
        Me.TXTCOURSE.Size = New System.Drawing.Size(175, 22)
        Me.TXTCOURSE.TabIndex = 59
        '
        'CBOCOLLEGE
        '
        Me.CBOCOLLEGE.Enabled = False
        Me.CBOCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOCOLLEGE.FormattingEnabled = True
        Me.CBOCOLLEGE.Location = New System.Drawing.Point(88, 134)
        Me.CBOCOLLEGE.Name = "CBOCOLLEGE"
        Me.CBOCOLLEGE.Size = New System.Drawing.Size(175, 25)
        Me.CBOCOLLEGE.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(14, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "College"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(14, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Course "
        '
        'TXTCOURSEID
        '
        Me.TXTCOURSEID.Enabled = False
        Me.TXTCOURSEID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOURSEID.Location = New System.Drawing.Point(90, 56)
        Me.TXTCOURSEID.Name = "TXTCOURSEID"
        Me.TXTCOURSEID.Size = New System.Drawing.Size(175, 22)
        Me.TXTCOURSEID.TabIndex = 53
        '
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.DGVCOURSESETTINGS)
        Me.PNLSettings.Controls.Add(Me.TXTSEARCH)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(308, 48)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 56
        '
        'DGVCOURSESETTINGS
        '
        Me.DGVCOURSESETTINGS.AllowUserToAddRows = False
        Me.DGVCOURSESETTINGS.AllowUserToDeleteRows = False
        Me.DGVCOURSESETTINGS.AutoGenerateColumns = False
        Me.DGVCOURSESETTINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCOURSESETTINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseidDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVCOURSESETTINGS.DataSource = Me.TblcourseBindingSource
        Me.DGVCOURSESETTINGS.Location = New System.Drawing.Point(20, 63)
        Me.DGVCOURSESETTINGS.Name = "DGVCOURSESETTINGS"
        Me.DGVCOURSESETTINGS.ReadOnly = True
        Me.DGVCOURSESETTINGS.Size = New System.Drawing.Size(275, 264)
        Me.DGVCOURSESETTINGS.TabIndex = 51
        '
        'CourseidDataGridViewTextBoxColumn
        '
        Me.CourseidDataGridViewTextBoxColumn.DataPropertyName = "courseid"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.CourseidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CourseidDataGridViewTextBoxColumn.HeaderText = "Course ID"
        Me.CourseidDataGridViewTextBoxColumn.Name = "CourseidDataGridViewTextBoxColumn"
        Me.CourseidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseidDataGridViewTextBoxColumn.Width = 80
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "course"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.CourseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseDataGridViewTextBoxColumn.Width = 150
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.CollegeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CollegeDataGridViewTextBoxColumn.Width = 150
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
        'TblcourseBindingSource
        '
        Me.TblcourseBindingSource.DataMember = "tbl_course"
        Me.TblcourseBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(78, 26)
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
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(20, 15)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(69, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "COURSE"
        '
        'Tbl_courseTableAdapter
        '
        Me.Tbl_courseTableAdapter.ClearBeforeFill = True
        '
        'ucCourseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PNLSettings)
        Me.Name = "ucCourseSettings"
        Me.Size = New System.Drawing.Size(643, 409)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        CType(Me.DGVCOURSESETTINGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTCOURSEID As System.Windows.Forms.TextBox
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLLEGE As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCOURSE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOCourseStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DGVCOURSESETTINGS As System.Windows.Forms.DataGridView
    Friend WithEvents TblcourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents Tbl_courseTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_courseTableAdapter
    Friend WithEvents CourseidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
