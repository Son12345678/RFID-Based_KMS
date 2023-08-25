<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRoomKeyReports
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
        Me.tbl_keyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTFILTERBYKEYTAG = New System.Windows.Forms.TextBox()
        Me.CBOFILTERBYROOMNO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOFILTERBYKEYOWNERSHIP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTNCLEARFILTER = New System.Windows.Forms.Button()
        Me.RVRoomKey = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_keyTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keyTableAdapter()
        CType(Me.tbl_keyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_keyBindingSource
        '
        Me.tbl_keyBindingSource.DataMember = "tbl_key"
        Me.tbl_keyBindingSource.DataSource = Me.db_kmsDataSet
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
        Me.lblHead2.Location = New System.Drawing.Point(4, 5)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(94, 38)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "ROOM KEY " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " REPORTS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.TXTFILTERBYKEYTAG)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYROOMNO)
        Me.Panel3.Controls.Add(Me.lblHead2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CBOFILTERBYKEYOWNERSHIP)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.BTNCLEARFILTER)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(851, 54)
        Me.Panel3.TabIndex = 78
        '
        'TXTFILTERBYKEYTAG
        '
        Me.TXTFILTERBYKEYTAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFILTERBYKEYTAG.Location = New System.Drawing.Point(446, 15)
        Me.TXTFILTERBYKEYTAG.Name = "TXTFILTERBYKEYTAG"
        Me.TXTFILTERBYKEYTAG.Size = New System.Drawing.Size(100, 21)
        Me.TXTFILTERBYKEYTAG.TabIndex = 69
        '
        'CBOFILTERBYROOMNO
        '
        Me.CBOFILTERBYROOMNO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYROOMNO.FormattingEnabled = True
        Me.CBOFILTERBYROOMNO.Location = New System.Drawing.Point(643, 13)
        Me.CBOFILTERBYROOMNO.Name = "CBOFILTERBYROOMNO"
        Me.CBOFILTERBYROOMNO.Size = New System.Drawing.Size(85, 25)
        Me.CBOFILTERBYROOMNO.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(384, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 32)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Filter by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Key Tag"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 32)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Filter by Key " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Ownership"
        '
        'CBOFILTERBYKEYOWNERSHIP
        '
        Me.CBOFILTERBYKEYOWNERSHIP.Enabled = False
        Me.CBOFILTERBYKEYOWNERSHIP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOFILTERBYKEYOWNERSHIP.FormattingEnabled = True
        Me.CBOFILTERBYKEYOWNERSHIP.Items.AddRange(New Object() {"College of Computer Studies", "College of Business", "College of Accountancy", "General Services Office"})
        Me.CBOFILTERBYKEYOWNERSHIP.Location = New System.Drawing.Point(209, 13)
        Me.CBOFILTERBYKEYOWNERSHIP.Name = "CBOFILTERBYKEYOWNERSHIP"
        Me.CBOFILTERBYKEYOWNERSHIP.Size = New System.Drawing.Size(159, 25)
        Me.CBOFILTERBYKEYOWNERSHIP.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(573, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 32)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Filter by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room No."
        '
        'BTNCLEARFILTER
        '
        Me.BTNCLEARFILTER.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCLEARFILTER.FlatAppearance.BorderSize = 0
        Me.BTNCLEARFILTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEARFILTER.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEARFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNCLEARFILTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLEARFILTER.Location = New System.Drawing.Point(752, 9)
        Me.BTNCLEARFILTER.Name = "BTNCLEARFILTER"
        Me.BTNCLEARFILTER.Size = New System.Drawing.Size(84, 30)
        Me.BTNCLEARFILTER.TabIndex = 19
        Me.BTNCLEARFILTER.Text = "Clear Filter"
        Me.BTNCLEARFILTER.UseVisualStyleBackColor = False
        '
        'RVRoomKey
        '
        ReportDataSource2.Name = "DataSet_roomkey"
        ReportDataSource2.Value = Me.tbl_keyBindingSource
        Me.RVRoomKey.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RVRoomKey.LocalReport.ReportEmbeddedResource = "RFID_Based_KMS.RPTRoomKey.rdlc"
        Me.RVRoomKey.Location = New System.Drawing.Point(3, 56)
        Me.RVRoomKey.Name = "RVRoomKey"
        Me.RVRoomKey.Size = New System.Drawing.Size(848, 343)
        Me.RVRoomKey.TabIndex = 79
        '
        'tbl_keyTableAdapter
        '
        Me.tbl_keyTableAdapter.ClearBeforeFill = True
        '
        'ucRoomKeyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RVRoomKey)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ucRoomKeyReports"
        Me.Size = New System.Drawing.Size(851, 406)
        CType(Me.tbl_keyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOFILTERBYKEYOWNERSHIP As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNCLEARFILTER As System.Windows.Forms.Button
    Friend WithEvents RVRoomKey As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_keyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents tbl_keyTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keyTableAdapter
    Friend WithEvents TXTFILTERBYKEYTAG As System.Windows.Forms.TextBox
    Friend WithEvents CBOFILTERBYROOMNO As System.Windows.Forms.ComboBox

End Class
