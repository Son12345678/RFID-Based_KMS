Public Class FRMGUARDMENU

    Private Sub FRMGUARDMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FRMHome As New ucHomeGuard()
        FRMHome.Parent = pnlguardmain
        FRMHome.Show()
        FRMHome.Dock = DockStyle.Fill
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Dim i As Integer
        For i = pnlguardmain.Controls.Count - 1 To 0
            pnlguardmain.Controls.RemoveAt(i)
        Next

        Dim keytrans As New ucguardtrans()
        keytrans.Parent = pnlguardmain
        keytrans.Show()
        keytrans.Dock = DockStyle.Fill
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim i As Integer
        For i = pnlguardmain.Controls.Count - 1 To 0
            pnlguardmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHomeGuard()
        home.Parent = pnlguardmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim i As Integer
        For i = pnlguardmain.Controls.Count - 1 To 0
            pnlguardmain.Controls.RemoveAt(i)
        Next

        Dim reports As New ucGuardReports()
        reports.Parent = pnlguardmain
        reports.Show()
        reports.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblm.Text = Format(Date.Now, "MMMM")
        lbld.Text = Format(Date.Now, "dd")
        lbly.Text = Format(Date.Now, "yyyy")
        lbltime.Text = Format(TimeOfDay, "hh:mm:ss tt")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        End
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
End Class