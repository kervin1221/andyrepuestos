Imports System.Data.SqlClient

Public Class Login
    Private connectionString As String = "server=" & nombredelserver & ";database=" & nombredelabasededatos & ";integrated security=true;"

    Public Function ValidateUser(username As String, password As String) As Boolean
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(1) FROM empleados WHERE nombredeusuario = @username AND contraseña = @password"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Try
                conn.Open()
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return result = 1
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If ValidateUser(username, password) Then
            Menu.Show()
            Me.Hide()
            ' Aquí puedes proceder a la siguiente forma o funcionalidad
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Configuracion.Show()
    End Sub
End Class