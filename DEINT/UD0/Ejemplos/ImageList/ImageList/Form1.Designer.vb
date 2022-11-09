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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imliListado = New System.Windows.Forms.ImageList(Me.components)
        Me.rdbImg1 = New System.Windows.Forms.RadioButton()
        Me.rdbImg2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imliListado
        '
        Me.imliListado.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imliListado.ImageStream = CType(resources.GetObject("imliListado.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imliListado.TransparentColor = System.Drawing.Color.Transparent
        Me.imliListado.Images.SetKeyName(0, "db26a740-2168-41aa-aef1-3636e593f395.png")
        Me.imliListado.Images.SetKeyName(1, "EaY8TBsWoAg1h6V.jpg")
        '
        'rdbImg1
        '
        Me.rdbImg1.AutoSize = True
        Me.rdbImg1.Location = New System.Drawing.Point(132, 161)
        Me.rdbImg1.Name = "rdbImg1"
        Me.rdbImg1.Size = New System.Drawing.Size(92, 24)
        Me.rdbImg1.TabIndex = 0
        Me.rdbImg1.TabStop = True
        Me.rdbImg1.Text = "Imagen 1"
        Me.rdbImg1.UseVisualStyleBackColor = True
        '
        'rdbImg2
        '
        Me.rdbImg2.AutoSize = True
        Me.rdbImg2.Location = New System.Drawing.Point(132, 210)
        Me.rdbImg2.Name = "rdbImg2"
        Me.rdbImg2.Size = New System.Drawing.Size(92, 24)
        Me.rdbImg2.TabIndex = 1
        Me.rdbImg2.TabStop = True
        Me.rdbImg2.Text = "Imagen 2"
        Me.rdbImg2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(343, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 219)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rdbImg2)
        Me.Controls.Add(Me.rdbImg1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imliListado As Windows.Forms.ImageList
    Friend WithEvents rdbImg1 As RadioButton
    Friend WithEvents rdbImg2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
