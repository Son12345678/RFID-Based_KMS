<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHomeGuard
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLreturnedtoguard = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.dashboardguard
        Me.PictureBox1.Location = New System.Drawing.Point(20, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 362)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(151, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "G U A R D     D A S H B O A R D"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLreturnedtoguard
        '
        Me.LBLreturnedtoguard.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.LBLreturnedtoguard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLreturnedtoguard.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLreturnedtoguard.ForeColor = System.Drawing.Color.White
        Me.LBLreturnedtoguard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLreturnedtoguard.Location = New System.Drawing.Point(302, 183)
        Me.LBLreturnedtoguard.Name = "LBLreturnedtoguard"
        Me.LBLreturnedtoguard.Size = New System.Drawing.Size(65, 32)
        Me.LBLreturnedtoguard.TabIndex = 15
        Me.LBLreturnedtoguard.Text = "000"
        Me.LBLreturnedtoguard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucHomeGuard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LBLreturnedtoguard)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ucHomeGuard"
        Me.Size = New System.Drawing.Size(630, 341)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLreturnedtoguard As System.Windows.Forms.Label

End Class
