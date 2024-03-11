<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyTasks
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Label1 = New Label()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSize = False
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(447, 349)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(138, 36)
        MaterialButton2.TabIndex = 7
        MaterialButton2.Text = "Close"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(247, 349)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(125, 36)
        MaterialButton1.TabIndex = 6
        MaterialButton1.Text = "Edit"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Underline)
        Label1.Location = New Point(350, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 41)
        Label1.TabIndex = 4
        Label1.Text = "My Tasks"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(57, 23)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(51, 19)
        MaterialLabel1.TabIndex = 8
        MaterialLabel1.Text = "Hi User"
        MaterialLabel1.Visible = False
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(333, 173)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(184, 19)
        MaterialLabel2.TabIndex = 9
        MaterialLabel2.Text = "You dont have any Tasks!"
        MaterialLabel2.Visible = False
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        Guna2DataGridView1.BackgroundColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        Guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 16F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(12, 67)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Guna2DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Guna2DataGridView1.Size = New Size(776, 273)
        Guna2DataGridView1.TabIndex = 10
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' MyTasks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(Label1)
        Controls.Add(Guna2DataGridView1)
        Name = "MyTasks"
        Text = "MyTasks"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
