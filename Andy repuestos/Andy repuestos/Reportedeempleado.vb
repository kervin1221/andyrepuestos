Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Reportedeempleado
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

    Private Sub limpiar()
        ' Función para limpiar el DataGridView y el TextBox
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
    End Sub
    Public Sub buscarfactura()
        ' Método para buscar empleados y mostrarlos en la base de datos
        Try
            If TextBox1.TextLength > 0 Then
                Dim consulta As String = "select * from [dbo].[empleados] where id = " + TextBox1.Text
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        imprimir()
    End Sub
    Private Sub imprimir()
        ' Crear el documento PDF
        Dim documento As New Document()

        ' Generar un nombre de archivo único usando un timestamp
        Dim filePath As String = $"Andy Repuestos - REPORTE DE EMPLEADO{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf"

        ' Crear el archivo PDF
        Using fs As New FileStream(filePath, FileMode.Create)
            PdfWriter.GetInstance(documento, fs)
            documento.Open()

            ' Agregar el contenido de la factura al documento PDF
            documento.Add(New Paragraph("
       ***** REPORTE DE EMPLEADO *****
                Andy Repuestos
"))
            documento.Add(New Paragraph($"Fecha: {DateTime.Now}"))
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim codigo = DataGridView1.Rows(0).Cells("id").Value
                    Dim nombre = DataGridView1.Rows(0).Cells("Nombre").Value
                    Dim apellido = DataGridView1.Rows(0).Cells("apellido").Value
                    Dim genero = DataGridView1.Rows(0).Cells("genero").Value
                    Dim fechadenacimiento = DataGridView1.Rows(0).Cells("fechadenacimiento").Value
                    Dim numerodetelefono = DataGridView1.Rows(0).Cells("numerodetelefono").Value
                    Dim correoelectronico = DataGridView1.Rows(0).Cells("correoelectronico").Value
                    Dim estadocivil = DataGridView1.Rows(0).Cells("estadocivil").Value
                    Dim cargo = DataGridView1.Rows(0).Cells("cargo").Value
                    Dim fechadecontratacion = DataGridView1.Rows(0).Cells("fechadecontratacion").Value
                    Dim salario = DataGridView1.Rows(0).Cells("salario").Value
                    Dim nombredeusuario = DataGridView1.Rows(0).Cells("nombredeusuario").Value
                    Dim contraseña = DataGridView1.Rows(0).Cells("contraseña").Value
                    documento.Add(New Paragraph(
    $"
        Codigo: {codigo}
                        
        Nombre: {nombre}
                        
        Apellido: {apellido}
                        
        Genero: {genero}
                        
        Fecha de Nacimiento: {fechadenacimiento}
                        
        Numero de telefono: {numerodetelefono}
                        
        Correo Electronico: {correoelectronico}
                        
        Estado Civil: {estadocivil}
                        
        Cargo: {cargo}
                        
        Fecha de contratacion: {fechadecontratacion}
                        
        Salario: {salario}
                        
        Nombre de Usuario: {nombredeusuario}
                        
        Contraseña: {contraseña}
    "
))
                End If

            Next

            ' Cerrar el documento
            documento.Close()
        End Using

        ' Abrir el documento PDF en Microsoft Edge
        Process.Start(New ProcessStartInfo(filePath) With {
        .UseShellExecute = True
    })
    End Sub
End Class