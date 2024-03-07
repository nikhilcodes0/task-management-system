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
                DataGridView1.DataSource = dt
            End If
        End Using
    End Sub

    Private Sub TaskEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskEntryToolStripMenuItem.Click
        TaskEntry.Show()
        Me.Hide()
    End Sub

    Private Sub TaskDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskDetailsToolStripMenuItem.Click
        MyTasks.Show()
        Me.Hide()
    End Sub
    'Private Sub MaterialTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaterialTextBox1.TextChanged

    'End Sub
    'Private Sub MenuBAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub Guna2ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Guna2ContextMenuStrip1.Opening

    'End Sub

    'Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

    'End Sub
End Class