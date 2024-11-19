Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Reportefactura
    Dim conexion As New SqlConnection()
    Private Sub Reportefactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server= " + nombredelserver + ";database= " + nombredelabasededatos + ";integrated security= true;")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscarfactura()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
    End Sub
    Public Sub buscarfactura()
        'Metodo para buscar empleados y mostrarlos en la base de datos-'
        Try
            If TextBox1.TextLength > 0 Then
                Dim consulta As String = "select * from [dbo].[facturas] where codigodefactura = " + TextBox1.Text
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                Dim dt As New DataTable
                adaptador.Fill(dt)
                DataGridView1.DataSource = dt
            Else
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Este campo solo admite datos de tipo numerico")
        End Try
    End Sub
    Private Sub limpiar()
        'Funcion para limpiar el datagridview y el textbox'
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Definir la ruta del archivo PDF
            Dim fileName As String = $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")} Reporte de factura - Andy Repuestos.pdf"
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)

            ' Crear un nuevo documento PDF
            Dim document As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
            document.Open()

            ' Añadir encabezado del documento
            document.Add(New Paragraph("***** REPORTE DE FACTURA *****" & vbCrLf & "Andy Repuestos"))
            document.Add(New Paragraph($"Fecha: {DateTime.Now}"))
            document.Add(New Paragraph(" "))

            ' Recorrer cada fila del DataGridView
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    ' Añadir los datos de la fila al documento
                    Dim codigo = row.Cells("codigodefactura").Value
                    Dim cliente = row.Cells("cliente").Value
                    Dim numerodetelefono = row.Cells("numerodetelefono").Value
                    Dim dniocedula = row.Cells("dniocedula").Value
                    Dim numerodecuenta = row.Cells("numerodecuenta").Value
                    Dim fechadefacturacion = row.Cells("fechadefacturacion").Value
                    Dim metododepago = row.Cells("metododepago").Value
                    Dim productos = row.Cells("productos").Value
                    Dim itbis = row.Cells("itbis").Value
                    Dim total = row.Cells("total").Value

                    document.Add(New Paragraph(
                    $"
                    Codigo de factura: {codigo}
                    Nombre del cliente: {cliente}
                    Numero de telefono: {numerodetelefono}
                    DNI o Cedula: {dniocedula}
                    Numero de Cuenta: {numerodecuenta}
                    Fecha de facturación: {fechadefacturacion}
                    Metodo de pago: {metododepago}
                    Productos: {productos}
                    Itbis: {itbis}
                    Total pagado: {total}
                    "
                ))
                    document.Add(New Paragraph(" "))
                End If
            Next

            ' Cerrar el documento
            document.Close()

            ' Abrir el archivo PDF
            Process.Start("explorer.exe", filePath)
        Catch ex As Exception
            MsgBox($"Algo salió mal, intenta de nuevo o reporta: {ex.Message}")
        End Try
    End Sub
End Class