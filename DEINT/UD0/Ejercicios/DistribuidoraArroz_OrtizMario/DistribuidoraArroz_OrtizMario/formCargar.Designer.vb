<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCargar
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
        Me.components = New System.ComponentModel.Container()
        Me.imgCamion = New System.Windows.Forms.PictureBox()
        Me.txtNumSaco = New System.Windows.Forms.Label()
        Me.cbxCamiones = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtInformacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgbCarga = New System.Windows.Forms.ProgressBar()
        Me.imgSaco = New System.Windows.Forms.PictureBox()
        Me.txtNumCamion = New System.Windows.Forms.Label()
        Me.txtCargando = New System.Windows.Forms.Label()
        Me.timerCarga = New System.Windows.Forms.Timer(Me.components)
        Me.imgAuxLleno = New System.Windows.Forms.PictureBox()
        Me.imgAuxVacio = New System.Windows.Forms.PictureBox()
        Me.timerDepartir = New System.Windows.Forms.Timer(Me.components)
        Me.timerEmpezar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.imgSaco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAuxLleno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAuxVacio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCamion
        '
        Me.imgCamion.Location = New System.Drawing.Point(12, 155)
        Me.imgCamion.Name = "imgCamion"
        Me.imgCamion.Size = New System.Drawing.Size(150, 131)
        Me.imgCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCamion.TabIndex = 0
        Me.imgCamion.TabStop = False
        '
        'txtNumSaco
        '
        Me.txtNumSaco.AutoSize = True
        Me.txtNumSaco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNumSaco.Location = New System.Drawing.Point(321, 50)
        Me.txtNumSaco.Name = "txtNumSaco"
        Me.txtNumSaco.Size = New System.Drawing.Size(92, 21)
        Me.txtNumSaco.TabIndex = 1
        Me.txtNumSaco.Text = "Nº sacos: 0"
        '
        'cbxCamiones
        '
        Me.cbxCamiones.Enabled = False
        Me.cbxCamiones.FormattingEnabled = True
        Me.cbxCamiones.Location = New System.Drawing.Point(12, 318)
        Me.cbxCamiones.Name = "cbxCamiones"
        Me.cbxCamiones.Size = New System.Drawing.Size(150, 23)
        Me.cbxCamiones.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtInformacion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtInformacion
        '
        Me.txtInformacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtInformacion.Name = "txtInformacion"
        Me.txtInformacion.Size = New System.Drawing.Size(75, 17)
        Me.txtInformacion.Text = "Información"
        '
        'pgbCarga
        '
        Me.pgbCarga.Location = New System.Drawing.Point(321, 318)
        Me.pgbCarga.Name = "pgbCarga"
        Me.pgbCarga.Size = New System.Drawing.Size(150, 23)
        Me.pgbCarga.TabIndex = 4
        '
        'imgSaco
        '
        Me.imgSaco.Location = New System.Drawing.Point(321, 155)
        Me.imgSaco.Name = "imgSaco"
        Me.imgSaco.Size = New System.Drawing.Size(150, 131)
        Me.imgSaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSaco.TabIndex = 5
        Me.imgSaco.TabStop = False
        '
        'txtNumCamion
        '
        Me.txtNumCamion.AutoSize = True
        Me.txtNumCamion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNumCamion.Location = New System.Drawing.Point(12, 50)
        Me.txtNumCamion.Name = "txtNumCamion"
        Me.txtNumCamion.Size = New System.Drawing.Size(108, 21)
        Me.txtNumCamion.TabIndex = 6
        Me.txtNumCamion.Text = "Nº camión: 0"
        '
        'txtCargando
        '
        Me.txtCargando.AutoSize = True
        Me.txtCargando.Location = New System.Drawing.Point(336, 357)
        Me.txtCargando.Name = "txtCargando"
        Me.txtCargando.Size = New System.Drawing.Size(120, 15)
        Me.txtCargando.TabIndex = 7
        Me.txtCargando.Text = "Atención, cargando..."
        '
        'timerCarga
        '
        Me.timerCarga.Interval = 500
        '
        'imgAuxLleno
        '
        Me.imgAuxLleno.Image = Global.DistribuidoraArroz_OrtizMario.My.Resources.Resources.sacolleno
        Me.imgAuxLleno.Location = New System.Drawing.Point(579, 234)
        Me.imgAuxLleno.Name = "imgAuxLleno"
        Me.imgAuxLleno.Size = New System.Drawing.Size(194, 157)
        Me.imgAuxLleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAuxLleno.TabIndex = 8
        Me.imgAuxLleno.TabStop = False
        Me.imgAuxLleno.Visible = False
        '
        'imgAuxVacio
        '
        Me.imgAuxVacio.Image = Global.DistribuidoraArroz_OrtizMario.My.Resources.Resources.sacovacio
        Me.imgAuxVacio.Location = New System.Drawing.Point(579, 50)
        Me.imgAuxVacio.Name = "imgAuxVacio"
        Me.imgAuxVacio.Size = New System.Drawing.Size(194, 157)
        Me.imgAuxVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAuxVacio.TabIndex = 9
        Me.imgAuxVacio.TabStop = False
        Me.imgAuxVacio.Visible = False
        '
        'timerDepartir
        '
        Me.timerDepartir.Interval = 1
        '
        'timerEmpezar
        '
        Me.timerEmpezar.Interval = 1
        '
        'formCargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgAuxVacio)
        Me.Controls.Add(Me.imgAuxLleno)
        Me.Controls.Add(Me.txtCargando)
        Me.Controls.Add(Me.txtNumCamion)
        Me.Controls.Add(Me.imgSaco)
        Me.Controls.Add(Me.pgbCarga)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cbxCamiones)
        Me.Controls.Add(Me.txtNumSaco)
        Me.Controls.Add(Me.imgCamion)
        Me.MaximumSize = New System.Drawing.Size(816, 500)
        Me.MinimumSize = New System.Drawing.Size(816, 500)
        Me.Name = "formCargar"
        Me.Text = "Carga de sacos de arroz"
        CType(Me.imgCamion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.imgSaco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAuxLleno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAuxVacio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgCamion As PictureBox
    Friend WithEvents txtNumSaco As Label
    Friend WithEvents cbxCamiones As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtInformacion As ToolStripStatusLabel
    Friend WithEvents pgbCarga As ProgressBar
    Friend WithEvents imgSaco As PictureBox
    Friend WithEvents txtNumCamion As Label
    Friend WithEvents txtCargando As Label
    Friend WithEvents timerCarga As Timer
    Friend WithEvents imgAuxLleno As PictureBox
    Friend WithEvents imgAuxVacio As PictureBox
    Friend WithEvents timerDepartir As Timer
    Friend WithEvents timerEmpezar As Timer
End Class
