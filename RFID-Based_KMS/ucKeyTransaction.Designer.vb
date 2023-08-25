<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucKeyTransaction
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
        Me.PNLTRANSACTION = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnblank = New System.Windows.Forms.Button()
        Me.BTNRETURN = New System.Windows.Forms.Button()
        Me.BTNBORROW = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNLTRANSACTION
        '
        Me.PNLTRANSACTION.BackColor = System.Drawing.SystemColors.Control
        Me.PNLTRANSACTION.Location = New System.Drawing.Point(12, 99)
        Me.PNLTRANSACTION.Name = "PNLTRANSACTION"
        Me.PNLTRANSACTION.Size = New System.Drawing.Size(846, 398)
        Me.PNLTRANSACTION.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.btnblank)
        Me.Panel3.Controls.Add(Me.BTNRETURN)
        Me.Panel3.Controls.Add(Me.BTNBORROW)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(876, 45)
        Me.Panel3.TabIndex = 52
        '
        'btnblank
        '
        Me.btnblank.BackColor = System.Drawing.Color.DarkCyan
        Me.btnblank.FlatAppearance.BorderSize = 0
        Me.btnblank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnblank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnblank.ForeColor = System.Drawing.Color.White
        Me.btnblank.Location = New System.Drawing.Point(293, 6)
        Me.btnblank.Name = "btnblank"
        Me.btnblank.Size = New System.Drawing.Size(128, 29)
        Me.btnblank.TabIndex = 8
        Me.btnblank.Text = "blank"
        Me.btnblank.UseVisualStyleBackColor = False
        Me.btnblank.Visible = False
        '
        'BTNRETURN
        '
        Me.BTNRETURN.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRETURN.FlatAppearance.BorderSize = 0
        Me.BTNRETURN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BTNRETURN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRETURN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETURN.ForeColor = System.Drawing.Color.White
        Me.BTNRETURN.Location = New System.Drawing.Point(148, 8)
        Me.BTNRETURN.Name = "BTNRETURN"
        Me.BTNRETURN.Size = New System.Drawing.Size(130, 29)
        Me.BTNRETURN.TabIndex = 7
        Me.BTNRETURN.Text = "RETURN"
        Me.BTNRETURN.UseVisualStyleBackColor = False
        '
        'BTNBORROW
        '
        Me.BTNBORROW.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNBORROW.FlatAppearance.BorderSize = 0
        Me.BTNBORROW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBORROW.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBORROW.ForeColor = System.Drawing.Color.White
        Me.BTNBORROW.Location = New System.Drawing.Point(12, 8)
        Me.BTNBORROW.Name = "BTNBORROW"
        Me.BTNBORROW.Size = New System.Drawing.Size(130, 29)
        Me.BTNBORROW.TabIndex = 6
        Me.BTNBORROW.Text = "BORROW "
        Me.BTNBORROW.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 49
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(845, 8)
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
        Me.lblHead2.Size = New System.Drawing.Size(179, 22)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "KEY TRANSACTION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.transaction
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ucKeyTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PNLTRANSACTION)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucKeyTransaction"
        Me.Size = New System.Drawing.Size(876, 509)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PNLTRANSACTION As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents BTNRETURN As System.Windows.Forms.Button
    Friend WithEvents BTNBORROW As System.Windows.Forms.Button
    Friend WithEvents btnblank As System.Windows.Forms.Button

End Class
