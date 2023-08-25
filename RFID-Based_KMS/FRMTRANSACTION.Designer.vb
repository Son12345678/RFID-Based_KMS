<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMTRANSACTION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbld = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTNBORROWING = New System.Windows.Forms.Button()
        Me.BTNRETURNING = New System.Windows.Forms.Button()
        Me.LblUsertype = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblHead1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnltransaction = New System.Windows.Forms.Panel()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TblkeyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblkeytransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblkeyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkeytransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.lbld)
        Me.Panel5.Controls.Add(Me.lbltime)
        Me.Panel5.Controls.Add(Me.lbly)
        Me.Panel5.Controls.Add(Me.lblm)
        Me.Panel5.Location = New System.Drawing.Point(20, 509)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(146, 120)
        Me.Panel5.TabIndex = 16
        '
        'lbld
        '
        Me.lbld.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld.ForeColor = System.Drawing.Color.White
        Me.lbld.Location = New System.Drawing.Point(8, 29)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(130, 37)
        Me.lbld.TabIndex = 11
        Me.lbld.Text = "00"
        Me.lbld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltime
        '
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(8, 89)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(130, 23)
        Me.lbltime.TabIndex = 12
        Me.lbltime.Text = "HH:MM:SS"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbly
        '
        Me.lbly.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbly.ForeColor = System.Drawing.Color.White
        Me.lbly.Location = New System.Drawing.Point(8, 60)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(130, 23)
        Me.lbly.TabIndex = 13
        Me.lbly.Text = "2021"
        Me.lbly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblm
        '
        Me.lblm.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.ForeColor = System.Drawing.Color.White
        Me.lblm.Location = New System.Drawing.Point(8, 10)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(130, 23)
        Me.lblm.TabIndex = 14
        Me.lblm.Text = "January "
        Me.lblm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.BTNBORROWING)
        Me.Panel4.Controls.Add(Me.BTNRETURNING)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 93)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 660)
        Me.Panel4.TabIndex = 23
        '
        'BTNBORROWING
        '
        Me.BTNBORROWING.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNBORROWING.FlatAppearance.BorderSize = 0
        Me.BTNBORROWING.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBORROWING.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBORROWING.ForeColor = System.Drawing.Color.White
        Me.BTNBORROWING.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBORROWING.Location = New System.Drawing.Point(23, 33)
        Me.BTNBORROWING.Name = "BTNBORROWING"
        Me.BTNBORROWING.Size = New System.Drawing.Size(146, 120)
        Me.BTNBORROWING.TabIndex = 14
        Me.BTNBORROWING.Text = "BORROW KEY"
        Me.BTNBORROWING.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNBORROWING.UseVisualStyleBackColor = False
        '
        'BTNRETURNING
        '
        Me.BTNRETURNING.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRETURNING.FlatAppearance.BorderSize = 0
        Me.BTNRETURNING.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRETURNING.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETURNING.ForeColor = System.Drawing.Color.White
        Me.BTNRETURNING.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETURNING.Location = New System.Drawing.Point(22, 187)
        Me.BTNRETURNING.Name = "BTNRETURNING"
        Me.BTNRETURNING.Size = New System.Drawing.Size(146, 120)
        Me.BTNRETURNING.TabIndex = 17
        Me.BTNRETURNING.Text = "RETURN KEY"
        Me.BTNRETURNING.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNRETURNING.UseVisualStyleBackColor = False
        '
        'LblUsertype
        '
        Me.LblUsertype.AutoSize = True
        Me.LblUsertype.BackColor = System.Drawing.Color.Transparent
        Me.LblUsertype.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsertype.ForeColor = System.Drawing.Color.White
        Me.LblUsertype.Location = New System.Drawing.Point(10, 65)
        Me.LblUsertype.Name = "LblUsertype"
        Me.LblUsertype.Size = New System.Drawing.Size(93, 22)
        Me.LblUsertype.TabIndex = 68
        Me.LblUsertype.Text = "USERTYPE"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(481, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(507, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "COLLEGE NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIVERSITY OF RIZAL SYSTEM BINANGONAN  -"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(322, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "RFID-BASED KEY MONITORING SYSTEM"
        '
        'lblClose
        '
        Me.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(1322, 21)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(23, 22)
        Me.lblClose.TabIndex = 69
        Me.lblClose.Text = "X"
        '
        'lblHead1
        '
        Me.lblHead1.AutoSize = True
        Me.lblHead1.BackColor = System.Drawing.Color.Transparent
        Me.lblHead1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead1.ForeColor = System.Drawing.Color.White
        Me.lblHead1.Location = New System.Drawing.Point(9, 9)
        Me.lblHead1.Name = "lblHead1"
        Me.lblHead1.Size = New System.Drawing.Size(375, 23)
        Me.lblHead1.TabIndex = 66
        Me.lblHead1.Text = "University of Rizal System - Binangonan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblClose)
        Me.Panel3.Controls.Add(Me.lblHead1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1357, 62)
        Me.Panel3.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LblUsertype)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1357, 93)
        Me.Panel1.TabIndex = 22
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'pnltransaction
        '
        Me.pnltransaction.BackColor = System.Drawing.Color.White
        Me.pnltransaction.Location = New System.Drawing.Point(219, 114)
        Me.pnltransaction.Name = "pnltransaction"
        Me.pnltransaction.Size = New System.Drawing.Size(1127, 630)
        Me.pnltransaction.TabIndex = 24
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'TblkeyBindingSource
        '
        Me.TblkeyBindingSource.DataMember = "tbl_key"
        '
        'TblkeytransactionBindingSource
        '
        Me.TblkeytransactionBindingSource.DataMember = "tbl_keytransaction"
        '
        'FRMTRANSACTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 753)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnltransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMTRANSACTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMTRANSACTION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblkeyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkeytransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TblkeyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblkeytransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbld As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BTNBORROWING As System.Windows.Forms.Button
    Friend WithEvents BTNRETURNING As System.Windows.Forms.Button
    Friend WithEvents LblUsertype As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblHead1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnltransaction As System.Windows.Forms.Panel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
