Public Class ucguardtrans
    Dim status As String = "Borrowed"
    Dim Gstatus As String = "Returned to Guard"
    Private Sub FUNCTION_CLEAR()
        TXTTRANSNO.Text = ""
        TXTCOLLEGE.Text = ""
        TXTIDTAG.Text = ""
        TXTNAME.Text = ""
        TXTKEYTAG.Text = ""
        TXTROOMNO.Text = ""
        TXTDATEBORROWED.Text = ""
    End Sub

    Private Sub BTNRETURNGUARD_Click(sender As Object, e As EventArgs) Handles BTNRETURNGUARD.Click
        '******************************************** ALL FIELDS ARE REQUIRED **************************************
        If TXTTRANSNO.Text = "" Or TXTCOLLEGE.Text = "" Or TXTNAME.Text = "" Or TXTIDTAG.Text = "" Or TXTKEYTAG.Text = "" Or TXTROOMNO.Text = "" Or TXTDATEBORROWED.Text = "" Or TXTDATERETURNEDTOGUARD.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            TXTKEYTAG.Focus()
            Exit Sub
        End If

        '******************************************** INSERTING TO DB **************************************
        con.Close()
        Dim transno As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = ("select max(transactionno) from tbl_guard")
        transno = Convert.ToInt64(cmd.ExecuteScalar())
        con.Close()

        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_guard values (@tn, @col, @it, @fullname, @kt, @rn, @db, @dr, @ts, @tr) "
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("tn", transno + 1)
        cmd.Parameters.AddWithValue("col", TXTCOLLEGE.Text)
        cmd.Parameters.AddWithValue("it", TXTIDTAG.Text)
        cmd.Parameters.AddWithValue("fullname", TXTNAME.Text)
        cmd.Parameters.AddWithValue("kt", TXTKEYTAG.Text)
        cmd.Parameters.AddWithValue("rn", TXTROOMNO.Text)
        cmd.Parameters.AddWithValue("db", Date.Now)
        cmd.Parameters.AddWithValue("dr", Date.Now)
        cmd.Parameters.AddWithValue("ts", "Returned to Guard")
        cmd.Parameters.AddWithValue("tr", DateTime.Now)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("The key have been returned!", vbOKOnly + vbInformation, "SYSTEM SUCCESS: RETURN KEY")
        FUNCTION_CLEAR()
        TXTDATERETURNEDTOGUARD.Text = ""

        '******************************************** UPDATING TO ACTIVITY LOG **************************************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMGUARDMENU.lblGuardAcountName.Text)
        cmd.Parameters.AddWithValue("act", Gstatus)
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BTNBROWSE_Click(sender As Object, e As EventArgs) Handles BTNBROWSE.Click
        PNLBROWSEKEYTRANS.Visible = True
    End Sub

    Private Sub BTNCANCELkeytrans_Click(sender As Object, e As EventArgs) Handles BTNCANCELkeytrans.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            PNLBROWSEKEYTRANS.Visible = False
            FUNCTION_CLEAR()
        End If
    End Sub

    Private Sub ucguardtrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_keytransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_keytransaction)

        '*****************************filtering *****************************************************
        Me.Tbl_keytransactionTableAdapter.FillBystatus(Me.Db_kmsDataSet.tbl_keytransaction, status)
        DGVkeytrans.Sort(DGVkeytrans.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub DGVkeytrans_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVkeytrans.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVkeytrans.Rows(e.RowIndex)
            TXTTRANSNO.Text = row.Cells(0).Value
            TXTCOLLEGE.Text = row.Cells(1).Value
            TXTIDTAG.Text = row.Cells(2).Value
            TXTNAME.Text = row.Cells(3).Value
            TXTKEYTAG.Text = row.Cells(4).Value
            TXTROOMNO.Text = row.Cells(5).Value
            TXTDATEBORROWED.Text = row.Cells(6).Value.ToString
            TXTDATERETURNEDTOGUARD.Text = Date.Now
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblkeytransactionBindingSource.Filter = "fullname like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim i As Integer
        For i = FRMGUARDMENU.pnlguardmain.Controls.Count - 1 To 0
            FRMGUARDMENU.pnlguardmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHomeGuard()
        home.Parent = FRMGUARDMENU.pnlguardmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
        End If
    End Sub

    Private Sub BTNPROCEED_Click(sender As Object, e As EventArgs) Handles BTNPROCEED.Click
        PNLBROWSEKEYTRANS.Visible = False
    End Sub
End Class
