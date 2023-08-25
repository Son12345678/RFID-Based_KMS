Public Class FRMTRANSCLOSE
    Dim status As String = "Active"
    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where pass = '" & TXTPASS.Text & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            FRMTRANSACTION.Close()
            Me.Close()
            TXTPASS.Text = ""
        Else
            MsgBox("Wrong password, please try again", vbOKOnly + vbInformation, "Error Exit")
            TXTPASS.Text = ""
            TXTPASS.Focus()
        End If
        con.Close()
    End Sub

    Private Sub CHKSHOWPASS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSHOWPASS.CheckedChanged
        If CHKSHOWPASS.Checked Then
            TXTPASS.PasswordChar = ""
        Else
            TXTPASS.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        TXTPASS.Text = ""
    End Sub
End Class