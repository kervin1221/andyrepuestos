<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturar
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Facturar))
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Label7 = New Label()
        Label6 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Label2 = New Label()
        TextBox9 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 43)
        Label1.TabIndex = 1
        Label1.Text = "Facturar Compra"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 163)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(548, 245)
        DataGridView1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 47)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Nombre del Cliente"
        TextBox2.Size = New Size(283, 23)
        TextBox2.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        ComboBox1.Location = New Point(301, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(249, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(301, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 9
        Label4.Text = "Metodo de Pago"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(554, 416)
        Button2.Name = "Button2"
        Button2.Size = New Size(227, 28)
        Button2.TabIndex = 14
        Button2.Text = "Facturar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(420, 416)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 28)
        Button3.TabIndex = 15
        Button3.Text = "Atras"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(281, 416)
        Button4.Name = "Button4"
        Button4.Size = New Size(133, 28)
        Button4.TabIndex = 16
        Button4.Text = "Limpiar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(601, 345)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 33
        Label7.Text = "Itbis"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(567, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 32
        Label6.Text = "Sub Total"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(655, 305)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(126, 27)
        TextBox5.TabIndex = 31
        TextBox5.WordWrap = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(655, 338)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(126, 27)
        TextBox4.TabIndex = 30
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(301, 98)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(147, 27)
        TextBox3.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(554, 374)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 28
        Label5.Text = "Total a Pagar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(301, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 20)
        Label3.TabIndex = 27
        Label3.Text = "Codigo del Producto"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(301, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(249, 28)
        Button1.TabIndex = 26
        Button1.Text = "Agregar Producto"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(655, 371)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(126, 27)
        TextBox1.TabIndex = 25
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(12, 105)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "DNI o Cedula"
        TextBox6.Size = New Size(283, 23)
        TextBox6.TabIndex = 34
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(12, 76)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Numero de Telefono"
        TextBox7.Size = New Size(283, 23)
        TextBox7.TabIndex = 35
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(12, 134)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Numero de Cuenta"
        TextBox8.Size = New Size(283, 23)
        TextBox8.TabIndex = 36
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(465, -91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(406, 378)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(12, 416)
        Button5.Name = "Button5"
        Button5.Size = New Size(260, 28)
        Button5.TabIndex = 38
        Button5.Text = "Crear Reporte de Factura"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(454, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 39
        Label2.Text = "Cantidad"
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox9.Location = New Point(454, 98)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(96, 27)
        TextBox9.TabIndex = 40
        ' 
        ' Facturar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(789, 450)
        Controls.Add(TextBox9)
        Controls.Add(Label2)
        Controls.Add(Button5)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(805, 489)
        MinimumSize = New Size(805, 489)
        Name = "Facturar"
        Text = "Andy Repuestos - Facturar"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
End Class
