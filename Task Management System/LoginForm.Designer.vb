<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Username = New MaterialSkin.Controls.MaterialTextBox2()
        Password = New MaterialSkin.Controls.MaterialTextBox2()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Cancel = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
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
        MaterialButton2.Location = New Point(89, 295)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(158, 37)
        MaterialButton2.TabIndex = 1
        MaterialButton2.Text = "Login"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' Username
        ' 
        Username.AnimateReadOnly = False
        Username.BackgroundImageLayout = ImageLayout.None
        Username.CharacterCasing = CharacterCasing.Normal
        Username.Depth = 0
        Username.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        Username.HideSelection = True
        Username.LeadingIcon = Nothing
        Username.Location = New Point(147, 102)
        Username.MaxLength = 32767
        Username.MouseState = MaterialSkin.MouseState.OUT
        Username.Name = "Username"
        Username.PasswordChar = ChrW(0)
        Username.PrefixSuffixText = Nothing
        Username.ReadOnly = False
        Username.RightToLeft = RightToLeft.No
        Username.SelectedText = ""
        Username.SelectionLength = 0
        Username.SelectionStart = 0
        Username.ShortcutsEnabled = True
        Username.Size = New Size(250, 48)
        Username.TabIndex = 2
        Username.TabStop = False
        Username.TextAlign = HorizontalAlignment.Left
        Username.TrailingIcon = Nothing
        Username.UseSystemPasswordChar = False
        ' 
        ' Password
        ' 
        Password.AnimateReadOnly = False
        Password.BackgroundImageLayout = ImageLayout.None
        Password.CharacterCasing = CharacterCasing.Normal
        Password.Depth = 0
        Password.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        Password.HideSelection = True
        Password.LeadingIcon = Nothing
        Password.Location = New Point(147, 189)
        Password.MaxLength = 32767
        Password.MouseState = MaterialSkin.MouseState.OUT
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.PrefixSuffixText = Nothing
        Password.ReadOnly = False
        Password.RightToLeft = RightToLeft.No
        Password.SelectedText = ""
        Password.SelectionLength = 0
        Password.SelectionStart = 0
        Password.ShortcutsEnabled = True
        Password.Size = New Size(250, 48)
        Password.TabIndex = 3
        Password.TabStop = False
        Password.TextAlign = HorizontalAlignment.Left
        Password.TrailingIcon = Nothing
        Password.UseSystemPasswordChar = False
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(180, 36)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(158, 21)
        MaterialLabel1.TabIndex = 4
        MaterialLabel1.Text = "Login to your account"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(45, 115)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(72, 19)
        MaterialLabel2.TabIndex = 5
        MaterialLabel2.Text = "Username"
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(45, 204)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(71, 19)
        MaterialLabel4.TabIndex = 7
        MaterialLabel4.Text = "Password"
        ' 
        ' Cancel
        ' 
        Cancel.Location = New Point(301, 295)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(136, 37)
        Cancel.TabIndex = 8
        Cancel.Text = "Close"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Cancel)
        GroupBox1.Controls.Add(MaterialLabel4)
        GroupBox1.Controls.Add(MaterialLabel2)
        GroupBox1.Controls.Add(MaterialLabel1)
        GroupBox1.Controls.Add(Password)
        GroupBox1.Controls.Add(Username)
        GroupBox1.Controls.Add(MaterialButton2)
        GroupBox1.Location = New Point(131, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "LoginForm"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Cancel As Button
    Friend WithEvents GroupBox1 As GroupBox

End Class
