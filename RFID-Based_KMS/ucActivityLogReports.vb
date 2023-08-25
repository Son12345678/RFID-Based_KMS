Public Class ucActivityLogReports

    Private Sub ucActivityLogReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_activitylogTableAdapter.Fill(Me.db_kmsDataSet.tbl_activitylog)
        Me.RVActLog.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVActLog.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYACTIVITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERBYACTIVITY.SelectedIndexChanged
        Me.tbl_activitylogTableAdapter.FillByactivity(Me.db_kmsDataSet.tbl_activitylog, CBOFILTERBYACTIVITY.Text)
        Me.RVActLog.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click      
            CBOFILTERBYACTIVITY.Text = ""
        TXTFilterAccName.Text = ""
            Me.RVActLog.RefreshReport()
            Me.tbl_activitylogTableAdapter.Fill(Me.db_kmsDataSet.tbl_activitylog)
    End Sub

    Private Sub DTPFILTERBYDATE_ValueChanged(sender As Object, e As EventArgs) Handles DTPFILTERBYDATE.ValueChanged
        Me.tbl_activitylogTableAdapter.FillBydate(Me.db_kmsDataSet.tbl_activitylog, DTPFILTERBYDATE.Value.ToLongDateString)
        Me.RVActLog.RefreshReport()
    End Sub

    Private Sub TXTFilterAccName_TextChanged(sender As Object, e As EventArgs) Handles TXTFilterAccName.TextChanged
        tbl_activitylogBindingSource.Filter = "accountname like '%" & TXTFilterAccName.Text & "%'"
        Me.RVActLog.RefreshReport()
    End Sub
End Class
