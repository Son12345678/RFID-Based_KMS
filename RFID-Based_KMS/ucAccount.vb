Public Class ucAccount
    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_useraccTableAdapter.FillByusertype(Me.Db_kmsDataSet.tbl_useracc, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_useraccTableAdapter.FillByusertype(Me.Db_kmsDataSet.tbl_useracc, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then         
            Me.Tbl_useraccTableAdapter.FillByusertype(Me.Db_kmsDataSet.tbl_useracc, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_useraccTableAdapter.FillByusertype(Me.Db_kmsDataSet.tbl_useracc, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then           
            Me.Tbl_useraccTableAdapter.Fill(Me.Db_kmsDataSet.tbl_useracc)
        End If
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTFNAME.Enabled = True
        TXTMNAME.Enabled = True
        TXTLNAME.Enabled = True
        TXTUN.Enabled = True
        TXTPASS.Enabled = True
        TXTCONFIRMPASS.Enabled = True
        CBOUTYPE.Enabled = True
        CBOACCSTATUS.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTFNAME.Enabled = False
        TXTMNAME.Enabled = False
        TXTLNAME.Enabled = False
        TXTUN.Enabled = False
        TXTPASS.Enabled = False
        TXTCONFIRMPASS.Enabled = False
        CBOUTYPE.Enabled = False
        CBOACCSTATUS.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTFNAME.Text = ""
        TXTMNAME.Text = ""
        TXTLNAME.Text = ""
        TXTUN.Text = ""
        TXTPASS.Text = ""
        TXTCONFIRMPASS.Text = ""
        CBOUTYPE.Text = ""
        CBOACCSTATUS.Text = ""
    End Sub

    Private Sub ucAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FUNCTION_REFRESH()
        'CBOUTYPE.Items.Clear()
        'CBOUTYPE.Items.Add(FRMAdminMenu.LblUsertype.Text)
        'If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    CBOUTYPE.Items.Clear()
        '    CBOUTYPE.Items.Add("College of Accountancy")
        '    CBOUTYPE.Items.Add("College of Business")
        '    CBOUTYPE.Items.Add("College of Computer Studies")
        '    CBOUTYPE.Items.Add("General Services Office")
        '    CBOUTYPE.Items.Add("Guard")
        '    Me.Tbl_useraccTableAdapter.Fill(Me.Db_kmsDataSet.tbl_useracc)
        'End If
        Dim collegestats As String = "Active"
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestats & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOUTYPE.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()
        FUNCTION_REFRESH()

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Dim i As Integer
        For i = FRMAdminMenu.pnlmain.Controls.Count - 1 To 0
            FRMAdminMenu.pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = FRMAdminMenu.pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
        TXTFNAME.Focus()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or TXTUN.Text = "" Or CBOUTYPE.Text = "" Or TXTPASS.Text = "" Or TXTCONFIRMPASS.Text = "" Or CBOACCSTATUS.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTUN.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - pass is not match **********************************
        If TXTPASS.Text <> TXTCONFIRMPASS.Text Then
            MsgBox("Password did not match", vbOKOnly + vbCritical, "Error Saving")
            TXTPASS.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - user type doesn't match **********************************
        If CBOUTYPE.Text <> "System Administrator" And CBOUTYPE.Text <> "College of Accountancy" And CBOUTYPE.Text <> "College of Business" And CBOUTYPE.Text <> "College of Computer Studies" And CBOUTYPE.Text <> "General Services Office" Then
            MsgBox("Usertype doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            CBOUTYPE.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - acc status doesn't match **********************************
        If CBOACCSTATUS.Text <> "Active" And CBOACCSTATUS.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            CBOACCSTATUS.Focus()
            Exit Sub
        End If

        '***********error trapping - if username already exist in the DB ***************
        If TXTUN.Text <> "" Then
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_useracc where username = '" & TXTUN.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Username already exist", vbOKOnly + vbCritical, "error saving")
                con.Close()
                TXTUN.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_useracc values (@un, @pass, @fn, @mn, @ln, @stat,@ut) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("pass", TXTPASS.Text)
            .AddWithValue("fn", TXTFNAME.Text)
            .AddWithValue("mn", TXTMNAME.Text)
            .AddWithValue("ln", TXTLNAME.Text)
            .AddWithValue("stat", CBOACCSTATUS.Text)
            .AddWithValue("ut", CBOUTYPE.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Your record has been saved", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()


        '*************************************** UPDATING ACTIVITY LOG ***************************** 
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @un ,activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("un", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New User")
        cmd.ExecuteNonQuery()

        con.Close()

    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or TXTUN.Text = "" Or CBOUTYPE.Text = "" Or TXTPASS.Text = "" Or TXTCONFIRMPASS.Text = "" Or CBOACCSTATUS.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTUN.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTUN.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '***********error trapping - fields are required ***************
            If TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or TXTUN.Text = "" Or CBOUTYPE.Text = "" Or TXTPASS.Text = "" Or TXTCONFIRMPASS.Text = "" Or CBOACCSTATUS.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTUN.Focus()
                Exit Sub
            End If
            '***********error trapping - if password is not match ***************
            If TXTPASS.Text <> TXTCONFIRMPASS.Text Then
                MsgBox("Password did not match", vbOKOnly + vbInformation, "Error Saving")
                TXTPASS.Focus()
                Exit Sub
            End If

            '**********update code***********************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_useracc Set username = @un, pass= @pass,  fname= @fn, mname = @mn, lname = @ln, status= @stat, usertype = @ut  where username = '" & TXTUN.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("un", TXTUN.Text)
                .AddWithValue("pass", TXTPASS.Text)
                .AddWithValue("fn", TXTFNAME.Text)
                .AddWithValue("mn", TXTMNAME.Text)
                .AddWithValue("ln", TXTLNAME.Text)
                .AddWithValue("stat", CBOACCSTATUS.Text)
                .AddWithValue("ut", CBOUTYPE.Text)
                cmd.ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("Your record has been updated", vbOKOnly + vbInformation, "Updating Record")
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"

            '*************************************** UPDATING ACTIVITY LOG ***************************** 
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Edited User")
            cmd.ExecuteNonQuery()

            con.Close()
        End If

    End Sub

    Private Sub DGVACC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVACC.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVACC.Rows(e.RowIndex)
            TXTUN.Text = row.Cells(0).Value
            TXTPASS.Text = row.Cells(1).Value
            TXTFNAME.Text = row.Cells(2).Value
            TXTMNAME.Text = row.Cells(3).Value
            TXTLNAME.Text = row.Cells(4).Value
            CBOACCSTATUS.Text = row.Cells(5).Value
            CBOUTYPE.Text = row.Cells(6).Value
        End If
        TXTCONFIRMPASS.Text = TXTPASS.Text
    End Sub

    Private Sub DGVACC_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVACC.CellFormatting
        If e.ColumnIndex = 1 Then
            e.Value = New String("*"c, e.Value.ToString.Length)
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

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TbluseraccBindingSource.Filter = "lname like '" & TXTSEARCH.Text & "%'"
    End Sub
End Class
