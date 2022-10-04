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
        Me.mitEjercicio1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnCalcularVolumen = New System.Windows.Forms.Button()
        Me.lblVolumen = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxEj1.SuspendLayout()
        Me.gbxEjercicio2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitEjercicio1, Me.Ejercicio2ToolStripMenuItem, Me.Ejercicio3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1452, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mitEjercicio1
        '
        Me.mitEjercicio1.Name = "mitEjercicio1"
        Me.mitEjercicio1.Size = New System.Drawing.Size(72, 20)
        Me.mitEjercicio1.Text = "Ejercicio 1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio 2"
        '
        'Ejercicio3ToolStripMenuItem
        '
        Me.Ejercicio3ToolStripMenuItem.Name = "Ejercicio3ToolStripMenuItem"
        Me.Ejercicio3ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Ejercicio3ToolStripMenuItem.Text = "Ejercicio 3"
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
        Me.gbxEj1.Location = New System.Drawing.Point(12, 27)
        Me.gbxEj1.Name = "gbxEj1"
        Me.gbxEj1.Size = New System.Drawing.Size(577, 387)
        Me.gbxEj1.TabIndex = 1
        Me.gbxEj1.TabStop = False
        Me.gbxEj1.Text = "Cálculo de necesidades combustible"
        Me.gbxEj1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(219, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Introduza estos datos"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(463, 315)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(107, 323)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(64, 15)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.Text = "Resultados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(85, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Capacidad de todoterrenos (litros):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(111, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Capacidad de turismos (litros):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(134, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número de todoterrenos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(159, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número de turismos: "
        '
        'txtCapTodoterr
        '
        Me.txtCapTodoterr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCapTodoterr.Location = New System.Drawing.Point(292, 254)
        Me.txtCapTodoterr.Name = "txtCapTodoterr"
        Me.txtCapTodoterr.Size = New System.Drawing.Size(131, 23)
        Me.txtCapTodoterr.TabIndex = 3
        '
        'txtCapTurismos
        '
        Me.txtCapTurismos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCapTurismos.Location = New System.Drawing.Point(292, 202)
        Me.txtCapTurismos.Name = "txtCapTurismos"
        Me.txtCapTurismos.Size = New System.Drawing.Size(131, 23)
        Me.txtCapTurismos.TabIndex = 2
        '
        'txtTodoterrenos
        '
        Me.txtTodoterrenos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTodoterrenos.Location = New System.Drawing.Point(292, 155)
        Me.txtTodoterrenos.Name = "txtTodoterrenos"
        Me.txtTodoterrenos.Size = New System.Drawing.Size(131, 23)
        Me.txtTodoterrenos.TabIndex = 1
        '
        'txtTurismos
        '
        Me.txtTurismos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTurismos.Location = New System.Drawing.Point(292, 112)
        Me.txtTurismos.Name = "txtTurismos"
        Me.txtTurismos.Size = New System.Drawing.Size(131, 23)
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
        Me.gbxEjercicio2.Location = New System.Drawing.Point(617, 38)
        Me.gbxEjercicio2.Name = "gbxEjercicio2"
        Me.gbxEjercicio2.Size = New System.Drawing.Size(596, 228)
        Me.gbxEjercicio2.TabIndex = 2
        Me.gbxEjercicio2.TabStop = False
        Me.gbxEjercicio2.Text = "Cálculo volumen cilindro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(38, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Introduzca el diámetro, en metros:"
        '
        'txtDiametro
        '
        Me.txtDiametro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtDiametro.Location = New System.Drawing.Point(264, 62)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(131, 23)
        Me.txtDiametro.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(58, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Introduzca la altura, en metros:"
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAltura.Location = New System.Drawing.Point(264, 104)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(131, 23)
        Me.txtAltura.TabIndex = 13
        '
        'btnCalcularVolumen
        '
        Me.btnCalcularVolumen.Location = New System.Drawing.Point(185, 147)
        Me.btnCalcularVolumen.Name = "btnCalcularVolumen"
        Me.btnCalcularVolumen.Size = New System.Drawing.Size(113, 29)
        Me.btnCalcularVolumen.TabIndex = 15
        Me.btnCalcularVolumen.Text = "Calcular Volumen"
        Me.btnCalcularVolumen.UseVisualStyleBackColor = True
        '
        'lblVolumen
        '
        Me.lblVolumen.AutoSize = True
        Me.lblVolumen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVolumen.Location = New System.Drawing.Point(96, 191)
        Me.lblVolumen.Name = "lblVolumen"
        Me.lblVolumen.Size = New System.Drawing.Size(62, 15)
        Me.lblVolumen.TabIndex = 16
        Me.lblVolumen.Text = "Resultado"
        '
        'winMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 769)
        Me.Controls.Add(Me.gbxEjercicio2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbxEj1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "winMain"
        Me.Text = "Ejercicio 3 | Mario Ortiz Jibaja"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxEj1.ResumeLayout(False)
        Me.gbxEj1.PerformLayout()
        Me.gbxEjercicio2.ResumeLayout(False)
        Me.gbxEjercicio2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mitEjercicio1 As ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio3ToolStripMenuItem As ToolStripMenuItem
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
End Class
