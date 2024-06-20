<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_feedback
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Label2 = New Label()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        txtFeedback = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Font = New Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 27)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(305, 51)
        Label2.TabIndex = 5
        Label2.Text = "View Feedbacks"
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(96, 162)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.Size = New Size(1700, 234)
        Guna2DataGridView1.TabIndex = 6
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' txtEmail
        ' 
        txtEmail.CustomizableEdges = CustomizableEdges3
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = Color.Black
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Location = New Point(161, 472)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.PasswordChar = ChrW(0)
        txtEmail.PlaceholderText = ""
        txtEmail.ReadOnly = True
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtEmail.Size = New Size(393, 53)
        txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtEmail.TabIndex = 7
        ' 
        ' txtFeedback
        ' 
        txtFeedback.BorderColor = Color.Black
        txtFeedback.BorderRadius = 10
        txtFeedback.CustomizableEdges = CustomizableEdges1
        txtFeedback.DefaultText = ""
        txtFeedback.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFeedback.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFeedback.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFeedback.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFeedback.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFeedback.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFeedback.ForeColor = Color.Black
        txtFeedback.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFeedback.Location = New Point(591, 459)
        txtFeedback.Margin = New Padding(4, 5, 4, 5)
        txtFeedback.Multiline = True
        txtFeedback.Name = "txtFeedback"
        txtFeedback.PasswordChar = ChrW(0)
        txtFeedback.PlaceholderText = ""
        txtFeedback.ReadOnly = True
        txtFeedback.SelectedText = ""
        txtFeedback.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtFeedback.Size = New Size(692, 219)
        txtFeedback.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(161, 439)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 28)
        Label1.TabIndex = 9
        Label1.Text = "Email"
        ' 
        ' UC_feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label1)
        Controls.Add(txtFeedback)
        Controls.Add(txtEmail)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(Label2)
        Name = "UC_feedback"
        Size = New Size(1863, 720)
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFeedback As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label

End Class
