Public Class ucCourseSettings
    Dim collegestats As String = "Active"
    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_courseTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_course, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_courseTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_course, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_courseTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_course, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_courseTableAdapter.Fill(Me.Db_kmsDataSet.tbl_course)
        End If
    End Sub
    Private Sub FUNCTION_ENABLED()
        TXTCOURSEID.Enabled = True
        CBOCOLLEGE.Enabled = True
        TXTCOURSE.Enabled = True
        CBOCourseStatus.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTCOURSEID.Enabled = False
        CBOCOLLEGE.Enabled = False
        TXTCOURSE.Enabled = False
        CBOCourseStatus.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTCOURSEID.Text = ""
        CBOCOLLEGE.Text = ""
        TXTCOURSE.Text = ""
        CBOCourseStatus.Text = ""
    End Sub

    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(courseid) FROM tbl_course")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTCOURSEID.Text = getID + 1
    End Sub
    Private Sub ucCourseSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CBOCOLLEGE.Items.Clear()
        'CBOCOLLEGE.Items.Add(FRMAdminMenu.LblUsertype.Text)
        'If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    CBOCOLLEGE.Items.Clear()
        '    CBOCOLLEGE.Items.Add("College of Accountancy")
        '    CBOCOLLEGE.Items.Add("College of Business")
        '    CBOCOLLEGE.Items.Add("College of Computer Studies")
        '    Me.Tbl_courseTableAdapter.Fill(Me.Db_kmsDataSet.tbl_course)
        'End If
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestats & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOCOLLEGE.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()
        FUNCTION_REFRESH()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTCOURSEID.Enabled = False
        TXTCOURSE.Focus()

        GETMAX()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTCOURSEID.Text = "" Or TXTCOURSE.Text = "" Or CBOCOLLEGE.Text = "" Or CBOCourseStatus.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTCOURSEID.Focus()
            Exit Sub
        End If

        ''**********************************************error trapping - college doesn't match **********************************
        If CBOCOLLEGE.Text <> "College of Accountancy" And CBOCOLLEGE.Text <> "College of Business" And CBOCOLLEGE.Text <> "College of Computer Studies" Then
            MsgBox("College doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        ''**********************************************error trapping - acc status doesn't match **********************************
        If CBOCourseStatus.Text <> "Active" And CBOCourseStatus.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '***********error trapping - if COurse already exist in the DB ***************
        If TXTCOURSE.Text <> "" Then
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_course where course = '" & TXTCOURSE.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Course already exist", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTCOURSEID.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '********************************** ERROR TRAPPIMG - COLLEGE IS INACTIVE ********************************************************
        con.Close()
        Dim collegestatus As String = "Inactive"
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select * from tbl_college where collegename = '" & CBOCOLLEGE.Text & "' and status = '" & collegestatus & "' "
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("College is Inactive", vbOKOnly + vbExclamation, "Error Adding")
            FUNCTION_CLEAR()
            FUNCTION_DISABLED()
            con.Close()
            Exit Sub
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_course values (@courseid, @course, @college, @stat) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("courseid", TXTCOURSEID.Text)
            .AddWithValue("course", TXTCOURSE.Text)
            .AddWithValue("college", CBOCOLLEGE.Text)
            .AddWithValue("stat", CBOCourseStatus.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Course added successfully", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()



        '*********** updating act log ***************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname = @an ,activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New Course")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click

        If TXTCOURSEID.Text = "" Or TXTCOURSE.Text = "" Or CBOCOLLEGE.Text = "" Or CBOCourseStatus.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTCOURSE.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTCOURSEID.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then
            '***********error trapping - fields are required ***************
            If TXTCOURSEID.Text = "" Or TXTCOURSE.Text = "" Or CBOCOLLEGE.Text = "" Or CBOCourseStatus.Text = "" Then
                MsgBox("all fields are required", vbOKOnly + vbCritical, "error saving")
                TXTCOURSEID.Focus()
                Exit Sub
            End If

            '**********update code***********************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_course Set courseid = @cid, course= @crs, college= @col, status = @stat where courseid = '" & TXTCOURSEID.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("cid", TXTCOURSEID.Text)
                .AddWithValue("crs", TXTCOURSE.Text)
                .AddWithValue("col", CBOCOLLEGE.Text)
                .AddWithValue("stat", CBOCourseStatus.Text)
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
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname = @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Edited Course")
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

    Private Sub DGVCOURSESETTINGS_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCOURSESETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVCOURSESETTINGS.Rows(e.RowIndex)
            TXTCOURSEID.Text = row.Cells(0).Value
            TXTCOURSE.Text = row.Cells(1).Value
            CBOCOLLEGE.Text = row.Cells(2).Value
            CBOCourseStatus.Text = row.Cells(3).Value
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblcourseBindingSource.Filter = "course like '%" & TXTSEARCH.Text & "%'"
    End Sub
End Class
