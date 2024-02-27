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
        MenuStrip1 = New MenuStrip()
        TaskDetailsToolStripMenuItem = New ToolStripMenuItem()
        TaskEntryToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
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
        TaskDetailsToolStripMenuItem.Size = New Size(66, 20)
        TaskDetailsToolStripMenuItem.Text = "My Tasks"
        ' 
        ' TaskEntryToolStripMenuItem
        ' 
        TaskEntryToolStripMenuItem.Name = "TaskEntryToolStripMenuItem"
        TaskEntryToolStripMenuItem.Size = New Size(71, 20)
        TaskEntryToolStripMenuItem.Text = "Task Entry"
        ' 
        ' MenuBAr
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MenuBAr"
        Text = "MenuBAr"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TaskDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskEntryToolStripMenuItem As ToolStripMenuItem
End Class
