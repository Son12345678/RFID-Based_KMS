<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucguardtrans
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNBROWSE = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTKEYTAG = New System.Windows.Forms.TextBox()
        Me.TXTDATEBORROWED = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTROOMNO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTIDTAG = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTCOLLEGE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTTRANSNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNRETURNGUARD = New System.Windows.Forms.Button()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.PNLBROWSEKEYTRANS = New System.Windows.Forms.Panel()
        Me.BTNPROCEED = New System.Windows.Forms.Button()
        Me.DGVkeytrans = New System.Windows.Forms.DataGridView()
        Me.TransactionnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeytagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimeborrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimereturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblkeytransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.BTNCANCELkeytrans = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Tbl_keytransactionTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keytransactionTableAdapter()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.TXTDATERETURNEDTOGUARD = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.PNLBROWSEKEYTRANS.SuspendLayout()
        CType(Me.DGVkeytrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkeytransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 38)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(595, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 22)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "X"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(755, 5)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(23, 22)
        Me.lblClose.TabIndex = 70
        Me.lblClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GUARD"
        '
        'BTNBROWSE
        '
        Me.BTNBROWSE.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNBROWSE.FlatAppearance.BorderSize = 0
        Me.BTNBROWSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBROWSE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBROWSE.ForeColor = System.Drawing.Color.White
        Me.BTNBROWSE.Location = New System.Drawing.Point(271, 90)
        Me.BTNBROWSE.Name = "BTNBROWSE"
        Me.BTNBROWSE.Size = New System.Drawing.Size(29, 22)
        Me.BTNBROWSE.TabIndex = 65
        Me.BTNBROWSE.Text = "..."
        Me.BTNBROWSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNBROWSE.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(341, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 32)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Date Return " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  to Guard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(345, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Key Tag"
        '
        'TXTKEYTAG
        '
        Me.TXTKEYTAG.Enabled = False
        Me.TXTKEYTAG.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKEYTAG.Location = New System.Drawing.Point(419, 87)
        Me.TXTKEYTAG.Name = "TXTKEYTAG"
        Me.TXTKEYTAG.Size = New System.Drawing.Size(179, 22)
        Me.TXTKEYTAG.TabIndex = 62
        '
        'TXTDATEBORROWED
        '
        Me.TXTDATEBORROWED.Enabled = False
        Me.TXTDATEBORROWED.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATEBORROWED.Location = New System.Drawing.Point(419, 159)
        Me.TXTDATEBORROWED.Name = "TXTDATEBORROWED"
        Me.TXTDATEBORROWED.Size = New System.Drawing.Size(179, 22)
        Me.TXTDATEBORROWED.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(345, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 32)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "   Date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrowed"
        '
        'TXTROOMNO
        '
        Me.TXTROOMNO.Enabled = False
        Me.TXTROOMNO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTROOMNO.Location = New System.Drawing.Point(419, 121)
        Me.TXTROOMNO.Name = "TXTROOMNO"
        Me.TXTROOMNO.Size = New System.Drawing.Size(179, 22)
        Me.TXTROOMNO.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(345, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Room No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(27, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Fullname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(27, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "ID Tag"
        '
        'TXTIDTAG
        '
        Me.TXTIDTAG.Enabled = False
        Me.TXTIDTAG.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIDTAG.Location = New System.Drawing.Point(88, 198)
        Me.TXTIDTAG.Name = "TXTIDTAG"
        Me.TXTIDTAG.Size = New System.Drawing.Size(212, 22)
        Me.TXTIDTAG.TabIndex = 55
        '
        'TXTNAME
        '
        Me.TXTNAME.Enabled = False
        Me.TXTNAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.Location = New System.Drawing.Point(88, 162)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(212, 22)
        Me.TXTNAME.TabIndex = 54
        '
        'TXTCOLLEGE
        '
        Me.TXTCOLLEGE.Enabled = False
        Me.TXTCOLLEGE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOLLEGE.Location = New System.Drawing.Point(88, 126)
        Me.TXTCOLLEGE.Name = "TXTCOLLEGE"
        Me.TXTCOLLEGE.Size = New System.Drawing.Size(212, 22)
        Me.TXTCOLLEGE.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(27, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "College"
        '
        'TXTTRANSNO
        '
        Me.TXTTRANSNO.Enabled = False
        Me.TXTTRANSNO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTRANSNO.Location = New System.Drawing.Point(138, 90)
        Me.TXTTRANSNO.Name = "TXTTRANSNO"
        Me.TXTTRANSNO.Size = New System.Drawing.Size(129, 22)
        Me.TXTTRANSNO.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(27, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Transaction No."
        '
        'BTNRETURNGUARD
        '
        Me.BTNRETURNGUARD.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRETURNGUARD.FlatAppearance.BorderSize = 0
        Me.BTNRETURNGUARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRETURNGUARD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETURNGUARD.ForeColor = System.Drawing.Color.White
        Me.BTNRETURNGUARD.Location = New System.Drawing.Point(238, 247)
        Me.BTNRETURNGUARD.Name = "BTNRETURNGUARD"
        Me.BTNRETURNGUARD.Size = New System.Drawing.Size(165, 32)
        Me.BTNRETURNGUARD.TabIndex = 67
        Me.BTNRETURNGUARD.Text = "RETURN KEY"
        Me.BTNRETURNGUARD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNRETURNGUARD.UseVisualStyleBackColor = False
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(7, 49)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(151, 23)
        Me.lblHead2.TabIndex = 69
        Me.lblHead2.Text = "KEY RETURNING"
        '
        'PNLBROWSEKEYTRANS
        '
        Me.PNLBROWSEKEYTRANS.BackColor = System.Drawing.Color.Teal
        Me.PNLBROWSEKEYTRANS.Controls.Add(Me.BTNPROCEED)
        Me.PNLBROWSEKEYTRANS.Controls.Add(Me.DGVkeytrans)
        Me.PNLBROWSEKEYTRANS.Controls.Add(Me.BTNCANCELkeytrans)
        Me.PNLBROWSEKEYTRANS.Controls.Add(Me.Label3)
        Me.PNLBROWSEKEYTRANS.Controls.Add(Me.TXTSEARCH)
        Me.PNLBROWSEKEYTRANS.Location = New System.Drawing.Point(31, 54)
        Me.PNLBROWSEKEYTRANS.Name = "PNLBROWSEKEYTRANS"
        Me.PNLBROWSEKEYTRANS.Size = New System.Drawing.Size(571, 272)
        Me.PNLBROWSEKEYTRANS.TabIndex = 70
        Me.PNLBROWSEKEYTRANS.Visible = False
        '
        'BTNPROCEED
        '
        Me.BTNPROCEED.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNPROCEED.FlatAppearance.BorderSize = 0
        Me.BTNPROCEED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPROCEED.ForeColor = System.Drawing.Color.DarkGreen
        Me.BTNPROCEED.Location = New System.Drawing.Point(276, 8)
        Me.BTNPROCEED.Name = "BTNPROCEED"
        Me.BTNPROCEED.Size = New System.Drawing.Size(196, 22)
        Me.BTNPROCEED.TabIndex = 68
        Me.BTNPROCEED.Text = "Proceed with selected transaction"
        Me.BTNPROCEED.UseVisualStyleBackColor = False
        '
        'DGVkeytrans
        '
        Me.DGVkeytrans.AllowUserToAddRows = False
        Me.DGVkeytrans.AllowUserToDeleteRows = False
        Me.DGVkeytrans.AutoGenerateColumns = False
        Me.DGVkeytrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVkeytrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionnumberDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.IdtagDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.KeytagDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.DatetimeborrowedDataGridViewTextBoxColumn, Me.DatetimereturnedDataGridViewTextBoxColumn, Me.TransactionstatusDataGridViewTextBoxColumn})
        Me.DGVkeytrans.DataSource = Me.TblkeytransactionBindingSource
        Me.DGVkeytrans.Location = New System.Drawing.Point(13, 34)
        Me.DGVkeytrans.Name = "DGVkeytrans"
        Me.DGVkeytrans.ReadOnly = True
        Me.DGVkeytrans.Size = New System.Drawing.Size(545, 225)
        Me.DGVkeytrans.TabIndex = 67
        '
        'TransactionnumberDataGridViewTextBoxColumn
        '
        Me.TransactionnumberDataGridViewTextBoxColumn.DataPropertyName = "transactionnumber"
        Me.TransactionnumberDataGridViewTextBoxColumn.HeaderText = "transactionnumber"
        Me.TransactionnumberDataGridViewTextBoxColumn.Name = "TransactionnumberDataGridViewTextBoxColumn"
        Me.TransactionnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "college"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdtagDataGridViewTextBoxColumn
        '
        Me.IdtagDataGridViewTextBoxColumn.DataPropertyName = "idtag"
        Me.IdtagDataGridViewTextBoxColumn.HeaderText = "idtag"
        Me.IdtagDataGridViewTextBoxColumn.Name = "IdtagDataGridViewTextBoxColumn"
        Me.IdtagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeytagDataGridViewTextBoxColumn
        '
        Me.KeytagDataGridViewTextBoxColumn.DataPropertyName = "keytag"
        Me.KeytagDataGridViewTextBoxColumn.HeaderText = "keytag"
        Me.KeytagDataGridViewTextBoxColumn.Name = "KeytagDataGridViewTextBoxColumn"
        Me.KeytagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "roomnumber"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "roomnumber"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        Me.RoomnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatetimeborrowedDataGridViewTextBoxColumn
        '
        Me.DatetimeborrowedDataGridViewTextBoxColumn.DataPropertyName = "datetimeborrowed"
        Me.DatetimeborrowedDataGridViewTextBoxColumn.HeaderText = "datetimeborrowed"
        Me.DatetimeborrowedDataGridViewTextBoxColumn.Name = "DatetimeborrowedDataGridViewTextBoxColumn"
        Me.DatetimeborrowedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatetimereturnedDataGridViewTextBoxColumn
        '
        Me.DatetimereturnedDataGridViewTextBoxColumn.DataPropertyName = "datetimereturned"
        Me.DatetimereturnedDataGridViewTextBoxColumn.HeaderText = "datetimereturned"
        Me.DatetimereturnedDataGridViewTextBoxColumn.Name = "DatetimereturnedDataGridViewTextBoxColumn"
        Me.DatetimereturnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionstatusDataGridViewTextBoxColumn
        '
        Me.TransactionstatusDataGridViewTextBoxColumn.DataPropertyName = "transactionstatus"
        Me.TransactionstatusDataGridViewTextBoxColumn.HeaderText = "transactionstatus"
        Me.TransactionstatusDataGridViewTextBoxColumn.Name = "TransactionstatusDataGridViewTextBoxColumn"
        Me.TransactionstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblkeytransactionBindingSource
        '
        Me.TblkeytransactionBindingSource.DataMember = "tbl_keytransaction"
        Me.TblkeytransactionBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNCANCELkeytrans
        '
        Me.BTNCANCELkeytrans.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNCANCELkeytrans.FlatAppearance.BorderSize = 0
        Me.BTNCANCELkeytrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCELkeytrans.ForeColor = System.Drawing.Color.DarkGreen
        Me.BTNCANCELkeytrans.Location = New System.Drawing.Point(478, 8)
        Me.BTNCANCELkeytrans.Name = "BTNCANCELkeytrans"
        Me.BTNCANCELkeytrans.Size = New System.Drawing.Size(71, 22)
        Me.BTNCANCELkeytrans.TabIndex = 65
        Me.BTNCANCELkeytrans.Text = "Cancel"
        Me.BTNCANCELkeytrans.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Search"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BackColor = System.Drawing.Color.White
        Me.TXTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.Location = New System.Drawing.Point(69, 11)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(201, 16)
        Me.TXTSEARCH.TabIndex = 63
        '
        'Tbl_keytransactionTableAdapter
        '
        Me.Tbl_keytransactionTableAdapter.ClearBeforeFill = True
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCANCEL.FlatAppearance.BorderSize = 0
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(221, 290)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(196, 32)
        Me.BTNCANCEL.TabIndex = 71
        Me.BTNCANCEL.Text = "CANCEL TRANSACTION"
        Me.BTNCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'TXTDATERETURNEDTOGUARD
        '
        Me.TXTDATERETURNEDTOGUARD.Enabled = False
        Me.TXTDATERETURNEDTOGUARD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATERETURNEDTOGUARD.Location = New System.Drawing.Point(419, 198)
        Me.TXTDATERETURNEDTOGUARD.Name = "TXTDATERETURNEDTOGUARD"
        Me.TXTDATERETURNEDTOGUARD.Size = New System.Drawing.Size(179, 22)
        Me.TXTDATERETURNEDTOGUARD.TabIndex = 72
        '
        'ucguardtrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PNLBROWSEKEYTRANS)
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.BTNRETURNGUARD)
        Me.Controls.Add(Me.BTNBROWSE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTKEYTAG)
        Me.Controls.Add(Me.TXTDATEBORROWED)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTROOMNO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTIDTAG)
        Me.Controls.Add(Me.TXTNAME)
        Me.Controls.Add(Me.TXTCOLLEGE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTTRANSNO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.TXTDATERETURNEDTOGUARD)
        Me.Name = "ucguardtrans"
        Me.Size = New System.Drawing.Size(630, 341)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PNLBROWSEKEYTRANS.ResumeLayout(False)
        Me.PNLBROWSEKEYTRANS.PerformLayout()
        CType(Me.DGVkeytrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkeytransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNBROWSE As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTKEYTAG As System.Windows.Forms.TextBox
    Friend WithEvents TXTDATEBORROWED As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTROOMNO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTIDTAG As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTCOLLEGE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTTRANSNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTNRETURNGUARD As System.Windows.Forms.Button
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents PNLBROWSEKEYTRANS As System.Windows.Forms.Panel
    Friend WithEvents DGVkeytrans As System.Windows.Forms.DataGridView
    Friend WithEvents BTNCANCELkeytrans As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents TransactionnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeytagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatetimeborrowedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatetimereturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblkeytransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents Tbl_keytransactionTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_keytransactionTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNPROCEED As System.Windows.Forms.Button
    Friend WithEvents TXTDATERETURNEDTOGUARD As System.Windows.Forms.TextBox

End Class
