Public Class ucTransactionReports

    Private Sub ucTransactionReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.tbl_keytransactionTableAdapter.Fill(Me.db_kmsDataSet.tbl_keytransaction)
        Else
            Me.tbl_keytransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_keytransaction, FRMAdminMenu.LblUsertype.Text)
        End If
        Me.RVKeyTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    'Private Sub FUNCTION_REFRESH()
    '    Me.tbl_keytransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_keytransaction, FRMAdminMenu.LblUsertype.Text)
    '    Me.RVKeyTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    Me.RVKeyTransaction.RefreshReport()
    'End Sub

    Private Sub CBOTRANSACTIONSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOTRANSACTIONSTATUS.SelectedIndexChanged
        Me.tbl_keytransactionTableAdapter.FillBystatus(Me.db_kmsDataSet.tbl_keytransaction, CBOTRANSACTIONSTATUS.Text)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    Private Sub DTPBORROWEDFROM_ValueChanged(sender As Object, e As EventArgs) Handles DTPBORROWEDFROM.ValueChanged
        Me.tbl_keytransactionTableAdapter.FillBydatetimeborrowed(Me.db_kmsDataSet.tbl_keytransaction, DTPBORROWEDFROM.Value.ToShortDateString, DTPBORROWEDTO.Value.ToShortDateString)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    Private Sub DTPBORROWEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPBORROWEDTO.ValueChanged
        Me.tbl_keytransactionTableAdapter.FillBydatetimeborrowed(Me.db_kmsDataSet.tbl_keytransaction, DTPBORROWEDFROM.Value.ToShortDateString, DTPBORROWEDTO.Value.ToShortDateString)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    Private Sub DTPRETURNEDFROM_ValueChanged(sender As Object, e As EventArgs) Handles DTPRETURNEDFROM.ValueChanged
        Me.tbl_keytransactionTableAdapter.FillBydatetimereturned(Me.db_kmsDataSet.tbl_keytransaction, DTPRETURNEDFROM.Value.ToShortDateString, DTPRETURNEDTO.Value.ToShortDateString)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    Private Sub DTPRETURNEDTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPRETURNEDTO.ValueChanged
        Me.tbl_keytransactionTableAdapter.FillBydatetimereturned(Me.db_kmsDataSet.tbl_keytransaction, DTPRETURNEDFROM.Value.ToShortDateString, DTPRETURNEDTO.Value.ToShortDateString)
        Me.RVKeyTransaction.RefreshReport()
    End Sub

    Private Sub BTNCLEARFILTER_Click(sender As Object, e As EventArgs) Handles BTNCLEARFILTER.Click
        If FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            Me.tbl_keytransactionTableAdapter.Fill(Me.db_kmsDataSet.tbl_keytransaction)
            CBOTRANSACTIONSTATUS.Text = ""
            Me.RVKeyTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVKeyTransaction.RefreshReport()
        Else
            Me.tbl_keytransactionTableAdapter.FillBycollegereports(Me.db_kmsDataSet.tbl_keytransaction, FRMAdminMenu.LblUsertype.Text)
            CBOTRANSACTIONSTATUS.Text = ""
            Me.RVKeyTransaction.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.RVKeyTransaction.RefreshReport()
        End If

    End Sub
End Class
