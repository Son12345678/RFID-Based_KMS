<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemQuantitySettings
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
        Me.TXTSEARCHITEM = New System.Windows.Forms.TextBox()
        Me.TXTitemname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOitemcat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVITEMSETTINGS = New System.Windows.Forms.DataGridView()
        Me.Db_kmsDataSet = New RFID_Based_KMS.db_kmsDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTitemno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOstatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOitemownership = New System.Windows.Forms.ComboBox()
        Me.TXTquantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.TblitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_itemTableAdapter = New RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemTableAdapter()
        Me.ItemnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemownershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVITEMSETTINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PNLSettings.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTSEARCHITEM
        '
        Me.TXTSEARCHITEM.Location = New System.Drawing.Point(77, 26)
        Me.TXTSEARCHITEM.Name = "TXTSEARCHITEM"
        Me.TXTSEARCHITEM.Size = New System.Drawing.Size(224, 20)
        Me.TXTSEARCHITEM.TabIndex = 50
        '
        'TXTitemname
        '
        Me.TXTitemname.Enabled = False
        Me.TXTitemname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTitemname.Location = New System.Drawing.Point(113, 49)
        Me.TXTitemname.Name = "TXTitemname"
        Me.TXTitemname.Size = New System.Drawing.Size(151, 22)
        Me.TXTitemname.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(11, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Item Category"
        '
        'CBOitemcat
        '
        Me.CBOitemcat.Enabled = False
        Me.CBOitemcat.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOitemcat.FormattingEnabled = True
        Me.CBOitemcat.Location = New System.Drawing.Point(114, 84)
        Me.CBOitemcat.Name = "CBOitemcat"
        Me.CBOitemcat.Size = New System.Drawing.Size(151, 25)
        Me.CBOitemcat.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Item Name"
        '
        'DGVITEMSETTINGS
        '
        Me.DGVITEMSETTINGS.AllowUserToAddRows = False
        Me.DGVITEMSETTINGS.AllowUserToDeleteRows = False
        Me.DGVITEMSETTINGS.AutoGenerateColumns = False
        Me.DGVITEMSETTINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVITEMSETTINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemnoDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemcategoryDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.ItemownershipDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVITEMSETTINGS.DataSource = Me.TblitemBindingSource
        Me.DGVITEMSETTINGS.Location = New System.Drawing.Point(17, 62)
        Me.DGVITEMSETTINGS.Name = "DGVITEMSETTINGS"
        Me.DGVITEMSETTINGS.ReadOnly = True
        Me.DGVITEMSETTINGS.Size = New System.Drawing.Size(284, 258)
        Me.DGVITEMSETTINGS.TabIndex = 48
        '
        'Db_kmsDataSet
        '
        Me.Db_kmsDataSet.DataSetName = "db_kmsDataSet"
        Me.Db_kmsDataSet.EnforceConstraints = False
        Me.Db_kmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Item No."
        '
        'TXTitemno
        '
        Me.TXTitemno.Enabled = False
        Me.TXTitemno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTitemno.Location = New System.Drawing.Point(113, 15)
        Me.TXTitemno.Name = "TXTitemno"
        Me.TXTitemno.Size = New System.Drawing.Size(151, 22)
        Me.TXTitemno.TabIndex = 52
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.CBOstatus)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.CBOitemownership)
        Me.Panel4.Controls.Add(Me.TXTquantity)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TXTitemname)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.CBOitemcat)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTitemno)
        Me.Panel4.Location = New System.Drawing.Point(22, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 226)
        Me.Panel4.TabIndex = 75
        '
        'CBOstatus
        '
        Me.CBOstatus.Enabled = False
        Me.CBOstatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOstatus.FormattingEnabled = True
        Me.CBOstatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOstatus.Location = New System.Drawing.Point(112, 189)
        Me.CBOstatus.Name = "CBOstatus"
        Me.CBOstatus.Size = New System.Drawing.Size(152, 25)
        Me.CBOstatus.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(18, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(13, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Item Ownership"
        '
        'CBOitemownership
        '
        Me.CBOitemownership.Enabled = False
        Me.CBOitemownership.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOitemownership.FormattingEnabled = True
        Me.CBOitemownership.Location = New System.Drawing.Point(113, 154)
        Me.CBOitemownership.Name = "CBOitemownership"
        Me.CBOitemownership.Size = New System.Drawing.Size(152, 25)
        Me.CBOitemownership.TabIndex = 64
        '
        'TXTquantity
        '
        Me.TXTquantity.Enabled = False
        Me.TXTquantity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTquantity.Location = New System.Drawing.Point(113, 120)
        Me.TXTquantity.Name = "TXTquantity"
        Me.TXTquantity.Size = New System.Drawing.Size(152, 22)
        Me.TXTquantity.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(13, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Quantity"
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
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.Color.MintCream
        Me.PNLSettings.Controls.Add(Me.DGVITEMSETTINGS)
        Me.PNLSettings.Controls.Add(Me.TXTSEARCHITEM)
        Me.PNLSettings.Controls.Add(Me.Label8)
        Me.PNLSettings.Location = New System.Drawing.Point(309, 48)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(316, 343)
        Me.PNLSettings.TabIndex = 76
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.BTNSAVE)
        Me.Panel5.Controls.Add(Me.BTNADD)
        Me.Panel5.Controls.Add(Me.BTNCANCEL)
        Me.Panel5.Controls.Add(Me.BTNEDIT)
        Me.Panel5.Location = New System.Drawing.Point(22, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 106)
        Me.Panel5.TabIndex = 74
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblHead2.Location = New System.Drawing.Point(18, 17)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(50, 19)
        Me.lblHead2.TabIndex = 73
        Me.lblHead2.Text = "ITEMS"
        '
        'TblitemBindingSource
        '
        Me.TblitemBindingSource.DataMember = "tbl_item"
        Me.TblitemBindingSource.DataSource = Me.Db_kmsDataSet
        '
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'ItemnoDataGridViewTextBoxColumn
        '
        Me.ItemnoDataGridViewTextBoxColumn.DataPropertyName = "itemno"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.ItemnoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ItemnoDataGridViewTextBoxColumn.HeaderText = "Item No."
        Me.ItemnoDataGridViewTextBoxColumn.Name = "ItemnoDataGridViewTextBoxColumn"
        Me.ItemnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ItemnameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcategoryDataGridViewTextBoxColumn
        '
        Me.ItemcategoryDataGridViewTextBoxColumn.DataPropertyName = "itemcategory"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ItemcategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemcategoryDataGridViewTextBoxColumn.HeaderText = "Item Category"
        Me.ItemcategoryDataGridViewTextBoxColumn.Name = "ItemcategoryDataGridViewTextBoxColumn"
        Me.ItemcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemownershipDataGridViewTextBoxColumn
        '
        Me.ItemownershipDataGridViewTextBoxColumn.DataPropertyName = "itemownership"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ItemownershipDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ItemownershipDataGridViewTextBoxColumn.HeaderText = "Item Ownership"
        Me.ItemownershipDataGridViewTextBoxColumn.Name = "ItemownershipDataGridViewTextBoxColumn"
        Me.ItemownershipDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemownershipDataGridViewTextBoxColumn.Width = 130
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ucItemQuantitySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PNLSettings)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lblHead2)
        Me.Name = "ucItemQuantitySettings"
        Me.Size = New System.Drawing.Size(643, 409)
        CType(Me.DGVITEMSETTINGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_kmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PNLSettings.ResumeLayout(False)
        Me.PNLSettings.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.TblitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTSEARCHITEM As System.Windows.Forms.TextBox
    Friend WithEvents Db_kmsDataSet As RFID_Based_KMS.db_kmsDataSet
    Friend WithEvents TXTitemname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOitemcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVITEMSETTINGS As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTitemno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BTNSAVE As System.Windows.Forms.Button
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents BTNCANCEL As System.Windows.Forms.Button
    Friend WithEvents BTNEDIT As System.Windows.Forms.Button
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents CBOstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOitemownership As System.Windows.Forms.ComboBox
    Friend WithEvents TXTquantity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TblitemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_itemTableAdapter As RFID_Based_KMS.db_kmsDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents ItemnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemcategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemownershipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
