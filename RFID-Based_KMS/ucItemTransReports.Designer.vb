<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemTransReports
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
        Me.tbl_itemtransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.DTPRETURNEDTO = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOSTAT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPRETURNEDFROM = New System.Windows.Forms.DateTimePicker()
        Me.DTPBORROWEDTO = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPBORROWEDFROM = New System.Windows.Forms.DateTimePicker()
        Me.RVItemTransaction = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_itemtransactionTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemtransactionTableAdapter()
        CType(Me.tbl_itemtransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_itemtransactionBindingSource
        '
        Me.tbl_itemtransactionBindingSource.DataMember = "tbl_itemtransaction"
        Me.tbl_itemtransactionBindingSource.DataSource = Me.db_kmsDataSet
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
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Controls.Add(Me.DTPRETURNEDTO)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.CBOSTAT)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.DTPRETURNEDFROM)
        Me.Panel3.Controls.Add(Me.DTPBORROWEDTO)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DTPBORROWEDFROM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 61)
        Me.Panel3.TabIndex = 83
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(3, 6)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(154, 38)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ITEM TRANSACTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         REPORTS"
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(762, 14)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(82, 36)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'DTPRETURNEDTO
        '
        Me.DTPRETURNEDTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRETURNEDTO.Location = New System.Drawing.Point(634, 37)
        Me.DTPRETURNEDTO.Name = "DTPRETURNEDTO"
        Me.DTPRETURNEDTO.Size = New System.Drawing.Size(116, 20)
        Me.DTPRETURNEDTO.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(162, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Filter by Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(614, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "to"
        '
        'CBOSTAT
        '
        Me.CBOSTAT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOSTAT.FormattingEnabled = True
        Me.CBOSTAT.Items.AddRange(New Object() {"Borrowed", "Returned"})
        Me.CBOSTAT.Location = New System.Drawing.Point(254, 19)
        Me.CBOSTAT.Name = "CBOSTAT"
        Me.CBOSTAT.Size = New System.Drawing.Size(88, 25)
        Me.CBOSTAT.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(350, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filter by Date Borrowed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(351, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Filter by Date Returned"
        '
        'DTPRETURNEDFROM
        '
        Me.DTPRETURNEDFROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRETURNEDFROM.Location = New System.Drawing.Point(495, 36)
        Me.DTPRETURNEDFROM.Name = "DTPRETURNEDFROM"
        Me.DTPRETURNEDFROM.Size = New System.Drawing.Size(116, 20)
        Me.DTPRETURNEDFROM.TabIndex = 87
        '
        'DTPBORROWEDTO
        '
        Me.DTPBORROWEDTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPBORROWEDTO.Location = New System.Drawing.Point(634, 12)
        Me.DTPBORROWEDTO.Name = "DTPBORROWEDTO"
        Me.DTPBORROWEDTO.Size = New System.Drawing.Size(116, 20)
        Me.DTPBORROWEDTO.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(615, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "to"
        '
        'DTPBORROWEDFROM
        '
        Me.DTPBORROWEDFROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPBORROWEDFROM.Location = New System.Drawing.Point(495, 12)
        Me.DTPBORROWEDFROM.Name = "DTPBORROWEDFROM"
        Me.DTPBORROWEDFROM.Size = New System.Drawing.Size(116, 20)
        Me.DTPBORROWEDFROM.TabIndex = 83
        '
        'RVItemTransaction
        '
        ReportDataSource1.Name = "db_kmsITEMTRANS"
        ReportDataSource1.Value = Me.tbl_itemtransactionBindingSource
        Me.RVItemTransaction.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVItemTransaction.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTITEMTRANS.rdlc"
        Me.RVItemTransaction.Location = New System.Drawing.Point(6, 65)
        Me.RVItemTransaction.Name = "RVItemTransaction"
        Me.RVItemTransaction.Size = New System.Drawing.Size(841, 336)
        Me.RVItemTransaction.TabIndex = 84
        '
        'tbl_itemtransactionTableAdapter
        '
        Me.tbl_itemtransactionTableAdapter.ClearBeforeFill = True
        '
        'ucItemTransReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVItemTransaction)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucItemTransReports"
        Me.Size = New System.Drawing.Size(851, 406)
        CType(Me.tbl_itemtransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents DTPRETURNEDTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPRETURNEDFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPBORROWEDTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPBORROWEDFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents CBOSTAT As System.Windows.Forms.ComboBox
    Friend WithEvents RVItemTransaction As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_itemtransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_itemtransactionTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemtransactionTableAdapter

End Class
