Public Class ucGuardReports

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim i As Integer
        For i = FRMGUARDMENU.pnlguardmain.Controls.Count - 1 To 0
            FRMGUARDMENU.pnlguardmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHomeGuard()
        home.Parent = FRMGUARDMENU.pnlguardmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub ucGuardReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blank As New ucguardblank()
        blank.Parent = pnlguardreports
        blank.Show()
        blank.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNTransactionReports_Click(sender As Object, e As EventArgs) Handles BTNTransactionReports.Click
        Dim i As Integer
        For i = pnlguardreports.Controls.Count - 1 To 0
            pnlguardreports.Controls.RemoveAt(i)
        Next

        Dim key As New ucGuardKeyTransReports()
        key.Parent = pnlguardreports
        key.Show()
        key.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNActlog_Click(sender As Object, e As EventArgs) Handles BTNActlog.Click
        Dim i As Integer
        For i = pnlguardreports.Controls.Count - 1 To 0
            pnlguardreports.Controls.RemoveAt(i)
        Next

        Dim key As New ucGuardActLog()
        key.Parent = pnlguardreports
        key.Show()
        key.Dock = DockStyle.Fill
    End Sub
End Class
