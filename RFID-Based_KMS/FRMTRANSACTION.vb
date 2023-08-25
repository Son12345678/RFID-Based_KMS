Public Class FRMTRANSACTION

    Private Sub FRMTRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blank As New ucTransactionBlank()
        blank.Parent = pnltransaction
        blank.Show()
        blank.Dock = DockStyle.Fill

        LblUsertype.Text = FRMAdminMenu.LblUsertype.Text
    End Sub

    Private Sub BTNBORROWING_Click(sender As Object, e As EventArgs) Handles BTNBORROWING.Click
        Dim i As Integer
        For i = pnltransaction.Controls.Count - 1 To 0
            pnltransaction.Controls.RemoveAt(i)
        Next

        Dim borrow As New ucBorrow()
        borrow.Parent = pnltransaction
        borrow.Show()
        borrow.Dock = DockStyle.Fill
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        FRMTRANSCLOSE.ShowDialog()
    End Sub

    Private Sub BTNRETURNING_Click(sender As Object, e As EventArgs) Handles BTNRETURNING.Click
        Dim i As Integer
        For i = pnltransaction.Controls.Count - 1 To 0
            pnltransaction.Controls.RemoveAt(i)
        Next

        Dim r As New ucReturn()
        r.Parent = pnltransaction
        r.Show()
        r.Dock = DockStyle.Fill
    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblm.Text = Format(Date.Now, "MMMM")
        lbld.Text = Format(Date.Now, "dd")
        lbly.Text = Format(Date.Now, "yyyy")
        lbltime.Text = Format(TimeOfDay, "hh:mm:ss tt")
    End Sub

    Private Sub COAlogo_Click(sender As Object, e As EventArgs)

    End Sub
End Class