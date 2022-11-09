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
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblUnidades.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUnidades.Location = New System.Drawing.Point(60, 68)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(454, 28)
        Me.lblUnidades.TabIndex = 0
        Me.lblUnidades.Text = "Se pueden hacer entregas. Hay 1000 unidades."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 353)
        Me.Controls.Add(Me.lblUnidades)
        Me.MaximumSize = New System.Drawing.Size(800, 400)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "Form1"
        Me.Text = "Ejercicio 1: Control de vacunas | Mario Ortiz Jibaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnidades As Label
End Class
