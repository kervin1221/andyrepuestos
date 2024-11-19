<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarproducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Agregarproducto))
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Amazon Ember Heavy", 24.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(19, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 41)
        Label1.TabIndex = 2
        Label1.Text = "Agregar Producto"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(12, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Nombre"
        TextBox1.Size = New Size(331, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(12, 123)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Precio"
        TextBox2.Size = New Size(331, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(12, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Cantidad Por Unidad"
        TextBox3.Size = New Size(331, 27)
        TextBox3.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(143, 213)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 7
        Label2.Text = "Fecha de Ingreso"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 8
        Label3.Text = "Categoria"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Filtros", "Frenos", "Baterías", "Llantas", "Encendido", "Aceites", "Suspensión", "Refrigeración", "Espejos", "Correas", "Termostatos", "Bombas de Agua", "Iluminación", "Embragues", "Alternadores", "Sensores", "Turbocompresores", "Limpiaparabrisas", "Ruedas de Repuesto", "Juntas", "Silenciadores", "Mangueras", "Pistones", "Bombas de Freno", "Catalizadores", "Tensores", "Cables Eléctricos", "Módulos", "Cajas de Cambios", "Bombas de Combustible", "Árboles de Levas", "Culatas", "Cárteres", "Reguladores de Voltaje", "Interruptores", "Cilindros de Embrague", "Dirección", "Transmisión", "Inyectores", "Escapes", "Rodamientos", "Admisión", "Varillas", "Soportes de Motor", "Válvulas EGR", "Sensores", "Tubos", "Motores de Arranque", "Cables de Acelerador", "Kits de Reparación", "Interruptores", "Cilindros de Freno", "Bombas de Agua"})
        ComboBox1.Location = New Point(12, 285)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(331, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(124, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 29)
        Button1.TabIndex = 10
        Button1.Text = "Limpiar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(223, 321)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 29)
        Button2.TabIndex = 11
        Button2.Text = "Agregar Producto"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 321)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 27)
        Button4.TabIndex = 12
        Button4.Text = "Atras"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Agregarproducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(355, 367)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(371, 406)
        MinimumSize = New Size(371, 406)
        Name = "Agregarproducto"
        Text = "Andy Repuetos - Agregar Producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
