<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHome
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
        Me.LBLBROFILECOUNT = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLITEMTRANS = New System.Windows.Forms.Label()
        Me.LBLRETURNEDKEYS = New System.Windows.Forms.Label()
        Me.LBLBORROWEDKEYS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerRefreshBorrow = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRefreshReturn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRefreshItem = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFilterAdmin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLBROFILECOUNT
        '
        Me.LBLBROFILECOUNT.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LBLBROFILECOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLBROFILECOUNT.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBROFILECOUNT.ForeColor = System.Drawing.Color.White
        Me.LBLBROFILECOUNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLBROFILECOUNT.Location = New System.Drawing.Point(224, 162)
        Me.LBLBROFILECOUNT.Name = "LBLBROFILECOUNT"
        Me.LBLBROFILECOUNT.Size = New System.Drawing.Size(80, 42)
        Me.LBLBROFILECOUNT.TabIndex = 11
        Me.LBLBROFILECOUNT.Text = "000"
        Me.LBLBROFILECOUNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.dashboard4
        Me.PictureBox1.Location = New System.Drawing.Point(97, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(658, 361)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LBLITEMTRANS
        '
        Me.LBLITEMTRANS.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LBLITEMTRANS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLITEMTRANS.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLITEMTRANS.ForeColor = System.Drawing.Color.White
        Me.LBLITEMTRANS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLITEMTRANS.Location = New System.Drawing.Point(572, 159)
        Me.LBLITEMTRANS.Name = "LBLITEMTRANS"
        Me.LBLITEMTRANS.Size = New System.Drawing.Size(80, 42)
        Me.LBLITEMTRANS.TabIndex = 11
        Me.LBLITEMTRANS.Text = "000"
        Me.LBLITEMTRANS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLRETURNEDKEYS
        '
        Me.LBLRETURNEDKEYS.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.LBLRETURNEDKEYS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLRETURNEDKEYS.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRETURNEDKEYS.ForeColor = System.Drawing.Color.White
        Me.LBLRETURNEDKEYS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLRETURNEDKEYS.Location = New System.Drawing.Point(575, 340)
        Me.LBLRETURNEDKEYS.Name = "LBLRETURNEDKEYS"
        Me.LBLRETURNEDKEYS.Size = New System.Drawing.Size(80, 42)
        Me.LBLRETURNEDKEYS.TabIndex = 11
        Me.LBLRETURNEDKEYS.Text = "000"
        Me.LBLRETURNEDKEYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLBORROWEDKEYS
        '
        Me.LBLBORROWEDKEYS.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.LBLBORROWEDKEYS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLBORROWEDKEYS.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBORROWEDKEYS.ForeColor = System.Drawing.Color.White
        Me.LBLBORROWEDKEYS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLBORROWEDKEYS.Location = New System.Drawing.Point(224, 342)
        Me.LBLBORROWEDKEYS.Name = "LBLBORROWEDKEYS"
        Me.LBLBORROWEDKEYS.Size = New System.Drawing.Size(80, 42)
        Me.LBLBORROWEDKEYS.TabIndex = 11
        Me.LBLBORROWEDKEYS.Text = "000"
        Me.LBLBORROWEDKEYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(238, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "S Y S T E M     D A S H B O A R D"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerRefreshBorrow
        '
        Me.TimerRefreshBorrow.Enabled = True
        '
        'TimerRefreshReturn
        '
        Me.TimerRefreshReturn.Enabled = True
        '
        'TimerRefreshItem
        '
        Me.TimerRefreshItem.Enabled = True
        '
        'TimerFilterAdmin
        '
        Me.TimerFilterAdmin.Enabled = True
        '
        'ucHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLRETURNEDKEYS)
        Me.Controls.Add(Me.LBLBORROWEDKEYS)
        Me.Controls.Add(Me.LBLITEMTRANS)
        Me.Controls.Add(Me.LBLBROFILECOUNT)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ucHome"
        Me.Size = New System.Drawing.Size(876, 509)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBLBROFILECOUNT As System.Windows.Forms.Label
    Friend WithEvents LBLITEMTRANS As System.Windows.Forms.Label
    Friend WithEvents LBLRETURNEDKEYS As System.Windows.Forms.Label
    Friend WithEvents LBLBORROWEDKEYS As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerRefreshBorrow As System.Windows.Forms.Timer
    Friend WithEvents TimerRefreshReturn As System.Windows.Forms.Timer
    Friend WithEvents TimerRefreshItem As System.Windows.Forms.Timer
    Friend WithEvents TimerFilterAdmin As System.Windows.Forms.Timer

End Class
