<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Menu))
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarEmpleadoToolStripMenuItem = New ToolStripMenuItem()
        BuscarProductoToolStripMenuItem = New ToolStripMenuItem()
        EmpleadosToolStripMenuItem = New ToolStripMenuItem()
        AgregarEmpleadoToolStripMenuItem1 = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeInventarioToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeFacturasToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeEToolStripMenuItem = New ToolStripMenuItem()
        Button2 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Label9 = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, ProductosToolStripMenuItem, EmpleadosToolStripMenuItem, ReportesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(709, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConfiguraciónToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' ConfiguraciónToolStripMenuItem
        ' 
        ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        ConfiguraciónToolStripMenuItem.Size = New Size(215, 22)
        ConfiguraciónToolStripMenuItem.Text = "Configuración del Servidor"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarEmpleadoToolStripMenuItem, BuscarProductoToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(67, 20)
        ProductosToolStripMenuItem.Text = "Registros"
        ' 
        ' AgregarEmpleadoToolStripMenuItem
        ' 
        AgregarEmpleadoToolStripMenuItem.Name = "AgregarEmpleadoToolStripMenuItem"
        AgregarEmpleadoToolStripMenuItem.Size = New Size(177, 22)
        AgregarEmpleadoToolStripMenuItem.Text = "Agregar Productos"
        ' 
        ' BuscarProductoToolStripMenuItem
        ' 
        BuscarProductoToolStripMenuItem.Name = "BuscarProductoToolStripMenuItem"
        BuscarProductoToolStripMenuItem.Size = New Size(177, 22)
        BuscarProductoToolStripMenuItem.Text = "Agregar Empleados"
        ' 
        ' EmpleadosToolStripMenuItem
        ' 
        EmpleadosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarEmpleadoToolStripMenuItem1, BuscarToolStripMenuItem})
        EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        EmpleadosToolStripMenuItem.Size = New Size(71, 20)
        EmpleadosToolStripMenuItem.Text = "Consultas"
        ' 
        ' AgregarEmpleadoToolStripMenuItem1
        ' 
        AgregarEmpleadoToolStripMenuItem1.Name = "AgregarEmpleadoToolStripMenuItem1"
        AgregarEmpleadoToolStripMenuItem1.Size = New Size(186, 22)
        AgregarEmpleadoToolStripMenuItem1.Text = "Consultar Productos"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(186, 22)
        BuscarToolStripMenuItem.Text = "Consultar Empleados"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReporteDeInventarioToolStripMenuItem, ReporteDeFacturasToolStripMenuItem, ReporteDeEToolStripMenuItem})
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(65, 20)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' ReporteDeInventarioToolStripMenuItem
        ' 
        ReporteDeInventarioToolStripMenuItem.Name = "ReporteDeInventarioToolStripMenuItem"
        ReporteDeInventarioToolStripMenuItem.Size = New Size(192, 22)
        ReporteDeInventarioToolStripMenuItem.Text = "Reporte de Inventario"
        ' 
        ' ReporteDeFacturasToolStripMenuItem
        ' 
        ReporteDeFacturasToolStripMenuItem.Name = "ReporteDeFacturasToolStripMenuItem"
        ReporteDeFacturasToolStripMenuItem.Size = New Size(192, 22)
        ReporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas"
        ' 
        ' ReporteDeEToolStripMenuItem
        ' 
        ReporteDeEToolStripMenuItem.Name = "ReporteDeEToolStripMenuItem"
        ReporteDeEToolStripMenuItem.Size = New Size(192, 22)
        ReporteDeEToolStripMenuItem.Text = "Reporte de Empleados"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(454, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(197, 52)
        Button2.TabIndex = 3
        Button2.Text = "Facturar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(59, 323)
        Button1.Name = "Button1"
        Button1.Size = New Size(197, 52)
        Button1.TabIndex = 4
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(629, 33)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 18)
        Label10.TabIndex = 26
        Label10.Text = "Fecha"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(558, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 18)
        Label9.TabIndex = 25
        Label9.Text = "Hora"
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(207, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 284)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(709, 406)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Andy Repuestos - Menu"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ReporteDeEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
