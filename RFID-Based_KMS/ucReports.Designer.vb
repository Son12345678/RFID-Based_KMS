<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReports
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PNLReports = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNActivityLogReports = New System.Windows.Forms.Button()
        Me.BTNItemTrans = New System.Windows.Forms.Button()
        Me.BTNAccountReports = New System.Windows.Forms.Button()
        Me.BTNRoomKeyReports = New System.Windows.Forms.Button()
        Me.BTNTransactionReports = New System.Windows.Forms.Button()
        Me.BTNProfileReports = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(842, 8)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(23, 22)
        Me.lblClose.TabIndex = 68
        Me.lblClose.Text = "X"
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.BackColor = System.Drawing.Color.Transparent
        Me.lblHead2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead2.ForeColor = System.Drawing.Color.White
        Me.lblHead2.Location = New System.Drawing.Point(48, 8)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(89, 22)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "REPORTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.lblHead2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 38)
        Me.Panel1.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.reports
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PNLReports
        '
        Me.PNLReports.BackColor = System.Drawing.SystemColors.Control
        Me.PNLReports.Location = New System.Drawing.Point(11, 89)
        Me.PNLReports.Name = "PNLReports"
        Me.PNLReports.Size = New System.Drawing.Size(851, 406)
        Me.PNLReports.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.BTNActivityLogReports)
        Me.Panel2.Controls.Add(Me.BTNItemTrans)
        Me.Panel2.Controls.Add(Me.BTNAccountReports)
        Me.Panel2.Controls.Add(Me.BTNRoomKeyReports)
        Me.Panel2.Controls.Add(Me.BTNTransactionReports)
        Me.Panel2.Controls.Add(Me.BTNProfileReports)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 45)
        Me.Panel2.TabIndex = 55
        '
        'BTNActivityLogReports
        '
        Me.BTNActivityLogReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNActivityLogReports.FlatAppearance.BorderSize = 0
        Me.BTNActivityLogReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNActivityLogReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActivityLogReports.ForeColor = System.Drawing.Color.White
        Me.BTNActivityLogReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNActivityLogReports.Location = New System.Drawing.Point(731, 6)
        Me.BTNActivityLogReports.Name = "BTNActivityLogReports"
        Me.BTNActivityLogReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNActivityLogReports.TabIndex = 15
        Me.BTNActivityLogReports.Text = "ACTIVITY LOG"
        Me.BTNActivityLogReports.UseVisualStyleBackColor = False
        '
        'BTNItemTrans
        '
        Me.BTNItemTrans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNItemTrans.FlatAppearance.BorderSize = 0
        Me.BTNItemTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNItemTrans.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNItemTrans.ForeColor = System.Drawing.Color.White
        Me.BTNItemTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNItemTrans.Location = New System.Drawing.Point(589, 6)
        Me.BTNItemTrans.Name = "BTNItemTrans"
        Me.BTNItemTrans.Size = New System.Drawing.Size(123, 27)
        Me.BTNItemTrans.TabIndex = 20
        Me.BTNItemTrans.Text = "ITEM TRANSACTION"
        Me.BTNItemTrans.UseVisualStyleBackColor = False
        '
        'BTNAccountReports
        '
        Me.BTNAccountReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNAccountReports.FlatAppearance.BorderSize = 0
        Me.BTNAccountReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAccountReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAccountReports.ForeColor = System.Drawing.Color.White
        Me.BTNAccountReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAccountReports.Location = New System.Drawing.Point(14, 6)
        Me.BTNAccountReports.Name = "BTNAccountReports"
        Me.BTNAccountReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNAccountReports.TabIndex = 19
        Me.BTNAccountReports.Text = "ACCOUNT"
        Me.BTNAccountReports.UseVisualStyleBackColor = False
        '
        'BTNRoomKeyReports
        '
        Me.BTNRoomKeyReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRoomKeyReports.FlatAppearance.BorderSize = 0
        Me.BTNRoomKeyReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRoomKeyReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRoomKeyReports.ForeColor = System.Drawing.Color.White
        Me.BTNRoomKeyReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRoomKeyReports.Location = New System.Drawing.Point(160, 6)
        Me.BTNRoomKeyReports.Name = "BTNRoomKeyReports"
        Me.BTNRoomKeyReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNRoomKeyReports.TabIndex = 18
        Me.BTNRoomKeyReports.Text = "ROOM KEY"
        Me.BTNRoomKeyReports.UseVisualStyleBackColor = False
        '
        'BTNTransactionReports
        '
        Me.BTNTransactionReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNTransactionReports.FlatAppearance.BorderSize = 0
        Me.BTNTransactionReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTransactionReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTransactionReports.ForeColor = System.Drawing.Color.White
        Me.BTNTransactionReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNTransactionReports.Location = New System.Drawing.Point(446, 7)
        Me.BTNTransactionReports.Name = "BTNTransactionReports"
        Me.BTNTransactionReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNTransactionReports.TabIndex = 16
        Me.BTNTransactionReports.Text = "KEY TRANSACTION"
        Me.BTNTransactionReports.UseVisualStyleBackColor = False
        '
        'BTNProfileReports
        '
        Me.BTNProfileReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNProfileReports.FlatAppearance.BorderSize = 0
        Me.BTNProfileReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNProfileReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNProfileReports.ForeColor = System.Drawing.Color.White
        Me.BTNProfileReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNProfileReports.Location = New System.Drawing.Point(307, 6)
        Me.BTNProfileReports.Name = "BTNProfileReports"
        Me.BTNProfileReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNProfileReports.TabIndex = 17
        Me.BTNProfileReports.Text = "PROFILE"
        Me.BTNProfileReports.UseVisualStyleBackColor = False
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNLReports)
        Me.Name = "ucReports"
        Me.Size = New System.Drawing.Size(876, 509)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PNLReports As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BTNAccountReports As System.Windows.Forms.Button
    Friend WithEvents BTNRoomKeyReports As System.Windows.Forms.Button
    Friend WithEvents BTNProfileReports As System.Windows.Forms.Button
    Friend WithEvents BTNTransactionReports As System.Windows.Forms.Button
    Friend WithEvents BTNActivityLogReports As System.Windows.Forms.Button
    Friend WithEvents BTNItemTrans As System.Windows.Forms.Button

End Class
