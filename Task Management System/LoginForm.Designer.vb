﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Cancel = New Button()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Password = New MaterialSkin.Controls.MaterialTextBox2()
        Username = New MaterialSkin.Controls.MaterialTextBox2()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Cancel
        ' 
        Cancel.Location = New Point(631, 291)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(136, 37)
        Cancel.TabIndex = 15
        Cancel.Text = "Close"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(426, 201)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(71, 19)
        MaterialLabel4.TabIndex = 14
        MaterialLabel4.Text = "Password"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(426, 112)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(72, 19)
        MaterialLabel2.TabIndex = 13
        MaterialLabel2.Text = "Username"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(521, 32)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(158, 21)
        MaterialLabel1.TabIndex = 12
        MaterialLabel1.Text = "Login to your account"
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
        Password.Location = New Point(528, 186)
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
        Password.TabIndex = 11
        Password.TabStop = False
        Password.TextAlign = HorizontalAlignment.Left
        Password.TrailingIcon = Nothing
        Password.UseSystemPasswordChar = False
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
        Username.Location = New Point(528, 99)
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
        Username.TabIndex = 10
        Username.TabStop = False
        Username.TextAlign = HorizontalAlignment.Left
        Username.TrailingIcon = Nothing
        Username.UseSystemPasswordChar = False
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSize = False
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(443, 291)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(158, 37)
        MaterialButton2.TabIndex = 9
        MaterialButton2.Text = "Login"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(454, 382)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(192, 19)
        MaterialLabel3.TabIndex = 16
        MaterialLabel3.Text = "Don't have an account yet?"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(653, 372)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(114, 37)
        MaterialButton1.TabIndex = 17
        MaterialButton1.Text = "Sign Up Now!"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(379, 456)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AcceptButton = MaterialButton2
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialLabel3)
        Controls.Add(Cancel)
        Controls.Add(MaterialLabel4)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(MaterialButton2)
        Name = "LoginForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox

End Class
