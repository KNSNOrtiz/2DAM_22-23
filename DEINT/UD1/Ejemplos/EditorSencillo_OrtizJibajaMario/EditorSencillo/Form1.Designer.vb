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
        Me.txtCuadro = New System.Windows.Forms.TextBox()
        Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.fdFuente = New System.Windows.Forms.FontDialog()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSelectTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolAbrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolColor = New System.Windows.Forms.ToolStripButton()
        Me.toolFuente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolSalir = New System.Windows.Forms.ToolStripButton()
        Me.toolSeleccionarTodo = New System.Windows.Forms.ToolStripButton()
        Me.toolCortar = New System.Windows.Forms.ToolStripButton()
        Me.toolCopiar = New System.Windows.Forms.ToolStripButton()
        Me.toolPegar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCuadro
        '
        Me.txtCuadro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCuadro.Location = New System.Drawing.Point(0, 55)
        Me.txtCuadro.Multiline = True
        Me.txtCuadro.Name = "txtCuadro"
        Me.txtCuadro.Size = New System.Drawing.Size(800, 395)
        Me.txtCuadro.TabIndex = 0
        '
        'ofdAbrir
        '
        Me.ofdAbrir.FileName = "OpenFileDialog1"
        '
        'menuMain
        '
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(800, 28)
        Me.menuMain.TabIndex = 1
        Me.menuMain.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitNuevo, Me.mitGuardar, Me.mitAbrir, Me.mitColor, Me.mitFuente, Me.mitSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'mitNuevo
        '
        Me.mitNuevo.Name = "mitNuevo"
        Me.mitNuevo.Size = New System.Drawing.Size(145, 26)
        Me.mitNuevo.Text = "Nuevo"
        '
        'mitGuardar
        '
        Me.mitGuardar.Name = "mitGuardar"
        Me.mitGuardar.Size = New System.Drawing.Size(145, 26)
        Me.mitGuardar.Text = "Guardar"
        '
        'mitAbrir
        '
        Me.mitAbrir.Name = "mitAbrir"
        Me.mitAbrir.Size = New System.Drawing.Size(145, 26)
        Me.mitAbrir.Text = "Abrir"
        '
        'mitColor
        '
        Me.mitColor.Name = "mitColor"
        Me.mitColor.Size = New System.Drawing.Size(145, 26)
        Me.mitColor.Text = "Color"
        '
        'mitFuente
        '
        Me.mitFuente.Name = "mitFuente"
        Me.mitFuente.Size = New System.Drawing.Size(145, 26)
        Me.mitFuente.Text = "Fuente"
        '
        'mitSalir
        '
        Me.mitSalir.Name = "mitSalir"
        Me.mitSalir.Size = New System.Drawing.Size(145, 26)
        Me.mitSalir.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitSelectTodo, Me.mitCortar, Me.mitCopiar, Me.mitPegar})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'mitSelectTodo
        '
        Me.mitSelectTodo.Name = "mitSelectTodo"
        Me.mitSelectTodo.Size = New System.Drawing.Size(204, 26)
        Me.mitSelectTodo.Text = "Seleccionar todo"
        '
        'mitCortar
        '
        Me.mitCortar.Name = "mitCortar"
        Me.mitCortar.Size = New System.Drawing.Size(204, 26)
        Me.mitCortar.Text = "Cortar"
        '
        'mitCopiar
        '
        Me.mitCopiar.Name = "mitCopiar"
        Me.mitCopiar.Size = New System.Drawing.Size(204, 26)
        Me.mitCopiar.Text = "Copiar"
        '
        'mitPegar
        '
        Me.mitPegar.Name = "mitPegar"
        Me.mitPegar.Size = New System.Drawing.Size(204, 26)
        Me.mitPegar.Text = "Pegar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNuevo, Me.toolGuardar, Me.toolAbrir, Me.ToolStripSeparator1, Me.toolColor, Me.toolFuente, Me.ToolStripSeparator2, Me.toolSeleccionarTodo, Me.toolCortar, Me.toolCopiar, Me.toolPegar, Me.ToolStripSeparator4, Me.toolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolNuevo
        '
        Me.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNuevo.Image = Global.EditorSencillo.My.Resources.Resources.icononuevo
        Me.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNuevo.Name = "toolNuevo"
        Me.toolNuevo.Size = New System.Drawing.Size(29, 24)
        Me.toolNuevo.Text = "ToolStripButton1"
        Me.toolNuevo.ToolTipText = "Crea un nuevo fichero de texto"
        '
        'toolGuardar
        '
        Me.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolGuardar.Image = Global.EditorSencillo.My.Resources.Resources.iconoguardar
        Me.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolGuardar.Name = "toolGuardar"
        Me.toolGuardar.Size = New System.Drawing.Size(29, 24)
        Me.toolGuardar.Text = "Guardar archivo"
        '
        'toolAbrir
        '
        Me.toolAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolAbrir.Image = Global.EditorSencillo.My.Resources.Resources.iconoabrir
        Me.toolAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolAbrir.Name = "toolAbrir"
        Me.toolAbrir.Size = New System.Drawing.Size(29, 24)
        Me.toolAbrir.Text = "Abrir archivo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'toolColor
        '
        Me.toolColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolColor.Image = Global.EditorSencillo.My.Resources.Resources.iconocolor
        Me.toolColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolColor.Name = "toolColor"
        Me.toolColor.Size = New System.Drawing.Size(29, 24)
        Me.toolColor.Text = "Cambiar color del texto"
        '
        'toolFuente
        '
        Me.toolFuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolFuente.Image = Global.EditorSencillo.My.Resources.Resources.iconofuente
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
        'toolSalir
        '
        Me.toolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSalir.Image = Global.EditorSencillo.My.Resources.Resources.iconosalir
        Me.toolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSalir.Name = "toolSalir"
        Me.toolSalir.Size = New System.Drawing.Size(29, 24)
        Me.toolSalir.Text = "Salir"
        '
        'toolSeleccionarTodo
        '
        Me.toolSeleccionarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSeleccionarTodo.Image = Global.EditorSencillo.My.Resources.Resources.iconoseleccionar
        Me.toolSeleccionarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSeleccionarTodo.Name = "toolSeleccionarTodo"
        Me.toolSeleccionarTodo.Size = New System.Drawing.Size(29, 24)
        Me.toolSeleccionarTodo.Text = "Seleccionar texto"
        '
        'toolCortar
        '
        Me.toolCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCortar.Image = Global.EditorSencillo.My.Resources.Resources.iconocortar
        Me.toolCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCortar.Name = "toolCortar"
        Me.toolCortar.Size = New System.Drawing.Size(29, 24)
        Me.toolCortar.Text = "ToolStripButton2"
        Me.toolCortar.ToolTipText = "Cortar el texto seleccionado"
        '
        'toolCopiar
        '
        Me.toolCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCopiar.Image = Global.EditorSencillo.My.Resources.Resources.iconocopiar
        Me.toolCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCopiar.Name = "toolCopiar"
        Me.toolCopiar.Size = New System.Drawing.Size(29, 24)
        Me.toolCopiar.Text = "ToolStripButton3"
        Me.toolCopiar.ToolTipText = "Copia el texto seleccionado"
        '
        'toolPegar
        '
        Me.toolPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolPegar.Image = Global.EditorSencillo.My.Resources.Resources.iconopegar
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCuadro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "Form1"
        Me.Text = "Editor sencillo mejorado | Mario Ortiz Jibaja"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCuadro As TextBox
    Friend WithEvents ofdAbrir As OpenFileDialog
    Friend WithEvents sfdGuardar As SaveFileDialog
    Friend WithEvents fdFuente As FontDialog
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitNuevo As ToolStripMenuItem
    Friend WithEvents mitGuardar As ToolStripMenuItem
    Friend WithEvents mitColor As ToolStripMenuItem
    Friend WithEvents mitFuente As ToolStripMenuItem
    Friend WithEvents mitSalir As ToolStripMenuItem
    Friend WithEvents mitAbrir As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolNuevo As ToolStripButton
    Friend WithEvents toolGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolAbrir As ToolStripButton
    Friend WithEvents toolColor As ToolStripButton
    Friend WithEvents toolFuente As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolSalir As ToolStripButton
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitSelectTodo As ToolStripMenuItem
    Friend WithEvents mitCortar As ToolStripMenuItem
    Friend WithEvents mitCopiar As ToolStripMenuItem
    Friend WithEvents mitPegar As ToolStripMenuItem
    Friend WithEvents toolSeleccionarTodo As ToolStripButton
    Friend WithEvents toolCortar As ToolStripButton
    Friend WithEvents toolCopiar As ToolStripButton
    Friend WithEvents toolPegar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
