<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBAr
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
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MenuStrip1 = New MenuStrip()
        TaskDetailsToolStripMenuItem = New ToolStripMenuItem()
        TaskEntryToolStripMenuItem = New ToolStripMenuItem()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(341, 211)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(158, 36)
        MaterialButton1.TabIndex = 1
        MaterialButton1.Text = "MaterialButton1"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {TaskDetailsToolStripMenuItem, TaskEntryToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TaskDetailsToolStripMenuItem
        ' 
        TaskDetailsToolStripMenuItem.Name = "TaskDetailsToolStripMenuItem"
        TaskDetailsToolStripMenuItem.Size = New Size(79, 20)
        TaskDetailsToolStripMenuItem.Text = "Task Details"
        ' 
        ' TaskEntryToolStripMenuItem
        ' 
        TaskEntryToolStripMenuItem.Name = "TaskEntryToolStripMenuItem"
        TaskEntryToolStripMenuItem.Size = New Size(71, 20)
        TaskEntryToolStripMenuItem.Text = "Task Entry"
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(250, 332)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(100, 50)
        MaterialTextBox1.TabIndex = 3
        MaterialTextBox1.Text = ""
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' MenuBAr
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialTextBox1)
        Controls.Add(MaterialButton1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MenuBAr"
        Text = "MenuBAr"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TaskDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
End Class
