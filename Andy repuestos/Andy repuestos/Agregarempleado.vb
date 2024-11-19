Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Agregarempleado
    ' Establece la cadena de conexión
    Dim connectionString As String = "server= " + nombredelserver + ";database= " + nombredelabasededatos + ";integrated security= true;"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Cierra el formulario
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Cadena SQL para insertar un nuevo registro
        Dim query As String = "INSERT INTO empleados (nombre, apellido, genero, fechadenacimiento, numerodetelefono, correoelectronico, estadocivil, cargo, fechadecontratacion, salario, nombredeusuario, contraseña) VALUES (@Nombre, @Apellido, @Genero, @FechaNacimiento, @NumeroTelefono, @CorreoElectronico, @EstadoCivil, @Cargo, @FechaContratacion, @Salario, @NombreUsuario, @Contraseña)"

        ' Crear la conexión a la base de datos
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Obtener los valores de los campos del formulario
            Dim nombre As String = TextBox1.Text
            Dim apellido As String = TextBox2.Text
            Dim genero As String = ComboBox1.Text
            Dim fechaNacimiento As Date = DateTimePicker1.Value
            Dim numeroTelefono As String = TextBox3.Text
            Dim correoElectronico As String = TextBox4.Text
            Dim estadoCivil As String = ComboBox2.Text
            Dim cargo As String = ComboBox3.Text
            Dim fechaContratacion As Date = DateTimePicker2.Value
            Dim salario As Decimal = Convert.ToDecimal(TextBox5.Text)
            Dim nombreUsuario As String = TextBox6.Text
            Dim contraseña As String = TextBox7.Text

            ' Abrir la conexión
            connection.Open()

            ' Crear el comando SQL
            Dim command As New SqlCommand(query, connection)

            ' Agregar parámetros para evitar inyección de SQL
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Apellido", apellido)
            command.Parameters.AddWithValue("@Genero", genero)
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            command.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono)
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico)
            command.Parameters.AddWithValue("@EstadoCivil", estadoCivil)
            command.Parameters.AddWithValue("@Cargo", cargo)
            command.Parameters.AddWithValue("@FechaContratacion", fechaContratacion)
            command.Parameters.AddWithValue("@Salario", salario)
            command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
            command.Parameters.AddWithValue("@Contraseña", contraseña)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Empleado agregado correctamente.")
        Catch ex As Exception
            ' Mostrar mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al agregar el empleado: " & ex.Message)
        Finally
            ' Cerrar la conexión y liberar recursos
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Limpiar todos los campos'
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        ComboBox1.Text = Nothing
        DateTimePicker1.Value = DateTime.Now
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        ComboBox2.Text = Nothing
        TextBox5.Text = Nothing
        DateTimePicker2.Value = DateTime.Now
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
    End Sub

    Private Sub Agregarempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class