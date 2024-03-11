<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskEntry))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox2 = New MaterialSkin.Controls.MaterialComboBox()
        MaterialMultiLineTextBox21 = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox3 = New MaterialSkin.Controls.MaterialComboBox()
        Label1 = New Label()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(612, 308)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(120, 19)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "Task Description"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(612, 104)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(90, 19)
        MaterialLabel2.TabIndex = 2
        MaterialLabel2.Text = "Task Priority"
        ' 
        ' MaterialComboBox1
        ' 
        MaterialComboBox1.AutoResize = False
        MaterialComboBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox1.Depth = 0
        MaterialComboBox1.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox1.DropDownHeight = 174
        MaterialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox1.DropDownWidth = 121
        MaterialComboBox1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox1.FormattingEnabled = True
        MaterialComboBox1.IntegralHeight = False
        MaterialComboBox1.ItemHeight = 43
        MaterialComboBox1.Items.AddRange(New Object() {"low", "medium", "ASAP"})
        MaterialComboBox1.Location = New Point(612, 126)
        MaterialComboBox1.MaxDropDownItems = 4
        MaterialComboBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialComboBox1.Name = "MaterialComboBox1"
        MaterialComboBox1.Size = New Size(392, 49)
        MaterialComboBox1.StartIndex = 0
        MaterialComboBox1.TabIndex = 3
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(612, 205)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(72, 19)
        MaterialLabel3.TabIndex = 4
        MaterialLabel3.Text = "Assign To"
        ' 
        ' MaterialComboBox2
        ' 
        MaterialComboBox2.AutoResize = False
        MaterialComboBox2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox2.Depth = 0
        MaterialComboBox2.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox2.DropDownHeight = 174
        MaterialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox2.DropDownWidth = 121
        MaterialComboBox2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox2.FormattingEnabled = True
        MaterialComboBox2.IntegralHeight = False
        MaterialComboBox2.ItemHeight = 43
        MaterialComboBox2.Location = New Point(612, 227)
        MaterialComboBox2.MaxDropDownItems = 4
        MaterialComboBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialComboBox2.Name = "MaterialComboBox2"
        MaterialComboBox2.Size = New Size(392, 49)
        MaterialComboBox2.StartIndex = 0
        MaterialComboBox2.TabIndex = 5
        ' 
        ' MaterialMultiLineTextBox21
        ' 
        MaterialMultiLineTextBox21.AnimateReadOnly = False
        MaterialMultiLineTextBox21.BackgroundImageLayout = ImageLayout.None
        MaterialMultiLineTextBox21.CharacterCasing = CharacterCasing.Normal
        MaterialMultiLineTextBox21.Depth = 0
        MaterialMultiLineTextBox21.HideSelection = True
        MaterialMultiLineTextBox21.Location = New Point(612, 330)
        MaterialMultiLineTextBox21.MaxLength = 32767
        MaterialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT
        MaterialMultiLineTextBox21.Name = "MaterialMultiLineTextBox21"
        MaterialMultiLineTextBox21.PasswordChar = ChrW(0)
        MaterialMultiLineTextBox21.ReadOnly = False
        MaterialMultiLineTextBox21.ScrollBars = ScrollBars.None
        MaterialMultiLineTextBox21.SelectedText = ""
        MaterialMultiLineTextBox21.SelectionLength = 0
        MaterialMultiLineTextBox21.SelectionStart = 0
        MaterialMultiLineTextBox21.ShortcutsEnabled = True
        MaterialMultiLineTextBox21.Size = New Size(392, 100)
        MaterialMultiLineTextBox21.TabIndex = 7
        MaterialMultiLineTextBox21.TabStop = False
        MaterialMultiLineTextBox21.TextAlign = HorizontalAlignment.Left
        MaterialMultiLineTextBox21.UseSystemPasswordChar = False
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(612, 467)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(86, 19)
        MaterialLabel4.TabIndex = 8
        MaterialLabel4.Text = "Task Status"
        ' 
        ' MaterialComboBox3
        ' 
        MaterialComboBox3.AutoResize = False
        MaterialComboBox3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialComboBox3.Depth = 0
        MaterialComboBox3.DrawMode = DrawMode.OwnerDrawVariable
        MaterialComboBox3.DropDownHeight = 174
        MaterialComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        MaterialComboBox3.DropDownWidth = 121
        MaterialComboBox3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialComboBox3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialComboBox3.FormattingEnabled = True
        MaterialComboBox3.IntegralHeight = False
        MaterialComboBox3.ItemHeight = 43
        MaterialComboBox3.Items.AddRange(New Object() {"Yet to Start", "In Progress", "Done"})
        MaterialComboBox3.Location = New Point(612, 489)
        MaterialComboBox3.MaxDropDownItems = 4
        MaterialComboBox3.MouseState = MaterialSkin.MouseState.OUT
        MaterialComboBox3.Name = "MaterialComboBox3"
        MaterialComboBox3.Size = New Size(392, 49)
        MaterialComboBox3.StartIndex = 0
        MaterialComboBox3.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19F, FontStyle.Underline)
        Label1.Location = New Point(713, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 36)
        Label1.TabIndex = 10
        Label1.Text = "Task Entry Form"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(643, 620)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(141, 36)
        MaterialButton1.TabIndex = 11
        MaterialButton1.Text = "Add Task"
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
        MaterialButton2.Location = New Point(835, 620)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(158, 36)
        MaterialButton2.TabIndex = 12
        MaterialButton2.Text = "Cancel"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        MaterialLabel5.Location = New Point(734, 567)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(183, 19)
        MaterialLabel5.TabIndex = 13
        MaterialLabel5.Text = "Task Added Successfully!"
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.White
        Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), Image)
        Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.FillColor = Color.Transparent
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageLocation = "10"
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.InitialImage = CType(resources.GetObject("Guna2PictureBox1.InitialImage"), Image)
        Guna2PictureBox1.Location = New Point(-1, -1)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(536, 717)
        Guna2PictureBox1.TabIndex = 14
        Guna2PictureBox1.TabStop = False
        ' 
        ' TaskEntry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(238))
        ClientSize = New Size(1098, 713)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(MaterialLabel5)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(Label1)
        Controls.Add(MaterialComboBox3)
        Controls.Add(MaterialLabel4)
        Controls.Add(MaterialMultiLineTextBox21)
        Controls.Add(MaterialComboBox2)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialComboBox1)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Name = "TaskEntry"
        Text = "TaskEntry"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialComboBox2 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialMultiLineTextBox21 As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialComboBox3 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
