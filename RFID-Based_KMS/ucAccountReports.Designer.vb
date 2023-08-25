<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAccountReports
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_useraccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTFILTERBYNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBOFILTERBYACCSTATUS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.CBOFILTERUTYPE = New System.Windows.Forms.ComboBox()
        Me.RVuseracc = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_useraccTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_useraccTableAdapter()
        CType(Me.tbl_useraccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_useraccBindingSource
        '
        Me.tbl_useraccBindingSource.DataMember = "tbl_useracc"
        Me.tbl_useraccBindingSource.DataSource = Me.db_kmsDataSet
        '
        'db_kmsDataSet
        '
        Me.db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.db_kmsDataSet.EnforceConstraints = False
        Me.db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(3, 5)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(83, 36)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ACCOUNT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REPORTS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.TXTFILTERBYNAME)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYACCSTATUS)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Controls.Add(Me.CBOFILTERUTYPE)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 50)
        Me.Panel3.TabIndex = 76
        '
        'TXTFILTERBYNAME
        '
        Me.TXTFILTERBYNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFILTERBYNAME.Location = New System.Drawing.Point(436, 16)
        Me.TXTFILTERBYNAME.Name = "TXTFILTERBYNAME"
        Me.TXTFILTERBYNAME.Size = New System.Drawing.Size(120, 22)
        Me.TXTFILTERBYNAME.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(566, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Filter by Status"
        '
        'CBOFILTERBYACCSTATUS
        '
        Me.CBOFILTERBYACCSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYACCSTATUS.FormattingEnabled = True
        Me.CBOFILTERBYACCSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOFILTERBYACCSTATUS.Location = New System.Drawing.Point(655, 15)
        Me.CBOFILTERBYACCSTATUS.Name = "CBOFILTERBYACCSTATUS"
        Me.CBOFILTERBYACCSTATUS.Size = New System.Drawing.Size(99, 25)
        Me.CBOFILTERBYACCSTATUS.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(333, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filter by Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(96, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Filter by Usertype"
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(766, 15)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(77, 24)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'CBOFILTERUTYPE
        '
        Me.CBOFILTERUTYPE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERUTYPE.FormattingEnabled = True
        Me.CBOFILTERUTYPE.Items.AddRange(New Object() {"College of Computer Studies", "College of Accountancy", "College of Business", "General Services Office", "System Administrator", "Guard"})
        Me.CBOFILTERUTYPE.Location = New System.Drawing.Point(203, 14)
        Me.CBOFILTERUTYPE.Name = "CBOFILTERUTYPE"
        Me.CBOFILTERUTYPE.Size = New System.Drawing.Size(121, 25)
        Me.CBOFILTERUTYPE.TabIndex = 33
        '
        'RVuseracc
        '
        Me.RVuseracc.DocumentMapWidth = 82
        ReportDataSource2.Name = "DataSet_useracc"
        ReportDataSource2.Value = Me.tbl_useraccBindingSource
        Me.RVuseracc.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RVuseracc.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTuseracc.rdlc"
        Me.RVuseracc.Location = New System.Drawing.Point(3, 54)
        Me.RVuseracc.Name = "RVuseracc"
        Me.RVuseracc.Size = New System.Drawing.Size(845, 341)
        Me.RVuseracc.TabIndex = 0
        '
        'tbl_useraccTableAdapter
        '
        Me.tbl_useraccTableAdapter.ClearBeforeFill = True
        '
        'ucAccountReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVuseracc)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucAccountReports"
        Me.Size = New System.Drawing.Size(851, 406)
        CType(Me.tbl_useraccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOFILTERUTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOFILTERBYACCSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents TXTFILTERBYNAME As System.Windows.Forms.TextBox
    Friend WithEvents RVuseracc As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_useraccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_useraccTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_useraccTableAdapter

End Class
