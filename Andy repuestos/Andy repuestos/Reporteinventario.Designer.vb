<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporteinventario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Reporteinventario))
        Label1 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Amazon Ember Heavy", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(409, 46)
        Label1.TabIndex = 10
        Label1.Text = "Reporte de Inventario"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(620, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(168, 36)
        Button4.TabIndex = 31
        Button4.Text = "Atras"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(408, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 36)
        Button1.TabIndex = 32
        Button1.Text = "Imprimir Reporte"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(800, 385)
        DataGridView1.TabIndex = 33
        ' 
        ' Reporteinventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "Reporteinventario"
        Text = "Andy Repuestos - Reporte de Inventario Actual"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
