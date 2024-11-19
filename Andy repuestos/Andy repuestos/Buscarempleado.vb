Imports System.Data.SqlClient

Public Class Buscarempleado
    Dim conexion As New SqlConnection()
    Private Sub Buscarempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection($"Server={nombredelserver};Database={nombredelabasededatos};Integrated Security=True;")
    End Sub
    Private Sub BuscarEmpleado()
        Dim nombre = TextBox2.Text
        ' Método para buscar productos y mostrarlos en un DataGridView'
        If TextBox1.TextLength > 0 Or TextBox2.TextLength > 0 Then
            Dim consulta As String = "SELECT * FROM empleados WHERE id = @id OR nombre = @nombre"
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable

            Try
                conexion.Open()
                Dim comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@id", TextBox1.Text)
                comando.Parameters.AddWithValue("@nombre", nombre)


                adaptador.SelectCommand = comando
                adaptador.Fill(dt)
                DataGridView1.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al buscar el empleado: " & ex.Message)

            Finally
                conexion.Close()
            End Try
        Else
            MessageBox.Show("Por favor, ingresa un ID para borrar un empleado o el nombre")
        End If
    End Sub
    Private Sub BorrarEmpleado()
        ' Método para eliminar un producto por ID'
        If TextBox2.TextLength > 0 Or TextBox1.TextLength > 0 Then
            Dim nombre = TextBox2.Text
            Dim consulta As String = "DELETE FROM empleados WHERE id = @id OR nombre = @nombre"
            Dim comando As New SqlCommand(consulta, conexion)

            Try
                conexion.Open()
                comando.Parameters.AddWithValue("@id", TextBox1.Text)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.ExecuteNonQuery()
                MessageBox.Show("Empleado borrado correctamente.")

            Catch ex As Exception
                MessageBox.Show("Error al borrar el epmpleado: " & ex.Message)

            Finally
                conexion.Close()
            End Try
        Else
            MessageBox.Show("Por favor, ingresa un ID para borrar un empleaod o el nombre")
        End If
    End Sub
    Private Sub Limpiar()
        ' Método para limpiar el DataGridView y los TextBox'
        TextBox1.Clear()
        TextBox2.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorrarEmpleado()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarEmpleado()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reportedeempleado.Show()
        Reportedeempleado.TextBox1.Text = TextBox1.Text
    End Sub
End Class