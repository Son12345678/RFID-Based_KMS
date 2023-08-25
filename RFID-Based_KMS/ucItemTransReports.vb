Public Class ucItemTransReports

    Private Sub ucItemTransReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RVItemTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVItemTransaction.RefreshReport()

        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.tbl_itemtransactionTableAdapter.Fill(Me.db_kmsDataSet.tbl_itemtransaction)
        Else
            Me.tbl_itemtransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_itemtransaction, FRMAdminMenu.LblUsertype.Text)
        End If
    End Sub
    'Private Sub FUNCTION_REFRESH()
    '    Me.tbl_itemtransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_itemtransaction, FRMAdminMenu.LblUsertype.Text)
    '    Me.RVItemTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    Me.RVItemTransaction.RefreshReport()
    'End Sub
    Private Sub CBOTRANSACTIONSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOSTAT.SelectedIndexChanged
        Me.tbl_itemtransactionTableAdapter.FillBytransactionstatus(Me.db_kmsDataSet.tbl_itemtransaction, CBOSTAT.Text)
        Me.RVItemTransaction.RefreshReport()
    End Sub

    Private Sub DTPBORROWEDFROM_ValueChanged(sender As Object, e As EventArgs) Handles DTPBORROWEDFROM.ValueChanged
        Me.tbl_itemtransactionTableAdapter.FillBydateborrowed(Me.db_kmsDataSet.tbl_itemtransaction, DTPBORROWEDFROM.Value.ToShortDateString, DTPBORROWEDTO.Value.ToShortDateString)
        Me.RVItemTransaction.RefreshReport()
    End Sub

    Private Sub DTPBORROWEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPBORROWEDTO.ValueChanged
        Me.tbl_itemtransactionTableAdapter.FillBydateborrowed(Me.db_kmsDataSet.tbl_itemtransaction, DTPBORROWEDFROM.Value.ToShortDateString, DTPBORROWEDTO.Value.ToShortDateString)
        Me.RVItemTransaction.RefreshReport()
    End Sub

    Private Sub DTPRETURNEDFROM_ValueChanged(sender As Object, e As EventArgs) Handles DTPRETURNEDFROM.ValueChanged
        Me.tbl_itemtransactionTableAdapter.FillBydatereturned(Me.db_kmsDataSet.tbl_itemtransaction, DTPRETURNEDFROM.Value.ToShortDateString, DTPRETURNEDTO.Value.ToShortDateString)
        Me.RVItemTransaction.RefreshReport()
    End Sub

    Private Sub DTPRETURNEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPRETURNEDTO.ValueChanged
        Me.tbl_itemtransactionTableAdapter.FillBydatereturned(Me.db_kmsDataSet.tbl_itemtransaction, DTPRETURNEDFROM.Value.ToShortDateString, DTPRETURNEDTO.Value.ToShortDateString)
        Me.RVItemTransaction.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click
        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.tbl_itemtransactionTableAdapter.Fill(Me.db_kmsDataSet.tbl_itemtransaction)
            CBOSTAT.Text = ""
            Me.RVItemTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVItemTransaction.RefreshReport()
        Else
            Me.tbl_itemtransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_itemtransaction, FRMAdminMenu.LblUsertype.Text)
            CBOSTAT.Text = ""
            Me.RVItemTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVItemTransaction.RefreshReport()
        End If
    End Sub
End Class
