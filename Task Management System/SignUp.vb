Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabel4.Visible = False
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If MaterialTextBox1.Text = "" Or MaterialTextBox2.Text = "" Or MaterialTextBox3.Text = "" Then
            MaterialLabel4.Visible = True
        ElseIf MaterialTextBox3.Text <> MaterialTextBox2.Text Then
            MaterialLabel4.Text = "Incorrect password in retype password field!"
        End If
    End Sub
End Class