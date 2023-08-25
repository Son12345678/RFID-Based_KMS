Public Class ucItemReturn
    Dim status As String = "Borrowed"
    Private Sub FUNCTION_CLEAR()
        TXTITEM.Text = ""
        TXTBORROWERSNAME.Text = ""
        TXTQUANTITY.Text = ""
        TXTITEMNAME.Text = ""
    End Sub

    Private Sub ucItemReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Tbl_itemtransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemtransaction)

        '************************************FILTER ***************************************
        Me.Tbl_itemtransactionTableAdapter.FillBytransactionstatus(Me.Db_kmsDataSet.tbl_itemtransaction, status)
        Me.Tbl_itemtransactionTableAdapter.FillBycollege(Me.Db_kmsDataSet.tbl_itemtransaction, FRMAdminMenu.LblUsertype.Text)
        DGVITEMTRANSACTION.Sort(DGVITEMTRANSACTION.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub FUNCTION_REFRESH()
        Me.Tbl_itemtransactionTableAdapter.Fill(Me.Db_kmsDataSet.tbl_itemtransaction)
        Me.Tbl_itemtransactionTableAdapter.FillBytransactionstatus(Me.Db_kmsDataSet.tbl_itemtransaction, status)
    End Sub

    Private Sub BTNBorrowSave_Click(sender As Object, e As EventArgs) Handles BTNBorrowSave.Click
        '*********************************ERROR TRAPPING - ALL FIELDS ARE REQUIRED *******************************************
        If TXTBORROWERSNAME.Text = "" Or TXTITEM.Text = "" Or TXTQUANTITY.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbInformation, "Error Saving")
            Exit Sub
        End If

        '********************************* QUANTITY - ADD *******************************************
        Dim quantity As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select * from tbl_item where itemno =@in"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("in", TXTITEM.Text)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                quantity = dr.GetValue(3)
            End While
        End If
        con.Close()

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "update tbl_item set quantity = @q where itemno = @in"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("q", Val(TXTQUANTITY.Text) + quantity)
        cmd.Parameters.AddWithValue("in", TXTITEM.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        '*************************UPDATE TO DB - STATUS *********************'
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "update tbl_itemtransaction set transactionstatus = @ts, datereturned = @tr, timereturned = @tr where itemno = @in"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("in", TXTITEM.Text)
        'cmd.Parameters.AddWithValue("tn", TXTTRANSNO.Text)
        cmd.Parameters.AddWithValue("ts", "Returned")
        cmd.Parameters.AddWithValue("dr", Date.Now)
        cmd.Parameters.AddWithValue("tr", DateTime.Now)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("The item you borrowed have been returned!", vbOKOnly + vbInformation, "SYSTEM SUCCESS: RETURN KEY")
        FUNCTION_REFRESH()
        FUNCTION_CLEAR()
    End Sub

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
        End If
    End Sub

    Private Sub DGVITEMTRANSACTION_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVITEMTRANSACTION.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVITEMTRANSACTION.Rows(e.RowIndex)
            TXTBORROWERSNAME.Text = row.Cells(4).Value
            TXTITEM.Text = row.Cells(1).Value
            TXTQUANTITY.Text = row.Cells(7).Value
            TXTTRANSNO.Text = row.Cells(0).Value

            TXTTRANSNUMBER.Text = row.Cells(0).Value
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblitemtransactionBindingSource.Filter = "borrowersname like '" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub TXTITEM_TextChanged(sender As Object, e As EventArgs) Handles TXTITEM.TextChanged
        OpenCon()
        cmd.CommandText = "Select * from tbl_item where itemno = @in "
        With cmd.Parameters
            .Clear()
            .AddWithValue("in", TXTITEM.Text)
            cmd.ExecuteNonQuery()
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                TXTITEMNAME.Text = dr(1)
            End While
        End If
    End Sub
End Class
