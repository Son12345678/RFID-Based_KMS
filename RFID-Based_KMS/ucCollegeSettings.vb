Public Class ucCollegeSettings

    Private Sub ucCollegeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_collegeTableAdapter.Fill(Me.Db_kmsDataSet.tbl_college)
    End Sub

    Private Sub FUNCTION_REFRESH()      
        Me.Tbl_collegeTableAdapter.Fill(Me.Db_kmsDataSet.tbl_college)
    End Sub
    Private Sub FUNCTION_ENABLED()
        TXTCOLLEGEID.Enabled = True
        TXTCOLLEGE.Enabled = True
        CBOCollegeStatus.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False

    End Sub

    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(collegeid) FROM tbl_college")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTCOLLEGEID.Text = getID + 1
    End Sub
    Private Sub FUNCTION_DISABLED()
        TXTCOLLEGEID.Enabled = False
        TXTCOLLEGE.Enabled = False
        CBOCollegeStatus.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTCOLLEGEID.Text = ""
        TXTCOLLEGE.Text = ""
        CBOCollegeStatus.Text = ""
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTCOLLEGEID.Enabled = False
        TXTCOLLEGEID.Focus()
        GETMAX()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTCOLLEGEID.Text = "" Or TXTCOLLEGE.Text = "" Or CBOCollegeStatus.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTCOLLEGEID.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - acc status doesn't match **********************************
        If CBOCollegeStatus.Text <> "Active" And CBOCollegeStatus.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '***********error trapping - if COLLEGE already exist in the DB ***************
        If TXTCOLLEGEID.Text <> "" Then
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_college where collegeid = '" & TXTCOLLEGEID.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("College already exist", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTCOLLEGEID.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_college values (@cid, @c, @stat) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("cid", TXTCOLLEGEID.Text)
            .AddWithValue("c", TXTCOLLEGE.Text)
            .AddWithValue("stat", CBOCollegeStatus.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("College added successfuly", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()

        '*********** updating act log ***************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New College")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        '*************************************select a record you want to edit ***********************
        If TXTCOLLEGEID.Text = "" Or TXTCOLLEGE.Text = "" Or CBOCollegeStatus.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTCOLLEGE.Focus()
            Exit Sub
        End If

        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTCOLLEGEID.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '***********error trapping - fields are required ***************
            If TXTCOLLEGEID.Text = "" Or TXTCOLLEGE.Text = "" Or CBOCollegeStatus.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTCOLLEGE.Focus()
                Exit Sub
            End If

            '**********update code***********************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_college Set collegeid = @cid, collegename = @c, status = @stat  where collegeid = '" & TXTCOLLEGEID.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("cid", TXTCOLLEGEID.Text)
                .AddWithValue("c", TXTCOLLEGE.Text)
                .AddWithValue("stat", CBOCollegeStatus.Text)
                cmd.ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("Your record has been updated", vbOKOnly + vbInformation, "Updating Record")
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"

            '*********** updating act log ***************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Edited College")
            cmd.ExecuteNonQuery()

            con.Close()
        End If

    End Sub


    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
            FUNCTION_DISABLED()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"
        End If
    End Sub

    Private Sub TXTCOLLEGEID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCOLLEGEID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVCOLLEGESETTINGS_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCOLLEGESETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVCOLLEGESETTINGS.Rows(e.RowIndex)
            TXTCOLLEGEID.Text = row.Cells(0).Value
            TXTCOLLEGE.Text = row.Cells(1).Value
            CBOCollegeStatus.Text = row.Cells(2).Value
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblcollegeBindingSource.Filter = "collegename like '%" & TXTSEARCH.Text & "%'"
    End Sub
End Class
