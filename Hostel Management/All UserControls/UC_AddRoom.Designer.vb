<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AddRoom
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtRoomNo = New Guna.UI2.WinForms.Guna2TextBox()
        txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        txtType = New Guna.UI2.WinForms.Guna2ComboBox()
        txtBed = New Guna.UI2.WinForms.Guna2ComboBox()
        btnAddRoom = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 13)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 51)
        Label1.TabIndex = 0
        Label1.Text = "Add New Room"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Comic Sans MS", 10.8F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Comic Sans MS", 10.8F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.Location = New Point(18, 90)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(799, 737)
        DataGridView1.TabIndex = 1
        DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView1.ThemeStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Comic Sans MS", 10.8F)
        DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.ThemeStyle.HeaderStyle.Height = 30
        DataGridView1.ThemeStyle.ReadOnly = False
        DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Comic Sans MS", 10.8F)
        DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridView1.ThemeStyle.RowsStyle.Height = 29
        DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 10.8F)
        Label2.Location = New Point(893, 90)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 24)
        Label2.TabIndex = 2
        Label2.Text = "Room No"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 10.8F)
        Label3.Location = New Point(893, 218)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 3
        Label3.Text = "Room Type"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 10.8F)
        Label4.Location = New Point(893, 348)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 24)
        Label4.TabIndex = 4
        Label4.Text = "Bed Type"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 10.8F)
        Label5.Location = New Point(898, 474)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 24)
        Label5.TabIndex = 5
        Label5.Text = "Price"
        ' 
        ' txtRoomNo
        ' 
        txtRoomNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtRoomNo.CustomizableEdges = CustomizableEdges1
        txtRoomNo.DefaultText = ""
        txtRoomNo.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRoomNo.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRoomNo.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRoomNo.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRoomNo.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRoomNo.Font = New Font("Microsoft Sans Serif", 10.8F)
        txtRoomNo.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtRoomNo.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRoomNo.Location = New Point(893, 118)
        txtRoomNo.Margin = New Padding(4)
        txtRoomNo.Name = "txtRoomNo"
        txtRoomNo.PasswordChar = ChrW(0)
        txtRoomNo.PlaceholderText = ""
        txtRoomNo.SelectedText = ""
        txtRoomNo.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtRoomNo.Size = New Size(392, 36)
        txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtRoomNo.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrice.CustomizableEdges = CustomizableEdges3
        txtPrice.DefaultText = ""
        txtPrice.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPrice.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPrice.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPrice.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPrice.Font = New Font("Microsoft Sans Serif", 10.8F)
        txtPrice.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtPrice.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPrice.Location = New Point(898, 502)
        txtPrice.Margin = New Padding(4)
        txtPrice.Name = "txtPrice"
        txtPrice.PasswordChar = ChrW(0)
        txtPrice.PlaceholderText = ""
        txtPrice.SelectedText = ""
        txtPrice.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPrice.Size = New Size(392, 36)
        txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtPrice.TabIndex = 7
        ' 
        ' txtType
        ' 
        txtType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtType.BackColor = Color.Transparent
        txtType.CustomizableEdges = CustomizableEdges5
        txtType.DrawMode = DrawMode.OwnerDrawFixed
        txtType.DropDownStyle = ComboBoxStyle.DropDownList
        txtType.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtType.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtType.Font = New Font("Microsoft Sans Serif", 10.8F)
        txtType.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtType.ItemHeight = 30
        txtType.Items.AddRange(New Object() {"Ac", "Non-Ac"})
        txtType.Location = New Point(892, 246)
        txtType.Margin = New Padding(4)
        txtType.Name = "txtType"
        txtType.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtType.Size = New Size(392, 36)
        txtType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtType.TabIndex = 8
        ' 
        ' txtBed
        ' 
        txtBed.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBed.BackColor = Color.Transparent
        txtBed.CustomizableEdges = CustomizableEdges7
        txtBed.DrawMode = DrawMode.OwnerDrawFixed
        txtBed.DropDownStyle = ComboBoxStyle.DropDownList
        txtBed.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtBed.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtBed.Font = New Font("Microsoft Sans Serif", 10.8F)
        txtBed.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtBed.ItemHeight = 30
        txtBed.Items.AddRange(New Object() {"Single", "Double", "Triple"})
        txtBed.Location = New Point(893, 376)
        txtBed.Margin = New Padding(4)
        txtBed.Name = "txtBed"
        txtBed.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtBed.Size = New Size(392, 36)
        txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtBed.TabIndex = 9
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddRoom.BorderRadius = 23
        btnAddRoom.BorderThickness = 1
        btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnAddRoom.CheckedState.FillColor = Color.BlueViolet
        btnAddRoom.CheckedState.ForeColor = Color.White
        btnAddRoom.CustomizableEdges = CustomizableEdges9
        btnAddRoom.DisabledState.BorderColor = Color.DarkGray
        btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddRoom.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddRoom.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddRoom.FillColor = Color.White
        btnAddRoom.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAddRoom.ForeColor = Color.Black
        btnAddRoom.Location = New Point(1158, 590)
        btnAddRoom.Margin = New Padding(4)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnAddRoom.Size = New Size(132, 45)
        btnAddRoom.TabIndex = 10
        btnAddRoom.Text = "Add Room"
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = Me
        ' 
        ' UC_AddRoom
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(btnAddRoom)
        Controls.Add(txtBed)
        Controls.Add(txtType)
        Controls.Add(txtPrice)
        Controls.Add(txtRoomNo)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Font = New Font("Comic Sans MS", 10.8F)
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Margin = New Padding(4)
        Name = "UC_AddRoom"
        Size = New Size(1914, 903)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoomNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtBed As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAddRoom As Guna.UI2.WinForms.Guna2Button
    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse

End Class
