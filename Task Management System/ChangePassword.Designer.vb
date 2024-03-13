<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Label1 = New Label()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        MaterialTextBox3 = New MaterialSkin.Controls.MaterialTextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Label2 = New Label()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 20F, FontStyle.Bold)
        Label1.Location = New Point(181, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 34)
        Label1.TabIndex = 0
        Label1.Text = "Change Password"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel1.Location = New Point(98, 106)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(135, 23)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Current Password:"
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(239, 97)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Password = True
        MaterialTextBox1.Size = New Size(251, 50)
        MaterialTextBox1.TabIndex = 2
        MaterialTextBox1.Text = ""
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' MaterialTextBox2
        ' 
        MaterialTextBox2.AnimateReadOnly = False
        MaterialTextBox2.BorderStyle = BorderStyle.None
        MaterialTextBox2.Depth = 0
        MaterialTextBox2.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox2.LeadingIcon = Nothing
        MaterialTextBox2.Location = New Point(239, 187)
        MaterialTextBox2.MaxLength = 50
        MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox2.Multiline = False
        MaterialTextBox2.Name = "MaterialTextBox2"
        MaterialTextBox2.Password = True
        MaterialTextBox2.Size = New Size(251, 50)
        MaterialTextBox2.TabIndex = 4
        MaterialTextBox2.Text = ""
        MaterialTextBox2.TrailingIcon = Nothing
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel2.Location = New Point(98, 196)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(113, 23)
        Guna2HtmlLabel2.TabIndex = 3
        Guna2HtmlLabel2.Text = "New Password:"
        ' 
        ' MaterialTextBox3
        ' 
        MaterialTextBox3.AnimateReadOnly = False
        MaterialTextBox3.BorderStyle = BorderStyle.None
        MaterialTextBox3.Depth = 0
        MaterialTextBox3.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox3.LeadingIcon = Nothing
        MaterialTextBox3.Location = New Point(239, 281)
        MaterialTextBox3.MaxLength = 50
        MaterialTextBox3.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox3.Multiline = False
        MaterialTextBox3.Name = "MaterialTextBox3"
        MaterialTextBox3.Password = True
        MaterialTextBox3.Size = New Size(251, 50)
        MaterialTextBox3.TabIndex = 6
        MaterialTextBox3.Text = ""
        MaterialTextBox3.TrailingIcon = Nothing
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel3.Location = New Point(33, 290)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(200, 23)
        Guna2HtmlLabel3.TabIndex = 5
        Guna2HtmlLabel3.Text = "Retype you New Password:"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(132, 419)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(160, 36)
        MaterialButton1.TabIndex = 7
        MaterialButton1.Text = "Update Password"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Malgun Gothic", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(190, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(253, 19)
        Label2.TabIndex = 8
        Label2.Text = "You have entered wrong password!"
        Label2.Visible = False
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(374, 419)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(77, 36)
        MaterialButton2.TabIndex = 9
        MaterialButton2.Text = "Cancel"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 504)
        Controls.Add(MaterialButton2)
        Controls.Add(Label2)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialTextBox3)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(MaterialTextBox2)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(MaterialTextBox1)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Label1)
        Name = "ChangePassword"
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MaterialTextBox3 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
End Class
