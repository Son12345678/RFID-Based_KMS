Public Class ucHomeGuard

    Private Sub ucHomeGuard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        OpenCon()
        Dim bp As String
        cmd.CommandText = "Select count(*) from tbl_guard"
        bp = cmd.ExecuteScalar()
        LBLreturnedtoguard.Text = bp
        con.Close()

        OpenCon()
        Dim rkeys As String
        cmd.CommandText = "Select count(*) from tbl_guard where datetimereturned = '" & Format(Date.Now, "yyyy-MM-dd") & "' "
        rkeys = cmd.ExecuteScalar()
        LBLreturnedtoguard.Text = rkeys
        con.Close()
    End Sub
End Class
