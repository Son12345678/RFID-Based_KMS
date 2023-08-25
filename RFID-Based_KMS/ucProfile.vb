Imports System.IO
Public Class ucProfile
    Dim username, fname, mname, lname, AccountName
    Dim imageExtension = ""
    Dim collegestats As String = "Active"

    Private Sub FUNCTION_REFRESH()
        Me.Tbl_borrowersprofileTableAdapter.Fill(Me.Db_kmsDataSet.tbl_borrowersprofile)
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTFNAME.Enabled = True
        TXTMNAME.Enabled = True
        TXTLNAME.Enabled = True
        CBOBORROWERSTYPE.Enabled = True
        CBOCOLLEGE.Enabled = True
        CBOCOURSEANDSEC.Enabled = True
        TXTCONTACT.Enabled = True
        CBOSTATUS.Enabled = True
        btnBrowsePic.Enabled = True
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        BTNEDIT.Enabled = False
        BTNADD.Enabled = False
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTFNAME.Enabled = False
        TXTMNAME.Enabled = False
        TXTLNAME.Enabled = False
        CBOBORROWERSTYPE.Enabled = False
        CBOCOLLEGE.Enabled = False
        CBOCOURSEANDSEC.Enabled = False
        TXTCONTACT.Enabled = False
        CBOSTATUS.Enabled = False
        btnBrowsePic.Enabled = False
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNEDIT.Enabled = True
        BTNADD.Enabled = True
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTIDTAG.Text = ""
        TXTFNAME.Text = ""
        TXTMNAME.Text = ""
        TXTLNAME.Text = ""
        CBOBORROWERSTYPE.Text = ""
        CBOCOLLEGE.Text = ""
        CBOCOURSEANDSEC.Text = ""
        TXTCONTACT.Text = ""
        CBOSTATUS.Text = ""
    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Dim i As Integer
        For i = FRMAdminMenu.pnlmain.Controls.Count - 1 To 0
            FRMAdminMenu.pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = FRMAdminMenu.pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
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

    Private Sub TXTIDTAG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDTAG.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTIDTAG_TextChanged(sender As Object, e As EventArgs) Handles TXTIDTAG.TextChanged

        If TXTIDTAG.Text.Length = 10 Then
            TXTIDTAG.Enabled = False
            FUNCTION_ENABLED()
            TXTFNAME.Focus()
        End If
    End Sub

    Private Sub ucProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPBLANK.Focus()
        Me.Tbl_borrowersprofileTableAdapter.Fill(Me.Db_kmsDataSet.tbl_borrowersprofile)

        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_college where status = '" & collegestats & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                CBOCOLLEGE.Items.Add(dr.Item("collegename"))
            End While
        End If
        con.Close()
        FUNCTION_REFRESH()

        picProfile.Image = My.Resources.BlankProfile
    End Sub

    Private Sub TIMERMSG_Tick(sender As Object, e As EventArgs) Handles TIMERMSG.Tick
        If TXTPBLANK.Text.Length = 10 Then
            TIMERMSG.Enabled = False
            MsgBox("Please click add button first", vbOKOnly + vbInformation, "Error Tapping")
            TXTPBLANK.Text = ""
            TIMERMSG.Enabled = True
        End If
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        TXTIDTAG.Focus()
        Timer1.Enabled = True
        TXTIDTAG.Enabled = True
        btnBrowsePic.Enabled = True
        'FUNCTION_ENABLED()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        '--------------Profile pic--------------
        Dim mstream As New System.IO.MemoryStream()
        If imageExtension <> "" Then
            Select Case imageExtension
                Case ".jpg"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case ".png"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                Case ".bmp"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp)
                Case ".tiff"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Tiff)
                Case ".gif"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Gif)
                Case ".exif"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Exif)
                Case ".wmf"
                    picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Wmf)
                Case Else
                    MsgBox("Selected picture format not available. The following formats are supported: JPEG, PNG, BMP, TIFF, GIF, EXIF, WMF", vbExclamation, "FORMAT NOT SUPPORTED")
                    mstream.Close()
                    Exit Sub
            End Select
        End If
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()
        '--------------END Profile pic--------------

        '****************************************** ERROR TRAPPING - SMARTCARD IS REQUIRED *****************************************
        'If TXTIDTAG.Text = "" Then
        '    MsgBox("Smart Card Field is required ", vbOKOnly + vbExclamation, "Error Saving")
        '    FUNCTION_CLEAR()
        '    FUNCTION_DISABLED()
        'End If

        '**********************************************ERROR TRAPPING - ALL FIELDS IS REQUIRED ****************************************
        If TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or CBOBORROWERSTYPE.Text = "" Or CBOCOLLEGE.Text = "" Or TXTCONTACT.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            TXTFNAME.Focus()
            FUNCTION_CLEAR()
            FUNCTION_DISABLED()
            Exit Sub
        End If

        '**********************************************ERROR TRAPPING - BORROWER'S TYPE DOESN'T MATCH ****************************************
        If CBOBORROWERSTYPE.Text <> "Faculty" And CBOBORROWERSTYPE.Text <> "Staff" And CBOBORROWERSTYPE.Text <> "Student" Then
            MsgBox("Please select a valid borrower's type", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If



        '**********************************************ERROR TRAPPING - COLLEGE DOESN'T EXIST *******************************************
        If CBOCOLLEGE.Text <> "" Then
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_college where collegename = '" & CBOCOLLEGE.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows = False Then
                MsgBox("Please select a valid College", vbOKOnly + vbCritical, "error saving")
                con.Close()
                CBOCOLLEGE.Text = ""
                CBOCOLLEGE.Focus()
                Exit Sub
            End If
            con.Close()
        End If


        '**********************************************ERROR TRAPPING - COURSE AND SEC DOESN'T MATCH ****************************************
        If CBOCOURSEANDSEC.Text <> "" Then

            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_section where section = '" & CBOCOURSEANDSEC.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows = False Then
                MsgBox("Please select a valid Course and Section", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                CBOCOURSEANDSEC.Text = ""
                CBOCOURSEANDSEC.Focus()
                Exit Sub
            End If
            con.Close()
        End If

        '**********************************************ERROR TRAPPING - STATUS DOESN'T MATCH ****************************************
        If CBOSTATUS.Text <> "Active" And CBOSTATUS.Text <> "Inactive" Then
            MsgBox("Please select a valid Borrower's status", vbOKOnly + vbCritical, "error saving")
            Exit Sub
        End If

        '**********************************************ERROR TRAPPING - ID TAG ALREADY EXIST ****************************************
        If TXTIDTAG.Text <> "" Then
            con.Close()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_borrowersprofile where idtag = '" & TXTIDTAG.Text & "' "
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("ID Tag already exist", vbOKOnly + vbCritical, "error saving")
                con.Close()
                TXTIDTAG.Focus()
                FUNCTION_CLEAR()
                FUNCTION_DISABLED()
                Exit Sub
            End If
            con.Close()
        End If



        '********************************************INSERTING VALUES TO DB ****************************************
        OpenCon()
        cmd.Connection = con

        If imageExtension = "" Then
            cmd.CommandText = "Insert into tbl_borrowersprofile set idtag = @idtag, firstname= @fname," &
                "middlename = @mname, lastname = @lname, borrowerstype = @btype, college = @col, courseandsection = @cs," &
                "contactno = @con, status = @stat "
            With cmd.Parameters
                .Clear()
                .AddWithValue("idtag", TXTIDTAG.Text)
                .AddWithValue("fname", TXTFNAME.Text)
                .AddWithValue("mname", TXTMNAME.Text)
                .AddWithValue("lname", TXTLNAME.Text)
                .AddWithValue("btype", CBOBORROWERSTYPE.Text)
                .AddWithValue("col", CBOCOLLEGE.Text)
                .AddWithValue("cs", CBOCOURSEANDSEC.Text)
                .AddWithValue("con", TXTCONTACT.Text)
                .AddWithValue("stat", CBOSTATUS.Text)
            End With
        Else
            cmd.CommandText = "Insert into tbl_borrowersprofile values (@idtag, @fname, @mname, @lname, @btype, @col, @cs, @con, @stat, @pp) "
            With cmd.Parameters
                .Clear()
                .AddWithValue("idtag", TXTIDTAG.Text)
                .AddWithValue("fname", TXTFNAME.Text)
                .AddWithValue("mname", TXTMNAME.Text)
                .AddWithValue("lname", TXTLNAME.Text)
                .AddWithValue("btype", CBOBORROWERSTYPE.Text)
                .AddWithValue("col", CBOCOLLEGE.Text)
                .AddWithValue("cs", CBOCOURSEANDSEC.Text)
                .AddWithValue("con", TXTCONTACT.Text)
                .AddWithValue("stat", CBOSTATUS.Text)
                .AddWithValue("pp", arrImage)
            End With
        End If

        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Your record has been saved", vbOKOnly + vbInformation, "Saving Record")
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()
        picProfile.Image = My.Resources.BlankProfile
        Timer1.Enabled = False



        '******************************* UPDATING ACT LOG *******************************************
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Add New Borrower's Profile")
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub CBOBORROWERSTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOBORROWERSTYPE.SelectedIndexChanged
        If CBOBORROWERSTYPE.Text = "Student" Then
            CBOCOURSEANDSEC.Enabled = True
        Else
            CBOCOURSEANDSEC.Enabled = False
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        btnBrowsePic.Enabled = True

        If TXTIDTAG.Text = "" Or TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or CBOBORROWERSTYPE.Text = "" Or CBOCOLLEGE.Text = "" Or TXTCONTACT.Text = "" Or CBOSTATUS.Text = "" Then
            MsgBox("Please select a record you want to edit", vbOKOnly + vbCritical, "Error Editing")
            TXTFNAME.Focus()
            Exit Sub
        End If

        If BTNEDIT.Text = "EDIT" Then
            FUNCTION_ENABLED()
            BTNSAVE.Enabled = False
            BTNEDIT.Enabled = True
            TXTIDTAG.Enabled = False
            BTNEDIT.Text = "UPDATE"

        ElseIf BTNEDIT.Text = "UPDATE" Then

            '--------------Profile pic--------------
            Dim mstream As New System.IO.MemoryStream()
            If imageExtension <> "" Then
                Select Case imageExtension
                    Case ".jpg"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case ".png"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                    Case ".bmp"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case ".tiff"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Tiff)
                    Case ".gif"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Gif)
                    Case ".exif"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Exif)
                    Case ".wmf"
                        picProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Wmf)
                    Case Else
                        MsgBox("Selected picture format not available. The following formats are supported: JPEG, PNG, BMP, TIFF, GIF, EXIF, WMF", vbExclamation, "FORMAT NOT SUPPORTED")
                        mstream.Close()
                        Exit Sub
                End Select
            End If
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()
            '--------------END Profile pic-------------

            '**********************************************ERROR TRAPPING - ALL FIELDS IS REQUIRED ****************************************
            If TXTIDTAG.Text = "" Or TXTFNAME.Text = "" Or TXTMNAME.Text = "" Or TXTLNAME.Text = "" Or CBOBORROWERSTYPE.Text = "" Or CBOCOLLEGE.Text = "" Or TXTCONTACT.Text = "" Or CBOSTATUS.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
                TXTFNAME.Focus()
                FUNCTION_CLEAR()
                FUNCTION_DISABLED()
                Exit Sub
            End If

            '********************************************** UPDATING RECORD TO DB ****************************************
            OpenCon()
            cmd.Connection = con

            If imageExtension = "" Then
                cmd.CommandText = "update tbl_borrowersprofile Set idtag = @it, firstname= @fn, middlename = @mn, lastname = @ln, borrowerstype= @bt, college= @col, courseandsection= @cs, contactno= @c, status= @stat where idtag = '" & TXTIDTAG.Text & "'"
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("it", TXTIDTAG.Text)
                    .AddWithValue("fn", TXTFNAME.Text)
                    .AddWithValue("mn", TXTMNAME.Text)
                    .AddWithValue("ln", TXTLNAME.Text)
                    .AddWithValue("bt", CBOBORROWERSTYPE.Text)
                    .AddWithValue("col", CBOCOLLEGE.Text)
                    .AddWithValue("cs", CBOCOURSEANDSEC.Text)
                    .AddWithValue("c", TXTCONTACT.Text)
                    .AddWithValue("stat", CBOSTATUS.Text)

                End With
            Else
                cmd.CommandText = "update tbl_borrowersprofile Set idtag = @it, firstname= @fn, middlename = @mn, lastname = @ln, borrowerstype= @bt, college= @col, courseandsection= @cs, contactno= @c, status= @stat, profilepicture = @pp where idtag = '" & TXTIDTAG.Text & "'"
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("it", TXTIDTAG.Text)
                    .AddWithValue("fn", TXTFNAME.Text)
                    .AddWithValue("mn", TXTMNAME.Text)
                    .AddWithValue("ln", TXTLNAME.Text)
                    .AddWithValue("bt", CBOBORROWERSTYPE.Text)
                    .AddWithValue("col", CBOCOLLEGE.Text)
                    .AddWithValue("cs", CBOCOURSEANDSEC.Text)
                    .AddWithValue("c", TXTCONTACT.Text)
                    .AddWithValue("stat", CBOSTATUS.Text)
                    .AddWithValue("pp", arrImage)

                End With
            End If

            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Your record has been updated", vbOKOnly + vbInformation, "Updating Record")
            FUNCTION_DISABLED()
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"
            picProfile.Image = My.Resources.BlankProfile
        End If


        '********************************************** ACTIVITY LOG ****************************************
        con.Close()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "Insert into tbl_activitylog set datetime=@dt, accountname= @an, activity=@act"

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("dt", DateTime.Now)
        cmd.Parameters.AddWithValue("an", FRMAdminMenu.lblAcountName.Text)
        cmd.Parameters.AddWithValue("act", "Edited Profile")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Dim x = MsgBox("Are you sure you want to cancel?", vbYesNo + vbInformation, "Cancel")
        If x = vbYes Then
            FUNCTION_CLEAR()
            FUNCTION_DISABLED()
            FUNCTION_REFRESH()
            BTNEDIT.Text = "EDIT"
            Timer1.Enabled = False
            picProfile.Image = My.Resources.BlankProfile
        End If
    End Sub

    Private Sub DGVPROFILE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPROFILE.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow
            row = DGVPROFILE.Rows(e.RowIndex)
            TXTIDTAG.Text = row.Cells(0).Value
            TXTFNAME.Text = row.Cells(1).Value
            TXTMNAME.Text = row.Cells(2).Value
            TXTLNAME.Text = row.Cells(3).Value
            CBOBORROWERSTYPE.Text = row.Cells(4).Value
            CBOCOLLEGE.Text = row.Cells(5).Value
            CBOCOURSEANDSEC.Text = row.Cells(6).Value
            TXTCONTACT.Text = row.Cells(7).Value
            CBOSTATUS.Text = row.Cells(8).Value
            FUNCTION_DISABLED()

            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "select * from tbl_borrowersprofile where idtag = '" & row.Cells(0).Value & "'"
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not IsDBNull(dr("profilepicture")) Then
                    Dim data As Byte() = dr("profilepicture")
                    Dim mstream As New MemoryStream(data)
                    picProfile.Image = Image.FromStream(mstream)
                    mstream.Close()
                Else
                    picProfile.Image = Nothing
                End If
            End If
            con.Close()

        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        TblborrowersprofileBindingSource.Filter = "lastname like '%" & TXTSEARCH.Text & "%'"
    End Sub

    Private Sub TXTCONTACT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCONTACT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CBOCOLLEGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCOLLEGE.SelectedIndexChanged
        Dim coursestats As String = "Active"
        OpenCon()
        cmd.CommandText = "Select * from tbl_section where college = @c and status = @stat"
        With cmd.Parameters
            .Clear()
            .AddWithValue("c", CBOCOLLEGE.Text)
            .AddWithValue("stat", coursestats)
        End With

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            CBOCOURSEANDSEC.Items.Clear()
            While dr.Read
                CBOCOURSEANDSEC.Items.Add(dr.Item("section"))
            End While
        End If
        con.Close()
    End Sub


    Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click
        Dim fd As OpenFileDialog = New OpenFileDialog
        Try
            fd.Filter = "Image Files | *.jpg; *.png; *.bmp; *.tiff; *.gif; *.exif; *.wmf"
            If fd.ShowDialog() = DialogResult.OK Then
                picProfile.Image = Image.FromFile(fd.FileName)
                imageExtension = Path.GetExtension(fd.FileName).ToLower
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "AN EXCEPTION HAS OCCURED")
        End Try
    End Sub
End Class
