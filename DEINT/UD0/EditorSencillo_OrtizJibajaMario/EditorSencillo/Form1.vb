Imports System.IO
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
        If sfdGuardar.FileName.Length > 0 Then
            Try
                Dim guardararchivo As IO.StreamWriter
                guardararchivo = New IO.StreamWriter(sfdGuardar.FileName)
                guardararchivo.WriteLine(txtCuadro.Text)
                guardararchivo.Close()
            Catch ex As IOException
                MsgBox("ERROR: No se ha podido guardar/escribir el archivo.")
            End Try
        End If
    End Sub

    Sub Color()
        cdColor.ShowDialog()
        txtCuadro.ForeColor = cdColor.Color
    End Sub

    Sub Fuente()
        fdFuente.ShowDialog()
        txtCuadro.Font = fdFuente.Font
    End Sub

    Sub SeleccionarTodo()
        txtCuadro.SelectAll()
    End Sub

    Sub Cortar()
        Copiar()
        txtCuadro.SelectedText = ""
    End Sub

    Sub Copiar()
        If txtCuadro.SelectedText.Length > 0 Then
            Clipboard.SetText(txtCuadro.SelectedText)
        End If
    End Sub

    Sub Pegar()
        txtCuadro.SelectedText += Clipboard.GetText()
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitColor.Click
        Color()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitFuente.Click
        Fuente()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitGuardar.Click
        Guardar()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitAbrir.Click
        Abrir()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitNuevo.Click
        Nuevo()
    End Sub

    Private Sub toolNuevo_Click(sender As Object, e As EventArgs) Handles toolNuevo.Click
        Nuevo()
    End Sub

    Private Sub toolGuardar_Click(sender As Object, e As EventArgs) Handles toolGuardar.Click
        Guardar()
    End Sub

    Private Sub toolAbrir_Click(sender As Object, e As EventArgs) Handles toolAbrir.Click
        Abrir()
    End Sub

    Private Sub toolColor_Click(sender As Object, e As EventArgs) Handles toolColor.Click
        Color()
    End Sub

    Private Sub toolFuente_Click(sender As Object, e As EventArgs) Handles toolFuente.Click
        Fuente()
    End Sub

    Private Sub toolSalir_Click(sender As Object, e As EventArgs) Handles toolSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub mitSelectTodo_Click(sender As Object, e As EventArgs) Handles mitSelectTodo.Click
        SeleccionarTodo()
    End Sub

    Private Sub mitCortar_Click(sender As Object, e As EventArgs) Handles mitCortar.Click
        Cortar()
    End Sub

    Private Sub mitPegar_Click(sender As Object, e As EventArgs) Handles mitPegar.Click
        Pegar()
    End Sub

    Private Sub toolSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles toolSeleccionarTodo.Click
        SeleccionarTodo()
    End Sub

    Private Sub toolCortar_Click(sender As Object, e As EventArgs) Handles toolCortar.Click
        Cortar()
    End Sub

    Private Sub toolCopiar_Click(sender As Object, e As EventArgs) Handles toolCopiar.Click
        Copiar()
    End Sub

    Private Sub toolPegar_Click(sender As Object, e As EventArgs) Handles toolPegar.Click
        Pegar()
    End Sub

#End Region

End Class
