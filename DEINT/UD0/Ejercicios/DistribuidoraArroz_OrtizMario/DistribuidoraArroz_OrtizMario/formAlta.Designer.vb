<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAlta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbC = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.imgPreview = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.imgPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Imagen:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 20)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtNombre.TabIndex = 3
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(80, 82)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(150, 23)
        Me.txtCapacidad.TabIndex = 4
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Checked = True
        Me.rdbA.Location = New System.Drawing.Point(91, 144)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(33, 19)
        Me.rdbA.TabIndex = 5
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "A"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Location = New System.Drawing.Point(130, 144)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(32, 19)
        Me.rdbB.TabIndex = 6
        Me.rdbB.Text = "B"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'rdbC
        '
        Me.rdbC.AutoSize = True
        Me.rdbC.Location = New System.Drawing.Point(168, 144)
        Me.rdbC.Name = "rdbC"
        Me.rdbC.Size = New System.Drawing.Size(33, 19)
        Me.rdbC.TabIndex = 7
        Me.rdbC.Text = "C"
        Me.rdbC.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(347, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Preview"
        '
        'imgPreview
        '
        Me.imgPreview.Location = New System.Drawing.Point(329, 55)
        Me.imgPreview.Name = "imgPreview"
        Me.imgPreview.Size = New System.Drawing.Size(100, 73)
        Me.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPreview.TabIndex = 9
        Me.imgPreview.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(285, 170)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(385, 170)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'formAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.imgPreview)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdbC)
        Me.Controls.Add(Me.rdbB)
        Me.Controls.Add(Me.rdbA)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formAlta"
        Me.Text = "Dar de alta un camión"
        CType(Me.imgPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents rdbA As RadioButton
    Friend WithEvents rdbB As RadioButton
    Friend WithEvents rdbC As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents imgPreview As PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
