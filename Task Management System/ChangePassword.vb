Imports Microsoft.Data.SqlClient

Public Class ChangePassword
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    'Dim adapter As New SqlDataAdapter
    Dim session As UserSession = UserSession.GetInstance()
    Dim userpwd As String

    Dim userId As Integer = session.UserID
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Using con As New SqlConnection(constr)
            con.Open()

            Dim query As String = "select UserPwd from Users where UserID='" & userId & "'"
            Using cmd As New SqlCommand(query, con)
                userpwd = cmd.ExecuteScalar()
            End Using


            If MaterialTextBox1.Text = userpwd Then
                If MaterialTextBox2.Text = MaterialTextBox3.Text Then
                    Dim query2 As String = "update Users set UserPwd='" & MaterialTextBox3.Text & "'where UserID='" & userId & "'"
                    Using cmd2 As New SqlCommand(query2, con)
                        cmd2.ExecuteNonQuery()
                        Label2.Visible = True
                        Label2.Text = "Password changed successfully!"
                    End Using
                Else
                    Label2.Visible = True
                    Label2.Text = "Please enter the same new password in both fields!"
                End If
            Else
                Label2.Visible = True
                Label2.Text = "You have entered wrong current password!"
            End If
        End Using
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        EditProfile.Show()
        Me.Close()
    End Sub
End Class