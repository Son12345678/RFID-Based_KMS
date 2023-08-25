Public Class ucItemBorrow
    Private Sub ucItemBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Db_kmsDataSet.tbl_itemtransaction.Constraints.Clear()
        Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        Me.Tbl_itemcartTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemcart)
        Me.Tbl_borrowersprofileTableAdapter.Fill(Me.Db_kmsDataSet.tbl_borrowersprofile)
        TXTIBBLANK.Focus()

        '***************************** FILTER BY COLLEGE- ITEM *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        End If

        '***************************** FILTER BY COLLEGE- ITEM TRANS *****************************************
        'If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Computer Studies")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Accountancy")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Business")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "General Services Office")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    Me.Tbl_itemtransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemtransaction)
        'End If
    End Sub

    Private Sub FUNCTION_REFRESH()
        Me.Db_kmsDataSet.tbl_itemtransaction.Constraints.Clear()
        'Me.Tbl_itemtransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemtransaction)
        'Me.Tbl_itemtransactionTableAdapter.FillBytransactionstatus(Me.Db_kmsDataSet.tbl_itemtransaction, transactionstatus)
        Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        Me.Tbl_borrowersprofileTableAdapter.Fill(Me.Db_kmsDataSet.tbl_borrowersprofile)
        Me.Tbl_itemcartTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemcart)

        '***************************** FILTER BY COLLEGE- ITEM *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_itemTableAdapter.FillByitemownership(Me.Db_kmsDataSet.tbl_item, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_itemTableAdapter.Fill(Me.Db_kmsDataSet.tbl_item)
        End If

        ''***************************** FILTER BY COLLEGE- ITEM TRANS *****************************************
        'If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Computer Studies")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Accountancy")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "College of Business")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
        '    Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, "General Services Office")
        'ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
        '    Me.Tbl_itemtransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemtransaction)
        'End If
    End Sub

    Private Sub GETMAX()
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_itemtransaction"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(transactionnumber) from tbl_itemtransaction"
            getno = Convert.ToInt64(cmd.ExecuteScalar())

            TXTTRANSNO.Text = getno + 1
        Else
            TXTTRANSNO.Text = 1
        End If
        con.Close()
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTSmartCard.Text = ""
        TXTBORROWERSNAME.Text = ""
        TXTDISPLAYBROWSENAME.Text = ""
        TXTITEMNUMBER.Text = ""
        TXTDISPLAYITEMNAME.Text = ""
        TXTDISPLAYITEMNO.Text = ""
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTSmartCard.Enabled = True
        TXTBORROWERSNAME.Enabled = True
        BTNBROWSEITEMS.Enabled = True
        BTNADDITEMTOCART.Enabled = True
        BTNREMOVEITEM.Enabled = True
        BTNCLEAR.Enabled = True
        BTNBROWSEBNAME.Enabled = True
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTSmartCard.Enabled = False
        TXTBORROWERSNAME.Enabled = False
        BTNBROWSEITEMS.Enabled = False
        BTNADDITEMTOCART.Enabled = False
        BTNREMOVEITEM.Enabled = False
        BTNCLEAR.Enabled = False
        BTNBROWSEBNAME.Enabled = False
    End Sub

    Private Sub BTNBROWSEBNAME_Click(sender As Object, e As EventArgs) Handles BTNBROWSEBNAME.Click
        PNLBROWSECARD.Visible = True
    End Sub

    Private Sub BTNBROWSEITEM_Click(sender As Object, e As EventArgs)
        PNLBROWSEITEM.Visible = True
    End Sub

    Private Sub BNTPROCEED_Click(sender As Object, e As EventArgs) Handles BNTPROCEED.Click
        PNLBROWSECARD.Visible = False
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            PNLBROWSECARD.Visible = False
            FUNCTION_CLEAR()
            FUNCTION_DISABLED()
            Timer1.Enabled = True
            TXTIBBLANK.Focus()
        End If
    End Sub

    Private Sub BTNPROCEED2_Click(sender As Object, e As EventArgs) Handles BTNADDITEM.Click
        PNLBROWSEITEM.Visible = False
        TXTQTY.Focus()
    End Sub

    Private Sub BTNCANCEL2_Click(sender As Object, e As EventArgs) Handles BTNCANCEL2.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            PNLBROWSEITEM.Visible = False
            TXTITEMNAME.Text = ""
            TXTITEMNUMBER.Text = ""
            TXTQTY.Text = ""
            Timer1.Enabled = True
            TXTIBBLANK.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SmartFar.Visible = True Then
            SmartFar.Visible = False
            SmartClose.Visible = True
        Else
            SmartFar.Visible = True
            SmartClose.Visible = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BTNBorrowSave_Click(sender As Object, e As EventArgs) Handles BTNBorrowSave.Click
        TXTDISPLAYITEMNAME.Text = ""
        TXTDISPLAYITEMNO.Text = ""

        '********************************** ERROR TRAPPIMG - BORROWER IS INACTIVE ********************************************************
        con.Close()
        Dim profilestatus As String = "Inactive"
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select * from tbl_borrowersprofile where idtag = '" & TXTSmartCard.Text & "' and status = '" & profilestatus & "' "
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("This user is Inactive", vbOKOnly + vbExclamation, "Error Borrowing")
            FUNCTION_CLEAR()
            con.Close()
            Exit Sub
            con.Close()
        End If

        '********************************** ERROR TRAPPIMG - ITEM IS INACTIVE ********************************************************
        'con.Close()
        'Dim itemstatus As String = "Inactive"
        'con.Close()
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "select * from tbl_item where itemname = '" & TXTITEMNAME.Text & "' and status = '" & itemstatus & "' "
        'dr = cmd.ExecuteReader()

        'If dr.HasRows Then
        '    MsgBox("Item is Inactive", vbOKOnly + vbExclamation, "Error Borrowing")
        '    FUNCTION_CLEAR()
        '    con.Close()
        '    Exit Sub
        '    con.Close()
        'End If

        '*********************************INSERTING TO DB - TBL_ITEM TRANSACTION *******************************************
        Dim i As Integer
        For i = 0 To DGVITEMCART.Rows.Count - 1
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "insert into tbl_itemtransaction (transactionnumber, itemno, college, cardtag, borrowersname, dateborrowed, quantity, transactionstatus, timeborrowed) " &
                "values (@tn, @in, @col, @ct, @bname, @db, @qty, @ts, @bt)"
            With cmd.Parameters
                .Clear()
                .AddWithValue("tn", DGVITEMCART.Rows(i).Cells(0).Value.ToString)
                .AddWithValue("in", DGVITEMCART.Rows(i).Cells(1).Value.ToString)
                .AddWithValue("qty", DGVITEMCART.Rows(i).Cells(3).Value.ToString)
                .AddWithValue("col", DGVITEMCART.Rows(i).Cells(4).Value.ToString)
                .AddWithValue("ct", DGVITEMCART.Rows(i).Cells(5).Value.ToString)
                .AddWithValue("bname", DGVITEMCART.Rows(i).Cells(6).Value.ToString)
                .AddWithValue("db", Format(Date.Now, "yyyy-MM-dd"))
                .AddWithValue("ts", "Borrowed")
                .AddWithValue("bt", DateTime.Now)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        '******************************** UPDATING QUANTITY *******************************************
        Dim updatedQTY As Integer
        For i = 0 To DGVITEMCART.Rows.Count - 1
            OpenCon()
            cmd.CommandText = "Select * from tbl_item where itemno = '" & DGVITEMCART.Rows(i).Cells(1).Value.ToString & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                updatedQTY = dr.Item("quantity") - DGVITEMCART.Rows(i).Cells(3).Value.ToString
            End While
            con.Close()
            dr.Close()

            OpenCon()
            cmd.CommandText = "update tbl_item set quantity = '" & updatedQTY & "' where itemno= '" & DGVITEMCART.Rows(i).Cells(1).Value.ToString & "' "
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        '********************************DELETING TO TBL_ITEM CART *******************************************
        OpenCon()
        cmd.CommandText = "Delete from tbl_itemcart"
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Your transaction has been recorded", vbOKOnly + vbInformation, "Transaction Saved")
        FUNCTION_REFRESH()
        FUNCTION_CLEAR()
        FUNCTION_DISABLED()
        BTNBorrowSave.Enabled = False
        TXTITEMNUMBER.Text = ""
        TXTITEMNAME.Text = ""
        TXTQTY.Text = ""
    End Sub

    Private Sub BTNNewTrans_Click(sender As Object, e As EventArgs) Handles BTNNewTrans.Click
        Timer1.Enabled = True
        TXTQTY.Enabled = True
        TXTSmartCard.Focus()
        FUNCTION_ENABLED()
        GETMAX()
    End Sub

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            TXTBORROWERSNAME.Text = ""
            TXTSmartCard.Text = ""
            'TXTQUANTITY.Text = ""
            BTNBorrowSave.Enabled = False
            'TXTSmartCard.Focus()
            Timer1.Enabled = False
            TXTIBBLANK.Focus()
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            TXTITEMNUMBER.Text = ""
            TXTITEMNAME.Text = ""
            TXTQTY.Text = ""
        End If
    End Sub

    Private Sub TXTSmartCard_TextChanged(sender As Object, e As EventArgs) Handles TXTSmartCard.TextChanged
        Dim fname, mname, lname
        If TXTSmartCard.Text.Length = 10 Then
            Timer1.Enabled = False
            TXTSmartCard.Enabled = False
            TXTBORROWERSNAME.Enabled = False

            con.Close()
            OpenCon()
            cmd.CommandText = "Select * from tbl_borrowersprofile where idtag = @it "
            With cmd.Parameters
                .Clear()
                .AddWithValue("it", TXTSmartCard.Text)
                cmd.ExecuteNonQuery()
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fname = dr(1)
                    mname = dr(2)
                    lname = dr(3)
                    TXTSmartCard.Text = dr(0)
                    TXTBORROWERSNAME.Text = fname + " " + mname + " " + lname
                End While
                con.Close()
            End If
            BTNBROWSEBNAME.Enabled = False
            btnfocus.Focus()
        End If
        con.Close()
    End Sub

    Private Sub MSGITEM_Tick(sender As Object, e As EventArgs) Handles MSGITEM.Tick
        '*********************************ERROR TRAPPING - CLICK NEW TRANS FIRST *******************************************
        If TXTIBBLANK.Text.Length = 10 Then
            MSGITEM.Enabled = False
            MsgBox("Please click new transaction button first", vbOKOnly + vbInformation, "Error Tapping")
            TXTIBBLANK.Text = ""
            MSGITEM.Enabled = True
        End If
    End Sub

    Private Sub TXTQUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVITEM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEM.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVITEM.Rows(e.RowIndex)
            TXTITEMNUMBER.Text = row.Cells(0).Value
            TXTITEMNAME.Text = row.Cells(1).Value
            TXTDISPLAYITEMNO.Text = row.Cells(0).Value
            TXTDISPLAYITEMNAME.Text = row.Cells(1).Value

            TXTTOTALQUANTITY.Text = row.Cells(3).Value
        End If
    End Sub

    Private Sub DGVBORROWERSNAME_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBORROWERSNAME.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVBORROWERSNAME.Rows(e.RowIndex)
            TXTSmartCard.Text = row.Cells(0).Value
            TXTBORROWERSNAME.Text = row.Cells(1).Value + " " + row.Cells(2).Value + " " + row.Cells(3).Value
            TXTDISPLAYBROWSENAME.Text = row.Cells(1).Value + " " + row.Cells(2).Value + " " + row.Cells(3).Value
        End If
    End Sub

    Private Sub TXTSEARCHTAG_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHTAG.TextChanged
        TblborrowersprofileBindingSource.Filter = "lastname like '" & TXTSEARCHTAG.Text & "%'"
    End Sub

    Private Sub TXTSEARCHITEM_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHITEM.TextChanged
        TblitemBindingSource.Filter = "itemname like '" & TXTSEARCHITEM.Text & "%'"
    End Sub

    Private Sub TXTBORROWERSNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTBORROWERSNAME.TextChanged
        BTNBROWSEBNAME.Enabled = False
    End Sub

    Private Sub BTNADDITEMTOCART_Click(sender As Object, e As EventArgs) Handles BTNADDITEMTOCART.Click
        BTNREMOVEITEM.Enabled = True
        BTNBorrowSave.Enabled = True
        TXTDISPLAYITEMNAME.Text = ""
        TXTDISPLAYITEMNO.Text = ""

        ''*********************************** ERROR TRAPPING - ITEM INFO REQUIRED *****************************
        If TXTITEMNUMBER.Text = "" Or TXTITEMNAME.Text = "" Or TXTQTY.Text = "" Then
            MsgBox("Please select Borrower/Item first", vbOKOnly + vbCritical, "Error Adding Item")
            FUNCTION_DISABLED()
            BTNBorrowSave.Enabled = False
            Exit Sub
        End If

        ''*********************************** ERROR TRAPPING - QUANTITY IS REQUIRED *****************************
        If TXTQTY.Text = "" Then
            MsgBox("Please input quantity first", vbOKOnly + vbCritical, "Error Adding Item")
            FUNCTION_DISABLED()
            BTNBorrowSave.Enabled = False
            Exit Sub
        End If


        ''*********************************** ERROR TRAPPING - ITEM EXISTING IN THE CART *****************************
        '=====get total quantity in tbl item 
        Dim TotalQty As Integer
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_item where itemno = '" & TXTITEMNUMBER.Text & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                TotalQty = dr.Item("quantity")
            End While
        End If
        'dr.Close()


        If TotalQty = 0 Then
            MsgBox("Sorry, there is no available item", vbOKOnly + vbInformation, "Error Adding Item")
            con.Close()
            TXTITEMNUMBER.Text = ""
            TXTITEMNAME.Text = ""
            TXTQTY.Text = ""
            con.Close()
            Exit Sub
        End If

        '===get total quantity in tbl item, compare if inputed quatity is more than the available quantity 
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_item where itemno = '" & TXTITEMNUMBER.Text & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim Quantity As Integer
            While dr.Read
                Quantity = dr.Item("quantity")
            End While
            If Val(TXTQTY.Text) > Quantity Then
                MsgBox("Sorry, Item quantity is insufficient", vbOKOnly + vbInformation, "Error Adding Item")
                con.Close()
                TXTITEMNUMBER.Text = ""
                TXTITEMNAME.Text = ""
                TXTQTY.Text = ""
                con.Close()
                Exit Sub
            End If
        End If

        '===get total quantity in itemcart + added quantity with same item number
        'con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_itemcart where itemno = '" & TXTITEMNUMBER.Text & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim Quantity As Integer
            While dr.Read
                Quantity = dr.Item("quantity") + Val(TXTQTY.Text)
                'con.Close()
                If Quantity > TotalQty Then
                    MsgBox("Sorry, Item quantity is insufficient", vbOKOnly + vbInformation, "Error Adding Item")
                    TXTITEMNUMBER.Text = ""
                    TXTITEMNAME.Text = ""
                    TXTQTY.Text = ""
                    Exit Sub
                End If

                If TotalQty = 0 Then
                    MsgBox("Sorry, there is no available item", vbOKOnly + vbInformation, "Error Adding Item")
                    con.Close()
                    TXTITEMNUMBER.Text = ""
                    TXTITEMNAME.Text = ""
                    TXTQTY.Text = ""
                    Exit Sub
                End If

            End While

            con.Close()
            OpenCon()
            cmd.CommandText = "Update tbl_itemcart set quantity = '" & Quantity & "' where itemno = '" & TXTITEMNUMBER.Text & "' "
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Quantity has been added in item " + TXTITEMNAME.Text, vbOKOnly + vbInformation, "Adding Item Successfully")
            TXTITEMNUMBER.Text = ""
            TXTITEMNAME.Text = ""
            TXTQTY.Text = ""
            FUNCTION_REFRESH()
            Exit Sub
        End If
        con.Close()

        ''*********************************** INSERTING TO DB - ITEM CART *****************************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "insert into tbl_itemcart (transactionnumber, itemno, itemname, college, cardtag, borrowersname, dateborrowed, quantity) " &
            "values (@tn, @in, @iname, @col, @ct, @bname, @db, @qty)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("tn", TXTTRANSNO.Text)
            .AddWithValue("in", TXTITEMNUMBER.Text)
            .AddWithValue("iname", TXTITEMNAME.Text)
            .AddWithValue("col", FRMAdminMenu.LblUsertype.Text)
            .AddWithValue("ct", TXTSmartCard.Text)
            .AddWithValue("bname", TXTBORROWERSNAME.Text)
            .AddWithValue("db", Date.Now)
            .AddWithValue("qty", TXTQTY.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Item successfully added in the item cart", vbOKOnly + vbInformation, "Cart Updated")
        FUNCTION_REFRESH()
        TXTITEMNUMBER.Text = ""
        TXTITEMNAME.Text = ""
        TXTQTY.Text = ""
    End Sub

    Private Sub BTNBROWSEITEMS_Click(sender As Object, e As EventArgs) Handles BTNBROWSEITEMS.Click
        '*********************************ERROR TRAPPING - SELECT BP FIRST *******************************************
        If TXTSmartCard.Text = "" Or TXTBORROWERSNAME.Text = "" Then
            MsgBox("Please select borrower first", vbOKOnly + vbCritical, "Error Browsing")
            Exit Sub
        End If

        '*********************************ERROR TRAPPING - CARD DOESN'T MATCH *******************************************
        If TXTBORROWERSNAME.Text = "" Then
            MsgBox("This card doesn’t match any records", vbOKOnly + vbCritical, "Error Tapping")
            TXTSmartCard.Text = ""
            Exit Sub
        End If
        PNLBROWSEITEM.Visible = True
        BTNBorrowSave.Enabled = True
    End Sub

    Private Sub DGVITEMCART_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEMCART.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVITEMCART.Rows(e.RowIndex)
            TXTITEMNUMBER.Text = row.Cells(1).Value
            TXTITEMNAME.Text = row.Cells(2).Value
            TXTQTY.Text = row.Cells(3).Value
        End If
        TXTQTY.Enabled = False
    End Sub

    Private Sub BTNREMOVEITEM_Click(sender As Object, e As EventArgs) Handles BTNREMOVEITEM.Click
        con.Close()
        OpenCon()
        cmd.CommandText = "Delete from tbl_itemcart where itemno = '" & TXTITEMNUMBER.Text & "' "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Item successfully removed!", vbOKOnly + vbInformation, "Removing Item Successfully")
        FUNCTION_REFRESH()
        TXTITEMNUMBER.Text = ""
        TXTITEMNAME.Text = ""
        TXTQTY.Text = ""
        TXTQTY.Enabled = True
    End Sub

    Private Sub TXTQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQTY.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVITEM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEM.CellContentClick

    End Sub
End Class