<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditar))
        Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolColor = New System.Windows.Forms.ToolStripButton()
        Me.toolFuente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolSeleccionarTodo = New System.Windows.Forms.ToolStripButton()
        Me.toolCortar = New System.Windows.Forms.ToolStripButton()
        Me.toolCopiar = New System.Windows.Forms.ToolStripButton()
        Me.toolPegar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtCuadro = New System.Windows.Forms.TextBox()
        Me.fdFuente = New System.Windows.Forms.FontDialog()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCaracteres = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLinea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pdImprimir = New System.Drawing.Printing.PrintDocument()
        Me.pdialogImprimir = New System.Windows.Forms.PrintDialog()
        Me.ppdImprimir = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolGuardar, Me.toolImprimir, Me.ToolStripSeparator1, Me.toolColor, Me.toolFuente, Me.ToolStripSeparator2, Me.toolSeleccionarTodo, Me.toolCortar, Me.toolCopiar, Me.toolPegar, Me.ToolStripSeparator4, Me.toolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolGuardar
        '
        Me.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolGuardar.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconoguardar
        Me.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolGuardar.Name = "toolGuardar"
        Me.toolGuardar.Size = New System.Drawing.Size(29, 24)
        Me.toolGuardar.Text = "Guardar archivo"
        '
        'toolImprimir
        '
        Me.toolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolImprimir.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconoimprimir
        Me.toolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolImprimir.Name = "toolImprimir"
        Me.toolImprimir.Size = New System.Drawing.Size(29, 24)
        Me.toolImprimir.Text = "Imprimir texto"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'toolColor
        '
        Me.toolColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolColor.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconocolor
        Me.toolColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolColor.Name = "toolColor"
        Me.toolColor.Size = New System.Drawing.Size(29, 24)
        Me.toolColor.Text = "Cambiar color del texto"
        '
        'toolFuente
        '
        Me.toolFuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolFuente.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconofuente
        Me.toolFuente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolFuente.Name = "toolFuente"
        Me.toolFuente.Size = New System.Drawing.Size(29, 24)
        Me.toolFuente.Text = "Cambiar fuente del texto"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'toolSeleccionarTodo
        '
        Me.toolSeleccionarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSeleccionarTodo.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconoseleccionar
        Me.toolSeleccionarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSeleccionarTodo.Name = "toolSeleccionarTodo"
        Me.toolSeleccionarTodo.Size = New System.Drawing.Size(29, 24)
        Me.toolSeleccionarTodo.Text = "Seleccionar texto"
        '
        'toolCortar
        '
        Me.toolCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCortar.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconocortar
        Me.toolCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCortar.Name = "toolCortar"
        Me.toolCortar.Size = New System.Drawing.Size(29, 24)
        Me.toolCortar.Text = "ToolStripButton2"
        Me.toolCortar.ToolTipText = "Cortar el texto seleccionado"
        '
        'toolCopiar
        '
        Me.toolCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCopiar.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconocopiar
        Me.toolCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCopiar.Name = "toolCopiar"
        Me.toolCopiar.Size = New System.Drawing.Size(29, 24)
        Me.toolCopiar.Text = "ToolStripButton3"
        Me.toolCopiar.ToolTipText = "Copia el texto seleccionado"
        '
        'toolPegar
        '
        Me.toolPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolPegar.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconopegar
        Me.toolPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolPegar.Name = "toolPegar"
        Me.toolPegar.Size = New System.Drawing.Size(29, 24)
        Me.toolPegar.Text = "ToolStripButton4"
        Me.toolPegar.ToolTipText = "Pega texto en la posición seleccionada del texto"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'toolSalir
        '
        Me.toolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSalir.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconosalir
        Me.toolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSalir.Name = "toolSalir"
        Me.toolSalir.Size = New System.Drawing.Size(29, 24)
        Me.toolSalir.Text = "Salir"
        '
        'txtCuadro
        '
        Me.txtCuadro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCuadro.Location = New System.Drawing.Point(0, 27)
        Me.txtCuadro.Multiline = True
        Me.txtCuadro.Name = "txtCuadro"
        Me.txtCuadro.Size = New System.Drawing.Size(914, 573)
        Me.txtCuadro.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCaracteres, Me.lblLinea})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 574)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(914, 26)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCaracteres
        '
        Me.lblCaracteres.Name = "lblCaracteres"
        Me.lblCaracteres.Size = New System.Drawing.Size(93, 20)
        Me.lblCaracteres.Text = "Caracteres: 0"
        '
        'lblLinea
        '
        Me.lblLinea.Name = "lblLinea"
        Me.lblLinea.Size = New System.Drawing.Size(65, 20)
        Me.lblLinea.Text = "Líneas: 0"
        '
        'pdImprimir
        '
        '
        'pdialogImprimir
        '
        Me.pdialogImprimir.UseEXDialog = True
        '
        'ppdImprimir
        '
        Me.ppdImprimir.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdImprimir.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdImprimir.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdImprimir.Enabled = True
        Me.ppdImprimir.Icon = CType(resources.GetObject("ppdImprimir.Icon"), System.Drawing.Icon)
        Me.ppdImprimir.Name = "ppdImprimir"
        Me.ppdImprimir.Visible = False
        '
        'formEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCuadro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formEditar"
        Me.Text = "formEditar"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfdGuardar As SaveFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolColor As ToolStripButton
    Friend WithEvents toolFuente As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolSeleccionarTodo As ToolStripButton
    Friend WithEvents toolCortar As ToolStripButton
    Friend WithEvents toolCopiar As ToolStripButton
    Friend WithEvents toolPegar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents toolSalir As ToolStripButton
    Friend WithEvents txtCuadro As TextBox
    Friend WithEvents fdFuente As FontDialog
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblCaracteres As ToolStripStatusLabel
    Friend WithEvents lblLinea As ToolStripStatusLabel
    Friend WithEvents toolImprimir As ToolStripButton
    Friend WithEvents pdImprimir As Printing.PrintDocument
    Friend WithEvents pdialogImprimir As PrintDialog
    Friend WithEvents ppdImprimir As PrintPreviewDialog
End Class
