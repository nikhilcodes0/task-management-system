Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class TaskEdit
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter
    Dim session As UserSession = UserSession.GetInstance()
    Dim userId As Integer = session.UserID
    Private Sub TaskEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New SqlConnection(constr)
            con.Open()
            Dim query As String = "select TaskID from Tasks where UserID='" & userid & "'"
            cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim dr1 As SqlDataReader
            dr1 = cmd.ExecuteReader
            Do While dr1.Read
                MaterialComboBox1.Items.Add(dr1("taskid"))
            Loop
            dr1.Close()

        End Using

    End Sub

    Function GetUserIDFromUsername(username As String)
        Using con As New SqlConnection(constr)
            Dim cmd4 As String = "select UserID from Users where Username = @Username"
            Using command As New SqlCommand(cmd4, con)
                command.Parameters.AddWithValue("@Username", username)
                con.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim userid As Integer? = GetUserIDFromUsername(MaterialComboBox2.Text)
        'MsgBox(userid)

        Using con As New SqlConnection(constr)
            con.Open()

            Dim cmd3 As String = "update Tasks set TaskDesc='" & MaterialMultiLineTextBox21.Text.ToString & "',UserID='" & userid & "',TaskStatus='" & MaterialComboBox3.Text.ToString & "',TaskPriority='" & MaterialComboBox4.Text & "'where TaskID='" & MaterialComboBox1.Text & "'"
            Using command As New SqlCommand(cmd3, con)
                command.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Close()
        MyTasks.Show()
    End Sub

    Private Sub MaterialComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialComboBox1.SelectedIndexChanged
        Using con As New SqlConnection(constr)
            con.ConnectionString = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
            con.Open()
            cmd.Connection = con

            Dim dr2 As SqlDataReader
            'Dim dr3 As SqlDataReader
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            cmd2.Connection = con
            cmd2.CommandText = "select u.UserID, u.Username, t.TaskDesc, t.TaskPriority, t.TaskStatus from Tasks t, Users u where t.TaskID=" & "(@taskid)"
            Dim parameterstate As New SqlParameter("@taskid", SqlDbType.Int)
            parameterstate.Direction = ParameterDirection.Input
            parameterstate.Value = MaterialComboBox1.SelectedItem
            cmd2.Parameters.Add(parameterstate)
            dr2 = cmd2.ExecuteReader
            'cmd3.CommandText = "select Username from Users where UserID='" & dr2("UserID") & "'"
            Do While dr2.Read
                MaterialMultiLineTextBox21.Text = dr2("TaskDesc")

                MaterialComboBox2.Items.Add(dr2("Username"))

            Loop
            dr2.Close()

        End Using
    End Sub
End Class