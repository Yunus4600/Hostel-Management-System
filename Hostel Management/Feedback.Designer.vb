<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtfeedback = New Guna.UI2.WinForms.Guna2TextBox()
        btnFeedback = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' txtfeedback
        ' 
        txtfeedback.BorderColor = Color.Black
        txtfeedback.BorderRadius = 10
        txtfeedback.CustomizableEdges = CustomizableEdges5
        txtfeedback.DefaultText = ""
        txtfeedback.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtfeedback.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtfeedback.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtfeedback.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtfeedback.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtfeedback.Font = New Font("Microsoft Sans Serif", 10.8F)
        txtfeedback.ForeColor = Color.Black
        txtfeedback.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtfeedback.Location = New Point(13, 13)
        txtfeedback.Margin = New Padding(4)
        txtfeedback.Multiline = True
        txtfeedback.Name = "txtfeedback"
        txtfeedback.PasswordChar = ChrW(0)
        txtfeedback.PlaceholderText = "Write here"
        txtfeedback.SelectedText = ""
        txtfeedback.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtfeedback.Size = New Size(510, 311)
        txtfeedback.TabIndex = 1
        ' 
        ' btnFeedback
        ' 
        btnFeedback.BorderRadius = 23
        btnFeedback.BorderThickness = 1
        btnFeedback.CheckedState.FillColor = Color.BlueViolet
        btnFeedback.CheckedState.ForeColor = Color.White
        btnFeedback.CustomizableEdges = CustomizableEdges7
        btnFeedback.DisabledState.BorderColor = Color.DarkGray
        btnFeedback.DisabledState.CustomBorderColor = Color.DarkGray
        btnFeedback.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnFeedback.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnFeedback.FillColor = Color.Transparent
        btnFeedback.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFeedback.ForeColor = Color.Black
        btnFeedback.Location = New Point(394, 331)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnFeedback.Size = New Size(129, 48)
        btnFeedback.TabIndex = 37
        btnFeedback.Text = "Submit"
        ' 
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(537, 388)
        Controls.Add(btnFeedback)
        Controls.Add(txtfeedback)
        FormBorderStyle = FormBorderStyle.None
        Name = "Feedback"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Feedback"
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtfeedback As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFeedback As Guna.UI2.WinForms.Guna2Button
End Class
