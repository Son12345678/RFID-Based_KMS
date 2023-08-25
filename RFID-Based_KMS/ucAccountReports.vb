Public Class ucAccountReports

    Private Sub ucAccountReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_useraccTableAdapter.Fill(Me.db_kmsDataSet.tbl_useracc)
        Me.RVuseracc.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVuseracc.RefreshReport()
    End Sub

    Private Sub CBOFILTERUTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERUTYPE.SelectedIndexChanged
        Me.tbl_useraccTableAdapter.FillByusertype(Me.db_kmsDataSet.tbl_useracc, CBOFILTERUTYPE.Text)
        Me.RVuseracc.RefreshReport()
    End Sub

    Private Sub TXTFILTERBYNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTERBYNAME.TextChanged
        tbl_useraccBindingSource.Filter = "lname like '" & TXTFILTERBYNAME.Text & "%'"
        Me.RVuseracc.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYACCSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERBYACCSTATUS.SelectedIndexChanged
        Me.tbl_useraccTableAdapter.FillBystatus(Me.db_kmsDataSet.tbl_useracc, CBOFILTERBYACCSTATUS.Text)
        Me.RVuseracc.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click
        TXTFILTERBYNAME.Text = ""
            CBOFILTERBYACCSTATUS.Text = ""
            CBOFILTERUTYPE.Text = ""
            Me.RVuseracc.RefreshReport()
            Me.tbl_useraccTableAdapter.Fill(Me.db_kmsDataSet.tbl_useracc)
    End Sub
End Class
