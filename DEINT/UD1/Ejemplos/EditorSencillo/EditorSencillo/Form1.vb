Imports System.Timers

Public Class Form1

#Region "MÉTODOS"
    Sub Abrir()
        ofdAbrir.Title = "Seleccione el archivo..."
        ofdAbrir.FileName = ""
        ofdAbrir.InitialDirectory = "C:\"
        ofdAbrir.Filter = "Archivo de texto (.txt)|*.txt"
        ofdAbrir.ShowDialog()
        If ofdAbrir.FileName.Length > 0 Then
            Dim verarchivo As New IO.StreamReader(Me.ofdAbrir.FileName)
            txtCuadro.Text = verarchivo.ReadToEnd
            verarchivo.Close()
        End If
    End Sub

    Sub Nuevo()
        txtCuadro.Text = ""
        sfdGuardar.Title = "Nuevo archivo..."
        sfdGuardar.InitialDirectory = "C:\"
        sfdGuardar.Filter = "Archivo de texto (.txt)|*.txt"
        sfdGuardar.ValidateNames = True
        sfdGuardar.ShowDialog()
    End Sub

    Sub Guardar()
        sfdGuardar.Title = "Guardar archivo..."
        sfdGuardar.InitialDirectory = "C:\"
        sfdGuardar.Filter = "Archivo de texto (.txt)|*.txt"
        sfdGuardar.ValidateNames = True
        sfdGuardar.ShowDialog()
        Dim guardararchivo As IO.StreamWriter
        guardararchivo = New IO.StreamWriter(sfdGuardar.FileName)
        guardararchivo.WriteLine(txtCuadro.Text)
        guardararchivo.Close()
    End Sub

    Sub Color()
        cdColor.ShowDialog()
        txtCuadro.ForeColor = cdColor.Color
    End Sub

    Sub Fuente()
        fdFuente.ShowDialog()
        txtCuadro.Font = fdFuente.Font
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Color()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        Fuente()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Abrir()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

#End Region

End Class
