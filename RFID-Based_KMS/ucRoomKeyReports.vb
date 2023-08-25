Public Class ucRoomKeyReports
    Private Sub ucRoomKeyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.tbl_keyTableAdapter.Fill(Me.db_kmsDataSet.tbl_key)
        Else
            Me.tbl_keyTableAdapter.FillBykeyownership(Me.db_kmsDataSet.tbl_key, FRMAdminMenu.LblUsertype.Text)
        End If

        Me.RVRoomKey.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVRoomKey.RefreshReport()

        OpenCon()
        cmd.CommandText = "Select * from tbl_key"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOFILTERBYROOMNO.Items.Add(dr.Item("roomnumber"))
            End While
        End If
        con.Close()

        OpenCon()
        cmd.CommandText = "Select * from tbl_key where keyownership = @c"
        With cmd.Parameters
            .Clear()
            .AddWithValue("c", FRMAdminMenu.LblUsertype.Text)
        End With

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            CBOFILTERBYROOMNO.Items.Clear()
            While dr.Read
                CBOFILTERBYROOMNO.Items.Add(dr.Item("roomnumber"))
            End While
        End If
        con.Close()

        If FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            CBOFILTERBYKEYOWNERSHIP.Enabled = False

        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            CBOFILTERBYKEYOWNERSHIP.Enabled = False

        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            CBOFILTERBYKEYOWNERSHIP.Enabled = False

        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            CBOFILTERBYKEYOWNERSHIP.Enabled = False

        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            CBOFILTERBYKEYOWNERSHIP.Enabled = True
        End If

    End Sub

    Private Sub FUNCTION_REFRESH()
        Me.tbl_keyTableAdapter.FillBykeyownership(Me.db_kmsDataSet.tbl_key, FRMAdminMenu.LblUsertype.Text)
        Me.RVRoomKey.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVRoomKey.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYKEYOWNERSHIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOFILTERBYKEYOWNERSHIP.SelectedIndexChanged
        Me.tbl_keyTableAdapter.FillBykeyownership(Me.db_kmsDataSet.tbl_key, CBOFILTERBYKEYOWNERSHIP.Text)
        Me.RVRoomKey.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click

        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            CBOFILTERBYKEYOWNERSHIP.Text = ""
            TXTFILTERBYKEYTAG.Text = ""
            CBOFILTERBYROOMNO.Text = ""
            Me.tbl_keyTableAdapter.Fill(Me.db_kmsDataSet.tbl_key)
            Me.RVRoomKey.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVRoomKey.RefreshReport()
        Else
            Me.tbl_keyTableAdapter.FillBykeyownership(Me.db_kmsDataSet.tbl_key, FRMAdminMenu.LblUsertype.Text)
            CBOFILTERBYKEYOWNERSHIP.Text = ""
            TXTFILTERBYKEYTAG.Text = ""
            CBOFILTERBYROOMNO.Text = ""
            Me.RVRoomKey.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVRoomKey.RefreshReport()
        End If

    End Sub

    Private Sub TXTFILTERBYKEYTAG_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTERBYKEYTAG.TextChanged
        tbl_keyBindingSource.Filter = "keytag like '" & TXTFILTERBYKEYTAG.Text & "%'"
        Me.RVRoomKey.RefreshReport()
    End Sub

    Private Sub CBOFILTERBYROOMNO_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBOFILTERBYROOMNO.SelectedIndexChanged
        Me.tbl_keyTableAdapter.FillByroomnumber(Me.db_kmsDataSet.tbl_key, CBOFILTERBYROOMNO.Text)
        Me.RVRoomKey.RefreshReport()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
