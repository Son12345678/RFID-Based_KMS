Imports System.IO
Public Class ucBorrow
    Dim KEYSTAT As String = "Inactive"
    Dim KEYSTATACTIVE As String = "Active"
    Private Sub ucBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Tbl_borrowersprofileTableAdapter.Fill(Me.Db_kmsDataSet.tbl_borrowersprofile)
        'Me.Tbl_keyTableAdapter.FillBySTATUS(Me.Db_kmsDataSet.tbl_key, "Active")
        Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        TXTKEYTAG.Enabled = True
        TXTKEYTAG.Focus()
        PBprofilepic.Image = My.Resources.BlankProfile
        '**************************** FILTER BY STATUS AND ORDER BY DESCENDING *****************************************
        'Me.Tbl_keytransactionTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_keytransaction, status)
        DGVKEYTRANS.Sort(DGVKEYTRANS.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        '***************************** FILTER BY KEY OWNERSHIP- KEY TABLE *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_keyTableAdapter.Fill(Me.Db_kmsDataSet.tbl_key)
        End If

        '***************************** FILTER BY COLLEGE *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        End If

    End Sub

    Private Sub FUNCTION_REFRESH()
        Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        'Me.Tbl_keytransactionTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_keytransaction, status)

        '***************************** REFRESH - KEY TABLE *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_keyTableAdapter.FillBykeyownership(Me.Db_kmsDataSet.tbl_key, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_keyTableAdapter.Fill(Me.Db_kmsDataSet.tbl_key)
        End If

        '***************************** REFRESH - KEY TRANSACTION TABLE *****************************************
        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Computer Studies")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Accountancy")
        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "College of Business")
        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            Me.Tbl_keytransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_keytransaction, "General Services Office")
        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        End If
    End Sub

    Private Sub FUNCTION_ENABLED()
        BTNBROWSECARD.Enabled = True
        BTNBROWSEKEY.Enabled = True
    End Sub
    Private Sub FUNCTION_CLEAR()
        TXTKEYTAG.Text = ""
        TXTBORROWERSNAME.Text = ""
        TXTROOMNUMBER.Text = ""
        TXTSmartCard.Text = ""
        LblBtype.Text = ""
        TXTDISPLAYBNAME.Text = ""
        TXTDISPLAYKEYTAG.Text = ""
        TXTDISPLAYroomno.Text = ""
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
            Timer2.Enabled = True
            Timer1.Enabled = False
            TXTKEYTAG.Enabled = False

            OpenCon()
            cmd.CommandText = "Select * from tbl_key where keytag = @kt"
            With cmd.Parameters
                .Clear()
                .AddWithValue("kt", TXTKEYTAG.Text)
                cmd.ExecuteNonQuery()
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    TXTROOMNUMBER.Text = dr(1)
                End While
                TXTSmartCard.Enabled = True
                TXTSmartCard.Focus()
            End If
            con.Close()
            BTNBROWSEKEY.Enabled = False
        Else
            Timer2.Enabled = False
            Timer1.Enabled = True
            TXTKEYTAG.Focus()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SmartFar.Visible = True Then
            SmartFar.Visible = False
            SmartClose.Visible = True
        Else
            SmartFar.Visible = True
            SmartClose.Visible = False
        End If
    End Sub

    Private Sub TXTSmartCard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSmartCard.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTSmartCard_TextChanged(sender As Object, e As EventArgs) Handles TXTSmartCard.TextChanged
        Dim fname, lname
        If TXTSmartCard.Text.Length = 10 Then
            Timer2.Enabled = True
            Timer1.Enabled = False
            TXTSmartCard.Enabled = False

            OpenCon()
            cmd.CommandText = "Select * from tbl_borrowersprofile where idtag = @it "
            With cmd.Parameters
                .Clear()
                .AddWithValue("it", TXTSmartCard.Text)
                cmd.ExecuteNonQuery()
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                fname = dr(1)
                lname = dr(3)
                TXTBORROWERSNAME.Text = fname + " " + " " + lname
                LblBtype.Text = dr(4)

                If Not IsDBNull(dr("profilepicture")) Then
                    Dim data As Byte() = dr("profilepicture")
                    Dim mstream As New MemoryStream(data)
                    PBprofilepic.Image = Image.FromStream(mstream)
                    mstream.Close()
                Else
                    PBprofilepic.Image = Nothing
                End If
            End If
            con.Close()
            BTNBROWSECARD.Enabled = False
        Else
            Timer1.Enabled = True
            Timer2.Enabled = False
            TXTSmartCard.Focus()
        End If

    End Sub

    Private Sub BTNBROWSECARD_Click(sender As Object, e As EventArgs) Handles BTNBROWSECARD.Click

        '********************************** ERROR TRAPPING - INPUT ROOM INFO ******************************
        If TXTKEYTAG.Text = "" And TXTROOMNUMBER.Text = "" Then
            MsgBox("Please input Room Information First", vbOKOnly + vbInformation, "Error Browsing Borrower")
            TXTKEYTAG.Focus()
        Else
            TXTSmartCard.Focus()
            PNLPROFILES.Visible = True
            Me.Tbl_borrowersprofileTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_borrowersprofile, "Active")
        End If
    End Sub

    Private Sub BTNPROCEED_Click(sender As Object, e As EventArgs) Handles BTNPROCEED.Click  
            PNLBROWSEKEY.Visible = False
            TXTSmartCard.Focus()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCELKEY.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            TXTKEYTAG.Text = ""
            TXTROOMNUMBER.Text = ""
            TXTKEYTAG.Enabled = True
            TXTKEYTAG.Focus()
            PNLBROWSEKEY.Visible = False
            BTNBROWSEKEY.Enabled = True
        End If
        'BTNBROWSEKEY
    End Sub

    Private Sub BNTPROCEED2_Click(sender As Object, e As EventArgs)
        PNLBROWSEKEY.Visible = False
    End Sub

    Private Sub BTNCANCEL2_Click(sender As Object, e As EventArgs)
        'PNLBROWSECARD.Visible = False
        FUNCTION_CLEAR()
    End Sub

    Private Sub BTNBorrowSave_Click(sender As Object, e As EventArgs) Handles BTNBorrowSave.Click
        '********************************** ERROR TRAPPIMG - ALL FIELDS ARE REQUIRED ********************************************************
        If TXTKEYTAG.Text = "" Or TXTROOMNUMBER.Text = "" Or TXTSmartCard.Text = "" Or TXTBORROWERSNAME.Text = "" Then
            MsgBox("Please select a borrower and room key!", vbOKOnly + vbExclamation, "Error Saving")
            TXTKEYTAG.Focus()
            Exit Sub
        End If

     
        '********************************** ERROR TRAPPIMG - ROOM IS ALREADY BORROWED ********************************************************
        con.Close()
        Dim stat As String = "Borrowed"
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select * from tbl_keytransaction where roomnumber = '" & TXTROOMNUMBER.Text & "' and transactionstatus = '" & stat & "' "
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("Room is already borrowed", vbOKOnly + vbExclamation, "Error Borrowing")
            FUNCTION_CLEAR()
            BTNBROWSECARD.Enabled = True
            BTNBROWSEKEY.Enabled = True
            TXTKEYTAG.Enabled = True
            TXTKEYTAG.Focus()
            con.Close()
            PBprofilepic.Image = My.Resources.BlankProfile
            Exit Sub

        End If
        con.Close()

        '********************************** ERROR TRAPPIMG - INFO OF ROOM AND BORROWERS ********************************************************
        'If TXTKEYTAG.Text = "" Or TXTROOMNUMBER.Text = "" Or TXTSmartCard.Text = "" Or TXTBORROWERSNAME.Text = "" Then
        '    MsgBox("Please input Key Information and Borrowers Information first", vbOKOnly + vbInformation, "Error Browsing Borrower")
        '    TXTKEYTAG.Focus()
        '    Exit Sub
        'End If

        '********************************** ERROR TRAPPIMG - ROOM KEY IS INACTIVE ********************************************************
        'con.Close()
        'Dim keystatus As String = "Inactive"
        'con.Close()
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "select * from tbl_key where roomnumber = '" & TXTROOMNUMBER.Text & "' and status = '" & keystatus & "' "
        'dr = cmd.ExecuteReader()

        'If dr.HasRows Then
        '    MsgBox("Room Key is Inactive", vbOKOnly + vbExclamation, "Error Borrowing")
        '    FUNCTION_CLEAR()
        '    BTNBROWSECARD.Enabled = True
        '    BTNBROWSEKEY.Enabled = True
        '    PBprofilepic.Image = My.Resources.BlankProfile
        '    TXTKEYTAG.Enabled = True
        '    TXTKEYTAG.Focus()
        '    con.Close()
        '    Exit Sub
        '    con.Close()
        'End If


        ''********************************** ERROR TRAPPIMG - BORROWER IS INACTIVE ********************************************************
        'con.Close()
        'Dim profilestatus As String = "Inactive"
        'con.Close()
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "select * from tbl_borrowersprofile where idtag = '" & TXTSmartCard.Text & "' and status = '" & profilestatus & "' "
        'dr = cmd.ExecuteReader()

        'If dr.HasRows Then
        '    MsgBox("This borrower is Inactive", vbOKOnly + vbExclamation, "Error Borrowing")
        '    FUNCTION_CLEAR()
        '    BTNBROWSECARD.Enabled = True
        '    BTNBROWSEKEY.Enabled = True
        '    PBprofilepic.Image = My.Resources.BlankProfile
        '    TXTKEYTAG.Enabled = True
        '    TXTKEYTAG.Focus()
        '    con.Close()
        '    Exit Sub
        '    con.Close()
        'End If
        'con.Close()

        '************************************INSERTING TO DB *****************************************
        con.Close()
        Dim transno As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("select max(transactionnumber) from tbl_keytransaction")
        transno = Convert.ToInt64(cmd.ExecuteScalar())
        con.Close()

        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "insert into tbl_keytransaction SET college = @col , idtag = @it , fullname = @n, keytag = @kt, roomnumber=@rn, datetimeborrowed=@db, transactionstatus = @ts, transactionnumber = @tn, timeborrowed = @tt"
        With cmd.Parameters
            .Clear()
            .AddWithValue("col", FRMAdminMenu.LblUsertype.Text)
            .AddWithValue("it", TXTSmartCard.Text)
            .AddWithValue("n", TXTBORROWERSNAME.Text)
            .AddWithValue("kt", TXTKEYTAG.Text)
            .AddWithValue("rn", TXTROOMNUMBER.Text)
            .AddWithValue("db", Date.Now)
            .AddWithValue("ts", "Borrowed")
            .AddWithValue("tn", transno + 1)
            .AddWithValue("tt", DateTime.Now)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Key successfully borrowed!", vbOKOnly + vbInformation, "SYSTEM SUCCESS: BORROW KEY")
        FUNCTION_REFRESH()
        FUNCTION_CLEAR()
        FUNCTION_ENABLED()
        TXTKEYTAG.Enabled = True
        TXTKEYTAG.Focus()
        PBprofilepic.Image = My.Resources.BlankProfile
    End Sub

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
            TXTKEYTAG.Enabled = True
            TXTKEYTAG.Focus()
            BTNBROWSECARD.Enabled = True
            BTNBROWSEKEY.Enabled = True
            PBprofilepic.Image = My.Resources.BlankProfile
        End If
    End Sub

    Private Sub BTNBROWSEKEY_Click(sender As Object, e As EventArgs) Handles BTNBROWSEKEY.Click
        PNLBROWSEKEY.Visible = True
        Me.Tbl_keyTableAdapter.FillBySTATUS(Me.Db_kmsDataSet.tbl_key, "Active", FRMAdminMenu.LblUsertype.Text)
    End Sub

    Private Sub DGVKBKEY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKBKEY.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVKBKEY.Rows(e.RowIndex)
            TXTKEYTAG.Text = row.Cells(0).Value
            TXTROOMNUMBER.Text = row.Cells(1).Value

            TXTDISPLAYKEYTAG.Text = row.Cells(0).Value
            TXTDISPLAYroomno.Text = row.Cells(1).Value
        End If
    End Sub

    Private Sub DGVKBPROFILES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKBPROFILES.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVKBPROFILES.Rows(e.RowIndex)
            TXTSmartCard.Text = row.Cells(0).Value
            TXTBORROWERSNAME.Text = row.Cells(1).Value + " " + " " + row.Cells(3).Value

            TXTDISPLAYBNAME.Text = row.Cells(1).Value + " " + " " + row.Cells(3).Value
        End If
    End Sub

    Private Sub BTNCANCELPROFILE_Click(sender As Object, e As EventArgs) Handles BTNCANCELPROFILE.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            PNLPROFILES.Visible = False
            LblBtype.Text = ""
            TXTBORROWERSNAME.Text = ""
            TXTSmartCard.Text = ""
            TXTSmartCard.Enabled = True
            TXTSmartCard.Focus()
            BTNBROWSECARD.Enabled = True
            PBprofilepic.Image = My.Resources.BlankProfile
        End If
    End Sub

    Private Sub BTNPROCEEDPROFILES_Click(sender As Object, e As EventArgs) Handles BTNPROCEEDPROFILES.Click
        PNLPROFILES.Visible = False
    End Sub

    Private Sub DGVKEYTRANS_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKEYTRANS.CellValueChanged
        DGVKEYTRANS.Columns(6).DefaultCellStyle.Format = "MMMM dd yyyy"
        DGVKEYTRANS.Columns(7).DefaultCellStyle.Format = "MMMM dd yyyy"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHKEY.TextChanged
        TblkeyBindingSource.Filter = "roomnumber like '" & TXTSEARCHKEY.Text & "%'"
    End Sub

    Private Sub TXTROOMNUMBER_TextChanged(sender As Object, e As EventArgs) Handles TXTROOMNUMBER.TextChanged
        lblRoomno.Text = TXTROOMNUMBER.Text
    End Sub

    Private Sub TXTBORROWERSNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTBORROWERSNAME.TextChanged
        lblBname.Text = TXTBORROWERSNAME.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblborrowersprofileBindingSource.Filter = "lastname like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    
End Class
