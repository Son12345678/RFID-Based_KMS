Public Class ucItemTransaction

    Private Sub BTNBORROW_Click(sender As Object, e As EventArgs) Handles BTNBORROW.Click
        Dim i As Integer
        For i = PNLITEMTRANS.Controls.Count - 1 To 0
            PNLITEMTRANS.Controls.RemoveAt(i)
        Next

        Dim itemborrow As New ucItemBorrow()
        itemborrow.Parent = PNLITEMTRANS
        itemborrow.Show()
        itemborrow.Dock = DockStyle.Fill
    End Sub

    Private Sub ucItemTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blank As New ucItemTransBlank()
        blank.Parent = PNLITEMTRANS
        blank.Show()
        blank.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNRETURN_Click(sender As Object, e As EventArgs) Handles BTNRETURN.Click
        Dim i As Integer
        For i = PNLITEMTRANS.Controls.Count - 1 To 0
            PNLITEMTRANS.Controls.RemoveAt(i)
        Next

        Dim itemreturn As New ucItemReturn()
        itemreturn.Parent = PNLITEMTRANS
        itemreturn.Show()
        itemreturn.Dock = DockStyle.Fill
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
End Class
