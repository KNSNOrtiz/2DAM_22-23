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
        Me.btnLineas = New System.Windows.Forms.Button()
        Me.btnRectangulos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLineas
        '
        Me.btnLineas.Location = New System.Drawing.Point(56, 226)
        Me.btnLineas.Name = "btnLineas"
        Me.btnLineas.Size = New System.Drawing.Size(134, 31)
        Me.btnLineas.TabIndex = 0
        Me.btnLineas.Text = "Líneas"
        Me.btnLineas.UseVisualStyleBackColor = True
        '
        'btnRectangulos
        '
        Me.btnRectangulos.Location = New System.Drawing.Point(295, 226)
        Me.btnRectangulos.Name = "btnRectangulos"
        Me.btnRectangulos.Size = New System.Drawing.Size(146, 57)
        Me.btnRectangulos.TabIndex = 1
        Me.btnRectangulos.Text = "Rectángulos y elipses"
        Me.btnRectangulos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRectangulos)
        Me.Controls.Add(Me.btnLineas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLineas As Button
    Friend WithEvents btnRectangulos As Button
End Class
