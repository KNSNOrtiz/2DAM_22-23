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
        Me.chkInterfaces = New System.Windows.Forms.CheckBox()
        Me.chkAndroid = New System.Windows.Forms.CheckBox()
        Me.chkBadat = New System.Windows.Forms.CheckBox()
        Me.lstAsignaturas = New System.Windows.Forms.ListBox()
        Me.lnkGoogle = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReloj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkInterfaces
        '
        Me.chkInterfaces.AutoSize = True
        Me.chkInterfaces.Location = New System.Drawing.Point(126, 90)
        Me.chkInterfaces.Name = "chkInterfaces"
        Me.chkInterfaces.Size = New System.Drawing.Size(95, 24)
        Me.chkInterfaces.TabIndex = 0
        Me.chkInterfaces.Text = "Interfaces"
        Me.chkInterfaces.UseVisualStyleBackColor = True
        '
        'chkAndroid
        '
        Me.chkAndroid.AutoSize = True
        Me.chkAndroid.Location = New System.Drawing.Point(126, 136)
        Me.chkAndroid.Name = "chkAndroid"
        Me.chkAndroid.Size = New System.Drawing.Size(85, 24)
        Me.chkAndroid.TabIndex = 1
        Me.chkAndroid.Text = "Android"
        Me.chkAndroid.UseVisualStyleBackColor = True
        '
        'chkBadat
        '
        Me.chkBadat.AutoSize = True
        Me.chkBadat.Location = New System.Drawing.Point(126, 184)
        Me.chkBadat.Name = "chkBadat"
        Me.chkBadat.Size = New System.Drawing.Size(130, 24)
        Me.chkBadat.TabIndex = 2
        Me.chkBadat.Text = "Bases de datos"
        Me.chkBadat.UseVisualStyleBackColor = True
        '
        'lstAsignaturas
        '
        Me.lstAsignaturas.FormattingEnabled = True
        Me.lstAsignaturas.ItemHeight = 20
        Me.lstAsignaturas.Location = New System.Drawing.Point(290, 90)
        Me.lstAsignaturas.Name = "lstAsignaturas"
        Me.lstAsignaturas.Size = New System.Drawing.Size(259, 124)
        Me.lstAsignaturas.TabIndex = 3
        '
        'lnkGoogle
        '
        Me.lnkGoogle.AutoSize = True
        Me.lnkGoogle.Location = New System.Drawing.Point(613, 137)
        Me.lnkGoogle.Name = "lnkGoogle"
        Me.lnkGoogle.Size = New System.Drawing.Size(58, 20)
        Me.lnkGoogle.TabIndex = 4
        Me.lnkGoogle.TabStop = True
        Me.lnkGoogle.Text = "Google"
        '
        'Timer1
        '
        '
        'btnReloj
        '
        Me.btnReloj.Location = New System.Drawing.Point(342, 284)
        Me.btnReloj.Name = "btnReloj"
        Me.btnReloj.Size = New System.Drawing.Size(107, 29)
        Me.btnReloj.TabIndex = 5
        Me.btnReloj.Text = "Iniciar/Parar"
        Me.btnReloj.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 486)
        Me.Controls.Add(Me.btnReloj)
        Me.Controls.Add(Me.lnkGoogle)
        Me.Controls.Add(Me.lstAsignaturas)
        Me.Controls.Add(Me.chkBadat)
        Me.Controls.Add(Me.chkAndroid)
        Me.Controls.Add(Me.chkInterfaces)
        Me.Name = "Form1"
        Me.Text = "Ejemplos checkbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkInterfaces As CheckBox
    Friend WithEvents chkAndroid As CheckBox
    Friend WithEvents chkBadat As CheckBox
    Friend WithEvents lstAsignaturas As ListBox
    Friend WithEvents lnkGoogle As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnReloj As Button
End Class
