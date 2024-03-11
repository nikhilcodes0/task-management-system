Imports Microsoft.Data.SqlClient

Public Class MyTasks

    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter
    Dim session As UserSession = UserSession.GetInstance()
    Dim userId As Integer = session.UserID
    Private Sub MyTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using con As New SqlConnection(constr)
            con.Open()
            'MsgBox(MaterialLabel1.Text)
            Dim query As String = "select * from Tasks where UserID='" & userId & "'"

            cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count = 0 Then
                ' Show the label indicating no tasks
                MaterialLabel2.Visible = True
                Guna2DataGridView1.Visible = False
            Else
                ' Hide the label if tasks exist
                Guna2DataGridView1.DataSource = dt

                MaterialLabel2.Visible = False
            End If

        End Using
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        MenuBAr.Show()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        TaskEdit.Show()
        Me.Close()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click

    End Sub
End Class