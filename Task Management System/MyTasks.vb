Imports Microsoft.Data.SqlClient

Public Class MyTasks

    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim constr As String = "Data Source=DESKTOP-49MOB3F;Initial Catalog=Task Management System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter
    Private Sub MyTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialLabel1.Visible = "False"
        Using con As New SqlConnection(constr)
            con.Open()
            'MsgBox(MaterialLabel1.Text)
            Dim query As String = "select * from Tasks where UserID='" & CInt(MaterialLabel1.Text) & "'"

            cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count = 0 Then
                ' Show the label indicating no tasks
                MaterialLabel2.Visible = True
                DataGridView1.Visible = False
            Else
                ' Hide the label if tasks exist
                DataGridView1.DataSource = dt
                DataGridView1.Columns("TaskDesc").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                MaterialLabel2.Visible = False
            End If

        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Me.Hide()
        MenuBAr.Show()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        TaskEdit.Show()
        Me.Hide()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub
End Class