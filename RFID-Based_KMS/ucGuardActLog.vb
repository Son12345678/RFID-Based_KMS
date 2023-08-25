Public Class ucGuardActLog
    Dim status As String = "Returned to Guard"
    Private Sub ucGuardActLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_activitylogTableAdapter.Fill(Me.db_kmsDataSet.tbl_activitylog)
        Me.RVGUARDACTLOG.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVGUARDACTLOG.RefreshReport()

        Me.tbl_activitylogTableAdapter.FillByactivity(Me.db_kmsDataSet.tbl_activitylog, status)
    End Sub

    Private Sub DTPDATE_ValueChanged(sender As Object, e As EventArgs) Handles DTPDATE.ValueChanged
        Me.tbl_activitylogTableAdapter.FillBydate(Me.db_kmsDataSet.tbl_activitylog, DTPDATE.Value.ToLongDateString)
        Me.RVGUARDACTLOG.RefreshReport()
    End Sub

    Private Sub BTNActlog_Click(sender As Object, e As EventArgs) Handles BTNActlogClear.Click
            DTPDATE.Text = ""
            Me.tbl_activitylogTableAdapter.Fill(Me.db_kmsDataSet.tbl_activitylog)
            Me.RVGUARDACTLOG.RefreshReport()
        Me.tbl_activitylogTableAdapter.FillByactivity(Me.db_kmsDataSet.tbl_activitylog, status)
    End Sub

    Private Sub TXTaccountname_TextChanged(sender As Object, e As EventArgs) Handles TXTaccountname.TextChanged
        tbl_activitylogBindingSource.Filter = "accountname like '%" & TXTaccountname.Text & "%'"
        Me.RVGUARDACTLOG.RefreshReport()
    End Sub
End Class
