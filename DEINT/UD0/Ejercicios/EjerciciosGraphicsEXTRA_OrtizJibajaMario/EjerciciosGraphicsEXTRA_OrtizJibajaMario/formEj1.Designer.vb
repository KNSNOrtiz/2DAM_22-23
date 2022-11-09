<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEj1
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
        Me.components = New System.ComponentModel.Container()
        Me.pbxAvion = New System.Windows.Forms.PictureBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnAutoAbajo = New System.Windows.Forms.Button()
        Me.btnAutoDerecha = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxAvion
        '
        Me.pbxAvion.Image = Global.EjerciciosGraphicsEXTRA_OrtizJibajaMario.My.Resources.Resources.avion
        Me.pbxAvion.Location = New System.Drawing.Point(47, 72)
        Me.pbxAvion.Name = "pbxAvion"
        Me.pbxAvion.Size = New System.Drawing.Size(80, 51)
        Me.pbxAvion.TabIndex = 0
        Me.pbxAvion.TabStop = False
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(77, 369)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(94, 51)
        Me.btnAbajo.TabIndex = 1
        Me.btnAbajo.Text = "Mover hacia abajo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(210, 369)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(109, 51)
        Me.btnDerecha.TabIndex = 2
        Me.btnDerecha.Text = "Mover hacia la der."
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnAutoAbajo
        '
        Me.btnAutoAbajo.Location = New System.Drawing.Point(419, 349)
        Me.btnAutoAbajo.Name = "btnAutoAbajo"
        Me.btnAutoAbajo.Size = New System.Drawing.Size(157, 71)
        Me.btnAutoAbajo.TabIndex = 3
        Me.btnAutoAbajo.Text = "Mover automáticamente abajo"
        Me.btnAutoAbajo.UseVisualStyleBackColor = True
        '
        'btnAutoDerecha
        '
        Me.btnAutoDerecha.Location = New System.Drawing.Point(616, 349)
        Me.btnAutoDerecha.Name = "btnAutoDerecha"
        Me.btnAutoDerecha.Size = New System.Drawing.Size(157, 71)
        Me.btnAutoDerecha.TabIndex = 4
        Me.btnAutoDerecha.Text = "Mover automáticamente der."
        Me.btnAutoDerecha.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'formEj1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 457)
        Me.Controls.Add(Me.btnAutoDerecha)
        Me.Controls.Add(Me.btnAutoAbajo)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.pbxAvion)
        Me.Name = "formEj1"
        Me.Text = "Ejercicio 1: Avión | Mario Ortiz Jibaja"
        CType(Me.pbxAvion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxAvion As PictureBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnAutoAbajo As Button
    Friend WithEvents btnAutoDerecha As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
