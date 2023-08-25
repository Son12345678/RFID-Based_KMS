Public Class ucGuardKeyTransReports

    Private Sub ucGuardKeyTransReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_guardTableAdapter.Fill(Me.db_kmsDataSet.tbl_guard)
        Me.RVGUARDTRANS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVGUARDTRANS.RefreshReport()
    End Sub

    Private Sub btncleargt_Click(sender As Object, e As EventArgs) Handles btncleargt.Click
            Me.RVGUARDTRANS.RefreshReport()
            Me.tbl_guardTableAdapter.Fill(Me.db_kmsDataSet.tbl_guard)
    End Sub

    Private Sub DTPDATEBORROWED_ValueChanged(sender As Object, e As EventArgs) Handles DTPDATEBORROWED.ValueChanged
        Me.tbl_guardTableAdapter.FillByDateBorrowed(Me.db_kmsDataSet.tbl_guard, DTPDATEBORROWED.Value.ToShortDateString, DTPDATEBORROWEDTO.Value.ToShortDateString)
        Me.RVGUARDTRANS.RefreshReport()
    End Sub


    Private Sub DTPDATEBORROWEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPDATEBORROWEDTO.ValueChanged
        Me.tbl_guardTableAdapter.FillByDateBorrowed(Me.db_kmsDataSet.tbl_guard, DTPDATEBORROWED.Value.ToShortDateString, DTPDATEBORROWEDTO.Value.ToShortDateString)
        Me.RVGUARDTRANS.RefreshReport()
    End Sub

    Private Sub DTPDATERETURNED_ValueChanged(sender As Object, e As EventArgs) Handles DTPDATERETURNED.ValueChanged
        Me.tbl_guardTableAdapter.FillByDateReturned(Me.db_kmsDataSet.tbl_guard, DTPDATERETURNED.Value.ToShortDateString, DTPDATERETURNEDTO.Value.ToShortDateString)
        Me.RVGUARDTRANS.RefreshReport()
    End Sub

    Private Sub DTPDATERETURNEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPDATERETURNEDTO.ValueChanged
        Me.tbl_guardTableAdapter.FillByDateReturned(Me.db_kmsDataSet.tbl_guard, DTPDATERETURNED.Value.ToShortDateString, DTPDATERETURNEDTO.Value.ToShortDateString)
        Me.RVGUARDTRANS.RefreshReport()
    End Sub
End Class
