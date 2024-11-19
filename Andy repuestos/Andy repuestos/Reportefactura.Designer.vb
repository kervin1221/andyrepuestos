<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportefactura
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Reportefactura))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(13, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 2
        Label1.Text = "Codigo de Factura"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(258, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 27)
        Button1.TabIndex = 3
        Button1.Text = "Buscar Factura"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(205, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(378, 42)
        Label2.TabIndex = 10
        Label2.Text = "Reporte de Facturas"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(645, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 27)
        Button2.TabIndex = 11
        Button2.Text = "Atras"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(385, 71)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 27)
        Button3.TabIndex = 12
        Button3.Text = "Limpiar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(497, 71)
        Button4.Name = "Button4"
        Button4.Size = New Size(142, 27)
        Button4.TabIndex = 14
        Button4.Text = "Imprimir Reporte"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 104)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(800, 346)
        DataGridView1.TabIndex = 15
        ' 
        ' Reportefactura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "Reportefactura"
        Text = "Andy Repuestos - Reporte de Facturas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents codigodefactura As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents fechadefacturacion As DataGridViewTextBoxColumn
    Friend WithEvents metododepago As DataGridViewTextBoxColumn
    Friend WithEvents productos As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents totalapagar As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
