Imports Microsoft.Data.SqlClient

Public Class UserProfile
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    'Dim adapter As New SqlDataAdapter
    Dim session As UserSession = UserSession.GetInstance()
    Dim Username As String
    Dim userId As Integer = session.UserID
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New SqlConnection(constr)
            con.Open()
            Dim query As String = "select Username from Users where UserID='" & userId & "'"
            Dim query2 As String = "select count(TaskID) from Tasks where TaskStatus = 'Done' and UserID = '" & userId & "'"
            Dim query3 As String = "select count(TaskID) from Tasks where Not TaskStatus = 'Done' and UserID = '" & userId & "'"
            Using cmd As New SqlCommand(query, con)
                Guna2HtmlLabel2.Text = cmd.ExecuteScalar()
            End Using
            Using cmd2 As New SqlCommand(query2, con)
                Guna2HtmlLabel3.Text = cmd2.ExecuteScalar()
            End Using
            Using cmd3 As New SqlCommand(query3, con)
                Guna2HtmlLabel5.Text = cmd3.ExecuteScalar()
            End Using
        End Using
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        EditProfile.Show()
        Me.Close()
    End Sub
End Class