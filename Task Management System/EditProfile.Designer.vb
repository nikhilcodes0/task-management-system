<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Ink Free", 19F, FontStyle.Bold)
        Guna2HtmlLabel1.Location = New Point(182, 39)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(202, 33)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Edit your Account"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(91, 154)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(129, 17)
        Guna2HtmlLabel2.TabIndex = 1
        Guna2HtmlLabel2.Text = "Change your username: "
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(226, 145)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(200, 36)
        Guna2TextBox1.TabIndex = 2
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Location = New Point(91, 104)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(102, 17)
        Guna2HtmlLabel3.TabIndex = 3
        Guna2HtmlLabel3.Text = "Current Username:"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Location = New Point(226, 104)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(72, 17)
        Guna2HtmlLabel4.TabIndex = 4
        Guna2HtmlLabel4.Text = "Nikhil Kumar"
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Location = New Point(91, 213)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(211, 17)
        Guna2HtmlLabel5.TabIndex = 5
        Guna2HtmlLabel5.Text = "Do you want to change your password?"
        ' 
        ' Guna2RadioButton1
        ' 
        Guna2RadioButton1.AutoSize = True
        Guna2RadioButton1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton1.CheckedState.BorderThickness = 0
        Guna2RadioButton1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton1.CheckedState.InnerColor = Color.White
        Guna2RadioButton1.CheckedState.InnerOffset = -4
        Guna2RadioButton1.Location = New Point(308, 211)
        Guna2RadioButton1.Name = "Guna2RadioButton1"
        Guna2RadioButton1.Size = New Size(42, 19)
        Guna2RadioButton1.TabIndex = 6
        Guna2RadioButton1.Text = "Yes"
        Guna2RadioButton1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Guna2RadioButton1.UncheckedState.FillColor = Color.Transparent
        Guna2RadioButton1.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' Guna2RadioButton2
        ' 
        Guna2RadioButton2.AutoSize = True
        Guna2RadioButton2.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton2.CheckedState.BorderThickness = 0
        Guna2RadioButton2.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton2.CheckedState.InnerColor = Color.White
        Guna2RadioButton2.CheckedState.InnerOffset = -4
        Guna2RadioButton2.Location = New Point(356, 211)
        Guna2RadioButton2.Name = "Guna2RadioButton2"
        Guna2RadioButton2.Size = New Size(41, 19)
        Guna2RadioButton2.TabIndex = 7
        Guna2RadioButton2.Text = "No"
        Guna2RadioButton2.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Guna2RadioButton2.UncheckedState.FillColor = Color.Transparent
        Guna2RadioButton2.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(125, 292)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(138, 36)
        MaterialButton1.TabIndex = 14
        MaterialButton1.Text = "Update Profile"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSize = False
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(308, 292)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(141, 36)
        MaterialButton2.TabIndex = 15
        MaterialButton2.Text = "Cancel"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' Guna2HtmlLabel6
        ' 
        Guna2HtmlLabel6.BackColor = Color.Transparent
        Guna2HtmlLabel6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Guna2HtmlLabel6.ForeColor = Color.Navy
        Guna2HtmlLabel6.Location = New Point(190, 253)
        Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Guna2HtmlLabel6.Size = New Size(194, 19)
        Guna2HtmlLabel6.TabIndex = 16
        Guna2HtmlLabel6.Text = "Username updated sucessfully!"
        Guna2HtmlLabel6.Visible = False
        ' 
        ' EditProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(587, 374)
        Controls.Add(Guna2HtmlLabel6)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(Guna2RadioButton2)
        Controls.Add(Guna2RadioButton1)
        Controls.Add(Guna2HtmlLabel5)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Name = "EditProfile"
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
