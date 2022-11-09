<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moj_formInfo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.moj_btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(166, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concesionario ""Visual"" Ortiz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección: Una calle de Granada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono: 123567890"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email: uncorreo@cualquiera.deporahi"
        '
        'moj_btnSalir
        '
        Me.moj_btnSalir.Location = New System.Drawing.Point(419, 181)
        Me.moj_btnSalir.Name = "moj_btnSalir"
        Me.moj_btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.moj_btnSalir.TabIndex = 4
        Me.moj_btnSalir.Text = "Salir"
        Me.moj_btnSalir.UseVisualStyleBackColor = True
        '
        'moj_formInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.moj_btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "moj_formInfo"
        Me.Text = "Información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents moj_btnSalir As Button
End Class
