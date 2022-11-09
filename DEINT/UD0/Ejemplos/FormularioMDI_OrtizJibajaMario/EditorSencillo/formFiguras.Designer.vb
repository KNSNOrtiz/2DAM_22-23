<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFiguras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFotocopiadora = New System.Windows.Forms.RadioButton()
        Me.rbSatelite = New System.Windows.Forms.RadioButton()
        Me.rbPortatil = New System.Windows.Forms.RadioButton()
        Me.imgPrincipal = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFotocopiadora)
        Me.GroupBox1.Controls.Add(Me.rbSatelite)
        Me.GroupBox1.Controls.Add(Me.rbPortatil)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Figuras"
        '
        'rbFotocopiadora
        '
        Me.rbFotocopiadora.AutoSize = True
        Me.rbFotocopiadora.Location = New System.Drawing.Point(35, 140)
        Me.rbFotocopiadora.Name = "rbFotocopiadora"
        Me.rbFotocopiadora.Size = New System.Drawing.Size(128, 24)
        Me.rbFotocopiadora.TabIndex = 2
        Me.rbFotocopiadora.TabStop = True
        Me.rbFotocopiadora.Text = "Fotocopiadora"
        Me.rbFotocopiadora.UseVisualStyleBackColor = True
        '
        'rbSatelite
        '
        Me.rbSatelite.AutoSize = True
        Me.rbSatelite.Location = New System.Drawing.Point(35, 100)
        Me.rbSatelite.Name = "rbSatelite"
        Me.rbSatelite.Size = New System.Drawing.Size(80, 24)
        Me.rbSatelite.TabIndex = 1
        Me.rbSatelite.TabStop = True
        Me.rbSatelite.Text = "Satélite"
        Me.rbSatelite.UseVisualStyleBackColor = True
        '
        'rbPortatil
        '
        Me.rbPortatil.AutoSize = True
        Me.rbPortatil.Location = New System.Drawing.Point(35, 58)
        Me.rbPortatil.Name = "rbPortatil"
        Me.rbPortatil.Size = New System.Drawing.Size(77, 24)
        Me.rbPortatil.TabIndex = 0
        Me.rbPortatil.TabStop = True
        Me.rbPortatil.Text = "Portátil"
        Me.rbPortatil.UseVisualStyleBackColor = True
        '
        'imgPrincipal
        '
        Me.imgPrincipal.Location = New System.Drawing.Point(366, 170)
        Me.imgPrincipal.Name = "imgPrincipal"
        Me.imgPrincipal.Size = New System.Drawing.Size(312, 243)
        Me.imgPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPrincipal.TabIndex = 1
        Me.imgPrincipal.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.portatil
        Me.PictureBox1.Location = New System.Drawing.Point(59, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 88)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.satelite
        Me.PictureBox2.Location = New System.Drawing.Point(244, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FormularioMDI_OrtizMario.My.Resources.Resources.fotocopiadora
        Me.PictureBox3.Location = New System.Drawing.Point(452, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(127, 88)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'formFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgPrincipal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formFiguras"
        Me.Text = "Formulario de figuras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbFotocopiadora As RadioButton
    Friend WithEvents rbSatelite As RadioButton
    Friend WithEvents rbPortatil As RadioButton
    Friend WithEvents imgPrincipal As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
