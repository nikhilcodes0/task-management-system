Imports Microsoft.Data.SqlClient

Public Class IncompleteTasks
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim session As UserSession = UserSession.GetInstance()
    Dim userId As Integer = session.UserID
    Private Sub IncompleteTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabel1.Visible = False
        Using con As New SqlConnection(constr)
            con.Open()

            Dim query As String = "select TaskID, TaskDesc, TaskPriority, TaskStatus from Tasks where UserID='" & userid & "'and Not TaskStatus='Done'"
            cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count = 0 Then
                MaterialLabel1.Visible = True
                Guna2DataGridView1.Visible = False
            Else
                Guna2DataGridView1.DataSource = dt
            End If

        End Using
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Me.Close()
        TaskEdit.Show()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        MenuBAr.Show()
    End Sub
End Class