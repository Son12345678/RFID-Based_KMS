Public Class ucReports

    Private Sub BTNAccountReports_Click(sender As Object, e As EventArgs) Handles BTNAccountReports.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim account As New ucAccountReports()
        account.Parent = PNLReports
        account.Show()
        account.Dock = DockStyle.Fill
    End Sub

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blank As New ucReportsBlank()
        blank.Parent = PNLReports
        blank.Show()
        blank.Dock = DockStyle.Fill

        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            BTNAccountReports.Enabled = False
            BTNRoomKeyReports.Enabled = True
            BTNProfileReports.Enabled = True
            BTNTransactionReports.Enabled = True
            BTNItemTrans.Enabled = True
            BTNActivityLogReports.Enabled = True


        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            BTNAccountReports.Enabled = False
            BTNRoomKeyReports.Enabled = True
            BTNProfileReports.Enabled = True
            BTNTransactionReports.Enabled = True
            BTNItemTrans.Enabled = True
            BTNActivityLogReports.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            BTNAccountReports.Enabled = False
            BTNRoomKeyReports.Enabled = True
            BTNProfileReports.Enabled = True
            BTNTransactionReports.Enabled = True
            BTNItemTrans.Enabled = True
            BTNActivityLogReports.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            BTNAccountReports.Enabled = False
            BTNRoomKeyReports.Enabled = True
            BTNProfileReports.Enabled = True
            BTNTransactionReports.Enabled = True
            BTNItemTrans.Enabled = False
            BTNActivityLogReports.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            BTNAccountReports.Enabled = True
            BTNRoomKeyReports.Enabled = True
            BTNProfileReports.Enabled = True
            BTNTransactionReports.Enabled = True
            BTNItemTrans.Enabled = True
            BTNActivityLogReports.Enabled = True
        End If

    End Sub

    Private Sub BTNRoomKeyReports_Click(sender As Object, e As EventArgs) Handles BTNRoomKeyReports.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim key As New ucRoomKeyReports()
        key.Parent = PNLReports
        key.Show()
        key.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNProfileReports_Click(sender As Object, e As EventArgs) Handles BTNProfileReports.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim profile As New ucProfileReports()
        profile.Parent = PNLReports
        profile.Show()
        profile.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNTransactionReports_Click(sender As Object, e As EventArgs) Handles BTNTransactionReports.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim transaction As New ucTransactionReports()
        transaction.Parent = PNLReports
        transaction.Show()
        transaction.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNActivityLogReports_Click(sender As Object, e As EventArgs) Handles BTNActivityLogReports.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim actlog As New ucActivityLogReports()
        actlog.Parent = PNLReports
        actlog.Show()
        actlog.Dock = DockStyle.Fill
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Dim i As Integer
        For i = FRMAdminMenu.pnlmain.Controls.Count - 1 To 0
            FRMAdminMenu.pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = FRMAdminMenu.pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNItemTrans_Click(sender As Object, e As EventArgs) Handles BTNItemTrans.Click
        Dim i As Integer
        For i = PNLReports.Controls.Count - 1 To 0
            PNLReports.Controls.RemoveAt(i)
        Next

        Dim itemtrans As New ucItemTransReports()
        itemtrans.Parent = PNLReports
        itemtrans.Show()
        itemtrans.Dock = DockStyle.Fill
    End Sub
End Class
