Public Class ucItemQuantitySettings
    Dim itemcatstats As String = "Active"
    Dim collegestat As String = "Active"
    Private Sub ucItemQuantitySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, FRMAdminMenu.LblUsertype.Text)

        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        End If

        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestat & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOitemownership.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()

        OpenCon()
        cmd.CommandText = "Select * from tbl_itemcategory where status = '" & itemcatstats & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOitemcat.Items.Add(dr.Item("categoryname"))
            End While
        End If
        con.Close()
    End Sub

    Private Sub GETMAX()
        Dim getID As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("SELECT MAX(itemno) FROM tbl_item")
        getID = Convert.ToInt64(cmd.ExecuteScalar())

        con.Close()
        TXTitemno.Text = getID + 1
    End Sub

    Private Sub FUNCTION_REFRESH()
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_itemTableAdapter.FillByOwnershipItem(Me.Db_kmsDataSet.tbl_item, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_itemTableAdapter.FillByOwnershipItem(Me.Db_kmsDataSet.tbl_item, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_itemTableAdapter.FillByOwnershipItem(Me.Db_kmsDataSet.tbl_item, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_itemTableAdapter.FillByOwnershipItem(Me.Db_kmsDataSet.tbl_item, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        End If
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTitemno.Enabled = True
        TXTitemname.Enabled = True
        CBOitemcat.Enabled = True
        TXTquantity.Enabled = True
        CBOitemownership.Enabled = True
        CBOstatus.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTitemno.Enabled = False
        TXTitemname.Enabled = False
        CBOitemcat.Enabled = False
        TXTquantity.Enabled = False
        CBOitemownership.Enabled = False
        CBOstatus.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTitemno.Text = ""
        TXTitemname.Text = ""
        CBOitemcat.Text = ""
        TXTquantity.Text = ""
        CBOitemownership.Text = ""
        CBOstatus.Text = ""
    End Sub


    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        GETMAX()
        TXTitemno.Enabled = False
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********************************************error trapping - all fields are required **********************************
        If TXTitemno.Text = "" Or TXTitemname.Text = "" Or CBOitemcat.Text = "" Or TXTquantity.Text = "" Or CBOitemownership.Text = "" Or CBOstatus.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            TXTitemno.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - Category name doesnt exist **********************************
        If CBOitemcat.Text <> "Tools" And CBOitemcat.Text <> "IT Equipment" And CBOitemcat.Text <> "Sound Equipment" Then
            MsgBox("Item Category doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTitemno.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - Category name doesnt exist **********************************
        If CBOitemownership.Text <> "College of Accountancy" And CBOitemownership.Text <> "College of Business" And CBOitemownership.Text <> "College of Computer Studies" Then
            MsgBox("Item Ownership doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTitemno.Focus()
            Exit Sub
        End If

        '**********************************************error trapping - STATUS doesnt exist **********************************
        If CBOstatus.Text <> "Active" And CBOstatus.Text <> "Inactive" Then
            MsgBox("Status doesn't exist", vbOKOnly + vbCritical, "Error Saving")
            TXTitemno.Focus()
            Exit Sub
        End If

        '****************************************inserting or saving values to the DB **************************************************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_item values (@itemno, @itemname, @itemcategory, @quantity, @itemownership, @status) "
        With cmd.Parameters
            .Clear()
            .AddWithValue("itemno", TXTitemno.Text)
            .AddWithValue("itemname", TXTitemname.Text)
            .AddWithValue("itemcategory", CBOitemcat.Text)
            .AddWithValue("quantity", TXTquantity.Text)
            .AddWithValue("itemownership", CBOitemownership.Text)
            .AddWithValue("status", CBOstatus.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Item added successfully", vbOKOnly + vbInformation, "Saving Record")
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
        cmd.Parameters.AddWithValue("act", "Add New Item")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTitemno.Text = "" Or TXTitemname.Text = "" Or CBOitemcat.Text = "" Or TXTquantity.Text = "" Or CBOitemownership.Text = "" Or CBOstatus.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTitemno.Focus()
            Exit Sub
        End If
        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTitemno.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '**********************************************error trapping - all fields are required **********************************
            If TXTitemno.Text = "" Or TXTitemname.Text = "" Or CBOitemcat.Text = "" Or TXTquantity.Text = "" Or CBOitemownership.Text = "" Or CBOstatus.Text = "" Then
                MsgBox("all fields are reuired", vbOKOnly + vbCritical, "error saving")
                TXTitemno.Focus()
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
            cmd.CommandText = "update tbl_item Set itemno = @itemno, itemname= @itemname, itemcategory= @itemcategory, quantity = @qty, itemownership= @itemownership, status = @status where itemno = '" & TXTitemno.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("itemno", TXTitemno.Text)
                .AddWithValue("itemname", TXTitemname.Text)
                .AddWithValue("itemcategory", CBOitemcat.Text)
                .AddWithValue("qty", TXTquantity.Text)
                .AddWithValue("itemownership", CBOitemownership.Text)
                .AddWithValue("status", CBOstatus.Text)
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
            cmd.Parameters.AddWithValue("act", "Edited Item")
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

    Private Sub DGVITEMSETTINGS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEMSETTINGS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVITEMSETTINGS.Rows(e.RowIndex)
            TXTitemno.Text = row.Cells(0).Value
            TXTitemname.Text = row.Cells(1).Value
            CBOitemcat.Text = row.Cells(2).Value
            TXTquantity.Text = row.Cells(3).Value
            CBOitemownership.Text = row.Cells(4).Value
            CBOstatus.Text = row.Cells(5).Value
        End If
    End Sub

    Private Sub TXTSEARCHITEM_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHITEM.TextChanged
        TblitemBindingSource.Filter = "itemname like '%" & TXTSEARCHITEM.Text & "%'"
    End Sub

    Private Sub TXTquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTquantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CBOitemownership_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOitemownership.SelectedIndexChanged
        'Dim itemstat As String = "Active"
        'OpenCon()
        'cmd.CommandText = "Select * from tbl_item where itemownership = @in and status = @stat"
        'With cmd.Parameters
        '    .Clear()
        '    .AddWithValue("in", CBOitemownership.Text)
        '    .AddWithValue("stat", itemstat)
        'End With
        'con.Close()
    End Sub
End Class
