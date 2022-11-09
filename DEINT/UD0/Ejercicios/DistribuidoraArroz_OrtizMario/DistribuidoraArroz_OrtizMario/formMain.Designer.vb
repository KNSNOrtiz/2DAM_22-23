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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestiónDeCamionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemCargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusFechaHora = New System.Windows.Forms.StatusStrip()
        Me.txtFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.lbCamiones = New System.Windows.Forms.ListBox()
        Me.imgCamion = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.hbarSaca = New System.Windows.Forms.HScrollBar()
        Me.txtPesoSaca = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.statusFechaHora.SuspendLayout()
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeCamionesToolStripMenuItem, Me.itemCargar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestiónDeCamionesToolStripMenuItem
        '
        Me.GestiónDeCamionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemAlta, Me.itemBaja})
        Me.GestiónDeCamionesToolStripMenuItem.Name = "GestiónDeCamionesToolStripMenuItem"
        Me.GestiónDeCamionesToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.GestiónDeCamionesToolStripMenuItem.Text = "Gestión de camiones"
        '
        'itemAlta
        '
        Me.itemAlta.Name = "itemAlta"
        Me.itemAlta.Size = New System.Drawing.Size(96, 22)
        Me.itemAlta.Text = "Alta"
        '
        'itemBaja
        '
        Me.itemBaja.Name = "itemBaja"
        Me.itemBaja.Size = New System.Drawing.Size(96, 22)
        Me.itemBaja.Text = "Baja"
        '
        'itemCargar
        '
        Me.itemCargar.Name = "itemCargar"
        Me.itemCargar.Size = New System.Drawing.Size(97, 20)
        Me.itemCargar.Text = "Carga de sacas"
        '
        'statusFechaHora
        '
        Me.statusFechaHora.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.statusFechaHora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtFechaHora})
        Me.statusFechaHora.Location = New System.Drawing.Point(0, 428)
        Me.statusFechaHora.Name = "statusFechaHora"
        Me.statusFechaHora.Size = New System.Drawing.Size(800, 22)
        Me.statusFechaHora.TabIndex = 1
        Me.statusFechaHora.Text = "StatusStrip1"
        '
        'txtFechaHora
        '
        Me.txtFechaHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Size = New System.Drawing.Size(127, 17)
        Me.txtFechaHora.Text = "Fecha y hora actuales:"
        '
        'timerFechaHora
        '
        Me.timerFechaHora.Enabled = True
        Me.timerFechaHora.Interval = 1000
        '
        'lbCamiones
        '
        Me.lbCamiones.FormattingEnabled = True
        Me.lbCamiones.ItemHeight = 15
        Me.lbCamiones.Location = New System.Drawing.Point(54, 81)
        Me.lbCamiones.Name = "lbCamiones"
        Me.lbCamiones.Size = New System.Drawing.Size(246, 139)
        Me.lbCamiones.TabIndex = 2
        '
        'imgCamion
        '
        Me.imgCamion.Location = New System.Drawing.Point(436, 81)
        Me.imgCamion.Name = "imgCamion"
        Me.imgCamion.Size = New System.Drawing.Size(235, 139)
        Me.imgCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCamion.TabIndex = 3
        Me.imgCamion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(54, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista de camiones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(436, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Imagen del camión seleccionado"
        '
        'listaImagenes
        '
        Me.listaImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.listaImagenes.ImageStream = CType(resources.GetObject("listaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.listaImagenes.Images.SetKeyName(0, "camionA.jpg")
        Me.listaImagenes.Images.SetKeyName(1, "camionB.jpg")
        Me.listaImagenes.Images.SetKeyName(2, "camionC.jpg")
        '
        'hbarSaca
        '
        Me.hbarSaca.LargeChange = 1
        Me.hbarSaca.Location = New System.Drawing.Point(24, 39)
        Me.hbarSaca.Maximum = 9000
        Me.hbarSaca.Minimum = 3000
        Me.hbarSaca.Name = "hbarSaca"
        Me.hbarSaca.Size = New System.Drawing.Size(258, 22)
        Me.hbarSaca.TabIndex = 6
        Me.hbarSaca.Value = 3000
        '
        'txtPesoSaca
        '
        Me.txtPesoSaca.AutoSize = True
        Me.txtPesoSaca.Location = New System.Drawing.Point(24, 77)
        Me.txtPesoSaca.Name = "txtPesoSaca"
        Me.txtPesoSaca.Size = New System.Drawing.Size(91, 15)
        Me.txtPesoSaca.TabIndex = 8
        Me.txtPesoSaca.Text = "Peso de la saca:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPesoSaca)
        Me.GroupBox1.Controls.Add(Me.hbarSaca)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 133)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Establecer saca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "9000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "3000"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgCamion)
        Me.Controls.Add(Me.lbCamiones)
        Me.Controls.Add(Me.statusFechaHora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Distribuidora de arroz | Ortiz Jibaja, Mario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.statusFechaHora.ResumeLayout(False)
        Me.statusFechaHora.PerformLayout()
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónDeCamionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents itemAlta As ToolStripMenuItem
    Friend WithEvents itemBaja As ToolStripMenuItem
    Friend WithEvents itemCargar As ToolStripMenuItem
    Friend WithEvents statusFechaHora As StatusStrip
    Friend WithEvents txtFechaHora As ToolStripStatusLabel
    Friend WithEvents timerFechaHora As Timer
    Friend WithEvents lbCamiones As ListBox
    Friend WithEvents imgCamion As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listaImagenes As ImageList
    Friend WithEvents hbarSaca As HScrollBar
    Friend WithEvents txtPesoSaca As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
