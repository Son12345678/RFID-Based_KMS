Public Class ucRoomKey
    Dim roomstats As String = "Active"
    Dim keyownershipstats As String = "Active"

    Private Sub ucRoomKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTRKBLANK.Focus()
        FUNCTION_REFRESH()

        'If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
        '    CBOKEYOWNERSHIP.Items.Clear()
        '    CBOKEYOWNERSHIP.Items.Add("College of Computer Studies")
        '    Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Computer Studies")

        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
        '    CBOKEYOWNERSHIP.Items.Clear()
        '    CBOKEYOWNERSHIP.Items.Add("College of Accountancy")
        '    Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Accountancy")

        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
        '    CBOKEYOWNERSHIP.Items.Clear()
        '    CBOKEYOWNERSHIP.Items.Add("College of Business")
        '    Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Business")


        'ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    CBOKEYOWNERSHIP.Items.Clear()
        '    CBOKEYOWNERSHIP.Items.Add("College of Accountancy")
        '    CBOKEYOWNERSHIP.Items.Add("College of Business")
        '    CBOKEYOWNERSHIP.Items.Add("College of Computer Studies")
        '    CBOKEYOWNERSHIP.Items.Add("General Services Office")
        '    Me.Tbl_keyTableAdapter.Fill(Me.Db_kmsDataSet.tbl_key)
        'End If

        Dim collegestat As String = "Active"
        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestat & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOKEYOWNERSHIP.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()

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

    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_keyTableAdapter.Fill(Me.Db_kmsDataSet.tbl_key)
        End If
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTKEYTAG.Enabled = True
        CBOROOMNUMBER.Enabled = True
        CBOROOMCAT.Enabled = True
        CBOKEYOWNERSHIP.Enabled = True
        CBOKEYTYPE.Enabled = True
        CBOSTATUS.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub
    Private Sub FUNCTION_DISABLED()
        TXTKEYTAG.Enabled = False
        CBOROOMNUMBER.Enabled = False
        CBOROOMCAT.Enabled = False
        CBOKEYOWNERSHIP.Enabled = False
        CBOKEYTYPE.Enabled = False
        CBOSTATUS.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTKEYTAG.Text = ""
        CBOROOMNUMBER.Text = ""
        CBOROOMCAT.Text = ""
        CBOKEYOWNERSHIP.Text = ""
        CBOKEYTYPE.Text = ""
        CBOSTATUS.Text = ""
    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        For i = FRMAdminMenu.pnlmain.Controls.Count - 1 To 0
            FRMAdminMenu.pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = FRMAdminMenu.pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PicFar.Visible = True Then
            PicFar.Visible = False
            PicClose.Visible = True
        Else
            PicFar.Visible = True
            PicClose.Visible = False
        End If
    End Sub

    Private Sub TXTKEYTAG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKEYTAG.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTKEYTAG_TextChanged(sender As Object, e As EventArgs) Handles TXTKEYTAG.TextChanged
        If TXTKEYTAG.Text.Length = 10 Then
            FUNCTION_ENABLED()
            CBOROOMCAT.Focus()
            TXTKEYTAG.Enabled = False
        End If

    End Sub
  

    Private Sub MSGROOMKEY_Tick(sender As Object, e As EventArgs) Handles MSGROOMKEY.Tick
        If TXTRKBLANK.Text.Length = 10 Then
            MSGROOMKEY.Enabled = False
            MsgBox("Please click add button first", vbOKOnly + vbInformation, "Error Tapping")
            TXTRKBLANK.Text = ""
            MSGROOMKEY.Enabled = True
        End If
    End Sub
    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Timer1.Enabled = True
        TXTKEYTAG.Enabled = True
        'FUNCTION_ENABLED()
        'FUNCTION_DISABLED()
        TXTKEYTAG.Focus()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '******************************************error trapping - id tag field required *****************************************
        If TXTKEYTAG.Text = "" Then
            MsgBox("Key Tag Field is required ", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If
        '**********************************************error trapping - all fields are required **********************************
        If TXTKEYTAG.Text = "" Or CBOROOMCAT.Text = "" Or CBOROOMNUMBER.Text = "" Or CBOKEYOWNERSHIP.Text = "" Or CBOKEYTYPE.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("all fields are required", vbOKOnly + vbCritical, "Error Saving")
            CBOROOMCAT.Focus()
            Exit Sub
        End If

        '******************************************error trapping - room cat doesn't match *****************************************
        If CBOROOMCAT.Text <> "Academic Room" And CBOROOMCAT.Text <> "Laboratory Room" Then
            MsgBox("Room Category doesn't match", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '******************************************error trapping - key ownership doesn't match *****************************************
        If CBOKEYOWNERSHIP.Text <> "College of Accountancy" And CBOKEYOWNERSHIP.Text <> "College of Business" And CBOKEYOWNERSHIP.Text <> "College of Computer Studies" And CBOKEYOWNERSHIP.Text <> "General Services Office" Then
            MsgBox("Key Ownership doesn't match", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '******************************************error trapping - key type doesn't match *****************************************
        If CBOKEYTYPE.Text <> "Original" And CBOKEYTYPE.Text <> "Duplicate" Then
            MsgBox("Key Type doesn't match", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '******************************************error trapping - status doesn't match *****************************************
        If CBOSTATUS.Text <> "Active" And CBOSTATUS.Text <> "Inactive" Then
            MsgBox("Status doesn't match", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        ''***********error trapping - if key tag already exist in the DB ***************
        'If CBOKEYTYPE.Text <> "" Then
        '    OpenCon()
        '    cmd.Connection = con
        '    cmd.CommandText = "select * from tbl_key where keytype = '" & CBOKEYTYPE.Text & "' "
        '    dr = cmd.ExecuteReader()

        '    If dr.HasRows Then
        '        MsgBox("Room number already exist", vbOKOnly + vbCritical, "error saving")
        '        con.Close()
        '        TXTKEYTAG.Focus()
        '        Exit Sub
        '    End If
        '    con.Close()
        'End If

        '***********inserting or saving values to the DB ***************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_key values (@keytag, @rn, @rcat, @ko, @kt, @stat) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("keytag", TXTKEYTAG.Text)
            .AddWithValue("rn", CBOROOMNUMBER.Text)
            .AddWithValue("rcat", CBOROOMCAT.Text)
            .AddWithValue("ko", CBOKEYOWNERSHIP.Text)
            .AddWithValue("kt", CBOKEYTYPE.Text)
            .AddWithValue("stat", CBOSTATUS.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Room key successfully added", vbOKOnly + vbInformation, "Saving Record")
        con.Close()
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()
        TXTKEYTAG.Focus()

        '*********** updating act log ***************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New Room Key")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTKEYTAG.Text = "" Or CBOROOMNUMBER.Text = "" Or CBOROOMCAT.Text = "" Or CBOKEYOWNERSHIP.Text = "" Or CBOKEYTYPE.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTKEYTAG.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTKEYTAG.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then
            '***********error trapping - fields are required ***************
            If TXTKEYTAG.Text = "" Or CBOROOMNUMBER.Text = "" Or CBOROOMCAT.Text = "" Or CBOKEYOWNERSHIP.Text = "" Or CBOKEYTYPE.Text = "" Or CBOSTATUS.Text = "" Then
                MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
                TXTKEYTAG.Focus()
                Exit Sub
            End If

            '**********update code***********************
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update tbl_key Set keytag = @kt, roomnumber = @rn, roomcategory = @rc, keyownership = @ko, keytype = @ktype, status = @stat where keytag = '" & TXTKEYTAG.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("kt", TXTKEYTAG.Text)
                .AddWithValue("rn", CBOROOMNUMBER.Text)
                .AddWithValue("rc", CBOROOMCAT.Text)
                .AddWithValue("ko", CBOKEYOWNERSHIP.Text)
                .AddWithValue("ktype", CBOKEYTYPE.Text)
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
            cmd.Parameters.AddWithValue("act", "Edited Room Key")
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
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub DGVROOMKEYS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVROOMKEYS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVROOMKEYS.Rows(e.RowIndex)
            TXTKEYTAG.Text = row.Cells(0).Value
            CBOROOMCAT.Text = row.Cells(1).Value
            CBOROOMNUMBER.Text = row.Cells(2).Value
            CBOKEYOWNERSHIP.Text = row.Cells(3).Value
            CBOKEYTYPE.Text = row.Cells(4).Value
            CBOSTATUS.Text = row.Cells(5).Value
            FUNCTION_DISABLED()
        End If
    End Sub

    Private Sub TXTROOMNO_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblkeyBindingSource1.Filter = "roomnumber like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub CBOROOMCAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOROOMCAT.SelectedIndexChanged
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_room where roomcategory = @c"
        With cmd.Parameters
            .Clear()
            .AddWithValue("c", CBOROOMCAT.Text)
        End With

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            CBOROOMNUMBER.Items.Clear()
            While dr.Read
                CBOROOMNUMBER.Items.Add(dr.Item("roomnumber"))
            End While
        End If
        con.Close()
    End Sub
End Class
