Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Reporteinventario
    Dim connecion As New SqlConnection()

    Private Sub Reporteinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connecion = New SqlConnection("server= " + nombredelserver + ";database= " + nombredelabasededatos + ";integrated security= true;")
            Dim consulta As String = "select * from [dbo].[productos]"
            Dim adaptador As New SqlDataAdapter(consulta, connecion)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Hay un error de conexio con la base de datos")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Definir la ruta del archivo PDF
        Dim filePath As String = $"Reporte de inventario - andy repuestos.pdf"

        ' Crear un nuevo documento PDF
        Dim document As New iTextSharp.text.Document()
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
        document.Open()

        ' Crear una tabla con el mismo número de columnas que el DataGridView
        Dim table As New PdfPTable(DataGridView1.ColumnCount)
        document.Add(New Paragraph(
        $"
        REPORTE DE INVENTARIO - ANDY REPUESTOS

        FECHA: {DateTime.Now}

        "))
        ' Añadir encabezados de columna
        For Each column As DataGridViewColumn In DataGridView1.Columns
            table.AddCell(New Phrase(column.HeaderText))
        Next

        ' Añadir filas
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For ' Ignorar la fila vacía
            For Each cell As DataGridViewCell In row.Cells
                Dim cellValue As String = If(cell.Value Is Nothing, String.Empty, cell.Value.ToString())
                table.AddCell(New Phrase(cellValue))
            Next
        Next

        ' Añadir la tabla al documento y cerrar
        document.Add(table)
        document.Close()

        ' Abrir el archivo PDF
        Process.Start("explorer.exe", filePath)
    End Sub
End Class