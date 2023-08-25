<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGuardKeyTransReports
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
        Me.tbl_guardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPDATEBORROWEDTO = New System.Windows.Forms.DateTimePicker()
        Me.DTPDATERETURNEDTO = New System.Windows.Forms.DateTimePicker()
        Me.DTPDATEBORROWED = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncleargt = New System.Windows.Forms.Button()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.DTPDATERETURNED = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RVGUARDTRANS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_guardTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_guardTableAdapter()
        CType(Me.tbl_guardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_guardBindingSource
        '
        Me.tbl_guardBindingSource.DataMember = "tbl_guard"
        Me.tbl_guardBindingSource.DataSource = Me.db_kmsDataSet
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
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.DTPDATEBORROWEDTO)
        Me.Panel3.Controls.Add(Me.DTPDATERETURNEDTO)
        Me.Panel3.Controls.Add(Me.DTPDATEBORROWED)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btncleargt)
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Controls.Add(Me.DTPDATERETURNED)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(621, 66)
        Me.Panel3.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(477, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(258, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "To"
        '
        'DTPDATEBORROWEDTO
        '
        Me.DTPDATEBORROWEDTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDATEBORROWEDTO.Location = New System.Drawing.Point(211, 42)
        Me.DTPDATEBORROWEDTO.Name = "DTPDATEBORROWEDTO"
        Me.DTPDATEBORROWEDTO.Size = New System.Drawing.Size(115, 20)
        Me.DTPDATEBORROWEDTO.TabIndex = 93
        '
        'DTPDATERETURNEDTO
        '
        Me.DTPDATERETURNEDTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDATERETURNEDTO.Location = New System.Drawing.Point(429, 42)
        Me.DTPDATERETURNEDTO.Name = "DTPDATERETURNEDTO"
        Me.DTPDATERETURNEDTO.Size = New System.Drawing.Size(115, 20)
        Me.DTPDATERETURNEDTO.TabIndex = 92
        '
        'DTPDATEBORROWED
        '
        Me.DTPDATEBORROWED.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDATEBORROWED.Location = New System.Drawing.Point(211, 6)
        Me.DTPDATEBORROWED.Name = "DTPDATEBORROWED"
        Me.DTPDATEBORROWED.Size = New System.Drawing.Size(115, 20)
        Me.DTPDATEBORROWED.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(110, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 32)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "   Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date Borrowed"
        '
        'btncleargt
        '
        Me.btncleargt.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btncleargt.FlatAppearance.BorderSize = 0
        Me.btncleargt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncleargt.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncleargt.ForeColor = System.Drawing.Color.White
        Me.btncleargt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncleargt.Location = New System.Drawing.Point(551, 18)
        Me.btncleargt.Name = "btncleargt"
        Me.btncleargt.Size = New System.Drawing.Size(63, 29)
        Me.btncleargt.TabIndex = 84
        Me.btncleargt.Text = "Clear Filter"
        Me.btncleargt.UseVisualStyleBackColor = False
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(3, 6)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(104, 48)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "KEY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSACTION " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REPORTS"
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
        'DTPDATERETURNED
        '
        Me.DTPDATERETURNED.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDATERETURNED.Location = New System.Drawing.Point(429, 6)
        Me.DTPDATERETURNED.Name = "DTPDATERETURNED"
        Me.DTPDATERETURNED.Size = New System.Drawing.Size(115, 20)
        Me.DTPDATERETURNED.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(334, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 32)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "   Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date Returned"
        '
        'RVGUARDTRANS
        '
        ReportDataSource1.Name = "DataSet_GuardKeyTrans"
        ReportDataSource1.Value = Me.tbl_guardBindingSource
        Me.RVGUARDTRANS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVGUARDTRANS.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTGuardKeyTrans.rdlc"
        Me.RVGUARDTRANS.Location = New System.Drawing.Point(6, 72)
        Me.RVGUARDTRANS.Name = "RVGUARDTRANS"
        Me.RVGUARDTRANS.Size = New System.Drawing.Size(608, 176)
        Me.RVGUARDTRANS.TabIndex = 84
        '
        'tbl_guardTableAdapter
        '
        Me.tbl_guardTableAdapter.ClearBeforeFill = True
        '
        'ucGuardKeyTransReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVGUARDTRANS)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucGuardKeyTransReports"
        Me.Size = New System.Drawing.Size(621, 260)
        CType(Me.tbl_guardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents DTPDATERETURNED As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btncleargt As System.Windows.Forms.Button
    Friend WithEvents DTPDATEBORROWED As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RVGUARDTRANS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_guardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_guardTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_guardTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPDATEBORROWEDTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDATERETURNEDTO As System.Windows.Forms.DateTimePicker

End Class
