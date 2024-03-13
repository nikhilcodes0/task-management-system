Imports Microsoft.Data.SqlClient

Public Class EditProfile
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    'Dim adapter As New SqlDataAdapter
    Dim session As UserSession = UserSession.GetInstance()
    Dim Username As string
    Dim userId As Integer = session.UserID
    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New SqlConnection(constr)
            con.Open()

            Dim query As String = "select Username from Users where UserID='" & userId & "'"
            cmd = New SqlCommand(query, con)
            Username = cmd.ExecuteScalar()
            Guna2HtmlLabel4.Text = Username
        End Using

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Using con As New SqlConnection(constr)
            con.Open()
            Dim query As String = "update Users set Username='" & Guna2TextBox1.Text & "'where Username='" & Username & "'"
            Using cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
            End Using
            Guna2HtmlLabel6.Visible = True
        End Using
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        UserProfile.Show()
        Me.Close()
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        ChangePassword.Show()
    End Sub
End Class