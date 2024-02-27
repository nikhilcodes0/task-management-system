<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyTasks
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
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        DataGridView1 = New DataGridView()
        TaskID = New DataGridViewTextBoxColumn()
        TaskDesc = New DataGridViewTextBoxColumn()
        User = New DataGridViewTextBoxColumn()
        TaskStatus = New DataGridViewTextBoxColumn()
        TaskPriority = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        MaterialButton2.Location = New Point(447, 349)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(138, 36)
        MaterialButton2.TabIndex = 7
        MaterialButton2.Text = "Close"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(247, 349)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(125, 36)
        MaterialButton1.TabIndex = 6
        MaterialButton1.Text = "Edit"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {TaskID, TaskDesc, User, TaskStatus, TaskPriority})
        DataGridView1.Location = New Point(104, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(593, 143)
        DataGridView1.TabIndex = 5
        ' 
        ' TaskID
        ' 
        TaskID.HeaderText = "TaskID"
        TaskID.Name = "TaskID"
        ' 
        ' TaskDesc
        ' 
        TaskDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        TaskDesc.HeaderText = "Task Description"
        TaskDesc.Name = "TaskDesc"
        ' 
        ' User
        ' 
        User.HeaderText = "Assigned To"
        User.Name = "User"
        ' 
        ' TaskStatus
        ' 
        TaskStatus.HeaderText = "Task Status"
        TaskStatus.Name = "TaskStatus"
        ' 
        ' TaskPriority
        ' 
        TaskPriority.HeaderText = "Task Priority"
        TaskPriority.Name = "TaskPriority"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Underline)
        Label1.Location = New Point(319, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 41)
        Label1.TabIndex = 4
        Label1.Text = "My Tasks"
        ' 
        ' MyTasks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "MyTasks"
        Text = "MyTasks"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TaskID As DataGridViewTextBoxColumn
    Friend WithEvents TaskDesc As DataGridViewTextBoxColumn
    Friend WithEvents User As DataGridViewTextBoxColumn
    Friend WithEvents TaskStatus As DataGridViewTextBoxColumn
    Friend WithEvents TaskPriority As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
