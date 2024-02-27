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
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox2 = New MaterialSkin.Controls.MaterialComboBox()
        MaterialMultiLineTextBox21 = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialComboBox3 = New MaterialSkin.Controls.MaterialComboBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(185, 302)
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
        MaterialLabel2.Location = New Point(185, 98)
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
        MaterialComboBox1.Location = New Point(185, 120)
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
        MaterialLabel3.Location = New Point(185, 199)
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
        MaterialComboBox2.Location = New Point(185, 221)
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
        MaterialMultiLineTextBox21.Location = New Point(185, 324)
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
        MaterialLabel4.Location = New Point(185, 461)
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
        MaterialComboBox3.Items.AddRange(New Object() {"Not Started", "In Progress", "Done"})
        MaterialComboBox3.Location = New Point(185, 483)
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
        Label1.Location = New Point(286, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 36)
        Label1.TabIndex = 10
        Label1.Text = "Task Entry Form"
        ' 
        ' TaskEntry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 621)
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
End Class
