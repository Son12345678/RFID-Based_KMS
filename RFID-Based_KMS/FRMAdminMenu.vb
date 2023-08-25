Public Class FRMAdminMenu

    Private Sub FRMAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_kmsDataSet.tbl_useracc' table. You can move, or remove it, as needed.
        Me.Tbl_useraccTableAdapter.Fill(Me.Db_kmsDataSet.tbl_useracc)
        Dim FRMHome As New ucHome()
        FRMHome.Parent = pnlmain
        FRMHome.Show()
        FRMHome.Dock = DockStyle.Fill


        If LblUsertype.Text = "College of Computer Studies" Then
            btnProfile.Enabled = True
            btnTrans.Enabled = True
            BTNItemTransaction.Enabled = True
            btnAccount.Enabled = False
            btnReports.Enabled = True
            btnSettings.Enabled = True
            btnLogout.Enabled = True

        ElseIf LblUsertype.Text = "College of Accountancy" Then
            btnProfile.Enabled = True
            btnTrans.Enabled = True
            BTNItemTransaction.Enabled = True
            btnAccount.Enabled = False
            btnReports.Enabled = True
            btnSettings.Enabled = True
            btnLogout.Enabled = True
        
        ElseIf LblUsertype.Text = "College of Business" Then
            btnProfile.Enabled = True
            btnTrans.Enabled = True
            BTNItemTransaction.Enabled = True
            btnAccount.Enabled = False
            btnReports.Enabled = True
            btnSettings.Enabled = True
            btnLogout.Enabled = True


        ElseIf LblUsertype.Text = "General Services Office" Then
            btnProfile.Enabled = True
            btnTrans.Enabled = True
            BTNItemTransaction.Enabled = False
            btnAccount.Enabled = False
            btnReports.Enabled = True
            btnSettings.Enabled = True
            btnLogout.Enabled = True


        ElseIf LblUsertype.Text = "System Administrator" Then
            btnProfile.Enabled = True
            btnTrans.Enabled = False
            BTNItemTransaction.Enabled = False
            btnAccount.Enabled = True
            btnReports.Enabled = True
            btnSettings.Enabled = True
            btnLogout.Enabled = True
        End If

        'Label5.Text = Date.Now

    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim account As New ucAccount()
        account.Parent = pnlmain
        account.Show()
        account.Dock = DockStyle.Fill

        
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim profile As New ucProfile()
        profile.Parent = pnlmain
        profile.Show()
        profile.Dock = DockStyle.Fill
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim settings As New ucSettings()
        settings.Parent = pnlmain
        settings.Show()
        settings.Dock = DockStyle.Fill
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim reports As New ucReports()
        reports.Parent = pnlmain
        reports.Show()
        reports.Dock = DockStyle.Fill
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim x = MsgBox("Are you sure you want to log out?", vbYesNo + vbInformation, "System Log out")
        If x = vbYes Then
            Application.Restart()
            'FRMLOGIN.Show()
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        'Dim i As Integer
        'For i = pnlmain.Controls.Count - 1 To 0
        '    pnlmain.Controls.RemoveAt(i)
        'Next

        'Dim keytransaction As New ucKeyTransaction()
        'keytransaction.Parent = pnlmain
        'keytransaction.Show()
        'keytransaction.Dock = DockStyle.Fill

        FRMTRANSACTION.Show()
    End Sub

    Private Sub BTNTransaction_Click(sender As Object, e As EventArgs) Handles BTNItemTransaction.Click
        Dim i As Integer
        For i = pnlmain.Controls.Count - 1 To 0
            pnlmain.Controls.RemoveAt(i)
        Next

        Dim itemtransaction As New ucItemTransaction()
        itemtransaction.Parent = pnlmain
        itemtransaction.Show()
        itemtransaction.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblm.Text = Format(Date.Now, "MMMM")
        lbld.Text = Format(Date.Now, "dd")
        lbly.Text = Format(Date.Now, "yyyy")
        lbltime.Text = Format(TimeOfDay, "hh:mm:ss tt")
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        End
    End Sub

    Private Sub LblUsertype_Click(sender As Object, e As EventArgs) Handles LblUsertype.Click

    End Sub
End Class
