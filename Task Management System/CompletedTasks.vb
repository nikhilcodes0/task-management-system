Imports MaterialSkin.Controls
Imports Microsoft.Data.SqlClient

Public Class CompletedTasks
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim session As UserSession = UserSession.GetInstance()
    Dim userId As Integer = session.UserID
    Private Sub CompletedTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using con As New SqlConnection(constr)
            con.Open()

            Dim query As String = "select TaskID, TaskDesc, TaskPriority, TaskStatus from Tasks where UserID='" & userId & "'and TaskStatus='Done'"
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

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        MenuBAr.Show()
        Me.Close()

    End Sub
End Class