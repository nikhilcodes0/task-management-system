Imports Microsoft.Data.SqlClient

Public Class MenuBAr
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter
    Private Sub MenuBAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using con As New SqlConnection(constr)
            con.Open()
            Dim query As String = "select t.TaskID, u.Username, t.TaskDesc, t.TaskPriority, t.TaskStatus from Tasks t, Users u where t.UserID = u.UserID"

            cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)

            If dt.Rows.Count = 0 Then
                MaterialLabel1.Visible = "True"
            Else
                MaterialLabel1.Visible = "False"
                Guna2DataGridView1.DataSource = dt
            End If
        End Using
    End Sub

    Private Sub TaskEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskEntryToolStripMenuItem.Click
        TaskEntry.Show()
        Me.Close()
    End Sub

    Private Sub TaskDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskDetailsToolStripMenuItem.Click
        MyTasks.Show()
        Me.Close()
    End Sub


    Private Sub IncompleteTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncompleteTasksToolStripMenuItem.Click
        IncompleteTasks.Show()
        Me.Close()
    End Sub

    Private Sub CompletedTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompletedTasksToolStripMenuItem.Click
        CompletedTasks.Show()
        Me.Close()

    End Sub

    Private Sub TeamOverviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamOverviewToolStripMenuItem.Click
        UserProfile.Show()
        Me.Close()

    End Sub
End Class