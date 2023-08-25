<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemReturn
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVITEMTRANSACTION = New System.Windows.Forms.DataGridView()
        Me.TransactionnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardtagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowersnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateborrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatereturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeborrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimereturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblitemtransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.BTNCLEAR = New System.Windows.Forms.Button()
        Me.BTNBorrowSave = New System.Windows.Forms.Button()
        Me.TXTITEM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTBORROWERSNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TXTITEMNAME = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTQUANTITY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTTRANSNO = New System.Windows.Forms.TextBox()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Tbl_itemtransactionTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemtransactionTableAdapter()
        Me.TXTTRANSNUMBER = New System.Windows.Forms.TextBox()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVITEMTRANSACTION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.DGVITEMTRANSACTION)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TXTSEARCH)
        Me.Panel3.Location = New System.Drawing.Point(268, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(414, 322)
        Me.Panel3.TabIndex = 78
        '
        'DGVITEMTRANSACTION
        '
        Me.DGVITEMTRANSACTION.AllowUserToAddRows = False
        Me.DGVITEMTRANSACTION.AllowUserToDeleteRows = False
        Me.DGVITEMTRANSACTION.AutoGenerateColumns = False
        Me.DGVITEMTRANSACTION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVITEMTRANSACTION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionnumberDataGridViewTextBoxColumn, Me.ItemnoDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.CardtagDataGridViewTextBoxColumn, Me.BorrowersnameDataGridViewTextBoxColumn, Me.DateborrowedDataGridViewTextBoxColumn, Me.DatereturnedDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TransactionstatusDataGridViewTextBoxColumn, Me.TimeborrowedDataGridViewTextBoxColumn, Me.TimereturnedDataGridViewTextBoxColumn})
        Me.DGVITEMTRANSACTION.DataSource = Me.TblitemtransactionBindingSource
        Me.DGVITEMTRANSACTION.Location = New System.Drawing.Point(13, 43)
        Me.DGVITEMTRANSACTION.Name = "DGVITEMTRANSACTION"
        Me.DGVITEMTRANSACTION.ReadOnly = True
        Me.DGVITEMTRANSACTION.Size = New System.Drawing.Size(385, 269)
        Me.DGVITEMTRANSACTION.TabIndex = 83
        '
        'TransactionnumberDataGridViewTextBoxColumn
        '
        Me.TransactionnumberDataGridViewTextBoxColumn.DataPropertyName = "transactionnumber"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.TransactionnumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TransactionnumberDataGridViewTextBoxColumn.HeaderText = "Trans No."
        Me.TransactionnumberDataGridViewTextBoxColumn.Name = "TransactionnumberDataGridViewTextBoxColumn"
        Me.TransactionnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnoDataGridViewTextBoxColumn
        '
        Me.ItemnoDataGridViewTextBoxColumn.DataPropertyName = "itemno"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ItemnoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemnoDataGridViewTextBoxColumn.HeaderText = "Item No"
        Me.ItemnoDataGridViewTextBoxColumn.Name = "ItemnoDataGridViewTextBoxColumn"
        Me.ItemnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.CollegeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CardtagDataGridViewTextBoxColumn
        '
        Me.CardtagDataGridViewTextBoxColumn.DataPropertyName = "cardtag"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.CardtagDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CardtagDataGridViewTextBoxColumn.HeaderText = "Card Tag"
        Me.CardtagDataGridViewTextBoxColumn.Name = "CardtagDataGridViewTextBoxColumn"
        Me.CardtagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowersnameDataGridViewTextBoxColumn
        '
        Me.BorrowersnameDataGridViewTextBoxColumn.DataPropertyName = "borrowersname"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.BorrowersnameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BorrowersnameDataGridViewTextBoxColumn.HeaderText = "Borrowers Name"
        Me.BorrowersnameDataGridViewTextBoxColumn.Name = "BorrowersnameDataGridViewTextBoxColumn"
        Me.BorrowersnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateborrowedDataGridViewTextBoxColumn
        '
        Me.DateborrowedDataGridViewTextBoxColumn.DataPropertyName = "dateborrowed"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DateborrowedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DateborrowedDataGridViewTextBoxColumn.HeaderText = "Date Borrowed"
        Me.DateborrowedDataGridViewTextBoxColumn.Name = "DateborrowedDataGridViewTextBoxColumn"
        Me.DateborrowedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatereturnedDataGridViewTextBoxColumn
        '
        Me.DatereturnedDataGridViewTextBoxColumn.DataPropertyName = "datereturned"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DatereturnedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DatereturnedDataGridViewTextBoxColumn.HeaderText = "Date Returned"
        Me.DatereturnedDataGridViewTextBoxColumn.Name = "DatereturnedDataGridViewTextBoxColumn"
        Me.DatereturnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionstatusDataGridViewTextBoxColumn
        '
        Me.TransactionstatusDataGridViewTextBoxColumn.DataPropertyName = "transactionstatus"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.TransactionstatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.TransactionstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.TransactionstatusDataGridViewTextBoxColumn.Name = "TransactionstatusDataGridViewTextBoxColumn"
        Me.TransactionstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeborrowedDataGridViewTextBoxColumn
        '
        Me.TimeborrowedDataGridViewTextBoxColumn.DataPropertyName = "timeborrowed"
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.TimeborrowedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TimeborrowedDataGridViewTextBoxColumn.HeaderText = "Time Borrowed"
        Me.TimeborrowedDataGridViewTextBoxColumn.Name = "TimeborrowedDataGridViewTextBoxColumn"
        Me.TimeborrowedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimereturnedDataGridViewTextBoxColumn
        '
        Me.TimereturnedDataGridViewTextBoxColumn.DataPropertyName = "timereturned"
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.TimereturnedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.TimereturnedDataGridViewTextBoxColumn.HeaderText = "Time Returned"
        Me.TimereturnedDataGridViewTextBoxColumn.Name = "TimereturnedDataGridViewTextBoxColumn"
        Me.TimereturnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblitemtransactionBindingSource
        '
        Me.TblitemtransactionBindingSource.DataMember = "tbl_itemtransaction"
        Me.TblitemtransactionBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Search"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BackColor = System.Drawing.Color.White
        Me.TXTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.Location = New System.Drawing.Point(73, 14)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(325, 23)
        Me.TXTSEARCH.TabIndex = 81
        '
        'BTNCLEAR
        '
        Me.BTNCLEAR.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNCLEAR.FlatAppearance.BorderSize = 0
        Me.BTNCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEAR.ForeColor = System.Drawing.Color.White
        Me.BTNCLEAR.Location = New System.Drawing.Point(13, 19)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.Size = New System.Drawing.Size(106, 40)
        Me.BTNCLEAR.TabIndex = 4
        Me.BTNCLEAR.Text = "CANCEL"
        Me.BTNCLEAR.UseVisualStyleBackColor = False
        '
        'BTNBorrowSave
        '
        Me.BTNBorrowSave.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNBorrowSave.FlatAppearance.BorderSize = 0
        Me.BTNBorrowSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBorrowSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBorrowSave.ForeColor = System.Drawing.Color.White
        Me.BTNBorrowSave.Location = New System.Drawing.Point(128, 19)
        Me.BTNBorrowSave.Name = "BTNBorrowSave"
        Me.BTNBorrowSave.Size = New System.Drawing.Size(106, 40)
        Me.BTNBorrowSave.TabIndex = 3
        Me.BTNBorrowSave.Text = "RETURN ITEM"
        Me.BTNBorrowSave.UseVisualStyleBackColor = False
        '
        'TXTITEM
        '
        Me.TXTITEM.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTITEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTITEM.Enabled = False
        Me.TXTITEM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTITEM.Location = New System.Drawing.Point(15, 100)
        Me.TXTITEM.Name = "TXTITEM"
        Me.TXTITEM.Size = New System.Drawing.Size(219, 23)
        Me.TXTITEM.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(15, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Item No."
        '
        'TXTBORROWERSNAME
        '
        Me.TXTBORROWERSNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTBORROWERSNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTBORROWERSNAME.Enabled = False
        Me.TXTBORROWERSNAME.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBORROWERSNAME.Location = New System.Drawing.Point(15, 50)
        Me.TXTBORROWERSNAME.Name = "TXTBORROWERSNAME"
        Me.TXTBORROWERSNAME.Size = New System.Drawing.Size(219, 23)
        Me.TXTBORROWERSNAME.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Borrowers Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.BTNCLEAR)
        Me.Panel2.Controls.Add(Me.BTNBorrowSave)
        Me.Panel2.Location = New System.Drawing.Point(15, 314)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 78)
        Me.Panel2.TabIndex = 77
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MintCream
        Me.Panel6.Controls.Add(Me.TXTITEMNAME)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.TXTQUANTITY)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.TXTITEM)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.TXTBORROWERSNAME)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(15, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(247, 238)
        Me.Panel6.TabIndex = 76
        '
        'TXTITEMNAME
        '
        Me.TXTITEMNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTITEMNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTITEMNAME.Enabled = False
        Me.TXTITEMNAME.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTITEMNAME.Location = New System.Drawing.Point(17, 153)
        Me.TXTITEMNAME.Name = "TXTITEMNAME"
        Me.TXTITEMNAME.Size = New System.Drawing.Size(219, 23)
        Me.TXTITEMNAME.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(18, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Item Name"
        '
        'TXTQUANTITY
        '
        Me.TXTQUANTITY.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTQUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTQUANTITY.Enabled = False
        Me.TXTQUANTITY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQUANTITY.Location = New System.Drawing.Point(14, 202)
        Me.TXTQUANTITY.Name = "TXTQUANTITY"
        Me.TXTQUANTITY.Size = New System.Drawing.Size(220, 23)
        Me.TXTQUANTITY.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(15, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Quantity"
        '
        'TXTTRANSNO
        '
        Me.TXTTRANSNO.Location = New System.Drawing.Point(307, 32)
        Me.TXTTRANSNO.Name = "TXTTRANSNO"
        Me.TXTTRANSNO.Size = New System.Drawing.Size(100, 20)
        Me.TXTTRANSNO.TabIndex = 79
        Me.TXTTRANSNO.Visible = False
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(19, 32)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(157, 23)
        Me.lblHead2.TabIndex = 75
        Me.lblHead2.Text = "ITEM RETURNING"
        '
        'Tbl_itemtransactionTableAdapter
        '
        Me.Tbl_itemtransactionTableAdapter.ClearBeforeFill = True
        '
        'TXTTRANSNUMBER
        '
        Me.TXTTRANSNUMBER.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TXTTRANSNUMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTRANSNUMBER.Enabled = False
        Me.TXTTRANSNUMBER.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTRANSNUMBER.Location = New System.Drawing.Point(191, 32)
        Me.TXTTRANSNUMBER.Name = "TXTTRANSNUMBER"
        Me.TXTTRANSNUMBER.Size = New System.Drawing.Size(101, 23)
        Me.TXTTRANSNUMBER.TabIndex = 80
        Me.TXTTRANSNUMBER.Visible = False
        '
        'ucItemReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.TXTTRANSNUMBER)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.TXTTRANSNO)
        Me.Name = "ucItemReturn"
        Me.Size = New System.Drawing.Size(696, 424)
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVITEMTRANSACTION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BTNCLEAR As System.Windows.Forms.Button
    Friend WithEvents BTNBorrowSave As System.Windows.Forms.Button
    Friend WithEvents TXTITEM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTBORROWERSNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents TXTQUANTITY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents TXTTRANSNO As System.Windows.Forms.TextBox
    Friend WithEvents DGVITEMTRANSACTION As System.Windows.Forms.DataGridView
    Friend WithEvents TblitemtransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_itemtransactionTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemtransactionTableAdapter
    Friend WithEvents TransactionnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardtagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowersnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateborrowedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatereturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeborrowedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimereturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTITEMNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTTRANSNUMBER As System.Windows.Forms.TextBox

End Class
