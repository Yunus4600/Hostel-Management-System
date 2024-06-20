<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_CheckOut
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Label2 = New Label()
        Label1 = New Label()
        txtName = New Guna.UI2.WinForms.Guna2TextBox()
        gridViewCheckout = New Guna.UI2.WinForms.Guna2DataGridView()
        txtSname = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        txtRoom = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtCheckOutDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnCkeckOut = New Guna.UI2.WinForms.Guna2Button()
        CType(gridViewCheckout, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Location = New Point(15, 14)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(365, 51)
        Label2.TabIndex = 3
        Label2.Text = "Student Check Out"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(758, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 28)
        Label1.TabIndex = 4
        Label1.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.CustomizableEdges = CustomizableEdges9
        txtName.DefaultText = ""
        txtName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtName.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.Black
        txtName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtName.Location = New Point(758, 161)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.PasswordChar = ChrW(0)
        txtName.PlaceholderText = "Enter Full Name"
        txtName.SelectedText = ""
        txtName.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtName.Size = New Size(385, 39)
        txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtName.TabIndex = 5
        ' 
        ' gridViewCheckout
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        gridViewCheckout.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        gridViewCheckout.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        gridViewCheckout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        gridViewCheckout.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        gridViewCheckout.DefaultCellStyle = DataGridViewCellStyle3
        gridViewCheckout.EditMode = DataGridViewEditMode.EditProgrammatically
        gridViewCheckout.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewCheckout.Location = New Point(15, 253)
        gridViewCheckout.Name = "gridViewCheckout"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        gridViewCheckout.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        gridViewCheckout.RowHeadersVisible = False
        gridViewCheckout.RowHeadersWidth = 51
        gridViewCheckout.Size = New Size(1836, 433)
        gridViewCheckout.TabIndex = 6
        gridViewCheckout.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        gridViewCheckout.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        gridViewCheckout.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        gridViewCheckout.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        gridViewCheckout.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        gridViewCheckout.ThemeStyle.BackColor = Color.White
        gridViewCheckout.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewCheckout.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        gridViewCheckout.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        gridViewCheckout.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        gridViewCheckout.ThemeStyle.HeaderStyle.ForeColor = Color.White
        gridViewCheckout.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        gridViewCheckout.ThemeStyle.HeaderStyle.Height = 30
        gridViewCheckout.ThemeStyle.ReadOnly = False
        gridViewCheckout.ThemeStyle.RowsStyle.BackColor = Color.White
        gridViewCheckout.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        gridViewCheckout.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        gridViewCheckout.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        gridViewCheckout.ThemeStyle.RowsStyle.Height = 29
        gridViewCheckout.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewCheckout.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' txtSname
        ' 
        txtSname.CustomizableEdges = CustomizableEdges7
        txtSname.DefaultText = ""
        txtSname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSname.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSname.ForeColor = Color.Black
        txtSname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSname.Location = New Point(25, 790)
        txtSname.Margin = New Padding(4)
        txtSname.Name = "txtSname"
        txtSname.PasswordChar = ChrW(0)
        txtSname.PlaceholderText = "Full Name"
        txtSname.ReadOnly = True
        txtSname.SelectedText = ""
        txtSname.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtSname.Size = New Size(385, 39)
        txtSname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtSname.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 758)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 7
        Label3.Text = "Name"
        ' 
        ' txtRoom
        ' 
        txtRoom.CustomizableEdges = CustomizableEdges5
        txtRoom.DefaultText = ""
        txtRoom.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRoom.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRoom.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRoom.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRoom.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRoom.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRoom.ForeColor = Color.Black
        txtRoom.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRoom.Location = New Point(534, 790)
        txtRoom.Margin = New Padding(4)
        txtRoom.Name = "txtRoom"
        txtRoom.PasswordChar = ChrW(0)
        txtRoom.PlaceholderText = "Room no"
        txtRoom.ReadOnly = True
        txtRoom.SelectedText = ""
        txtRoom.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtRoom.Size = New Size(385, 39)
        txtRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtRoom.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(534, 758)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 28)
        Label4.TabIndex = 9
        Label4.Text = "Room No"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1097, 758)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 28)
        Label5.TabIndex = 11
        Label5.Text = "Checkout Date"
        ' 
        ' txtCheckOutDate
        ' 
        txtCheckOutDate.Checked = True
        txtCheckOutDate.CustomizableEdges = CustomizableEdges3
        txtCheckOutDate.Font = New Font("Segoe UI", 9F)
        txtCheckOutDate.Format = DateTimePickerFormat.Short
        txtCheckOutDate.Location = New Point(1097, 790)
        txtCheckOutDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        txtCheckOutDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        txtCheckOutDate.Name = "txtCheckOutDate"
        txtCheckOutDate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtCheckOutDate.Size = New Size(385, 39)
        txtCheckOutDate.TabIndex = 12
        txtCheckOutDate.Value = New Date(2024, 4, 2, 12, 11, 54, 439)
        ' 
        ' btnCkeckOut
        ' 
        btnCkeckOut.BorderRadius = 23
        btnCkeckOut.BorderThickness = 1
        btnCkeckOut.CheckedState.FillColor = Color.BlueViolet
        btnCkeckOut.CheckedState.ForeColor = Color.White
        btnCkeckOut.CustomizableEdges = CustomizableEdges1
        btnCkeckOut.DisabledState.BorderColor = Color.DarkGray
        btnCkeckOut.DisabledState.CustomBorderColor = Color.DarkGray
        btnCkeckOut.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCkeckOut.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCkeckOut.FillColor = Color.White
        btnCkeckOut.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        btnCkeckOut.ForeColor = Color.Black
        btnCkeckOut.Location = New Point(1653, 790)
        btnCkeckOut.Name = "btnCkeckOut"
        btnCkeckOut.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnCkeckOut.Size = New Size(164, 45)
        btnCkeckOut.TabIndex = 28
        btnCkeckOut.Text = "Check Out"
        ' 
        ' UC_CheckOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(btnCkeckOut)
        Controls.Add(txtCheckOutDate)
        Controls.Add(Label5)
        Controls.Add(txtRoom)
        Controls.Add(Label4)
        Controls.Add(txtSname)
        Controls.Add(Label3)
        Controls.Add(gridViewCheckout)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "UC_CheckOut"
        Size = New Size(1881, 906)
        CType(gridViewCheckout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gridViewCheckout As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCheckOutDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnCkeckOut As Guna.UI2.WinForms.Guna2Button

End Class
