Imports System.IO
Public Class ucReturn
    Dim status As String = "Borrowed"
    Dim imageExtension = ""
    Private Sub ucReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTKEYTAG.Focus()
        'Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        Me.Tbl_guardTableAdapter.Fill(Me.Db_kmsDataSet.tbl_guard)
        'Me.Tbl_keytransactionTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_keytransaction, status)
        'Me.Tbl_guardTableAdapter.FillByDate(Me.Db_kmsDataSet.tbl_guard, Date.Now)
        Me.Tbl_guardTableAdapter.FillByCollegeGuardTrans(Me.Db_kmsDataSet.tbl_guard, FRMAdminMenu.LblUsertype.Text, Date.Now)
        DGVKEYTRANS.Sort(DGVKEYTRANS.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        DGVGUARDTRANS.Sort(DGVGUARDTRANS.Columns(0), System.ComponentModel.ListSortDirection.Descending)

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
        PBprofile.Image = My.Resources.BlankProfile


    End Sub

    Private Sub FUNCTION_REFRESH()
        'Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)
        Me.Tbl_guardTableAdapter.FillByDate(Me.Db_kmsDataSet.tbl_guard, Date.Now)
        Me.Tbl_keytransactionTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_keytransaction, status)
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTKEYTAG.Text = ""
        TXTBORROWERSNAME.Text = ""
        TXTROOMNUMBER.Text = ""
        TXTTRANSNO.Text = ""
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

    Private Sub BTNReturnSave_Click(sender As Object, e As EventArgs) Handles BTNReturnSave.Click

        '********************************** ERROR TRAPPIMG - ALL FIELDS ARE REQUIRED ********************************************************
        If TXTKEYTAG.Text = "" Or TXTROOMNUMBER.Text = "" Or TXTBORROWERSNAME.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            TXTKEYTAG.Focus()
            Exit Sub
        End If

        '********************************** KEY RETURNING ********************************************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "update tbl_keytransaction set transactionstatus = @ts, datetimereturned = @dr, timereturned = @tr where transactionnumber = @tn"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("tn", TXTTRANSNO.Text)
        cmd.Parameters.AddWithValue("ts", "Returned")
        cmd.Parameters.AddWithValue("dr", Date.Now)
        cmd.Parameters.AddWithValue("tr", DateTime.Now)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("The key you borrowed have been returned!", vbOKOnly + vbInformation, "SYSTEM SUCCESS: RETURN KEY")
        con.Close()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()
        TXTKEYTAG.Enabled = True
        TXTKEYTAG.Focus()
        PBprofile.Image = My.Resources.BlankProfile
    End Sub

    Private Sub TXTKEYTAG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKEYTAG.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTKEYTAG_TextChanged(sender As Object, e As EventArgs) Handles TXTKEYTAG.TextChanged
        If TXTKEYTAG.Text.Length = 10 Then
            Timer1.Enabled = False
            TXTKEYTAG.Enabled = False

            OpenCon()
            cmd.CommandText = "Select * from tbl_keytransaction where keytag = @kt "
            With cmd.Parameters
                .Clear()
                .AddWithValue("kt", TXTKEYTAG.Text)
                cmd.ExecuteNonQuery()
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    TXTROOMNUMBER.Text = dr(5)
                    TXTBORROWERSNAME.Text = dr(3)
                    TXTIDTAG.Text = dr(2)
                    TXTTRANSNO.Text = dr(0)
                End While

                con.Close()
                OpenCon()
                cmd.CommandText = "Select * from tbl_borrowersprofile where idtag = @it "
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("it", TXTIDTAG.Text)
                    cmd.ExecuteNonQuery()
                End With
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    If Not IsDBNull(dr("profilepicture")) Then
                        Dim data As Byte() = dr("profilepicture")
                        Dim mstream As New MemoryStream(data)
                        PBprofile.Image = Image.FromStream(mstream)
                        mstream.Close()
                    Else
                        PBprofile.Image = Nothing
                    End If
                End If
            End If
        End If
        con.Close()
    End Sub

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
            TXTKEYTAG.Enabled = True
            TXTKEYTAG.Focus()
            PBprofile.Image = My.Resources.BlankProfile
        End If
    End Sub

    Private Sub BTNReturnDO_Click(sender As Object, e As EventArgs)

        ''************************* UPDATING TRANSACTION STATUS - GUARD *********************'
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "update tbl_guard set transactionstatus=@ts where keytag = @kt"
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("ts", "Returned to Dean's Office")
        'cmd.Parameters.AddWithValue("kt", TXTKEYTAG.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()
        'FUNCTION_CLEAR()
        'FUNCTION_REFRESH()

        ''********************************** DEAN'S OFFICE KEY RETURNING ********************************************
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "update tbl_keytransaction set transactionstatus = @ts where keytag = @kt"
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("ts", "Returned")
        'cmd.Parameters.AddWithValue("kt", TXTKEYTAG.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()


        'MsgBox("The key have been returned!", vbOKOnly + vbInformation, "SYSTEM SUCCESS: RETURN KEY")

        '************************* UPDATING TRANSACTION TB - DATE RETURNED *********************'
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "update tbl_keytransaction set datetimereturned=@dr where keytag = @kt"
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("dr", Date.Now)
        'cmd.Parameters.AddWithValue("kt", TXTKEYTAG.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()
        'FUNCTION_CLEAR()
        'FUNCTION_REFRESH()

        '************************* UPDATING TRANSACTION TB - TIME RETURNED *********************'
        'OpenCon()
        'cmd.Connection = con
        'cmd.CommandText = "update tbl_keytransaction set timereturned=@tr where keytag = @kt"
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("tr", DateTime.Now)
        'cmd.Parameters.AddWithValue("kt", TXTKEYTAG.Text)
        'cmd.ExecuteNonQuery()
        'con.Close()
        'FUNCTION_CLEAR()
        'FUNCTION_REFRESH()


    End Sub

    Private Sub DGVGUARDTRANS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGUARDTRANS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVGUARDTRANS.Rows(e.RowIndex)
            TXTBORROWERSNAME.Text = row.Cells(3).Value
            TXTKEYTAG.Text = row.Cells(4).Value
            TXTROOMNUMBER.Text = row.Cells(5).Value
        End If
        'PNLGUARDTRANS.Visible = False
    End Sub

    Private Sub BTNCANCELTRANS_Click(sender As Object, e As EventArgs) Handles BTNCANCELTRANS.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
            PNLGUARDTRANS.Visible = False
            TXTKEYTAG.Text = ""
            TXTKEYTAG.Enabled = True
            TXTKEYTAG.Focus()

            BTNReturnSave.Enabled = True
            BTNCLEAR.Enabled = True
            PBprofile.Image = My.Resources.BlankProfile
        End If
    End Sub

    Private Sub BTNBROWSEGUARDTRANS_Click(sender As Object, e As EventArgs) Handles BTNBROWSEGUARDTRANS.Click
        PNLGUARDTRANS.Visible = True
        BTNReturnSave.Enabled = False
        BTNCLEAR.Enabled = False
    End Sub

    Private Sub DGVKEYTRANS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKEYTRANS.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVKEYTRANS.Rows(e.RowIndex)
            TXTTRANSNO.Text = row.Cells(0).Value
            TXTBORROWERSNAME.Text = row.Cells(3).Value
            TXTKEYTAG.Text = row.Cells(4).Value
            TXTROOMNUMBER.Text = row.Cells(5).Value
        End If
        TXTKEYTAG.Enabled = False
    End Sub

    Private Sub DGVKEYTRANS_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKEYTRANS.CellValueChanged
        DGVKEYTRANS.Columns(6).DefaultCellStyle.Format = "MMMM dd yyyy"
        DGVKEYTRANS.Columns(7).DefaultCellStyle.Format = "MMMM dd yyyy"
    End Sub

    Private Sub TXTSEARCHROOM_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHROOM.TextChanged
        TblkeytransactionBindingSource.Filter = "roomnumber like '" & TXTSEARCHROOM.Text & "%'"
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblguardBindingSource.Filter = "roomnumber like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub BTNPROCEEDgt_Click(sender As Object, e As EventArgs) Handles BTNPROCEEDgt.Click
        PNLGUARDTRANS.Visible = False
        BTNReturnSave.Enabled = True
        BTNCLEAR.Enabled = True
    End Sub

    Private Sub TXTROOMNUMBER_TextChanged(sender As Object, e As EventArgs) Handles TXTROOMNUMBER.TextChanged
        lblRoomno.Text = TXTROOMNUMBER.Text
    End Sub

    Private Sub TXTBORROWERSNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTBORROWERSNAME.TextChanged
        LBLBname.Text = TXTBORROWERSNAME.Text
    End Sub
End Class
