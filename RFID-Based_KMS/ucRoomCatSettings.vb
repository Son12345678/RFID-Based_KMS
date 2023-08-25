Public Class ucRoomCatSettings
    Private Sub FUNCTION_REFRESH()
        'If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
        '    Me.Tbl_roomcategoryTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_roomcategory, "College of Computer Studies")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
        '    Me.Tbl_roomcategoryTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_roomcategory, "College of Accountancy")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
        '    Me.Tbl_roomcategoryTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_roomcategory, "College of Business")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        'End If
        Me.Tbl_roomcategoryTableAdapter.Fill(Me.Db_kmsDataSet.tbl_roomcategory)
    End Sub
    Private Sub FUNCTION_ENABLED()
        TXTCATEGORYNAME.Enabled = True
        TXTCATEGORYNO.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTCATEGORYNAME.Enabled = False
        TXTCATEGORYNO.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub
    Private Sub FUNCTION_CLEAR()
        TXTCATEGORYNAME.Text = ""
        TXTCATEGORYNO.Text = ""
    End Sub

    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(categorynumber) FROM tbl_roomcategory")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTCATEGORYNO.Text = getID + 1
    End Sub

    Private Sub ucRoomCatSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FUNCTION_REFRESH()
        Me.Tbl_roomcategoryTableAdapter.Fill(Me.Db_kmsDataSet.tbl_roomcategory)
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTCATEGORYNO.Enabled = False
        TXTCATEGORYNO.Focus()

        GETMAX()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTCATEGORYNO.Text = "" Or TXTCATEGORYNAME.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTCATEGORYNO.Focus()
            Exit Sub
        End If

        '***********error trapping - if ROOMCAT already exist in the DB ***************
        If TXTCATEGORYNAME.Text <> "" Then
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_roomcategory where categoryname = '" & TXTCATEGORYNAME.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Room Category already exist", vbOKOnly + vbCritical, "error saving")
                con.Close()
                TXTCATEGORYNO.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_roomcategory values (@cno, @cname) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("cno", TXTCATEGORYNO.Text)
            .AddWithValue("cname", TXTCATEGORYNAME.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Room Category added successfully", vbOKOnly + vbInformation, "Saving Record")
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
        cmd.Parameters.AddWithValue("act", "Add New Room Category")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
      
        '**********************************************error trapping - select record **********************************
        If TXTCATEGORYNO.Text = "" Or TXTCATEGORYNAME.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTCATEGORYNO.Focus()
            Exit Sub
        End If

            If BTNEDIT.Text = "EDIT" Then
                FUNCTION_ENABLED()
                BTNSAVE.Enabled = False
                BTNEDIT.Enabled = True
                TXTCATEGORYNO.Enabled = False
                BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then
            '**********************************************error trapping - all fields are required **********************************
            If TXTCATEGORYNO.Text = "" Or TXTCATEGORYNAME.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTCATEGORYNO.Focus()
                Exit Sub
            End If
            ''***********error trapping - if cat already exist in the DB ***************
            'If TXTCATEGORYNO.Text <> "" Then
            '    OpenCon()
            '    cmd.Connection = con
            '    cmd.CommandText = "select * from tbl_roomcategory where categorynumber  = '" & TXTCATEGORYNO.Text & "' "
            '    dr = cmd.ExecuteReader()

            '    If dr.HasRows Then
            '        MsgBox("Room Category already exist", vbOKOnly + vbCritical, "error saving")
            '        con.Close()
            '        TXTCATEGORYNO.Focus()
            '        Exit Sub
            '    End If
            '    con.Close()

            '**********update code***********************
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_roomcategory Set categorynumber = @cno, categoryname= @cname where categorynumber = '" & TXTCATEGORYNO.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("cno", TXTCATEGORYNO.Text)
                .AddWithValue("cname", TXTCATEGORYNAME.Text)
                cmd.ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("Your record has been updated", vbOKOnly + vbInformation, "Updating Record")
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"

            '*********** updating act log ***************
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Edited Room Category")
            cmd.ExecuteNonQuery()

            con.Close()
        End If
        'End If
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

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblroomcategoryBindingSource.Filter = "categoryname like '%" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub DGVROOMCAT_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVROOMCAT.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVROOMCAT.Rows(e.RowIndex)
            TXTCATEGORYNO.Text = row.Cells(0).Value
            TXTCATEGORYNAME.Text = row.Cells(1).Value
        End If
    End Sub

End Class
