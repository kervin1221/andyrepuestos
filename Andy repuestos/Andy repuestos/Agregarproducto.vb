Imports System.Data.SqlClient

Public Class Agregarproducto
    ' Establece la cadena de conexión
    Dim connectionString As String = "server= " + nombredelserver + ";database= " + nombredelabasededatos + ";integrated security= true;"

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Cierra el formulario
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Lipia todo'
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Cadena SQL para insertar un nuevo registro
        Dim query As String = "INSERT INTO productos (nombre, precio, stock, fecha_ingreso, categoria) VALUES (@Nombre, @Precio, @Cantidad, @FechaIngreso, @Categoria)"

        ' Crear la conexión a la base de datos
        Dim connection As New SqlConnection(connectionString)
        Try
            ' Obtiene los valores de los campos del formulario
            Dim nombre As String = TextBox1.Text
            Dim precio As Decimal = Convert.ToDecimal(TextBox2.Text)
            Dim cantidad As Integer = Convert.ToInt32(TextBox3.Text)
            Dim fechaIngreso As Date = Date.Parse(DateTimePicker1.Text)
            Dim categoria As String = ComboBox1.Text
            ' Abrir la conexión
            connection.Open()

            ' Crear el comando SQL
            Dim command As New SqlCommand(query, connection)

            ' Agregar parámetros para evitar inyección de SQL
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Precio", precio)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso)
            command.Parameters.AddWithValue("@Categoria", categoria)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Producto agregado correctamente.")
        Catch ex As Exception
            ' Mostrar mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        Finally
            ' Cerrar la conexión y liberar recursos
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Dispose()
        End Try
    End Sub
End Class