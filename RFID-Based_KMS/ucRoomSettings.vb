Public Class ucRoomSettings
    Dim collegestats As String = "Active"
    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_roomTableAdapter.FillByroomownership(Me.Db_kmsDataSet.tbl_room, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_roomTableAdapter.FillByroomownership(Me.Db_kmsDataSet.tbl_room, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_roomTableAdapter.FillByroomownership(Me.Db_kmsDataSet.tbl_room, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_roomTableAdapter.Fill(Me.Db_kmsDataSet.tbl_room)
        End If
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTROOMNO.Enabled = True
        CBOROOMCAT.Enabled = True
        CBOROOMOWNERSHIP.Enabled = True
        CBOSTATUS.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTROOMNO.Enabled = False
        CBOROOMCAT.Enabled = False
        CBOROOMOWNERSHIP.Enabled = False
        CBOSTATUS.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTROOMNO.Text = ""
        CBOROOMCAT.Text = ""
        CBOROOMOWNERSHIP.Text = ""
        CBOSTATUS.Text = ""
    End Sub

    Private Sub ucRoomSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FUNCTION_REFRESH()

        'CBOROOMOWNERSHIP.Items.Clear()
        'CBOROOMOWNERSHIP.Items.Add(FRMAdminMenu.LblUsertype.Text)
        'If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    CBOROOMOWNERSHIP.Items.Clear()
        '    CBOROOMOWNERSHIP.Items.Add("College of Accountancy")
        '    CBOROOMOWNERSHIP.Items.Add("College of Business")
        '    CBOROOMOWNERSHIP.Items.Add("College of Computer Studies")
        '    Me.Tbl_roomTableAdapter.Fill(Me.Db_kmsDataSet.tbl_room)
        'End If
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestats & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOROOMOWNERSHIP.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()

        OpenCon()
        cmd.CommandText = "Select * from tbl_roomcategory"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOROOMCAT.Items.Add(dr.Item("categoryname"))
            End While
        End If
        con.Close()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTROOMNO.Focus()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTROOMNO.Text = "" Or CBOROOMCAT.Text = "" Or CBOROOMOWNERSHIP.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTROOMNO.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - room cat doesn't match **********************************
        If CBOROOMCAT.Text <> "Laboratory Room" And CBOROOMCAT.Text <> "Academic Room" Then
            MsgBox("Room Category doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '**********************************************error trapping - room ownership doesn't match **********************************
        If CBOROOMOWNERSHIP.Text <> "College of Accountancy" And CBOROOMOWNERSHIP.Text <> "College of Business" And CBOROOMOWNERSHIP.Text <> "College of Computer Studies" And CBOROOMOWNERSHIP.Text <> "General Services Office" Then
            MsgBox("Room Ownership doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '**********************************************error trapping - acc status doesn't match **********************************
        If CBOSTATUS.Text <> "Active" And CBOSTATUS.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '***********error trapping - if COurse already exist in the DB ***************
        If TXTROOMNO.Text <> "" Then
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_room where roomnumber = '" & TXTROOMNO.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Room already exist", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTROOMNO.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_room values (@rn, @rc , @ro, @stat) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("rn", TXTROOMNO.Text)
            .AddWithValue("rc", CBOROOMCAT.Text)
            .AddWithValue("ro", CBOROOMOWNERSHIP.Text)
            .AddWithValue("stat", CBOSTATUS.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Room added successfully", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()

        '*********** updating act log ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New Room")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTROOMNO.Text = "" Or CBOROOMCAT.Text = "" Or CBOROOMOWNERSHIP.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTROOMNO.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTROOMNO.Enabled = True
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '**********************************************error trapping - all fields are required **********************************
            If TXTROOMNO.Text = "" Or CBOROOMCAT.Text = "" Or CBOROOMOWNERSHIP.Text = "" Or CBOSTATUS.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTROOMNO.Focus()
                Exit Sub
            End If


            '**********update code***********************
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_room Set roomnumber= @rn, roomcategory= @rc, roomownership= @ro, status= @stat where roomnumber = '" & TXTROOMNO.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("rn", TXTROOMNO.Text)
                .AddWithValue("rc", CBOROOMCAT.Text)
                .AddWithValue("ro", CBOROOMOWNERSHIP.Text)
                .AddWithValue("stat", CBOSTATUS.Text)
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
            cmd.Parameters.AddWithValue("act", "Edited Room")
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

    Private Sub DGVROOMSETTINGS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVROOMSETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVROOMSETTINGS.Rows(e.RowIndex)
            TXTROOMNO.Text = row.Cells(0).Value
            CBOROOMCAT.Text = row.Cells(1).Value
            CBOROOMOWNERSHIP.Text = row.Cells(2).Value
            CBOSTATUS.Text = row.Cells(3).Value
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        Me.TblroomBindingSource.Filter = "roomnumber like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub TXTROOMNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTROOMNO.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
