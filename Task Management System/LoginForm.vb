Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class LoginForm
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        Try
            Using con As New SqlConnection(constr)
                con.Open()
                Dim query = "SELECT UserID FROM Users WHERE Username='" & Username.Text & "'AND UserPwd='" & Password.Text & "'"

                cmd = New SqlCommand(query, con)
                adapter = New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim userID As Integer = cmd.ExecuteScalar()
                    Dim loggedInUserID = userID
                    MyTasks.MaterialLabel1.Text = loggedInUserID
                    MenuBAr.Show()

                    'Me.Hide()

                Else
                    MessageBox.Show("Invalid Username or Password!")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        SignUp.Show()
        Me.Hide()
    End Sub
End Class
