Public Class LoginForm


    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        If (Username.Text = "admin" And Password.Text = "123") Then
            MenuBAr.Show()
        Else
            MsgBox("Incorrect Username Or Password")
        End If

    End Sub


End Class
