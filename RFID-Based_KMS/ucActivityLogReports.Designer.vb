<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucActivityLogReports
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_activitylogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTFilterAccName = New System.Windows.Forms.TextBox()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.DTPFILTERBYDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOFILTERBYACTIVITY = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RVActLog = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_activitylogTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_activitylogTableAdapter()
        CType(Me.tbl_activitylogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_activitylogBindingSource
        '
        Me.tbl_activitylogBindingSource.DataMember = "tbl_activitylog"
        Me.tbl_activitylogBindingSource.DataSource = Me.db_kmsDataSet
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
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(6, 14)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(113, 19)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ACTIVITY LOG"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.TXTFilterAccName)
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Controls.Add(Me.DTPFILTERBYDATE)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYACTIVITY)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 49)
        Me.Panel3.TabIndex = 80
        '
        'TXTFilterAccName
        '
        Me.TXTFilterAccName.Location = New System.Drawing.Point(414, 15)
        Me.TXTFilterAccName.Name = "TXTFilterAccName"
        Me.TXTFilterAccName.Size = New System.Drawing.Size(137, 20)
        Me.TXTFilterAccName.TabIndex = 82
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(744, 11)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(90, 28)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'DTPFILTERBYDATE
        '
        Me.DTPFILTERBYDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFILTERBYDATE.Location = New System.Drawing.Point(637, 15)
        Me.DTPFILTERBYDATE.Name = "DTPFILTERBYDATE"
        Me.DTPFILTERBYDATE.Size = New System.Drawing.Size(92, 20)
        Me.DTPFILTERBYDATE.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(129, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 32)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activity"
        '
        'CBOFILTERBYACTIVITY
        '
        Me.CBOFILTERBYACTIVITY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYACTIVITY.FormattingEnabled = True
        Me.CBOFILTERBYACTIVITY.Items.AddRange(New Object() {"Add New Borrower's Profile", "Add New User", "Add New  College", "Add Course", "Add New Item", "Add New  Room Category", "Add New Room", "Add New  Section", "Add New Room Key", "Edited Profile", "Edited User", "Edited College", "Edited Course", "Edited Item", "Edited Room Category", "Edited Room", "Edited Section", "Edited Room Key", "Returned to Guard"})
        Me.CBOFILTERBYACTIVITY.Location = New System.Drawing.Point(191, 13)
        Me.CBOFILTERBYACTIVITY.Name = "CBOFILTERBYACTIVITY"
        Me.CBOFILTERBYACTIVITY.Size = New System.Drawing.Size(115, 25)
        Me.CBOFILTERBYACTIVITY.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(557, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Filter by Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(311, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account Name"
        '
        'RVActLog
        '
        ReportDataSource3.Name = "db_KMSactlog"
        ReportDataSource3.Value = Me.tbl_activitylogBindingSource
        Me.RVActLog.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RVActLog.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTactivitylog.rdlc"
        Me.RVActLog.Location = New System.Drawing.Point(8, 53)
        Me.RVActLog.Name = "RVActLog"
        Me.RVActLog.Size = New System.Drawing.Size(838, 343)
        Me.RVActLog.TabIndex = 81
        '
        'tbl_activitylogTableAdapter
        '
        Me.tbl_activitylogTableAdapter.ClearBeforeFill = True
        '
        'ucActivityLogReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVActLog)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucActivityLogReports"
        Me.Size = New System.Drawing.Size(851, 406)
        CType(Me.tbl_activitylogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DTPFILTERBYDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents CBOFILTERBYACTIVITY As System.Windows.Forms.ComboBox
    Friend WithEvents RVActLog As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_activitylogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_activitylogTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_activitylogTableAdapter
    Friend WithEvents TXTFilterAccName As System.Windows.Forms.TextBox

End Class
