<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Label1 = New Label()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialTextBox3 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(188, 91)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(80, 19)
        MaterialLabel1.TabIndex = 0
        MaterialLabel1.Text = "Your Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        Label1.Location = New Point(250, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 36)
        Label1.TabIndex = 1
        Label1.Text = "Create your account!"
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(274, 78)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(244, 50)
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
        MaterialTextBox2.Location = New Point(274, 169)
        MaterialTextBox2.MaxLength = 50
        MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox2.Multiline = False
        MaterialTextBox2.Name = "MaterialTextBox2"
        MaterialTextBox2.Size = New Size(244, 50)
        MaterialTextBox2.TabIndex = 4
        MaterialTextBox2.Text = ""
        MaterialTextBox2.TrailingIcon = Nothing
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(160, 182)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(108, 19)
        MaterialLabel2.TabIndex = 3
        MaterialLabel2.Text = "Your Password"
        ' 
        ' MaterialTextBox3
        ' 
        MaterialTextBox3.AnimateReadOnly = False
        MaterialTextBox3.BorderStyle = BorderStyle.None
        MaterialTextBox3.Depth = 0
        MaterialTextBox3.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox3.LeadingIcon = Nothing
        MaterialTextBox3.Location = New Point(274, 249)
        MaterialTextBox3.MaxLength = 50
        MaterialTextBox3.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox3.Multiline = False
        MaterialTextBox3.Name = "MaterialTextBox3"
        MaterialTextBox3.Size = New Size(244, 50)
        MaterialTextBox3.TabIndex = 6
        MaterialTextBox3.Text = ""
        MaterialTextBox3.TrailingIcon = Nothing
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(108, 262)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(160, 19)
        MaterialLabel3.TabIndex = 5
        MaterialLabel3.Text = "Retype Your Password"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(238, 362)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(137, 36)
        MaterialButton1.TabIndex = 7
        MaterialButton1.Text = "Sign Up"
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
        MaterialButton2.Location = New Point(419, 362)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(115, 36)
        MaterialButton2.TabIndex = 8
        MaterialButton2.Text = "Cancel"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        MaterialLabel4.Location = New Point(306, 324)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(164, 19)
        MaterialLabel4.TabIndex = 9
        MaterialLabel4.Text = "Please fill all the fields!"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialLabel4)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialTextBox3)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialTextBox2)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialTextBox1)
        Controls.Add(Label1)
        Controls.Add(MaterialLabel1)
        Name = "SignUp"
        Text = "SignUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox3 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
End Class
