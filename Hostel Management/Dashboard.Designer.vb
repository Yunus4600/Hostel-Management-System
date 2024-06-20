<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        MovingPanel = New Panel()
        btnFeedback = New Guna.UI2.WinForms.Guna2Button()
        btnDetails = New Guna.UI2.WinForms.Guna2Button()
        btnReg = New Guna.UI2.WinForms.Guna2Button()
        btnCheckout = New Guna.UI2.WinForms.Guna2Button()
        btnAddRoom = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        UC_StudentDetails_1 = New UC_StudentDetails_()
        UC_CheckOut1 = New UC_CheckOut()
        UC_NewRegistration1 = New UC_NewRegistration()
        UC_AddRoom1 = New UC_AddRoom()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(components)
        btnLogout = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(components)
        UC_feedback1 = New UC_feedback()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlueViolet
        Panel1.Controls.Add(MovingPanel)
        Panel1.Controls.Add(btnFeedback)
        Panel1.Controls.Add(btnDetails)
        Panel1.Controls.Add(btnReg)
        Panel1.Controls.Add(btnCheckout)
        Panel1.Controls.Add(btnAddRoom)
        Panel1.Location = New Point(12, 8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1285, 123)
        Panel1.TabIndex = 0
        ' 
        ' MovingPanel
        ' 
        MovingPanel.BackColor = Color.White
        MovingPanel.Location = New Point(28, 102)
        MovingPanel.Name = "MovingPanel"
        MovingPanel.Size = New Size(199, 5)
        MovingPanel.TabIndex = 0
        ' 
        ' btnFeedback
        ' 
        btnFeedback.BorderRadius = 26
        btnFeedback.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnFeedback.CheckedState.FillColor = Color.White
        btnFeedback.CheckedState.ForeColor = Color.BlueViolet
        btnFeedback.CustomizableEdges = CustomizableEdges1
        btnFeedback.DisabledState.BorderColor = Color.DarkGray
        btnFeedback.DisabledState.CustomBorderColor = Color.DarkGray
        btnFeedback.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnFeedback.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnFeedback.FillColor = Color.BlueViolet
        btnFeedback.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFeedback.ForeColor = Color.White
        btnFeedback.Image = CType(resources.GetObject("btnFeedback.Image"), Image)
        btnFeedback.ImageSize = New Size(30, 30)
        btnFeedback.Location = New Point(1035, 11)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnFeedback.Size = New Size(236, 85)
        btnFeedback.TabIndex = 4
        btnFeedback.Text = "View Feedbacks"
        ' 
        ' btnDetails
        ' 
        btnDetails.BorderRadius = 26
        btnDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnDetails.CheckedState.FillColor = Color.White
        btnDetails.CheckedState.ForeColor = Color.BlueViolet
        btnDetails.CustomizableEdges = CustomizableEdges3
        btnDetails.DisabledState.BorderColor = Color.DarkGray
        btnDetails.DisabledState.CustomBorderColor = Color.DarkGray
        btnDetails.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDetails.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDetails.FillColor = Color.BlueViolet
        btnDetails.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDetails.ForeColor = Color.White
        btnDetails.Image = CType(resources.GetObject("btnDetails.Image"), Image)
        btnDetails.ImageSize = New Size(30, 30)
        btnDetails.Location = New Point(782, 11)
        btnDetails.Name = "btnDetails"
        btnDetails.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDetails.Size = New Size(236, 85)
        btnDetails.TabIndex = 3
        btnDetails.Text = "Student Details"
        ' 
        ' btnReg
        ' 
        btnReg.BorderRadius = 26
        btnReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnReg.CheckedState.FillColor = Color.White
        btnReg.CheckedState.ForeColor = Color.BlueViolet
        btnReg.CustomizableEdges = CustomizableEdges5
        btnReg.DisabledState.BorderColor = Color.DarkGray
        btnReg.DisabledState.CustomBorderColor = Color.DarkGray
        btnReg.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReg.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReg.FillColor = Color.BlueViolet
        btnReg.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReg.ForeColor = Color.White
        btnReg.Image = CType(resources.GetObject("btnReg.Image"), Image)
        btnReg.ImageSize = New Size(35, 35)
        btnReg.Location = New Point(270, 11)
        btnReg.Name = "btnReg"
        btnReg.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnReg.Size = New Size(236, 85)
        btnReg.TabIndex = 2
        btnReg.Text = "New Registration"
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BorderRadius = 26
        btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnCheckout.CheckedState.FillColor = Color.White
        btnCheckout.CheckedState.ForeColor = Color.BlueViolet
        btnCheckout.CustomizableEdges = CustomizableEdges7
        btnCheckout.DisabledState.BorderColor = Color.DarkGray
        btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray
        btnCheckout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCheckout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCheckout.FillColor = Color.BlueViolet
        btnCheckout.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.White
        btnCheckout.Image = CType(resources.GetObject("btnCheckout.Image"), Image)
        btnCheckout.ImageSize = New Size(40, 40)
        btnCheckout.Location = New Point(525, 11)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnCheckout.Size = New Size(236, 85)
        btnCheckout.TabIndex = 1
        btnCheckout.Text = "Check out"
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.BorderRadius = 26
        btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnAddRoom.CheckedState.FillColor = Color.White
        btnAddRoom.CheckedState.ForeColor = Color.BlueViolet
        btnAddRoom.CustomizableEdges = CustomizableEdges9
        btnAddRoom.DisabledState.BorderColor = Color.DarkGray
        btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddRoom.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddRoom.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddRoom.FillColor = Color.BlueViolet
        btnAddRoom.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddRoom.ForeColor = Color.White
        btnAddRoom.Image = CType(resources.GetObject("btnAddRoom.Image"), Image)
        btnAddRoom.ImageSize = New Size(30, 30)
        btnAddRoom.Location = New Point(11, 11)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnAddRoom.Size = New Size(236, 85)
        btnAddRoom.TabIndex = 0
        btnAddRoom.Text = "Add Room"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(UC_feedback1)
        Panel2.Controls.Add(UC_StudentDetails_1)
        Panel2.Controls.Add(UC_CheckOut1)
        Panel2.Controls.Add(UC_NewRegistration1)
        Panel2.Controls.Add(UC_AddRoom1)
        Panel2.Location = New Point(12, 137)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1892, 899)
        Panel2.TabIndex = 1
        ' 
        ' UC_StudentDetails_1
        ' 
        UC_StudentDetails_1.BackColor = Color.White
        UC_StudentDetails_1.Location = New Point(4, 3)
        UC_StudentDetails_1.Name = "UC_StudentDetails_1"
        UC_StudentDetails_1.Size = New Size(2372, 1112)
        UC_StudentDetails_1.TabIndex = 3
        ' 
        ' UC_CheckOut1
        ' 
        UC_CheckOut1.BackColor = Color.White
        UC_CheckOut1.Location = New Point(4, 4)
        UC_CheckOut1.Name = "UC_CheckOut1"
        UC_CheckOut1.Size = New Size(2351, 1132)
        UC_CheckOut1.TabIndex = 2
        ' 
        ' UC_NewRegistration1
        ' 
        UC_NewRegistration1.BackColor = Color.White
        UC_NewRegistration1.Location = New Point(4, 4)
        UC_NewRegistration1.Name = "UC_NewRegistration1"
        UC_NewRegistration1.Size = New Size(2365, 1124)
        UC_NewRegistration1.TabIndex = 1
        ' 
        ' UC_AddRoom1
        ' 
        UC_AddRoom1.BackColor = Color.White
        UC_AddRoom1.Font = New Font("Comic Sans MS", 10.8F)
        UC_AddRoom1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UC_AddRoom1.Location = New Point(4, 4)
        UC_AddRoom1.Margin = New Padding(4)
        UC_AddRoom1.Name = "UC_AddRoom1"
        UC_AddRoom1.Size = New Size(2392, 1129)
        UC_AddRoom1.TabIndex = 0
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 30
        Guna2Elipse2.TargetControl = Me
        ' 
        ' btnClose
        ' 
        btnClose.DisabledState.BorderColor = Color.DarkGray
        btnClose.DisabledState.CustomBorderColor = Color.DarkGray
        btnClose.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnClose.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnClose.FillColor = Color.BlueViolet
        btnClose.Font = New Font("Segoe UI", 9F)
        btnClose.ForeColor = Color.White
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageOffset = New Point(1, 1)
        btnClose.ImageSize = New Size(40, 40)
        btnClose.Location = New Point(1801, 8)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnClose.Size = New Size(49, 48)
        btnClose.TabIndex = 2
        ' 
        ' Guna2CircleButton2
        ' 
        Guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton2.FillColor = Color.BlueViolet
        Guna2CircleButton2.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton2.ForeColor = Color.White
        Guna2CircleButton2.Image = CType(resources.GetObject("Guna2CircleButton2.Image"), Image)
        Guna2CircleButton2.ImageOffset = New Point(1, 0)
        Guna2CircleButton2.ImageSize = New Size(40, 40)
        Guna2CircleButton2.Location = New Point(1746, 8)
        Guna2CircleButton2.Name = "Guna2CircleButton2"
        Guna2CircleButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton2.Size = New Size(49, 48)
        Guna2CircleButton2.TabIndex = 3
        ' 
        ' Guna2Elipse3
        ' 
        Guna2Elipse3.BorderRadius = 30
        Guna2Elipse3.TargetControl = Me
        ' 
        ' Guna2Elipse4
        ' 
        Guna2Elipse4.BorderRadius = 30
        Guna2Elipse4.TargetControl = Me
        ' 
        ' btnLogout
        ' 
        btnLogout.DisabledState.BorderColor = Color.DarkGray
        btnLogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogout.FillColor = Color.BlueViolet
        btnLogout.Font = New Font("Segoe UI", 9F)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageOffset = New Point(1, 1)
        btnLogout.ImageSize = New Size(40, 40)
        btnLogout.Location = New Point(1850, 67)
        btnLogout.Name = "btnLogout"
        btnLogout.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnLogout.Size = New Size(49, 48)
        btnLogout.TabIndex = 4
        ' 
        ' Guna2Elipse5
        ' 
        Guna2Elipse5.BorderRadius = 30
        Guna2Elipse5.TargetControl = Me
        ' 
        ' UC_feedback1
        ' 
        UC_feedback1.BackColor = Color.White
        UC_feedback1.Location = New Point(4, 4)
        UC_feedback1.Name = "UC_feedback1"
        UC_feedback1.Size = New Size(2155, 900)
        UC_feedback1.TabIndex = 4
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlueViolet
        ClientSize = New Size(1920, 1051)
        Controls.Add(btnLogout)
        Controls.Add(Guna2CircleButton2)
        Controls.Add(btnClose)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddRoom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFeedback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDetails As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MovingPanel As Panel
    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_AddRoom1 As UC_AddRoom
    Private WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents UC_NewRegistration1 As UC_NewRegistration
    Private WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_CheckOut1 As UC_CheckOut
    Private WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_StudentDetails_1 As UC_StudentDetails_
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2CircleButton
    Private WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_feedback1 As UC_feedback

End Class
