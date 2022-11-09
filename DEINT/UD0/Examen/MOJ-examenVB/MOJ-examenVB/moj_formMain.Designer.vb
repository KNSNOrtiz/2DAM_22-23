<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class moj_formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(moj_formMain))
        Me.moj_mainMenu = New System.Windows.Forms.MenuStrip()
        Me.EjerciciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemEjercicio1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemEjercicio2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemEjercicio3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_gbxEjercicio1 = New System.Windows.Forms.GroupBox()
        Me.moj_txtCoche = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.moj_contextColores = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.moj_itemAnadirColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemColorAleatorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_itemStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.moj_rdbRojo = New System.Windows.Forms.RadioButton()
        Me.moj_rdbNegro = New System.Windows.Forms.RadioButton()
        Me.moj_rdbBlanco = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.moj_rdbElectrico = New System.Windows.Forms.RadioButton()
        Me.moj_rdbGasolina = New System.Windows.Forms.RadioButton()
        Me.moj_rdbDiesel = New System.Windows.Forms.RadioButton()
        Me.moj_gbxEjercicio2 = New System.Windows.Forms.GroupBox()
        Me.moj_txtColorEscogido = New System.Windows.Forms.Label()
        Me.moj_btnAnadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.moj_txtColor = New System.Windows.Forms.TextBox()
        Me.moj_lbColores = New System.Windows.Forms.ListBox()
        Me.moj_status = New System.Windows.Forms.StatusStrip()
        Me.moj_txtEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.moj_toolstrip = New System.Windows.Forms.ToolStrip()
        Me.moj_toolEj1 = New System.Windows.Forms.ToolStripButton()
        Me.moj_toolEj2 = New System.Windows.Forms.ToolStripButton()
        Me.moj_toolEj3 = New System.Windows.Forms.ToolStripButton()
        Me.moj_toolEj4 = New System.Windows.Forms.ToolStripButton()
        Me.moj_gbxEjercicio3 = New System.Windows.Forms.GroupBox()
        Me.moj_btnCambiarBack = New System.Windows.Forms.Button()
        Me.moj_btnCambiarFore = New System.Windows.Forms.Button()
        Me.moj_txtEj3 = New System.Windows.Forms.Label()
        Me.moj_colDialog = New System.Windows.Forms.ColorDialog()
        Me.moj_gbxEjercicio4 = New System.Windows.Forms.GroupBox()
        Me.moj_btnParar = New System.Windows.Forms.Button()
        Me.moj_btnIniciar = New System.Windows.Forms.Button()
        Me.moj_imgCoche = New System.Windows.Forms.PictureBox()
        Me.moj_timerCoche = New System.Windows.Forms.Timer(Me.components)
        Me.moj_listaIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.moj_mainMenu.SuspendLayout()
        Me.moj_gbxEjercicio1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.moj_contextColores.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.moj_gbxEjercicio2.SuspendLayout()
        Me.moj_status.SuspendLayout()
        Me.moj_toolstrip.SuspendLayout()
        Me.moj_gbxEjercicio3.SuspendLayout()
        Me.moj_gbxEjercicio4.SuspendLayout()
        CType(Me.moj_imgCoche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'moj_mainMenu
        '
        Me.moj_mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjerciciosToolStripMenuItem, Me.moj_itemInfo, Me.moj_itemSalir})
        Me.moj_mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.moj_mainMenu.Name = "moj_mainMenu"
        Me.moj_mainMenu.Size = New System.Drawing.Size(1018, 24)
        Me.moj_mainMenu.TabIndex = 0
        Me.moj_mainMenu.Text = "MenuStrip1"
        '
        'EjerciciosToolStripMenuItem
        '
        Me.EjerciciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moj_itemEjercicio1, Me.moj_itemEjercicio2, Me.moj_itemEjercicio3, Me.Ejercicio4ToolStripMenuItem})
        Me.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem"
        Me.EjerciciosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EjerciciosToolStripMenuItem.Text = "&Ejercicios"
        '
        'moj_itemEjercicio1
        '
        Me.moj_itemEjercicio1.Name = "moj_itemEjercicio1"
        Me.moj_itemEjercicio1.Size = New System.Drawing.Size(127, 22)
        Me.moj_itemEjercicio1.Text = "Ejercicio 1"
        '
        'moj_itemEjercicio2
        '
        Me.moj_itemEjercicio2.Name = "moj_itemEjercicio2"
        Me.moj_itemEjercicio2.Size = New System.Drawing.Size(127, 22)
        Me.moj_itemEjercicio2.Text = "Ejercicio 2"
        '
        'moj_itemEjercicio3
        '
        Me.moj_itemEjercicio3.Name = "moj_itemEjercicio3"
        Me.moj_itemEjercicio3.Size = New System.Drawing.Size(127, 22)
        Me.moj_itemEjercicio3.Text = "Ejercicio 3"
        '
        'Ejercicio4ToolStripMenuItem
        '
        Me.Ejercicio4ToolStripMenuItem.Name = "Ejercicio4ToolStripMenuItem"
        Me.Ejercicio4ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Ejercicio4ToolStripMenuItem.Text = "Ejercicio 4"
        '
        'moj_itemInfo
        '
        Me.moj_itemInfo.Name = "moj_itemInfo"
        Me.moj_itemInfo.Size = New System.Drawing.Size(40, 20)
        Me.moj_itemInfo.Text = "&Info"
        '
        'moj_itemSalir
        '
        Me.moj_itemSalir.Name = "moj_itemSalir"
        Me.moj_itemSalir.Size = New System.Drawing.Size(41, 20)
        Me.moj_itemSalir.Text = "&Salir"
        '
        'moj_gbxEjercicio1
        '
        Me.moj_gbxEjercicio1.Controls.Add(Me.moj_txtCoche)
        Me.moj_gbxEjercicio1.Controls.Add(Me.Panel2)
        Me.moj_gbxEjercicio1.Controls.Add(Me.Panel1)
        Me.moj_gbxEjercicio1.Location = New System.Drawing.Point(12, 57)
        Me.moj_gbxEjercicio1.Name = "moj_gbxEjercicio1"
        Me.moj_gbxEjercicio1.Size = New System.Drawing.Size(302, 201)
        Me.moj_gbxEjercicio1.TabIndex = 1
        Me.moj_gbxEjercicio1.TabStop = False
        Me.moj_gbxEjercicio1.Text = "Ejercicio 1"
        '
        'moj_txtCoche
        '
        Me.moj_txtCoche.AutoSize = True
        Me.moj_txtCoche.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.moj_txtCoche.Location = New System.Drawing.Point(31, 158)
        Me.moj_txtCoche.Name = "moj_txtCoche"
        Me.moj_txtCoche.Size = New System.Drawing.Size(44, 15)
        Me.moj_txtCoche.TabIndex = 3
        Me.moj_txtCoche.Text = "Coche:"
        '
        'Panel2
        '
        Me.Panel2.ContextMenuStrip = Me.moj_contextColores
        Me.Panel2.Controls.Add(Me.moj_rdbRojo)
        Me.Panel2.Controls.Add(Me.moj_rdbNegro)
        Me.Panel2.Controls.Add(Me.moj_rdbBlanco)
        Me.Panel2.Location = New System.Drawing.Point(163, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 83)
        Me.Panel2.TabIndex = 3
        '
        'moj_contextColores
        '
        Me.moj_contextColores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moj_itemAnadirColor, Me.moj_itemColorAleatorio, Me.moj_itemStock})
        Me.moj_contextColores.Name = "ContextMenuStrip1"
        Me.moj_contextColores.Size = New System.Drawing.Size(153, 70)
        '
        'moj_itemAnadirColor
        '
        Me.moj_itemAnadirColor.Name = "moj_itemAnadirColor"
        Me.moj_itemAnadirColor.Size = New System.Drawing.Size(152, 22)
        Me.moj_itemAnadirColor.Text = "Añadir color..."
        '
        'moj_itemColorAleatorio
        '
        Me.moj_itemColorAleatorio.Name = "moj_itemColorAleatorio"
        Me.moj_itemColorAleatorio.Size = New System.Drawing.Size(152, 22)
        Me.moj_itemColorAleatorio.Text = "Color aleatorio"
        '
        'moj_itemStock
        '
        Me.moj_itemStock.Name = "moj_itemStock"
        Me.moj_itemStock.Size = New System.Drawing.Size(152, 22)
        Me.moj_itemStock.Text = "En stock"
        '
        'moj_rdbRojo
        '
        Me.moj_rdbRojo.AutoSize = True
        Me.moj_rdbRojo.Location = New System.Drawing.Point(3, 53)
        Me.moj_rdbRojo.Name = "moj_rdbRojo"
        Me.moj_rdbRojo.Size = New System.Drawing.Size(49, 19)
        Me.moj_rdbRojo.TabIndex = 2
        Me.moj_rdbRojo.TabStop = True
        Me.moj_rdbRojo.Text = "Rojo"
        Me.moj_rdbRojo.UseVisualStyleBackColor = True
        '
        'moj_rdbNegro
        '
        Me.moj_rdbNegro.AutoSize = True
        Me.moj_rdbNegro.Location = New System.Drawing.Point(3, 3)
        Me.moj_rdbNegro.Name = "moj_rdbNegro"
        Me.moj_rdbNegro.Size = New System.Drawing.Size(58, 19)
        Me.moj_rdbNegro.TabIndex = 0
        Me.moj_rdbNegro.TabStop = True
        Me.moj_rdbNegro.Text = "Negro"
        Me.moj_rdbNegro.UseVisualStyleBackColor = True
        '
        'moj_rdbBlanco
        '
        Me.moj_rdbBlanco.AutoSize = True
        Me.moj_rdbBlanco.Location = New System.Drawing.Point(3, 28)
        Me.moj_rdbBlanco.Name = "moj_rdbBlanco"
        Me.moj_rdbBlanco.Size = New System.Drawing.Size(61, 19)
        Me.moj_rdbBlanco.TabIndex = 1
        Me.moj_rdbBlanco.TabStop = True
        Me.moj_rdbBlanco.Text = "Blanco"
        Me.moj_rdbBlanco.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.moj_rdbElectrico)
        Me.Panel1.Controls.Add(Me.moj_rdbGasolina)
        Me.Panel1.Controls.Add(Me.moj_rdbDiesel)
        Me.Panel1.Location = New System.Drawing.Point(16, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 83)
        Me.Panel1.TabIndex = 2
        '
        'moj_rdbElectrico
        '
        Me.moj_rdbElectrico.AutoSize = True
        Me.moj_rdbElectrico.Location = New System.Drawing.Point(3, 53)
        Me.moj_rdbElectrico.Name = "moj_rdbElectrico"
        Me.moj_rdbElectrico.Size = New System.Drawing.Size(70, 19)
        Me.moj_rdbElectrico.TabIndex = 2
        Me.moj_rdbElectrico.TabStop = True
        Me.moj_rdbElectrico.Text = "Eléctrico"
        Me.moj_rdbElectrico.UseVisualStyleBackColor = True
        '
        'moj_rdbGasolina
        '
        Me.moj_rdbGasolina.AutoSize = True
        Me.moj_rdbGasolina.Location = New System.Drawing.Point(3, 3)
        Me.moj_rdbGasolina.Name = "moj_rdbGasolina"
        Me.moj_rdbGasolina.Size = New System.Drawing.Size(70, 19)
        Me.moj_rdbGasolina.TabIndex = 0
        Me.moj_rdbGasolina.TabStop = True
        Me.moj_rdbGasolina.Text = "Gasolina"
        Me.moj_rdbGasolina.UseVisualStyleBackColor = True
        '
        'moj_rdbDiesel
        '
        Me.moj_rdbDiesel.AutoSize = True
        Me.moj_rdbDiesel.Location = New System.Drawing.Point(3, 28)
        Me.moj_rdbDiesel.Name = "moj_rdbDiesel"
        Me.moj_rdbDiesel.Size = New System.Drawing.Size(56, 19)
        Me.moj_rdbDiesel.TabIndex = 1
        Me.moj_rdbDiesel.TabStop = True
        Me.moj_rdbDiesel.Text = "Diesel"
        Me.moj_rdbDiesel.UseVisualStyleBackColor = True
        '
        'moj_gbxEjercicio2
        '
        Me.moj_gbxEjercicio2.Controls.Add(Me.moj_txtColorEscogido)
        Me.moj_gbxEjercicio2.Controls.Add(Me.moj_btnAnadir)
        Me.moj_gbxEjercicio2.Controls.Add(Me.Label1)
        Me.moj_gbxEjercicio2.Controls.Add(Me.moj_txtColor)
        Me.moj_gbxEjercicio2.Controls.Add(Me.moj_lbColores)
        Me.moj_gbxEjercicio2.Location = New System.Drawing.Point(528, 57)
        Me.moj_gbxEjercicio2.Name = "moj_gbxEjercicio2"
        Me.moj_gbxEjercicio2.Size = New System.Drawing.Size(421, 201)
        Me.moj_gbxEjercicio2.TabIndex = 2
        Me.moj_gbxEjercicio2.TabStop = False
        Me.moj_gbxEjercicio2.Text = "Ejercicio 2"
        Me.moj_gbxEjercicio2.Visible = False
        '
        'moj_txtColorEscogido
        '
        Me.moj_txtColorEscogido.AutoSize = True
        Me.moj_txtColorEscogido.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.moj_txtColorEscogido.Location = New System.Drawing.Point(16, 170)
        Me.moj_txtColorEscogido.Name = "moj_txtColorEscogido"
        Me.moj_txtColorEscogido.Size = New System.Drawing.Size(58, 15)
        Me.moj_txtColorEscogido.TabIndex = 4
        Me.moj_txtColorEscogido.Text = "Escogido:"
        '
        'moj_btnAnadir
        '
        Me.moj_btnAnadir.Location = New System.Drawing.Point(97, 126)
        Me.moj_btnAnadir.Name = "moj_btnAnadir"
        Me.moj_btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.moj_btnAnadir.TabIndex = 3
        Me.moj_btnAnadir.Text = "Añadir"
        Me.moj_btnAnadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color:"
        '
        'moj_txtColor
        '
        Me.moj_txtColor.Location = New System.Drawing.Point(72, 80)
        Me.moj_txtColor.Name = "moj_txtColor"
        Me.moj_txtColor.Size = New System.Drawing.Size(100, 23)
        Me.moj_txtColor.TabIndex = 1
        '
        'moj_lbColores
        '
        Me.moj_lbColores.FormattingEnabled = True
        Me.moj_lbColores.ItemHeight = 15
        Me.moj_lbColores.Location = New System.Drawing.Point(234, 31)
        Me.moj_lbColores.Name = "moj_lbColores"
        Me.moj_lbColores.Size = New System.Drawing.Size(165, 154)
        Me.moj_lbColores.TabIndex = 0
        '
        'moj_status
        '
        Me.moj_status.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.moj_status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moj_txtEstado})
        Me.moj_status.Location = New System.Drawing.Point(0, 508)
        Me.moj_status.Name = "moj_status"
        Me.moj_status.Size = New System.Drawing.Size(1018, 22)
        Me.moj_status.TabIndex = 3
        Me.moj_status.Text = "StatusStrip1"
        '
        'moj_txtEstado
        '
        Me.moj_txtEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.moj_txtEstado.Name = "moj_txtEstado"
        Me.moj_txtEstado.Size = New System.Drawing.Size(127, 17)
        Me.moj_txtEstado.Text = "Ejercicio seleccionado"
        '
        'moj_toolstrip
        '
        Me.moj_toolstrip.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.moj_toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.moj_toolEj1, Me.moj_toolEj2, Me.moj_toolEj3, Me.moj_toolEj4})
        Me.moj_toolstrip.Location = New System.Drawing.Point(0, 24)
        Me.moj_toolstrip.Name = "moj_toolstrip"
        Me.moj_toolstrip.Size = New System.Drawing.Size(1018, 25)
        Me.moj_toolstrip.TabIndex = 4
        Me.moj_toolstrip.Text = "ToolStrip1"
        '
        'moj_toolEj1
        '
        Me.moj_toolEj1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.moj_toolEj1.Image = CType(resources.GetObject("moj_toolEj1.Image"), System.Drawing.Image)
        Me.moj_toolEj1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.moj_toolEj1.Name = "moj_toolEj1"
        Me.moj_toolEj1.Size = New System.Drawing.Size(23, 22)
        Me.moj_toolEj1.Text = "moj_toolEj1"
        Me.moj_toolEj1.ToolTipText = "Ejercicio 1"
        '
        'moj_toolEj2
        '
        Me.moj_toolEj2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.moj_toolEj2.Image = CType(resources.GetObject("moj_toolEj2.Image"), System.Drawing.Image)
        Me.moj_toolEj2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.moj_toolEj2.Name = "moj_toolEj2"
        Me.moj_toolEj2.Size = New System.Drawing.Size(23, 22)
        Me.moj_toolEj2.Text = "ToolStripButton2"
        Me.moj_toolEj2.ToolTipText = "Ejercicio 2"
        '
        'moj_toolEj3
        '
        Me.moj_toolEj3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.moj_toolEj3.Image = CType(resources.GetObject("moj_toolEj3.Image"), System.Drawing.Image)
        Me.moj_toolEj3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.moj_toolEj3.Name = "moj_toolEj3"
        Me.moj_toolEj3.Size = New System.Drawing.Size(23, 22)
        Me.moj_toolEj3.Text = "ToolStripButton3"
        Me.moj_toolEj3.ToolTipText = "Ejercicio 3"
        '
        'moj_toolEj4
        '
        Me.moj_toolEj4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.moj_toolEj4.Image = CType(resources.GetObject("moj_toolEj4.Image"), System.Drawing.Image)
        Me.moj_toolEj4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.moj_toolEj4.Name = "moj_toolEj4"
        Me.moj_toolEj4.Size = New System.Drawing.Size(23, 22)
        Me.moj_toolEj4.Text = "ToolStripButton4"
        Me.moj_toolEj4.ToolTipText = "Ejercicio 4"
        '
        'moj_gbxEjercicio3
        '
        Me.moj_gbxEjercicio3.Controls.Add(Me.moj_btnCambiarBack)
        Me.moj_gbxEjercicio3.Controls.Add(Me.moj_btnCambiarFore)
        Me.moj_gbxEjercicio3.Controls.Add(Me.moj_txtEj3)
        Me.moj_gbxEjercicio3.Location = New System.Drawing.Point(12, 283)
        Me.moj_gbxEjercicio3.Name = "moj_gbxEjercicio3"
        Me.moj_gbxEjercicio3.Size = New System.Drawing.Size(322, 213)
        Me.moj_gbxEjercicio3.TabIndex = 5
        Me.moj_gbxEjercicio3.TabStop = False
        Me.moj_gbxEjercicio3.Text = "Ejercicio 3"
        Me.moj_gbxEjercicio3.Visible = False
        '
        'moj_btnCambiarBack
        '
        Me.moj_btnCambiarBack.Location = New System.Drawing.Point(187, 132)
        Me.moj_btnCambiarBack.Name = "moj_btnCambiarBack"
        Me.moj_btnCambiarBack.Size = New System.Drawing.Size(99, 23)
        Me.moj_btnCambiarBack.TabIndex = 2
        Me.moj_btnCambiarBack.Text = "Color fondo"
        Me.moj_btnCambiarBack.UseVisualStyleBackColor = True
        '
        'moj_btnCambiarFore
        '
        Me.moj_btnCambiarFore.Location = New System.Drawing.Point(25, 132)
        Me.moj_btnCambiarFore.Name = "moj_btnCambiarFore"
        Me.moj_btnCambiarFore.Size = New System.Drawing.Size(99, 23)
        Me.moj_btnCambiarFore.TabIndex = 1
        Me.moj_btnCambiarFore.Text = "Color letra"
        Me.moj_btnCambiarFore.UseVisualStyleBackColor = True
        '
        'moj_txtEj3
        '
        Me.moj_txtEj3.AutoSize = True
        Me.moj_txtEj3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.moj_txtEj3.Location = New System.Drawing.Point(87, 75)
        Me.moj_txtEj3.Name = "moj_txtEj3"
        Me.moj_txtEj3.Size = New System.Drawing.Size(140, 15)
        Me.moj_txtEj3.TabIndex = 0
        Me.moj_txtEj3.Text = "Esternocleidomastoideo"
        '
        'moj_gbxEjercicio4
        '
        Me.moj_gbxEjercicio4.Controls.Add(Me.moj_btnParar)
        Me.moj_gbxEjercicio4.Controls.Add(Me.moj_btnIniciar)
        Me.moj_gbxEjercicio4.Controls.Add(Me.moj_imgCoche)
        Me.moj_gbxEjercicio4.Location = New System.Drawing.Point(528, 283)
        Me.moj_gbxEjercicio4.Name = "moj_gbxEjercicio4"
        Me.moj_gbxEjercicio4.Size = New System.Drawing.Size(421, 213)
        Me.moj_gbxEjercicio4.TabIndex = 3
        Me.moj_gbxEjercicio4.TabStop = False
        Me.moj_gbxEjercicio4.Text = "Ejercicio 4"
        Me.moj_gbxEjercicio4.Visible = False
        '
        'moj_btnParar
        '
        Me.moj_btnParar.Location = New System.Drawing.Point(240, 168)
        Me.moj_btnParar.Name = "moj_btnParar"
        Me.moj_btnParar.Size = New System.Drawing.Size(75, 23)
        Me.moj_btnParar.TabIndex = 8
        Me.moj_btnParar.Text = "Parar"
        Me.moj_btnParar.UseVisualStyleBackColor = True
        '
        'moj_btnIniciar
        '
        Me.moj_btnIniciar.Location = New System.Drawing.Point(130, 168)
        Me.moj_btnIniciar.Name = "moj_btnIniciar"
        Me.moj_btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.moj_btnIniciar.TabIndex = 7
        Me.moj_btnIniciar.Text = "Iniciar"
        Me.moj_btnIniciar.UseVisualStyleBackColor = True
        '
        'moj_imgCoche
        '
        Me.moj_imgCoche.Location = New System.Drawing.Point(130, 32)
        Me.moj_imgCoche.Name = "moj_imgCoche"
        Me.moj_imgCoche.Size = New System.Drawing.Size(185, 109)
        Me.moj_imgCoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.moj_imgCoche.TabIndex = 6
        Me.moj_imgCoche.TabStop = False
        '
        'moj_timerCoche
        '
        Me.moj_timerCoche.Interval = 1000
        '
        'moj_listaIconos
        '
        Me.moj_listaIconos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.moj_listaIconos.ImageStream = CType(resources.GetObject("moj_listaIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.moj_listaIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.moj_listaIconos.Images.SetKeyName(0, "uno.png")
        Me.moj_listaIconos.Images.SetKeyName(1, "dos.png")
        Me.moj_listaIconos.Images.SetKeyName(2, "tres.png")
        Me.moj_listaIconos.Images.SetKeyName(3, "cuatro.png")
        '
        'moj_formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.moj_gbxEjercicio4)
        Me.Controls.Add(Me.moj_gbxEjercicio3)
        Me.Controls.Add(Me.moj_toolstrip)
        Me.Controls.Add(Me.moj_status)
        Me.Controls.Add(Me.moj_gbxEjercicio2)
        Me.Controls.Add(Me.moj_gbxEjercicio1)
        Me.Controls.Add(Me.moj_mainMenu)
        Me.MainMenuStrip = Me.moj_mainMenu
        Me.Name = "moj_formMain"
        Me.Text = "Mario Ortiz Jibaja | Examen VisualBasic"
        Me.moj_mainMenu.ResumeLayout(False)
        Me.moj_mainMenu.PerformLayout()
        Me.moj_gbxEjercicio1.ResumeLayout(False)
        Me.moj_gbxEjercicio1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.moj_contextColores.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.moj_gbxEjercicio2.ResumeLayout(False)
        Me.moj_gbxEjercicio2.PerformLayout()
        Me.moj_status.ResumeLayout(False)
        Me.moj_status.PerformLayout()
        Me.moj_toolstrip.ResumeLayout(False)
        Me.moj_toolstrip.PerformLayout()
        Me.moj_gbxEjercicio3.ResumeLayout(False)
        Me.moj_gbxEjercicio3.PerformLayout()
        Me.moj_gbxEjercicio4.ResumeLayout(False)
        CType(Me.moj_imgCoche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents moj_mainMenu As MenuStrip
    Friend WithEvents EjerciciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents moj_itemInfo As ToolStripMenuItem
    Friend WithEvents moj_itemSalir As ToolStripMenuItem
    Friend WithEvents moj_gbxEjercicio1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents moj_rdbElectrico As RadioButton
    Friend WithEvents moj_rdbGasolina As RadioButton
    Friend WithEvents moj_rdbDiesel As RadioButton
    Friend WithEvents moj_txtCoche As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents moj_rdbRojo As RadioButton
    Friend WithEvents moj_rdbNegro As RadioButton
    Friend WithEvents moj_rdbBlanco As RadioButton
    Friend WithEvents moj_itemEjercicio1 As ToolStripMenuItem
    Friend WithEvents moj_itemEjercicio2 As ToolStripMenuItem
    Friend WithEvents moj_itemEjercicio3 As ToolStripMenuItem
    Friend WithEvents moj_gbxEjercicio2 As GroupBox
    Friend WithEvents moj_btnAnadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents moj_txtColor As TextBox
    Friend WithEvents moj_lbColores As ListBox
    Friend WithEvents moj_txtColorEscogido As Label
    Friend WithEvents moj_status As StatusStrip
    Friend WithEvents moj_toolstrip As ToolStrip
    Friend WithEvents moj_gbxEjercicio3 As GroupBox
    Friend WithEvents moj_txtEj3 As Label
    Friend WithEvents moj_btnCambiarBack As Button
    Friend WithEvents moj_btnCambiarFore As Button
    Friend WithEvents moj_colDialog As ColorDialog
    Friend WithEvents moj_gbxEjercicio4 As GroupBox
    Friend WithEvents moj_imgCoche As PictureBox
    Friend WithEvents moj_timerCoche As Timer
    Friend WithEvents moj_btnParar As Button
    Friend WithEvents moj_btnIniciar As Button
    Friend WithEvents moj_toolEj1 As ToolStripButton
    Friend WithEvents moj_toolEj2 As ToolStripButton
    Friend WithEvents moj_toolEj3 As ToolStripButton
    Friend WithEvents moj_toolEj4 As ToolStripButton
    Friend WithEvents Ejercicio4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents moj_txtEstado As ToolStripStatusLabel
    Friend WithEvents moj_listaIconos As ImageList
    Friend WithEvents moj_contextColores As ContextMenuStrip
    Friend WithEvents moj_itemAnadirColor As ToolStripMenuItem
    Friend WithEvents moj_itemColorAleatorio As ToolStripMenuItem
    Friend WithEvents moj_itemStock As ToolStripMenuItem
End Class
