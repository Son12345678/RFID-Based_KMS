Public Class FRMSPLASHSCREEN

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblpb.Width = lblpb.Width + 1
        If lblpb.Width = 403 Then
            Timer1.Stop()
            Me.Hide()
            FRMLOGIN.Show()
        End If
        If lblpb.Width = 100 Then
            lblstatus.Text = "LOADING DATABASE ..."
        ElseIf lblpb.Width = 150 Then
            lblstatus.Text = "LOADING PROFILES ..."
        ElseIf lblpb.Width = 200 Then
            lblstatus.Text = "LOADING FILES ..."
        ElseIf lblpb.Width = 250 Then
            lblstatus.Text = "LOADING FORMS ..."
        ElseIf lblpb.Width = 300 Then
            lblstatus.Text = "LOADING ACCOUNTS ..."
        ElseIf lblpb.Width = 350 Then
            lblstatus.Text = "ALMOST COMPLETE ..."
        ElseIf lblpb.Width = 403 Then
            lblstatus.Text = "COMPLETE!"
        End If

    End Sub
End Class