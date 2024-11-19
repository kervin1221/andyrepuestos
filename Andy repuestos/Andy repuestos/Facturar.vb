Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Facturar
    ' Establece la cadena de conexión
    Dim connectionString As String = "server= " + nombredelserver + ";database= " + nombredelabasededatos + ";integrated security= true;"
    Dim connecion As New SqlConnection()
    Dim table As New DataTable()

    Private Sub Facturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connecion = New SqlConnection(connectionString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Cierra el formulario
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reportefactura.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim idProducto As Integer
            If Integer.TryParse(TextBox3.Text, idProducto) Then
                Dim query As String = "SELECT * FROM Productos WHERE id = @IDProducto"
                Dim cmd As New SqlCommand(query, connecion)
                cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim newTable As New DataTable()
                adapter.Fill(newTable)

                If newTable.Rows.Count > 0 Then
                    ' Si se encontró el producto, lo agregamos al DataTable existente
                    table.Merge(newTable)

                    ' Verificamos si la columna "Cantidad" existe en el DataTable
                    If Not table.Columns.Contains("Cantidad") Then
                        table.Columns.Add("Cantidad", GetType(Integer)) ' Añadimos la columna "Cantidad" si no existe
                    End If

                    ' Establecemos el valor de la columna "Cantidad" como el contenido del campo de texto TextBox9
                    Dim cantidad As Integer = 1 ' Establecemos la cantidad por defecto como 1
                    If Not String.IsNullOrWhiteSpace(TextBox9.Text) Then ' Verificamos si TextBox9 tiene un valor
                        If Not Integer.TryParse(TextBox9.Text, cantidad) Then ' Intentamos convertir el valor de TextBox9 a un entero
                            MessageBox.Show("Por favor ingresa una cantidad válida.")
                            Return
                        End If
                    End If

                    Dim newRow As DataRow = table.Rows(table.Rows.Count - 1)
                    newRow("Cantidad") = cantidad
                    Dim precioUnitario As Double = CDbl(newRow("Precio"))
                    Dim precioTotal As Double = cantidad * precioUnitario

                    ' Actualizamos el DataSource del DataGridView
                    DataGridView1.DataSource = table

                    ' Calculamos el total acumulado
                    Dim precioTotalAcumulado As Double = 0
                    For Each row As DataRow In table.Rows
                        precioTotalAcumulado += CInt(row("Cantidad")) * CDbl(row("Precio"))
                    Next

                    TextBox5.Text = precioTotalAcumulado.ToString("F2") ' Mostramos el total acumulado con dos decimales

                    ' Calculamos el IVA (18%) y el total final
                    Dim iva As Double = precioTotalAcumulado * 0.18
                    TextBox4.Text = iva.ToString("F2")

                    Dim totalFinal As Double = precioTotalAcumulado + iva
                    TextBox1.Text = totalFinal.ToString("F2")
                Else
                    MessageBox.Show("No se encontró ningún producto con ese ID.")
                End If
            Else
                MessageBox.Show("Por favor ingresa un ID de producto válido.")
            End If
        Catch ex As Exception
            MsgBox("Algo fue mal, intentalo de nuevo")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Tarjeta" AndAlso (TextBox6.Text.Trim() = "" OrElse TextBox8.Text.Trim() = "") Then
            MessageBox.Show("Por favor, rellene los campos de cédula y número de cuenta para pagos con tarjeta.")
            Return
        End If
        Dim datosConcatenados As New StringBuilder()

        ' Iniciar una transacción SQL
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    ' Iterar a través de las filas del DataGridView
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.IsNewRow Then Continue For ' Ignorar la fila de nueva entrada

                        ' Recuperar los valores de las columnas
                        Dim idProducto As Integer = CInt(row.Cells("ID").Value)
                        Dim nombre As String = row.Cells("Nombre").Value.ToString()
                        Dim precio As Decimal = Decimal.Parse(row.Cells("Precio").Value.ToString())
                        Dim cantidad As Integer = CInt(row.Cells("Cantidad").Value)

                        ' Concatenar los valores con un delimitador, por ejemplo, una coma
                        datosConcatenados.Append($"{nombre},{precio},{cantidad};")

                        ' Actualizar la cantidad en la tabla de productos
                        actualizarInventario(idProducto, cantidad, connection, transaction)
                    Next

                    ' Eliminar el último delimitador
                    If datosConcatenados.Length > 0 Then
                        datosConcatenados.Length -= 1 ' Eliminar el último ';'
                    End If

                    ' Validar y convertir los valores de los TextBox
                    Dim numerodetelefono As String = TextBox7.Text
                    Dim dniocedula As String = TextBox6.Text
                    Dim numerodecuenta As String = TextBox8.Text
                    Dim itbis As Decimal
                    Dim total As Decimal

                    If Not Decimal.TryParse(TextBox4.Text, itbis) Then Throw New Exception("ITBIS inválido.")
                    If Not Decimal.TryParse(TextBox1.Text, total) Then Throw New Exception("Total inválido.")

                    ' Guardar los datos concatenados en la base de datos
                    guardarenbasededatos(TextBox2.Text, numerodetelefono, dniocedula, numerodecuenta, DateTime.Now, ComboBox1.Text, datosConcatenados.ToString(), itbis, total, connection, transaction)

                    ' Confirmar la transacción
                    transaction.Commit()

                    MessageBox.Show("Factura guardada y productos actualizados correctamente.")
                    imprimir()
                Catch ex As Exception
                    ' En caso de error, deshacer la transacción
                    transaction.Rollback()
                    MessageBox.Show("Ocurrió un error, se deshicieron los cambios: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub guardarenbasededatos(cliente As String, numerodetelefono As String, dniocedula As String, numerodecuenta As String, fechadefacturacion As Date, metododepago As String, productos As String, itbis As Decimal, total As Decimal, connection As SqlConnection, transaction As SqlTransaction)
        Dim query As String = "INSERT INTO facturas (cliente, numerodetelefono, dniocedula, numerodecuenta, fechadefacturacion, metododepago, productos, itbis, total) VALUES (@cliente, @numerodetelefono, @dniocedula, @numerodecuenta, @fechadefacturacion, @metododepago, @productos, @itbis, @total)"

        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@cliente", cliente)
            command.Parameters.AddWithValue("@numerodetelefono", numerodetelefono)
            command.Parameters.AddWithValue("@dniocedula", dniocedula)
            command.Parameters.AddWithValue("@numerodecuenta", numerodecuenta)
            command.Parameters.AddWithValue("@fechadefacturacion", fechadefacturacion)
            command.Parameters.AddWithValue("@metododepago", metododepago)
            command.Parameters.AddWithValue("@productos", productos)
            command.Parameters.AddWithValue("@itbis", itbis)
            command.Parameters.AddWithValue("@total", total)

            command.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub actualizarInventario(idProducto As Integer, cantidadVendida As Integer, connection As SqlConnection, transaction As SqlTransaction)
        Try
            ' Actualizar la cantidad en la tabla de productos
            Dim query As String = "UPDATE Productos SET stock = stock - @CantidadVendida WHERE id = @IDProducto"

            Using command As New SqlCommand(query, connection, transaction)
                command.Parameters.AddWithValue("@CantidadVendida", cantidadVendida)
                command.Parameters.AddWithValue("@IDProducto", idProducto)

                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al actualizar el inventario: " & ex.Message)
            Throw ' Vuelve a lanzar la excepción para ser capturada por el bloque Try-Catch principal
        End Try
    End Sub
    Private Sub imprimir()
        ' Crear el documento PDF
        Dim documento As New Document()

        ' Generar un nombre de archivo único usando un timestamp
        Dim filePath As String = $"Factura - Andy Repuestos{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf"
        Dim rowdd = 0
        ' Crear el archivo PDF
        Using fs As New FileStream(filePath, FileMode.Create)
            PdfWriter.GetInstance(documento, fs)
            documento.Open()

            ' Agregar el contenido de la factura al documento PDF
            documento.Add(New Paragraph("
            ***** Factura *****
                Andy Repuestos
"))
            documento.Add(New Paragraph($"Fecha: {DateTime.Now}"))
            documento.Add(New Paragraph($"Cliente: {TextBox2.Text}"))
            documento.Add(New Paragraph($"Productos"))
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then

                    Dim nombre As String = DataGridView1.Rows(rowdd).Cells("Nombre").Value.ToString()
                    Dim cantidad As Integer = CInt(DataGridView1.Rows(rowdd).Cells("Cantidad").Value)
                    Dim precio As Double = CDbl(DataGridView1.Rows(rowdd).Cells("Precio").Value)
                    documento.Add(New Paragraph($"{nombre} ${precio} {cantidad}"))
                    rowdd += 1
                End If
            Next
            rowdd = 0
            Dim subtotal As Double
            Dim itbis As Double
            Dim total As Double
            If Double.TryParse(TextBox5.Text, subtotal) Then
                documento.Add(New Paragraph($"Sub Total: ${subtotal}"))
            End If
            If Double.TryParse(TextBox4.Text, itbis) Then
                documento.Add(New Paragraph($"Itbis: ${itbis}"))
            End If
            If Double.TryParse(TextBox1.Text, total) Then
                documento.Add(New Paragraph($"Total: ${total}"))
            End If

            ' Cerrar el documento
            documento.Close()
        End Using


        'funcion para la vista previa------------------------
        ' Abrir el documento PDF en Microsoft Edge
        Process.Start(New ProcessStartInfo(filePath) With {
        .UseShellExecute = True
    })
    End Sub
    Private Sub Limpiar()
        ComboBox1.Text = ""
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
        DataGridView1.DataSource = Nothing
        TextBox8.Clear()
        TextBox9.Clear()
        table.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
    End Sub
End Class
