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
        Me.lblHola = New System.Windows.Forms.Label()
        Me.btnHolaUp = New System.Windows.Forms.Button()
        Me.btnHolaLeft = New System.Windows.Forms.Button()
        Me.btnHolaDown = New System.Windows.Forms.Button()
        Me.btnHolaRight = New System.Windows.Forms.Button()
        Me.btnCambiarColor = New System.Windows.Forms.Button()
        Me.btnFormRight = New System.Windows.Forms.Button()
        Me.btnFormDwn = New System.Windows.Forms.Button()
        Me.btnFormLeft = New System.Windows.Forms.Button()
        Me.btnFormUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHola
        '
        Me.lblHola.AutoSize = True
        Me.lblHola.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHola.Location = New System.Drawing.Point(235, 113)
        Me.lblHola.Name = "lblHola"
        Me.lblHola.Size = New System.Drawing.Size(67, 32)
        Me.lblHola.TabIndex = 0
        Me.lblHola.Text = "Hola"
        '
        'btnHolaUp
        '
        Me.btnHolaUp.Location = New System.Drawing.Point(150, 251)
        Me.btnHolaUp.Name = "btnHolaUp"
        Me.btnHolaUp.Size = New System.Drawing.Size(44, 29)
        Me.btnHolaUp.TabIndex = 1
        Me.btnHolaUp.Text = "&W"
        Me.btnHolaUp.UseVisualStyleBackColor = True
        '
        'btnHolaLeft
        '
        Me.btnHolaLeft.Location = New System.Drawing.Point(112, 286)
        Me.btnHolaLeft.Name = "btnHolaLeft"
        Me.btnHolaLeft.Size = New System.Drawing.Size(44, 29)
        Me.btnHolaLeft.TabIndex = 2
        Me.btnHolaLeft.Text = "&A"
        Me.btnHolaLeft.UseVisualStyleBackColor = True
        '
        'btnHolaDown
        '
        Me.btnHolaDown.Location = New System.Drawing.Point(150, 321)
        Me.btnHolaDown.Name = "btnHolaDown"
        Me.btnHolaDown.Size = New System.Drawing.Size(44, 29)
        Me.btnHolaDown.TabIndex = 3
        Me.btnHolaDown.Text = "&S"
        Me.btnHolaDown.UseVisualStyleBackColor = True
        '
        'btnHolaRight
        '
        Me.btnHolaRight.Location = New System.Drawing.Point(189, 286)
        Me.btnHolaRight.Name = "btnHolaRight"
        Me.btnHolaRight.Size = New System.Drawing.Size(44, 29)
        Me.btnHolaRight.TabIndex = 4
        Me.btnHolaRight.Text = "&D"
        Me.btnHolaRight.UseVisualStyleBackColor = True
        '
        'btnCambiarColor
        '
        Me.btnCambiarColor.Location = New System.Drawing.Point(301, 383)
        Me.btnCambiarColor.Name = "btnCambiarColor"
        Me.btnCambiarColor.Size = New System.Drawing.Size(156, 29)
        Me.btnCambiarColor.TabIndex = 5
        Me.btnCambiarColor.Text = "&Cambiar color"
        Me.btnCambiarColor.UseVisualStyleBackColor = True
        '
        'btnFormRight
        '
        Me.btnFormRight.Location = New System.Drawing.Point(644, 286)
        Me.btnFormRight.Name = "btnFormRight"
        Me.btnFormRight.Size = New System.Drawing.Size(44, 29)
        Me.btnFormRight.TabIndex = 9
        Me.btnFormRight.Text = "&6"
        Me.btnFormRight.UseVisualStyleBackColor = True
        '
        'btnFormDwn
        '
        Me.btnFormDwn.Location = New System.Drawing.Point(605, 321)
        Me.btnFormDwn.Name = "btnFormDwn"
        Me.btnFormDwn.Size = New System.Drawing.Size(44, 29)
        Me.btnFormDwn.TabIndex = 8
        Me.btnFormDwn.Text = "&2"
        Me.btnFormDwn.UseVisualStyleBackColor = True
        '
        'btnFormLeft
        '
        Me.btnFormLeft.Location = New System.Drawing.Point(567, 286)
        Me.btnFormLeft.Name = "btnFormLeft"
        Me.btnFormLeft.Size = New System.Drawing.Size(44, 29)
        Me.btnFormLeft.TabIndex = 7
        Me.btnFormLeft.Text = "&4"
        Me.btnFormLeft.UseVisualStyleBackColor = True
        '
        'btnFormUp
        '
        Me.btnFormUp.Location = New System.Drawing.Point(605, 251)
        Me.btnFormUp.Name = "btnFormUp"
        Me.btnFormUp.Size = New System.Drawing.Size(44, 29)
        Me.btnFormUp.TabIndex = 6
        Me.btnFormUp.Text = "&8"
        Me.btnFormUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFormRight)
        Me.Controls.Add(Me.btnFormDwn)
        Me.Controls.Add(Me.btnFormLeft)
        Me.Controls.Add(Me.btnFormUp)
        Me.Controls.Add(Me.btnCambiarColor)
        Me.Controls.Add(Me.btnHolaRight)
        Me.Controls.Add(Me.btnHolaDown)
        Me.Controls.Add(Me.btnHolaLeft)
        Me.Controls.Add(Me.btnHolaUp)
        Me.Controls.Add(Me.lblHola)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHola As Label
    Friend WithEvents btnHolaUp As Button
    Friend WithEvents btnHolaLeft As Button
    Friend WithEvents btnHolaDown As Button
    Friend WithEvents btnHolaRight As Button
    Friend WithEvents btnCambiarColor As Button
    Friend WithEvents btnFormRight As Button
    Friend WithEvents btnFormDwn As Button
    Friend WithEvents btnFormLeft As Button
    Friend WithEvents btnFormUp As Button
End Class
