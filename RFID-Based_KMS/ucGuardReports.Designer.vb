<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGuardReports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNActivityLogReports = New System.Windows.Forms.Button()
        Me.BTNActlog = New System.Windows.Forms.Button()
        Me.BTNTransactionReports = New System.Windows.Forms.Button()
        Me.pnlguardreports = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.lblHead2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 36)
        Me.Panel1.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(598, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 22)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "X"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.BTNActivityLogReports)
        Me.Panel2.Controls.Add(Me.BTNActlog)
        Me.Panel2.Controls.Add(Me.BTNTransactionReports)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 36)
        Me.Panel2.TabIndex = 56
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
        'BTNActlog
        '
        Me.BTNActlog.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNActlog.FlatAppearance.BorderSize = 0
        Me.BTNActlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNActlog.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActlog.ForeColor = System.Drawing.Color.White
        Me.BTNActlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNActlog.Location = New System.Drawing.Point(158, 3)
        Me.BTNActlog.Name = "BTNActlog"
        Me.BTNActlog.Size = New System.Drawing.Size(123, 27)
        Me.BTNActlog.TabIndex = 20
        Me.BTNActlog.Text = "ACTIVITY LOG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNActlog.UseVisualStyleBackColor = False
        '
        'BTNTransactionReports
        '
        Me.BTNTransactionReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNTransactionReports.FlatAppearance.BorderSize = 0
        Me.BTNTransactionReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTransactionReports.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTransactionReports.ForeColor = System.Drawing.Color.White
        Me.BTNTransactionReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNTransactionReports.Location = New System.Drawing.Point(14, 3)
        Me.BTNTransactionReports.Name = "BTNTransactionReports"
        Me.BTNTransactionReports.Size = New System.Drawing.Size(123, 27)
        Me.BTNTransactionReports.TabIndex = 16
        Me.BTNTransactionReports.Text = "KEY TRANSACTION"
        Me.BTNTransactionReports.UseVisualStyleBackColor = False
        '
        'pnlguardreports
        '
        Me.pnlguardreports.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlguardreports.Location = New System.Drawing.Point(3, 76)
        Me.pnlguardreports.Name = "pnlguardreports"
        Me.pnlguardreports.Size = New System.Drawing.Size(621, 260)
        Me.pnlguardreports.TabIndex = 57
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
        'ucGuardReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlguardreports)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucGuardReports"
        Me.Size = New System.Drawing.Size(630, 341)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BTNActivityLogReports As System.Windows.Forms.Button
    Friend WithEvents BTNActlog As System.Windows.Forms.Button
    Friend WithEvents BTNTransactionReports As System.Windows.Forms.Button
    Friend WithEvents pnlguardreports As System.Windows.Forms.Panel

End Class
