Imports Microsoft.Data.SqlClient

Public Class SignUp
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabel4.Visible = False
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If MaterialTextBox1.Text = "" Or MaterialTextBox2.Text = "" Or MaterialTextBox3.Text = "" Then
            MaterialLabel4.Visible = True
        ElseIf MaterialTextBox3.Text = MaterialTextBox2.Text Then
            Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
            Using con As New SqlConnection(constr)
                con.Open()

                Dim q1 As String = "insert into Users values('" & MaterialTextBox1.Text.ToString & "','" & MaterialTextBox2.Text.ToString & "')"
                Using cmd As New SqlCommand(q1, con)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
            MaterialLabel4.Visible = True
            MaterialLabel4.Text = "You have successfully created a account!"

        Else
            MaterialLabel4.Visible = True
            MaterialLabel4.Text = "Incorrect password in retype password field!"
        End If
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        LoginForm.Show()

    End Sub
End Class