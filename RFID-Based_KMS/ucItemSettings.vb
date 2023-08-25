Public Class ucItemSettings
    Private Sub FUNCTION_REFRESH()
        Me.Tbl_itemcategoryTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemcategory)
    End Sub

    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(categoryid) FROM tbl_itemcategory")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTCategoryID.Text = getID + 1
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTCategoryID.Enabled = True
        TXTCATNAME.Enabled = True
        CBOSTATUS.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTCategoryID.Enabled = False
        TXTCATNAME.Enabled = False
        CBOSTATUS.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub
    Private Sub FUNCTION_CLEAR()
        TXTCategoryID.Text = ""
        TXTCATNAME.Text = ""
        CBOSTATUS.Text = ""
    End Sub

    Private Sub ucItemSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FUNCTION_REFRESH()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        GETMAX()
        TXTCategoryID.Enabled = False
        TXTCategoryID.Focus()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTCategoryID.Text = "" Or TXTCATNAME.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTCategoryID.Focus()
            Exit Sub
        End If

        ''**********************************************error trapping - Category name doesnt exist **********************************
        'If cb.Text <> "Tools" And TXTCATNAME.Text <> "IT Equipment" And TXTCATNAME.Text <> "Sound Equipment" Then
        '    MsgBox("Category name doesn't exist", vbOKOnly + vbCritical, "Error Saving")
        '    TXTCategoryID.Focus()
        '    Exit Sub
        'End If

        '**********************************************error trapping - item ownership doesnt exist **********************************
        'If CBOITEMOWNERSHIP.Text <> "College of Accountancy" And CBOITEMOWNERSHIP.Text <> "College of Business" And CBOITEMOWNERSHIP.Text <> "College of Computer Studies" And CBOITEMOWNERSHIP.Text <> "General Services Office" Then
        '    MsgBox("Item Ownership doesn't exist", vbOKOnly + vbCritical, "Error Saving")
        '    TXTCategoryID.Focus()
        '    Exit Sub
        'End If

        '**********************************************error trapping - STATUS doesnt exist **********************************
        If CBOSTATUS.Text <> "Active" And CBOSTATUS.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTCategoryID.Focus()
            Exit Sub
        End If

        '***********error trapping - if COurse already exist in the DB ***************
        If TXTCategoryID.Text <> "" Then
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_itemcategory where categoryid = '" & TXTCategoryID.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Course already exist", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTCategoryID.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_itemcategory values (@catid, @catname, @status) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("catid", TXTCategoryID.Text)
            .AddWithValue("catname", TXTCATNAME.Text)
            .AddWithValue("status", CBOSTATUS.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Item Category added successfully", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()

        '*********** updating act log ***************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New Item Category")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTCategoryID.Text = "" Or TXTCATNAME.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTCategoryID.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTCategoryID.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '**********************************************error trapping - all fields are required **********************************
            If TXTCategoryID.Text = "" Or TXTCATNAME.Text = "" Then
                MsgBox("all fields are reuired", vbOKOnly + vbCritical, "error saving")
                TXTCategoryID.Focus()
                Exit Sub
            End If

            ''***********error trapping - if item already exist in the DB ***************
            'If TXTCategoryID.Text <> "" Then
            '    OpenCon()
            '    cmd.Connection = con
            '    cmd.CommandText = "select * from tbl_itemcategory where categoryid  = '" & TXTCategoryID.Text & "' "
            '    dr = cmd.ExecuteReader()

            '    If dr.HasRows Then
            '        MsgBox("College already exist", vbOKOnly + vbCritical, "error saving")
            '        con.Close()
            '        TXTCategoryID.Focus()
            '        Exit Sub
            '    End If
            '    con.Close()

            '**********update code***********************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_itemcategory Set categoryid = @catid, categoryname= @catname, status = @status where categoryid = '" & TXTCategoryID.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("catid", TXTCategoryID.Text)
                .AddWithValue("catname", TXTCATNAME.Text)
                .AddWithValue("status", CBOSTATUS.Text)
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
            cmd.Parameters.AddWithValue("act", "Edited Item Category")
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

    Private Sub DGVCOURSESETTINGS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEMSETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVITEMSETTINGS.Rows(e.RowIndex)
            TXTCategoryID.Text = row.Cells(0).Value
            TXTCATNAME.Text = row.Cells(1).Value
            CBOSTATUS.Text = row.Cells(2).Value
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblitemcategoryBindingSource.Filter = "categoryname like '%" & TXTSEARCH.Text & "%'"
    End Sub
End Class
