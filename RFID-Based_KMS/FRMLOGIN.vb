Public Class FRMLOGIN
    Dim admin As String = "System Administrator"
    Dim ccs As String = "College of Computer Studies"
    Dim coa As String = "College of Accountancy"
    Dim cob As String = "College of Business"
    Dim gso As String = "General Services Office"
    Dim guard As String = "Guard"
    Dim status As String = "Active"

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CHKSHOWPASS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSHOWPASS.CheckedChanged
        If CHKSHOWPASS.Checked Then
            TXTPASS.PasswordChar = ""
        Else
            TXTPASS.PasswordChar = "*"
        End If
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        '*************************** ERROR TRAPPING: ALL FIELDS REQUIRED **********************'
        If TXTUN.Text = "" Or TXTPASS.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "SYSTEM ERROR: Login")
            TXTUN.Focus()
            Exit Sub
        End If

        '*********************************************** LOG IN FOR ADMIN *************************************************
        'con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & admin & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then

            Dim fname, mname, lname As String
            
            While dr.Read
                fname = dr(2)
                mname = dr(3)
                lname = dr(4)
                FRMAdminMenu.lblAcountName.Text = fname + " " + mname + " " + lname
                FRMAdminMenu.LblUsertype.Text = dr(6)
            End While
            dr.Close()

            FRMAdminMenu.Show()
            FRMAdminMenu.DEFAULTLOGO.Visible = True
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        End If
        con.Close()

        '*********************************************** LOG IN FOR CCS *************************************************
        'con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & ccs & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            'con.Close()
            Dim fname, mname, lname As String
            'OpenCon()
            'cmd.CommandText = "Select * from tbl_useracc where username = @un "
            'With cmd.Parameters
            '    .Clear()
            '    .AddWithValue("un", TXTUN.Text)
            '    cmd.ExecuteNonQuery()
            'End With
            'dr = cmd.ExecuteReader
            'If dr.HasRows Then
            While dr.Read
                fname = dr(2)
                mname = dr(3)
                lname = dr(4)
                FRMAdminMenu.lblAcountName.Text = fname + " " + mname + " " + lname
                FRMAdminMenu.LblUsertype.Text = dr(6)
            End While
            dr.Close()
            'End If
            'con.Close()

            FRMAdminMenu.Show()
            FRMAdminMenu.CCSLOGO.Visible = True
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        End If
        con.Close()


        '*********************************************** LOG IN FOR COA *************************************************
        'con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & coa & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            'con.Close()
            Dim fname, mname, lname As String
            'OpenCon()
            'cmd.CommandText = "Select * from tbl_useracc where username = @un "
            'With cmd.Parameters
            '    .Clear()
            '    .AddWithValue("un", TXTUN.Text)
            '    cmd.ExecuteNonQuery()
            'End With
            'dr = cmd.ExecuteReader
            'If dr.HasRows Then
            While dr.Read
                fname = dr(2)
                mname = dr(3)
                lname = dr(4)
                FRMAdminMenu.lblAcountName.Text = fname + " " + mname + " " + lname
                FRMAdminMenu.LblUsertype.Text = dr(6)
            End While
            dr.Close()
            'End If
            'con.Close()

            FRMAdminMenu.Show()
            FRMAdminMenu.COALOGO.Visible = True
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        End If
        con.Close()


        '*********************************************** LOG IN FOR COB *************************************************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & cob & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            Dim fname, mname, lname As String

            While dr.Read
                fname = dr(2).ToString
                mname = dr(3).ToString
                lname = dr(4).ToString
                FRMAdminMenu.lblAcountName.Text = fname + " " + mname + " " + lname
                FRMAdminMenu.LblUsertype.Text = dr(6)
            End While

            FRMAdminMenu.Show()
            FRMAdminMenu.COBLOGO.Visible = True
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        End If
        con.Close()

        '*********************************************** LOG IN FOR GSO *************************************************
        'con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & gso & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            'FRMAdminMenu.LblUsertype.Text = gso

            'con.Close()
            Dim fname, mname, lname As String
            'OpenCon()
            'cmd.CommandText = "Select * from tbl_useracc where username = @un "
            'With cmd.Parameters
            '    .Clear()
            '    .AddWithValue("un", TXTUN.Text)
            '    cmd.ExecuteNonQuery()
            'End With
            'dr = cmd.ExecuteReader
            'If dr.HasRows Then
            While dr.Read
                fname = dr(2)
                mname = dr(3)
                lname = dr(4)
                FRMAdminMenu.lblAcountName.Text = fname + " " + mname + " " + lname
                FRMAdminMenu.LblUsertype.Text = dr(6)
            End While
            dr.Close()
            'End If
            'con.Close()

            FRMAdminMenu.Show()
            FRMAdminMenu.DEFAULTLOGO.Visible = True
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        End If
        con.Close()

        '*********************************************** LOG IN FOR GUARD *************************************************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Select * from tbl_useracc where username = '" & TXTUN.Text & "' and pass = '" & TXTPASS.Text & "' and usertype = '" & guard & "'  and status = '" & status & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then

            Dim fname, mname, lname As String
            While dr.Read
                fname = dr(2)
                mname = dr(3)
                lname = dr(4)
                FRMGUARDMENU.lblGuardAcountName.Text = fname + " " + mname + " " + lname
                FRMGUARDMENU.lblutype.Text = dr(6)
            End While
            dr.Close()

            FRMGUARDMENU.Show()
            Me.Close()
            con.Close()

            '*********************************************** ACTIVITY LOG *************************************************
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an ,activity=@act"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("dt", DateTime.Now)
            cmd.Parameters.AddWithValue("an", FRMGUARDMENU.lblGuardAcountName.Text)
            cmd.Parameters.AddWithValue("act", "Log-in")
            cmd.ExecuteNonQuery()

            con.Close()
            Exit Sub
        Else
            MsgBox("Sorry wrong Username and Password", vbOKOnly + vbInformation, "SYSTEM ERROR: Error Login")
            TXTUN.Focus()
            TXTUN.Text = ""
            TXTPASS.Text = ""
            CHKSHOWPASS.Checked = False
            con.Close()
        End If
        con.Close()
        Exit Sub
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Me.Close()
    End Sub
End Class
