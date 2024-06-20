Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UC_AddRoom1.Visible = False
        btnAddRoom.PerformClick()
        UC_NewRegistration1.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        MovingPanel.Left = btnReg.Left + 18
        UC_NewRegistration1.Visible = True
        UC_NewRegistration1.BringToFront()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        MovingPanel.Left = btnCheckout.Left + 18
        UC_CheckOut1.Visible = True
        UC_CheckOut1.BringToFront()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        MovingPanel.Left = btnDetails.Left + 18
        UC_StudentDetails_1.Visible = True
        UC_StudentDetails_1.BringToFront()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        MovingPanel.Left = btnFeedback.Left + 18
        UC_feedback1.Visible = True
        UC_feedback1.BringToFront()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        MovingPanel.Left = btnAddRoom.Left + 18
        UC_AddRoom1.Visible = True
        UC_AddRoom1.BringToFront()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class