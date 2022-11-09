<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class winMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mitEjercicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEjercicio1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEjercicio2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEjercicio3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxEj1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCapTodoterr = New System.Windows.Forms.TextBox()
        Me.txtCapTurismos = New System.Windows.Forms.TextBox()
        Me.txtTodoterrenos = New System.Windows.Forms.TextBox()
        Me.txtTurismos = New System.Windows.Forms.TextBox()
        Me.gbxEjercicio2 = New System.Windows.Forms.GroupBox()
        Me.lblVolumen = New System.Windows.Forms.Label()
        Me.btnCalcularVolumen = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.gbxEj3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcularMedia = New System.Windows.Forms.Button()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecio3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecio1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxEj1.SuspendLayout()
        Me.gbxEjercicio2.SuspendLayout()
        Me.gbxEj3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitEjercicios, Me.mitSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mitEjercicios
        '
        Me.mitEjercicios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitEjercicio1, Me.mitEjercicio2, Me.mitEjercicio3})
        Me.mitEjercicios.Name = "mitEjercicios"
        Me.mitEjercicios.Size = New System.Drawing.Size(85, 24)
        Me.mitEjercicios.Text = "Ejercicios"
        '
        'mitEjercicio1
        '
        Me.mitEjercicio1.Name = "mitEjercicio1"
        Me.mitEjercicio1.Size = New System.Drawing.Size(224, 26)
        Me.mitEjercicio1.Text = "Ejercicio 1"
        '
        'mitEjercicio2
        '
        Me.mitEjercicio2.Name = "mitEjercicio2"
        Me.mitEjercicio2.Size = New System.Drawing.Size(224, 26)
        Me.mitEjercicio2.Text = "Ejercicio 2"
        '
        'mitEjercicio3
        '
        Me.mitEjercicio3.Name = "mitEjercicio3"
        Me.mitEjercicio3.Size = New System.Drawing.Size(224, 26)
        Me.mitEjercicio3.Text = "Ejercicio 3"
        '
        'mitSalir
        '
        Me.mitSalir.Name = "mitSalir"
        Me.mitSalir.Size = New System.Drawing.Size(52, 24)
        Me.mitSalir.Text = "Salir"
        '
        'gbxEj1
        '
        Me.gbxEj1.Controls.Add(Me.Label5)
        Me.gbxEj1.Controls.Add(Me.btnAceptar)
        Me.gbxEj1.Controls.Add(Me.lblResultado)
        Me.gbxEj1.Controls.Add(Me.Label4)
        Me.gbxEj1.Controls.Add(Me.Label3)
        Me.gbxEj1.Controls.Add(Me.Label2)
        Me.gbxEj1.Controls.Add(Me.Label1)
        Me.gbxEj1.Controls.Add(Me.txtCapTodoterr)
        Me.gbxEj1.Controls.Add(Me.txtCapTurismos)
        Me.gbxEj1.Controls.Add(Me.txtTodoterrenos)
        Me.gbxEj1.Controls.Add(Me.txtTurismos)
        Me.gbxEj1.Location = New System.Drawing.Point(14, 36)
        Me.gbxEj1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxEj1.Name = "gbxEj1"
        Me.gbxEj1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxEj1.Size = New System.Drawing.Size(659, 516)
        Me.gbxEj1.TabIndex = 1
        Me.gbxEj1.TabStop = False
        Me.gbxEj1.Text = "Cálculo de necesidades combustible"
        Me.gbxEj1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(250, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Introduza estos datos"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(488, 393)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 31)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(122, 431)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(81, 20)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.Text = "Resultados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(97, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Capacidad de todoterrenos (litros):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(127, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Capacidad de turismos (litros):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(153, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número de todoterrenos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(182, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número de turismos: "
        '
        'txtCapTodoterr
        '
        Me.txtCapTodoterr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCapTodoterr.Location = New System.Drawing.Point(356, 335)
        Me.txtCapTodoterr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapTodoterr.Name = "txtCapTodoterr"
        Me.txtCapTodoterr.Size = New System.Drawing.Size(149, 27)
        Me.txtCapTodoterr.TabIndex = 3
        '
        'txtCapTurismos
        '
        Me.txtCapTurismos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCapTurismos.Location = New System.Drawing.Point(356, 266)
        Me.txtCapTurismos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapTurismos.Name = "txtCapTurismos"
        Me.txtCapTurismos.Size = New System.Drawing.Size(149, 27)
        Me.txtCapTurismos.TabIndex = 2
        '
        'txtTodoterrenos
        '
        Me.txtTodoterrenos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTodoterrenos.Location = New System.Drawing.Point(350, 202)
        Me.txtTodoterrenos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTodoterrenos.Name = "txtTodoterrenos"
        Me.txtTodoterrenos.Size = New System.Drawing.Size(149, 27)
        Me.txtTodoterrenos.TabIndex = 1
        '
        'txtTurismos
        '
        Me.txtTurismos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTurismos.Location = New System.Drawing.Point(350, 146)
        Me.txtTurismos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTurismos.Name = "txtTurismos"
        Me.txtTurismos.Size = New System.Drawing.Size(149, 27)
        Me.txtTurismos.TabIndex = 0
        '
        'gbxEjercicio2
        '
        Me.gbxEjercicio2.Controls.Add(Me.lblVolumen)
        Me.gbxEjercicio2.Controls.Add(Me.btnCalcularVolumen)
        Me.gbxEjercicio2.Controls.Add(Me.Label7)
        Me.gbxEjercicio2.Controls.Add(Me.txtAltura)
        Me.gbxEjercicio2.Controls.Add(Me.Label6)
        Me.gbxEjercicio2.Controls.Add(Me.txtDiametro)
        Me.gbxEjercicio2.Location = New System.Drawing.Point(12, 36)
        Me.gbxEjercicio2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxEjercicio2.Name = "gbxEjercicio2"
        Me.gbxEjercicio2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxEjercicio2.Size = New System.Drawing.Size(683, 331)
        Me.gbxEjercicio2.TabIndex = 2
        Me.gbxEjercicio2.TabStop = False
        Me.gbxEjercicio2.Text = "Cálculo volumen cilindro"
        Me.gbxEjercicio2.Visible = False
        '
        'lblVolumen
        '
        Me.lblVolumen.AutoSize = True
        Me.lblVolumen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVolumen.Location = New System.Drawing.Point(110, 255)
        Me.lblVolumen.Name = "lblVolumen"
        Me.lblVolumen.Size = New System.Drawing.Size(79, 20)
        Me.lblVolumen.TabIndex = 16
        Me.lblVolumen.Text = "Resultado"
        '
        'btnCalcularVolumen
        '
        Me.btnCalcularVolumen.Location = New System.Drawing.Point(211, 196)
        Me.btnCalcularVolumen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcularVolumen.Name = "btnCalcularVolumen"
        Me.btnCalcularVolumen.Size = New System.Drawing.Size(155, 33)
        Me.btnCalcularVolumen.TabIndex = 15
        Me.btnCalcularVolumen.Text = "Calcular Volumen"
        Me.btnCalcularVolumen.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(66, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Introduzca la altura, en metros:"
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAltura.Location = New System.Drawing.Point(302, 139)
        Me.txtAltura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(149, 27)
        Me.txtAltura.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(43, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Introduzca el diámetro, en metros:"
        '
        'txtDiametro
        '
        Me.txtDiametro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDiametro.Location = New System.Drawing.Point(302, 83)
        Me.txtDiametro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(149, 27)
        Me.txtDiametro.TabIndex = 11
        '
        'gbxEj3
        '
        Me.gbxEj3.Controls.Add(Me.btnCalcularMedia)
        Me.gbxEj3.Controls.Add(Me.lblMedia)
        Me.gbxEj3.Controls.Add(Me.Label10)
        Me.gbxEj3.Controls.Add(Me.txtPrecio3)
        Me.gbxEj3.Controls.Add(Me.Label9)
        Me.gbxEj3.Controls.Add(Me.txtPrecio2)
        Me.gbxEj3.Controls.Add(Me.Label8)
        Me.gbxEj3.Controls.Add(Me.txtPrecio1)
        Me.gbxEj3.Location = New System.Drawing.Point(14, 36)
        Me.gbxEj3.Name = "gbxEj3"
        Me.gbxEj3.Size = New System.Drawing.Size(681, 413)
        Me.gbxEj3.TabIndex = 3
        Me.gbxEj3.TabStop = False
        Me.gbxEj3.Text = "Cálculo precio medio producto"
        Me.gbxEj3.Visible = False
        '
        'btnCalcularMedia
        '
        Me.btnCalcularMedia.Location = New System.Drawing.Point(248, 277)
        Me.btnCalcularMedia.Name = "btnCalcularMedia"
        Me.btnCalcularMedia.Size = New System.Drawing.Size(165, 29)
        Me.btnCalcularMedia.TabIndex = 7
        Me.btnCalcularMedia.Text = "Calcular precio medio"
        Me.btnCalcularMedia.UseVisualStyleBackColor = True
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMedia.Location = New System.Drawing.Point(151, 342)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(126, 20)
        Me.lblMedia.TabIndex = 6
        Me.lblMedia.Text = "Resultado media"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(29, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(384, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Introduzca el precio en establecimiento nº3, en euros:"
        '
        'txtPrecio3
        '
        Me.txtPrecio3.Location = New System.Drawing.Point(449, 202)
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecio3.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(29, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(384, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Introduzca el precio en establecimiento nº2, en euros:"
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Location = New System.Drawing.Point(449, 133)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecio2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(29, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Introduzca el precio en establecimiento nº1, en euros:"
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Location = New System.Drawing.Point(449, 64)
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecio1.TabIndex = 0
        '
        'winMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxEj3)
        Me.Controls.Add(Me.gbxEjercicio2)
        Me.Controls.Add(Me.gbxEj1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "winMain"
        Me.Text = "Ejercicio 3 | Mario Ortiz Jibaja"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxEj1.ResumeLayout(False)
        Me.gbxEj1.PerformLayout()
        Me.gbxEjercicio2.ResumeLayout(False)
        Me.gbxEjercicio2.PerformLayout()
        Me.gbxEj3.ResumeLayout(False)
        Me.gbxEj3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mitEjercicios As ToolStripMenuItem
    Friend WithEvents gbxEj1 As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCapTodoterr As TextBox
    Friend WithEvents txtCapTurismos As TextBox
    Friend WithEvents txtTodoterrenos As TextBox
    Friend WithEvents txtTurismos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gbxEjercicio2 As GroupBox
    Friend WithEvents lblVolumen As Label
    Friend WithEvents btnCalcularVolumen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiametro As TextBox
    Friend WithEvents gbxEj3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecio1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecio3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecio2 As TextBox
    Friend WithEvents lblMedia As Label
    Friend WithEvents btnCalcularMedia As Button
    Friend WithEvents mitEjercicio1 As ToolStripMenuItem
    Friend WithEvents mitEjercicio2 As ToolStripMenuItem
    Friend WithEvents mitEjercicio3 As ToolStripMenuItem
    Friend WithEvents mitSalir As ToolStripMenuItem
End Class
