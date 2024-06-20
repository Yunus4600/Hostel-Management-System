<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_StudentDetails_
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Label2 = New Label()
        Label1 = New Label()
        txtSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        gridViewDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(gridViewDetails, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Location = New Point(26, 19)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(303, 51)
        Label2.TabIndex = 4
        Label2.Text = "Student Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(796, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 28)
        Label1.TabIndex = 5
        Label1.Text = "Search By"
        ' 
        ' txtSearchBy
        ' 
        txtSearchBy.BackColor = Color.Transparent
        txtSearchBy.CustomizableEdges = CustomizableEdges1
        txtSearchBy.DrawMode = DrawMode.OwnerDrawFixed
        txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList
        txtSearchBy.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearchBy.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearchBy.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchBy.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        txtSearchBy.ItemHeight = 30
        txtSearchBy.Items.AddRange(New Object() {"All Students", "In Hostel Students ", "Checked Out Students"})
        txtSearchBy.Location = New Point(796, 152)
        txtSearchBy.Name = "txtSearchBy"
        txtSearchBy.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearchBy.Size = New Size(385, 36)
        txtSearchBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtSearchBy.TabIndex = 6
        ' 
        ' gridViewDetails
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        gridViewDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        gridViewDetails.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        gridViewDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        gridViewDetails.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        gridViewDetails.DefaultCellStyle = DataGridViewCellStyle3
        gridViewDetails.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewDetails.Location = New Point(26, 261)
        gridViewDetails.Name = "gridViewDetails"
        gridViewDetails.RowHeadersVisible = False
        gridViewDetails.RowHeadersWidth = 51
        gridViewDetails.Size = New Size(1832, 626)
        gridViewDetails.TabIndex = 7
        gridViewDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        gridViewDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        gridViewDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        gridViewDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        gridViewDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        gridViewDetails.ThemeStyle.BackColor = Color.White
        gridViewDetails.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        gridViewDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        gridViewDetails.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        gridViewDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White
        gridViewDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        gridViewDetails.ThemeStyle.HeaderStyle.Height = 30
        gridViewDetails.ThemeStyle.ReadOnly = False
        gridViewDetails.ThemeStyle.RowsStyle.BackColor = Color.White
        gridViewDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        gridViewDetails.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        gridViewDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        gridViewDetails.ThemeStyle.RowsStyle.Height = 29
        gridViewDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gridViewDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' UC_StudentDetails_
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(gridViewDetails)
        Controls.Add(txtSearchBy)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "UC_StudentDetails_"
        Size = New Size(1898, 890)
        CType(gridViewDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gridViewDetails As Guna.UI2.WinForms.Guna2DataGridView

End Class
