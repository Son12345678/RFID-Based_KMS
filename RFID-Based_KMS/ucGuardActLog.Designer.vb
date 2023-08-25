<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGuardActLog
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
        Me.tbl_activitylogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTaccountname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNActlogClear = New System.Windows.Forms.Button()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.DTPDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RVGUARDACTLOG = New Microsoft.Reporting.WinForms.ReportViewer()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.TXTaccountname)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.BTNActlogClear)
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Controls.Add(Me.DTPDATE)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(621, 39)
        Me.Panel3.TabIndex = 84
        '
        'TXTaccountname
        '
        Me.TXTaccountname.Location = New System.Drawing.Point(406, 8)
        Me.TXTaccountname.Name = "TXTaccountname"
        Me.TXTaccountname.Size = New System.Drawing.Size(127, 20)
        Me.TXTaccountname.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(310, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account Name"
        '
        'BTNActlogClear
        '
        Me.BTNActlogClear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNActlogClear.FlatAppearance.BorderSize = 0
        Me.BTNActlogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNActlogClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActlogClear.ForeColor = System.Drawing.Color.White
        Me.BTNActlogClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNActlogClear.Location = New System.Drawing.Point(541, 5)
        Me.BTNActlogClear.Name = "BTNActlogClear"
        Me.BTNActlogClear.Size = New System.Drawing.Size(74, 24)
        Me.BTNActlogClear.TabIndex = 85
        Me.BTNActlogClear.Text = "Clear Filter"
        Me.BTNActlogClear.UseVisualStyleBackColor = False
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(13, 7)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(108, 18)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ACTIVITY LOG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(767, 15)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(76, 36)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'DTPDATE
        '
        Me.DTPDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDATE.Location = New System.Drawing.Point(210, 9)
        Me.DTPDATE.Name = "DTPDATE"
        Me.DTPDATE.Size = New System.Drawing.Size(95, 20)
        Me.DTPDATE.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(126, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Filter by Date"
        '
        'RVGUARDACTLOG
        '
        ReportDataSource1.Name = "db_KMSguardactlog"
        ReportDataSource1.Value = Me.tbl_activitylogBindingSource
        Me.RVGUARDACTLOG.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVGUARDACTLOG.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTGuardActivityLog.rdlc"
        Me.RVGUARDACTLOG.Location = New System.Drawing.Point(5, 46)
        Me.RVGUARDACTLOG.Name = "RVGUARDACTLOG"
        Me.RVGUARDACTLOG.Size = New System.Drawing.Size(609, 207)
        Me.RVGUARDACTLOG.TabIndex = 85
        '
        'tbl_activitylogTableAdapter
        '
        Me.tbl_activitylogTableAdapter.ClearBeforeFill = True
        '
        'ucGuardActLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVGUARDACTLOG)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucGuardActLog"
        Me.Size = New System.Drawing.Size(621, 260)
        CType(Me.tbl_activitylogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents DTPDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNActlogClear As System.Windows.Forms.Button
    Friend WithEvents RVGUARDACTLOG As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_activitylogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_activitylogTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_activitylogTableAdapter
    Friend WithEvents TXTaccountname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
