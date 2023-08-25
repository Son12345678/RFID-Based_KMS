<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSettings
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
        Me.PNLSettings = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNItemsQT = New System.Windows.Forms.Button()
        Me.btnRoomKey = New System.Windows.Forms.Button()
        Me.BTNItems = New System.Windows.Forms.Button()
        Me.BTNCollege = New System.Windows.Forms.Button()
        Me.BTNCourse = New System.Windows.Forms.Button()
        Me.BTNRoom = New System.Windows.Forms.Button()
        Me.BTNRoomCategory = New System.Windows.Forms.Button()
        Me.BTNSection = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNLSettings
        '
        Me.PNLSettings.BackColor = System.Drawing.SystemColors.Control
        Me.PNLSettings.Location = New System.Drawing.Point(182, 67)
        Me.PNLSettings.Name = "PNLSettings"
        Me.PNLSettings.Size = New System.Drawing.Size(643, 409)
        Me.PNLSettings.TabIndex = 50
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
        Me.lblClose.Location = New System.Drawing.Point(844, 8)
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
        Me.lblHead2.Size = New System.Drawing.Size(90, 22)
        Me.lblHead2.TabIndex = 68
        Me.lblHead2.Text = "SETTINGS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Based_KMS.My.Resources.Resources.SETTINGS
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.BTNRoom)
        Me.Panel3.Controls.Add(Me.BTNItemsQT)
        Me.Panel3.Controls.Add(Me.btnRoomKey)
        Me.Panel3.Controls.Add(Me.BTNItems)
        Me.Panel3.Controls.Add(Me.BTNCollege)
        Me.Panel3.Controls.Add(Me.BTNCourse)
        Me.Panel3.Controls.Add(Me.BTNRoomCategory)
        Me.Panel3.Controls.Add(Me.BTNSection)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 471)
        Me.Panel3.TabIndex = 54
        '
        'BTNItemsQT
        '
        Me.BTNItemsQT.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNItemsQT.FlatAppearance.BorderSize = 0
        Me.BTNItemsQT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNItemsQT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNItemsQT.ForeColor = System.Drawing.Color.White
        Me.BTNItemsQT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNItemsQT.Location = New System.Drawing.Point(1, 386)
        Me.BTNItemsQT.Name = "BTNItemsQT"
        Me.BTNItemsQT.Size = New System.Drawing.Size(127, 27)
        Me.BTNItemsQT.TabIndex = 22
        Me.BTNItemsQT.Text = "ITEMS"
        Me.BTNItemsQT.UseVisualStyleBackColor = False
        '
        'btnRoomKey
        '
        Me.btnRoomKey.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRoomKey.FlatAppearance.BorderSize = 0
        Me.btnRoomKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomKey.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomKey.ForeColor = System.Drawing.Color.White
        Me.btnRoomKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoomKey.Location = New System.Drawing.Point(2, 294)
        Me.btnRoomKey.Name = "btnRoomKey"
        Me.btnRoomKey.Size = New System.Drawing.Size(127, 27)
        Me.btnRoomKey.TabIndex = 21
        Me.btnRoomKey.Text = "ROOM KEY"
        Me.btnRoomKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRoomKey.UseVisualStyleBackColor = False
        '
        'BTNItems
        '
        Me.BTNItems.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNItems.FlatAppearance.BorderSize = 0
        Me.BTNItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNItems.ForeColor = System.Drawing.Color.White
        Me.BTNItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNItems.Location = New System.Drawing.Point(2, 343)
        Me.BTNItems.Name = "BTNItems"
        Me.BTNItems.Size = New System.Drawing.Size(127, 27)
        Me.BTNItems.TabIndex = 20
        Me.BTNItems.Text = "ITEM CATEGORY"
        Me.BTNItems.UseVisualStyleBackColor = False
        '
        'BTNCollege
        '
        Me.BTNCollege.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCollege.FlatAppearance.BorderSize = 0
        Me.BTNCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCollege.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCollege.ForeColor = System.Drawing.Color.White
        Me.BTNCollege.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCollege.Location = New System.Drawing.Point(2, 49)
        Me.BTNCollege.Name = "BTNCollege"
        Me.BTNCollege.Size = New System.Drawing.Size(127, 27)
        Me.BTNCollege.TabIndex = 19
        Me.BTNCollege.Text = "COLLEGE"
        Me.BTNCollege.UseVisualStyleBackColor = False
        '
        'BTNCourse
        '
        Me.BTNCourse.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNCourse.FlatAppearance.BorderSize = 0
        Me.BTNCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCourse.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCourse.ForeColor = System.Drawing.Color.White
        Me.BTNCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCourse.Location = New System.Drawing.Point(2, 98)
        Me.BTNCourse.Name = "BTNCourse"
        Me.BTNCourse.Size = New System.Drawing.Size(127, 27)
        Me.BTNCourse.TabIndex = 18
        Me.BTNCourse.Text = "COURSE"
        Me.BTNCourse.UseVisualStyleBackColor = False
        '
        'BTNRoom
        '
        Me.BTNRoom.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRoom.FlatAppearance.BorderSize = 0
        Me.BTNRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRoom.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRoom.ForeColor = System.Drawing.Color.White
        Me.BTNRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRoom.Location = New System.Drawing.Point(1, 245)
        Me.BTNRoom.Name = "BTNRoom"
        Me.BTNRoom.Size = New System.Drawing.Size(127, 27)
        Me.BTNRoom.TabIndex = 17
        Me.BTNRoom.Text = "ROOM"
        Me.BTNRoom.UseVisualStyleBackColor = False
        '
        'BTNRoomCategory
        '
        Me.BTNRoomCategory.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRoomCategory.FlatAppearance.BorderSize = 0
        Me.BTNRoomCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRoomCategory.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRoomCategory.ForeColor = System.Drawing.Color.White
        Me.BTNRoomCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRoomCategory.Location = New System.Drawing.Point(2, 197)
        Me.BTNRoomCategory.Name = "BTNRoomCategory"
        Me.BTNRoomCategory.Size = New System.Drawing.Size(127, 27)
        Me.BTNRoomCategory.TabIndex = 16
        Me.BTNRoomCategory.Text = "ROOM CATEGORY"
        Me.BTNRoomCategory.UseVisualStyleBackColor = False
        '
        'BTNSection
        '
        Me.BTNSection.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNSection.FlatAppearance.BorderSize = 0
        Me.BTNSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSection.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSection.ForeColor = System.Drawing.Color.White
        Me.BTNSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSection.Location = New System.Drawing.Point(2, 147)
        Me.BTNSection.Name = "BTNSection"
        Me.BTNSection.Size = New System.Drawing.Size(127, 27)
        Me.BTNSection.TabIndex = 15
        Me.BTNSection.Text = "SECTION"
        Me.BTNSection.UseVisualStyleBackColor = False
        '
        'ucSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PNLSettings)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucSettings"
        Me.Size = New System.Drawing.Size(876, 509)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PNLSettings As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BTNCollege As System.Windows.Forms.Button
    Friend WithEvents BTNCourse As System.Windows.Forms.Button
    Friend WithEvents BTNRoom As System.Windows.Forms.Button
    Friend WithEvents BTNRoomCategory As System.Windows.Forms.Button
    Friend WithEvents BTNSection As System.Windows.Forms.Button
    Friend WithEvents BTNItems As System.Windows.Forms.Button
    Friend WithEvents btnRoomKey As System.Windows.Forms.Button
    Friend WithEvents BTNItemsQT As System.Windows.Forms.Button

End Class
