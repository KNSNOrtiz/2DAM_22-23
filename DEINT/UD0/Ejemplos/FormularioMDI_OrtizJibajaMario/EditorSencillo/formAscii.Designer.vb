<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAscii
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSimbolo = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.barraAscii = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(292, 59)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(101, 17)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Código ASCII"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSimbolo
        '
        Me.lblSimbolo.AutoSize = True
        Me.lblSimbolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSimbolo.Location = New System.Drawing.Point(336, 106)
        Me.lblSimbolo.Name = "lblSimbolo"
        Me.lblSimbolo.Size = New System.Drawing.Size(0, 48)
        Me.lblSimbolo.TabIndex = 1
        Me.lblSimbolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNumero.Location = New System.Drawing.Point(292, 219)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(94, 17)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Valor ASCII:"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'barraAscii
        '
        Me.barraAscii.Location = New System.Drawing.Point(157, 284)
        Me.barraAscii.Maximum = 255
        Me.barraAscii.Minimum = 1
        Me.barraAscii.Name = "barraAscii"
        Me.barraAscii.Size = New System.Drawing.Size(447, 26)
        Me.barraAscii.TabIndex = 3
        Me.barraAscii.Value = 1
        '
        'formAscii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.barraAscii)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblSimbolo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "formAscii"
        Me.Text = "Código ASCII"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSimbolo As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents barraAscii As HScrollBar
End Class
