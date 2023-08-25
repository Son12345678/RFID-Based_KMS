Public Class ucSectionSettings
    Dim collegestats As String = "Active"
    Private Sub ucSectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FUNCTION_REFRESH()

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

        'CBOCOLLEGE.Items.Clear()
        'CBOCOLLEGE.Items.Add(FRMAdminMenu.LblUsertype.Text)
        'If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    CBOCOLLEGE.Items.Clear()
        '    CBOCOLLEGE.Items.Add("College of Accountancy")
        '    CBOCOLLEGE.Items.Add("College of Business")
        '    CBOCOLLEGE.Items.Add("College of Computer Studies")
        '    Me.Tbl_sectionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_section)
        'End If

    End Sub
    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(sectionid) FROM tbl_section")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTSECTIONID.Text = getID + 1
    End Sub

    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_sectionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_section, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_sectionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_section, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_sectionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_section, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_sectionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_section)
        End If
    End Sub
    Private Sub FUNCTION_ENABLED()
        TXTSECTION.Enabled = True
        TXTSECTIONID.Enabled = True
        CBOcourse.Enabled = True
        CBOCOLLEGE.Enabled = True
        CBOSectionStatus.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTSECTION.Enabled = False
        TXTSECTIONID.Enabled = False
        CBOcourse.Enabled = False
        CBOCOLLEGE.Enabled = False
        CBOSectionStatus.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTSECTION.Text = ""
        TXTSECTIONID.Text = ""
        CBOcourse.Text = ""
        CBOCOLLEGE.Text = ""
        CBOSectionStatus.Text = ""
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTSECTIONID.Enabled = False
        TXTSECTIONID.Focus()

        GETMAX()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTSECTION.Text = "" Or TXTSECTIONID.Text = "" Or CBOcourse.Text = "" Or CBOCOLLEGE.Text = "" Or CBOSectionStatus.Text = "" Then
            MsgBox("all fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTSECTIONID.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - college doesn't match **********************************
        If CBOCOLLEGE.Text <> "College of Accountancy" And CBOCOLLEGE.Text <> "College of Business" And CBOCOLLEGE.Text <> "College of Computer Studies" Then
            MsgBox("College doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTSECTIONID.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - college doesn't match **********************************
        If CBOSectionStatus.Text <> "Active" And CBOSectionStatus.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTSECTIONID.Focus()
            Exit Sub
        End If

        '***********error trapping - if SECTION already exist in the DB ***************
        'If TXTSECTION.Text <> "" Then
        '    OpenCon()
        '    cmd.Connection = con
        '    cmd.CommandText = "select * from tbl_section where section = '" & TXTSECTION.Text & "' "
        '    dr = cmd.ExecuteReader()

        '    If dr.HasRows Then
        '        MsgBox("Section already exist", vbOKOnly + vbCritical, "Error Saving")
        '        con.Close()
        '        TXTSECTIONID.Focus()
        '        Exit Sub
        '    End If
        '    con.Close()
        'End If

        '***********inserting or saving values to the DB ***************
        If CBOcourse.Text <> "" Then
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_course where course = '" & CBOcourse.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                con.Close()
                OpenCon()
                cmd.Connection = con
                cmd.CommandText = "Insert into tbl_section values (@sid, @sec, @course, @college, @stat) "
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("sid", TXTSECTIONID.Text)
                    .AddWithValue("sec", TXTSECTION.Text)
                    .AddWithValue("course", CBOcourse.Text)
                    .AddWithValue("college", CBOCOLLEGE.Text)
                    .AddWithValue("stat", CBOSectionStatus.Text)
                    cmd.ExecuteNonQuery()
                End With
                MsgBox("Section added successfully", vbOKOnly + vbInformation, "Saving Record")
                con.Close()
                FUNCTION_DISABLED()
                FUNCTION_CLEAR()
                FUNCTION_REFRESH()

                '********************************************** ACTIVITY LOG ****************************************
                con.Close()
                OpenCon()
                cmd.Connection = con
                cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("dt", DateTime.Now)
                cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
                cmd.Parameters.AddWithValue("act", "Add New Section")
                cmd.ExecuteNonQuery()
                con.Close()

            Else
                MsgBox("Course doesn't exist", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                Exit Sub
            End If
            con.Close()
            Exit Sub
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click

        If TXTSECTION.Text = "" Or TXTSECTIONID.Text = "" Or CBOcourse.Text = "" Or CBOCOLLEGE.Text = "" Or CBOSectionStatus.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTSECTIONID.Focus()
            Exit Sub
        End If

        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTSECTIONID.Enabled = False
            CBOCOLLEGE.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '**********************************************error trapping - all fields are required **********************************
            If TXTSECTION.Text = "" Or TXTSECTIONID.Text = "" Or CBOcourse.Text = "" Or CBOCOLLEGE.Text = "" Or CBOSectionStatus.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTSECTIONID.Focus()
                Exit Sub
            End If

            '**********update code***********************
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_section Set sectionid = @sid, section= @sec, course = @course, section= @sec, college = @col, status = @stat where sectionid = '" & TXTSECTIONID.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("sid", TXTSECTIONID.Text)
                .AddWithValue("sec", TXTSECTION.Text)
                .AddWithValue("course", CBOcourse.Text)
                .AddWithValue("col", CBOCOLLEGE.Text)
                .AddWithValue("stat", CBOSectionStatus.Text)
                cmd.ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("Your record has been updated", vbOKOnly + vbInformation, "Updating Record")
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"

            '********************************************** ACTIVITY LOG ****************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Edited Section")
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

    Private Sub DGVSECTIONSETTINGS_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSECTIONSETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVSECTIONSETTINGS.Rows(e.RowIndex)
            TXTSECTIONID.Text = row.Cells(0).Value
            TXTSECTION.Text = row.Cells(1).Value
            CBOcourse.Text = row.Cells(2).Value
            CBOCOLLEGE.Text = row.Cells(3).Value
            CBOSectionStatus.Text = row.Cells(4).Value
        End If
    End Sub

    Private Sub TXTsearchsection_TextChanged(sender As Object, e As EventArgs) Handles TXTsearchsection.TextChanged
        TblsectionBindingSource.Filter = "course like '%" & TXTsearchsection.Text & "%'"
    End Sub

    Private Sub CBOCOLLEGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCOLLEGE.SelectedIndexChanged
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_course where college = @c"
        With cmd.Parameters
            .Clear()
            .AddWithValue("c", CBOCOLLEGE.Text)
        End With

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            CBOcourse.Items.Clear()
            While dr.Read
                CBOcourse.Items.Add(dr.Item("course"))
            End While
        End If
        con.Close()
    End Sub
End Class
