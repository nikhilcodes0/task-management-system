Imports Microsoft.Data.SqlClient


Public Class TaskEntry

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    'Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    ' End Sub

    Private Sub TaskEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabel5.Visible = "False"
        con.ConnectionString = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select Username from Users"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            MaterialComboBox2.Items.Add(dr1("Username"))
        Loop
        dr1.Close()


    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim tpriority As String = MaterialComboBox1.Text
        Dim tstatus As String = MaterialComboBox3.Text
        Dim tuser As String = MaterialComboBox2.Text
        Dim tdesc As String = MaterialMultiLineTextBox21.Text
        Dim tuserid As Integer

        Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
        Using con As New SqlConnection(constr)
            con.Open()
            Dim q1 As String = "select UserID from Users where Username ='" & tuser & "'"
            Using cmd As New SqlCommand(q1, con)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    tuserid = Convert.ToInt32(result)
                End If
            End Using
            Dim q2 As String = "insert into Tasks values('" & tuserid & "','" & tdesc & "','" & tpriority & "','" & tstatus & "')"
            Using cmd2 As New SqlCommand(q2, con)
                cmd2.ExecuteNonQuery()
            End Using
        End Using
        MaterialLabel5.Visible = "True"
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        MenuBAr.Show()

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub


    'Private Sub MaterialTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaterialTextBox1.TextChanged

    'End Sub

    'Private Sub MaterialDrawer1_Click(sender As Object, e As EventArgs) Handles MaterialDrawer1.Click

    'End Sub
End Class