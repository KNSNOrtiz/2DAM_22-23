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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEjercicio1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitEjercicio2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFocus1 = New System.Windows.Forms.Button()
        Me.btnFocus2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitEjercicio1, Me.mitEjercicio2})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'mitEjercicio1
        '
        Me.mitEjercicio1.Name = "mitEjercicio1"
        Me.mitEjercicio1.Size = New System.Drawing.Size(160, 26)
        Me.mitEjercicio1.Text = "Ejercicio 1"
        '
        'mitEjercicio2
        '
        Me.mitEjercicio2.Name = "mitEjercicio2"
        Me.mitEjercicio2.Size = New System.Drawing.Size(160, 26)
        Me.mitEjercicio2.Text = "Ejercicio 2"
        '
        'btnFocus1
        '
        Me.btnFocus1.Location = New System.Drawing.Point(201, 154)
        Me.btnFocus1.Name = "btnFocus1"
        Me.btnFocus1.Size = New System.Drawing.Size(94, 29)
        Me.btnFocus1.TabIndex = 1
        Me.btnFocus1.Text = "Foco en 1"
        Me.btnFocus1.UseVisualStyleBackColor = True
        '
        'btnFocus2
        '
        Me.btnFocus2.Location = New System.Drawing.Point(416, 154)
        Me.btnFocus2.Name = "btnFocus2"
        Me.btnFocus2.Size = New System.Drawing.Size(94, 29)
        Me.btnFocus2.TabIndex = 2
        Me.btnFocus2.Text = "Foco en 2"
        Me.btnFocus2.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFocus2)
        Me.Controls.Add(Me.btnFocus1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mitEjercicio1 As ToolStripMenuItem
    Friend WithEvents mitEjercicio2 As ToolStripMenuItem
    Friend WithEvents btnFocus1 As Button
    Friend WithEvents btnFocus2 As Button
End Class
