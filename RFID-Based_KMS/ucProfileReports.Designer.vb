<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProfileReports
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_borrowersprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.TXTFILTERBYNAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBOFILTERBYSTATUS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOFILTERBYCOLLEGE = New System.Windows.Forms.ComboBox()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.RVProfiles = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_borrowersprofileTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_borrowersprofileTableAdapter()
        CType(Me.tbl_borrowersprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_borrowersprofileBindingSource
        '
        Me.tbl_borrowersprofileBindingSource.DataMember = "tbl_borrowersprofile"
        Me.tbl_borrowersprofileBindingSource.DataSource = Me.db_kmsDataSet
        '
        'db_kmsDataSet
        '
        Me.db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.db_kmsDataSet.EnforceConstraints = False
        Me.db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.TXTFILTERBYNAME)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYSTATUS)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYCOLLEGE)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 47)
        Me.Panel3.TabIndex = 80
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(10, 4)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(72, 38)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "PROFILE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REPORTS"
        '
        'TXTFILTERBYNAME
        '
        Me.TXTFILTERBYNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFILTERBYNAME.Location = New System.Drawing.Point(637, 10)
        Me.TXTFILTERBYNAME.Name = "TXTFILTERBYNAME"
        Me.TXTFILTERBYNAME.Size = New System.Drawing.Size(111, 22)
        Me.TXTFILTERBYNAME.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(547, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Filter by Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(337, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Filter by Status"
        '
        'CBOFILTERBYSTATUS
        '
        Me.CBOFILTERBYSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYSTATUS.FormattingEnabled = True
        Me.CBOFILTERBYSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOFILTERBYSTATUS.Location = New System.Drawing.Point(425, 10)
        Me.CBOFILTERBYSTATUS.Name = "CBOFILTERBYSTATUS"
        Me.CBOFILTERBYSTATUS.Size = New System.Drawing.Size(112, 25)
        Me.CBOFILTERBYSTATUS.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(105, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filter by College"
        '
        'CBOFILTERBYCOLLEGE
        '
        Me.CBOFILTERBYCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYCOLLEGE.FormattingEnabled = True
        Me.CBOFILTERBYCOLLEGE.Items.AddRange(New Object() {"College of Computer Studies", "College of Business", "College of Accountancy"})
        Me.CBOFILTERBYCOLLEGE.Location = New System.Drawing.Point(215, 11)
        Me.CBOFILTERBYCOLLEGE.Name = "CBOFILTERBYCOLLEGE"
        Me.CBOFILTERBYCOLLEGE.Size = New System.Drawing.Size(111, 25)
        Me.CBOFILTERBYCOLLEGE.TabIndex = 35
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(766, 8)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(73, 25)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'RVProfiles
        '
        ReportDataSource1.Name = "DataSet_Profile"
        ReportDataSource1.Value = Me.tbl_borrowersprofileBindingSource
        Me.RVProfiles.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVProfiles.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTProfile.rdlc"
        Me.RVProfiles.Location = New System.Drawing.Point(3, 53)
        Me.RVProfiles.Name = "RVProfiles"
        Me.RVProfiles.Size = New System.Drawing.Size(845, 342)
        Me.RVProfiles.TabIndex = 81
        '
        'tbl_borrowersprofileTableAdapter
        '
        Me.tbl_borrowersprofileTableAdapter.ClearBeforeFill = True
        '
        'ucProfileReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVProfiles)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucProfileReports"
        Me.Size = New System.Drawing.Size(851, 406)
        CType(Me.tbl_borrowersprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOFILTERBYSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOFILTERBYCOLLEGE As System.Windows.Forms.ComboBox
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents TXTFILTERBYNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RVProfiles As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_borrowersprofileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_borrowersprofileTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_borrowersprofileTableAdapter

End Class
