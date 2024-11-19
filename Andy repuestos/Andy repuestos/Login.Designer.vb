<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 123)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Nombre de Usuario"
        TextBox1.Size = New Size(260, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 160)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Contraseña"
        TextBox2.Size = New Size(260, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(52, 193)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 36)
        Button1.TabIndex = 2
        Button1.Text = "Iniciar Sesión"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(69, 232)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(148, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Configuracion del Servidor"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ed9Suw3iQ0_owGIOUs6pjA_removebg_preview1
        PictureBox1.Location = New Point(44, -12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 158)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(284, 281)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(300, 320)
        MinimumSize = New Size(300, 320)
        Name = "Login"
        Text = "Andy Repuestos - Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
