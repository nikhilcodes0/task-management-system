<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 16F, FontStyle.Bold)
        Label1.Location = New Point(162, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 27)
        Label1.TabIndex = 0
        Label1.Text = "User Profile"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Guna2HtmlLabel1.Location = New Point(130, 107)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(84, 23)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Username: "
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel2.Location = New Point(220, 107)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(112, 23)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "User not found!"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel3.Location = New Point(272, 156)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(12, 23)
        Guna2HtmlLabel3.TabIndex = 4
        Guna2HtmlLabel3.Text = "0"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Guna2HtmlLabel4.Location = New Point(130, 156)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(136, 23)
        Guna2HtmlLabel4.TabIndex = 3
        Guna2HtmlLabel4.Text = "Completed Tasks: "
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Segoe UI", 12F)
        Guna2HtmlLabel5.Location = New Point(281, 199)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(12, 23)
        Guna2HtmlLabel5.TabIndex = 6
        Guna2HtmlLabel5.Text = "0"
        ' 
        ' Guna2HtmlLabel6
        ' 
        Guna2HtmlLabel6.BackColor = Color.Transparent
        Guna2HtmlLabel6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Guna2HtmlLabel6.Location = New Point(130, 199)
        Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Guna2HtmlLabel6.Size = New Size(139, 23)
        Guna2HtmlLabel6.TabIndex = 5
        Guna2HtmlLabel6.Text = "Incomplete Tasks: "
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(162, 270)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(114, 36)
        MaterialButton1.TabIndex = 7
        MaterialButton1.Text = "Edit Profile"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' UserProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(483, 364)
        Controls.Add(MaterialButton1)
        Controls.Add(Guna2HtmlLabel5)
        Controls.Add(Guna2HtmlLabel6)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Label1)
        Name = "UserProfile"
        Text = "UserProfile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
