Public Class ucHome
    Dim Admin As String = "System Administrator"
    Dim Day = Format(Date.Now, "yyyy-MM-dd")
    Dim BorrowerStatus As String = "Active"
    Private Sub ucHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************************************** BORROWERS PROFILE - TOTAL **********************************
        con.Close()
        OpenCon()
        Dim bp As String
        cmd.CommandText = "Select count(*) from tbl_borrowersprofile where status = '" & BorrowerStatus & "' "
        bp = cmd.ExecuteScalar()
        LBLBROFILECOUNT.Text = bp
        con.Close()

        'If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    ''************************************** ITEM TRANSACTION - TOTAL **********************************
        '    con.Close()
        '    OpenCon()
        '    Dim it As String
        '    cmd.CommandText = "Select count(*) from tbl_itemtransaction where dateborrowed = '" & Format(Date.Now, "yyyy-MM-dd") & "' "
        '    it = cmd.ExecuteScalar()
        '    LBLITEMTRANS.Text = it
        '    con.Close()

        '    ''************************************** BORROWED KEYS - TOTAL **********************************
        '    con.Close()
        '    OpenCon()
        '    Dim bk As String
        '    cmd.CommandText = "Select count(*) from tbl_keytransaction where datetimeborrowed = '" & Format(Date.Now, "yyyy-MM-dd") & "' "
        '    bk = cmd.ExecuteScalar()
        '    LBLBORROWEDKEYS.Text = bk
        '    con.Close()

        '    ''************************************** RETURNED KEYS - TOTAL **********************************
        '    con.Close()
        '    OpenCon()
        '    Dim rk As String
        '    cmd.CommandText = "Select count(*) from tbl_keytransaction where datetimereturned = '" & Format(Date.Now, "yyyy-MM-dd") & "' "
        '    rk = cmd.ExecuteScalar()
        '    LBLRETURNEDKEYS.Text = rk
        '    con.Close()
        'End If

    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefreshBorrow.Tick
        con.Close()
        OpenCon()
        Dim bkeys As String
        cmd.CommandText = "Select count(*) from tbl_keytransaction where datetimeborrowed  = '" & Day & "' and college = '" & FRMAdminMenu.LblUsertype.Text & "' "
        bkeys = cmd.ExecuteScalar()
        LBLBORROWEDKEYS.Text = bkeys
        con.Close()
    End Sub

    Private Sub TimerRefreshReturn_Tick(sender As Object, e As EventArgs) Handles TimerRefreshReturn.Tick
        con.Close()
        OpenCon()
        Dim rkeys As String
        cmd.CommandText = "Select count(*) from tbl_keytransaction where datetimereturned  = '" & Day & "' and college = '" & FRMAdminMenu.LblUsertype.Text & "' "
        rkeys = cmd.ExecuteScalar()
        LBLRETURNEDKEYS.Text = rkeys
        con.Close()
    End Sub

    Private Sub TimerRefreshItem_Tick(sender As Object, e As EventArgs) Handles TimerRefreshItem.Tick
        OpenCon()
        Dim itotal As String
        cmd.CommandText = "Select count(*) from tbl_itemtransaction where dateborrowed = '" & Format(Date.Now, "yyyy-MM-dd") & "' and college = '" & FRMAdminMenu.LblUsertype.Text & "' "
        itotal = cmd.ExecuteScalar()
        LBLITEMTRANS.Text = itotal
        con.Close()
    End Sub

    Private Sub TimerFilterAdmin_Tick(sender As Object, e As EventArgs) Handles TimerFilterAdmin.Tick
        'con.Close()
        'OpenCon()
        'Dim rkeys As String
        'cmd.CommandText = "Select count(*) from tbl_keytransaction where datetimereturned  = '" & Day & "' and college = '" & FRMAdminMenu.LblUsertype.Text & "' "
        'rkeys = cmd.ExecuteScalar()
        'LBLRETURNEDKEYS.Text = rkeys
        'con.Close()
    End Sub
End Class
