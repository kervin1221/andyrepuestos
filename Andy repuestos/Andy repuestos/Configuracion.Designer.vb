<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Configuracion))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(13, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(13, 99)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(261, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("AmazonEmber-Bold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(47, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 40)
        Label1.TabIndex = 2
        Label1.Text = "Configuración"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("AmazonEmber-Regular", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(13, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre Del Servidor"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(141, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 37)
        Button1.TabIndex = 4
        Button1.Text = "Guardar Cambios"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 202)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 37)
        Button2.TabIndex = 5
        Button2.Text = "Salir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("AmazonEmber-Regular", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(13, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 20)
        Label3.TabIndex = 6
        Label3.Text = "Nombre de la Base de Datos"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(12, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(297, 138)
        Panel1.TabIndex = 8
        ' 
        ' Configuracion
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 251)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Amazon Ember Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(340, 290)
        MinimumSize = New Size(340, 290)
        Name = "Configuracion"
        Text = "Andy Repuestos - Configuración"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
