Public Class ucProfileReports

    Private Sub ucProfileReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_borrowersprofileTableAdapter.Fill(Me.db_kmsDataSet.tbl_borrowersprofile)
        Me.RVProfiles.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVProfiles.RefreshReport()
    End Sub

    Private Sub TXTFILTERBYNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTERBYNAME.TextChanged
        tbl_borrowersprofileBindingSource.Filter = "lastname like '" & TXTFILTERBYNAME.Text & "%'"
        tbl_borrowersprofileBindingSource.Filter = "firstname like '" & TXTFILTERBYNAME.Text & "%'"
        Me.RVProfiles.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYCOLLEGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERBYCOLLEGE.SelectedIndexChanged
        Me.tbl_borrowersprofileTableAdapter.FillBycollege(Me.db_kmsDataSet.tbl_borrowersprofile, CBOFILTERBYCOLLEGE.Text)
        Me.RVProfiles.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERBYSTATUS.SelectedIndexChanged
        Me.tbl_borrowersprofileTableAdapter.FillBystatus(Me.db_kmsDataSet.tbl_borrowersprofile, CBOFILTERBYSTATUS.Text)
        Me.RVProfiles.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click
        Me.tbl_borrowersprofileTableAdapter.Fill(Me.db_kmsDataSet.tbl_borrowersprofile)
        CBOFILTERBYSTATUS.Text = ""
        CBOFILTERBYCOLLEGE.Text = ""
        TXTFILTERBYNAME.Text = ""
        Me.RVProfiles.RefreshReport()
    End Sub
End Class
