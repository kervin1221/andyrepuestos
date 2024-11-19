
Public Class Menu
    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        Agregarproducto.Show()
    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProductoToolStripMenuItem.Click
        Agregarempleado.Show()
    End Sub

    Private Sub AgregarEmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem1.Click
        buscarproducto.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Buscarempleado.Show()
    End Sub

    Private Sub ReporteDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeInventarioToolStripMenuItem.Click
        Reporteinventario.Show()
    End Sub

    Private Sub ReporteDeFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeFacturasToolStripMenuItem.Click
        Reportefactura.Show()
    End Sub

    Private Sub ReporteDeEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEToolStripMenuItem.Click
        Reportedeempleado.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Facturar.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
            Login.Close()
        End If
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Llama a Application.Exit() para cerrar la aplicación completamente.
        Application.Exit()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub

    Private Sub UpdateTime()
        Dim horaActual As DateTime = DateTime.Now
        Label9.Text = horaActual.ToString("HH:mm")
        Label10.Text = horaActual.ToString("dd/MM/yy")
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Configuracion.Show()
    End Sub
End Class