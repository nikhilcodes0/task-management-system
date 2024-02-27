Imports Microsoft.Data.SqlClient


Public Class TaskEntry

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    'Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    ' End Sub

    Private Sub TaskEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    'Private Sub MaterialTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaterialTextBox1.TextChanged

    'End Sub

    'Private Sub MaterialDrawer1_Click(sender As Object, e As EventArgs) Handles MaterialDrawer1.Click

    'End Sub
End Class