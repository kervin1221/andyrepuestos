Module variables
    Public nombredelserver As String = My.Settings.sever
    Public nombredelabasededatos As String = My.Settings.basedatos
End Module
Public Class Configuracion
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = nombredelserver
        TextBox2.Text = nombredelabasededatos
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text <> nombredelserver Or TextBox2.Text <> nombredelabasededatos Then
                nombredelserver = TextBox1.Text
                nombredelabasededatos = TextBox2.Text
                'guargar en la configuracion'
                My.Settings.sever = nombredelserver
                My.Settings.basedatos = nombredelabasededatos
                'guardar los cambios'
                My.Settings.Save()
                MsgBox("Se guardaron los cambios")
            End If
        Catch ex As Exception
            MsgBox("Algo no fue bien con el sistema, Reporte el fallo")
        End Try
        TextBox1.Text = nombredelserver
        TextBox2.Text = nombredelabasededatos
    End Sub
End Class