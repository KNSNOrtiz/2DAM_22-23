<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisFormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitFecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitFiguras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitASCII = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarIconosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolAbrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolSalir = New System.Windows.Forms.ToolStripButton()
        Me.menuMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCuadro
        '
        Me.txtCuadro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCuadro.Location = New System.Drawing.Point(0, 51)
        Me.txtCuadro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCuadro.Multiline = True
        Me.txtCuadro.Name = "txtCuadro"
        Me.txtCuadro.Size = New System.Drawing.Size(754, 430)
        Me.txtCuadro.TabIndex = 0
        Me.txtCuadro.Visible = False
        '
        'ofdAbrir
        '
        Me.ofdAbrir.FileName = "OpenFileDialog1"
        '
        'menuMain
        '
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MisFormulariosToolStripMenuItem, Me.VentanasToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menuMain.Size = New System.Drawing.Size(754, 24)
        Me.menuMain.TabIndex = 1
        Me.menuMain.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitNuevo, Me.mitAbrir, Me.mitSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'mitNuevo
        '
        Me.mitNuevo.Name = "mitNuevo"
        Me.mitNuevo.Size = New System.Drawing.Size(109, 22)
        Me.mitNuevo.Text = "Nuevo"
        '
        'mitAbrir
        '
        Me.mitAbrir.Name = "mitAbrir"
        Me.mitAbrir.Size = New System.Drawing.Size(109, 22)
        Me.mitAbrir.Text = "Abrir"
        '
        'mitSalir
        '
        Me.mitSalir.Name = "mitSalir"
        Me.mitSalir.Size = New System.Drawing.Size(109, 22)
        Me.mitSalir.Text = "Salir"
        '
        'MisFormulariosToolStripMenuItem
        '
        Me.MisFormulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitFecha, Me.mitFiguras, Me.mitASCII})
        Me.MisFormulariosToolStripMenuItem.Name = "MisFormulariosToolStripMenuItem"
        Me.MisFormulariosToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MisFormulariosToolStripMenuItem.Text = "Mis formularios"
        '
        'mitFecha
        '
        Me.mitFecha.Name = "mitFecha"
        Me.mitFecha.Size = New System.Drawing.Size(144, 22)
        Me.mitFecha.Text = "Fecha"
        '
        'mitFiguras
        '
        Me.mitFiguras.Name = "mitFiguras"
        Me.mitFiguras.Size = New System.Drawing.Size(144, 22)
        Me.mitFiguras.Text = "Imágenes"
        '
        'mitASCII
        '
        Me.mitASCII.Name = "mitASCII"
        Me.mitASCII.Size = New System.Drawing.Size(144, 22)
        Me.mitASCII.Text = "Código ASCII"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitCascada, Me.mitHorizontal, Me.mitVertical, Me.OrganizarIconosToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanasToolStripMenuItem.Text = "Ventana"
        '
        'mitCascada
        '
        Me.mitCascada.Name = "mitCascada"
        Me.mitCascada.Size = New System.Drawing.Size(177, 22)
        Me.mitCascada.Text = "Cascada"
        '
        'mitHorizontal
        '
        Me.mitHorizontal.Name = "mitHorizontal"
        Me.mitHorizontal.Size = New System.Drawing.Size(177, 22)
        Me.mitHorizontal.Text = "Mosaico Horizontal"
        '
        'mitVertical
        '
        Me.mitVertical.Name = "mitVertical"
        Me.mitVertical.Size = New System.Drawing.Size(177, 22)
        Me.mitVertical.Text = "Mosaico Vertical"
        '
        'OrganizarIconosToolStripMenuItem
        '
        Me.OrganizarIconosToolStripMenuItem.Name = "OrganizarIconosToolStripMenuItem"
        Me.OrganizarIconosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrganizarIconosToolStripMenuItem.Text = "Organizar iconos"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNuevo, Me.toolAbrir, Me.ToolStripSeparator1, Me.toolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(754, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolNuevo
        '
        Me.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNuevo.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.icononuevo
        Me.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNuevo.Name = "toolNuevo"
        Me.toolNuevo.Size = New System.Drawing.Size(24, 24)
        Me.toolNuevo.Text = "ToolStripButton1"
        Me.toolNuevo.ToolTipText = "Crea un nuevo fichero de texto"
        '
        'toolAbrir
        '
        Me.toolAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolAbrir.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconoabrir
        Me.toolAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolAbrir.Name = "toolAbrir"
        Me.toolAbrir.Size = New System.Drawing.Size(24, 24)
        Me.toolAbrir.Text = "Abrir archivo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'toolSalir
        '
        Me.toolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSalir.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.iconosalir
        Me.toolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSalir.Name = "toolSalir"
        Me.toolSalir.Size = New System.Drawing.Size(24, 24)
        Me.toolSalir.Text = "Salir"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 481)
        Me.Controls.Add(Me.txtCuadro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.menuMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMain
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formMain"
        Me.Text = "Formulario Principal | Mario Ortiz Jibaja"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCuadro As TextBox
    Friend WithEvents ofdAbrir As OpenFileDialog
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitNuevo As ToolStripMenuItem
    Friend WithEvents mitSalir As ToolStripMenuItem
    Friend WithEvents mitAbrir As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolAbrir As ToolStripButton
    Friend WithEvents toolSalir As ToolStripButton
    Friend WithEvents MisFormulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitFecha As ToolStripMenuItem
    Friend WithEvents mitFiguras As ToolStripMenuItem
    Friend WithEvents mitASCII As ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitCascada As ToolStripMenuItem
    Friend WithEvents mitHorizontal As ToolStripMenuItem
    Friend WithEvents mitVertical As ToolStripMenuItem
    Friend WithEvents OrganizarIconosToolStripMenuItem As ToolStripMenuItem
End Class
