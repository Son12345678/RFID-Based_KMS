Public Class ucSettings

    Private Sub ucSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blank As New ucSettingsBlank()
        blank.Parent = PNLSettings
        blank.Show()
        blank.Dock = DockStyle.Fill

        If FRMAdminMenu.LblUsertype.Text = "College of Computer Studies" Then
            BTNCollege.Enabled = False
            BTNCourse.Enabled = True
            BTNRoom.Enabled = True
            BTNRoomCategory.Enabled = True
            BTNItems.Enabled = True
            btnRoomKey.Enabled = True
            BTNSection.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Accountancy" Then
            BTNCollege.Enabled = False
            BTNCourse.Enabled = True
            BTNRoom.Enabled = True
            BTNRoomCategory.Enabled = True
            BTNItems.Enabled = True
            btnRoomKey.Enabled = True
            BTNSection.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "College of Business" Then
            BTNCollege.Enabled = False
            BTNCourse.Enabled = True
            BTNRoom.Enabled = True
            BTNRoomCategory.Enabled = True
            BTNItems.Enabled = True
            btnRoomKey.Enabled = True
            BTNSection.Enabled = True

        ElseIf FRMAdminMenu.LblUsertype.Text = "General Services Office" Then
            BTNCollege.Enabled = False
            BTNCourse.Enabled = False
            BTNRoom.Enabled = True
            BTNRoomCategory.Enabled = True
            BTNItems.Enabled = True
            btnRoomKey.Enabled = True
            BTNSection.Enabled = False
            BTNItems.Enabled = False

        ElseIf FRMAdminMenu.LblUsertype.Text = "System Administrator" Then
            BTNCollege.Enabled = True
            BTNCourse.Enabled = True
            BTNRoom.Enabled = True
            BTNRoomCategory.Enabled = True
            BTNItems.Enabled = True
            btnRoomKey.Enabled = True
            BTNSection.Enabled = True
        End If
    End Sub

    Private Sub BTNCollege_Click(sender As Object, e As EventArgs) Handles BTNCollege.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim college As New ucCollegeSettings()
        college.Parent = PNLSettings
        college.Show()
        college.Dock = DockStyle.Fill
    End Sub

    Private Sub PNLSettings_Paint(sender As Object, e As PaintEventArgs) Handles PNLSettings.Paint

    End Sub


    Private Sub BTNCourse_Click(sender As Object, e As EventArgs) Handles BTNCourse.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim course As New ucCourseSettings()
        course.Parent = PNLSettings
        course.Show()
        course.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNRoomCategory_Click(sender As Object, e As EventArgs) Handles BTNRoomCategory.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim roomcategory As New ucRoomCatSettings()
        roomcategory.Parent = PNLSettings
        roomcategory.Show()
        roomcategory.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNRoom_Click(sender As Object, e As EventArgs) Handles BTNRoom.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim room As New ucRoomSettings()
        room.Parent = PNLSettings
        room.Show()
        room.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNSection_Click(sender As Object, e As EventArgs) Handles BTNSection.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim section As New ucSectionSettings()
        section.Parent = PNLSettings
        section.Show()
        section.Dock = DockStyle.Fill
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

    Private Sub BTNItems_Click(sender As Object, e As EventArgs) Handles BTNItems.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim items As New ucItemSettings()
        items.Parent = PNLSettings
        items.Show()
        items.Dock = DockStyle.Fill
    End Sub

    Private Sub btnRoomKey_Click(sender As Object, e As EventArgs) Handles btnRoomKey.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim roomkey As New ucRoomKey()
        roomkey.Parent = PNLSettings
        roomkey.Show()
        roomkey.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNItemsQT_Click(sender As Object, e As EventArgs) Handles BTNItemsQT.Click
        Dim i As Integer
        For i = PNLSettings.Controls.Count - 1 To 0
            PNLSettings.Controls.RemoveAt(i)
        Next

        Dim itemsQT As New ucItemQuantitySettings()
        itemsQT.Parent = PNLSettings
        itemsQT.Show()
        itemsQT.Dock = DockStyle.Fill
    End Sub
End Class
