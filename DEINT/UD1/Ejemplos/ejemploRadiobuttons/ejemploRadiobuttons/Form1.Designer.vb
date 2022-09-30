<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radRango = New System.Windows.Forms.RadioButton()
        Me.radHoy = New System.Windows.Forms.RadioButton()
        Me.radAno = New System.Windows.Forms.RadioButton()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRango)
        Me.GroupBox1.Controls.Add(Me.radHoy)
        Me.GroupBox1.Controls.Add(Me.radAno)
        Me.GroupBox1.Location = New System.Drawing.Point(158, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccion informe"
        '
        'radRango
        '
        Me.radRango.AutoSize = True
        Me.radRango.Location = New System.Drawing.Point(19, 86)
        Me.radRango.Name = "radRango"
        Me.radRango.Size = New System.Drawing.Size(140, 24)
        Me.radRango.TabIndex = 2
        Me.radRango.TabStop = True
        Me.radRango.Text = "Rango de fechas"
        Me.radRango.UseVisualStyleBackColor = True
        '
        'radHoy
        '
        Me.radHoy.AutoSize = True
        Me.radHoy.Location = New System.Drawing.Point(19, 56)
        Me.radHoy.Name = "radHoy"
        Me.radHoy.Size = New System.Drawing.Size(57, 24)
        Me.radHoy.TabIndex = 1
        Me.radHoy.TabStop = True
        Me.radHoy.Text = "Hoy"
        Me.radHoy.UseVisualStyleBackColor = True
        '
        'radAno
        '
        Me.radAno.AutoSize = True
        Me.radAno.Location = New System.Drawing.Point(19, 26)
        Me.radAno.Name = "radAno"
        Me.radAno.Size = New System.Drawing.Size(101, 24)
        Me.radAno.TabIndex = 0
        Me.radAno.TabStop = True
        Me.radAno.Text = "Año actual"
        Me.radAno.UseVisualStyleBackColor = True
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(226, 258)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(182, 27)
        Me.txtDesde.TabIndex = 1
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(226, 291)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(182, 27)
        Me.txtHasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(529, 153)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejemplo: Informe con Radiobuttons"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radRango As RadioButton
    Friend WithEvents radHoy As RadioButton
    Friend WithEvents radAno As RadioButton
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSalir As Button
End Class
