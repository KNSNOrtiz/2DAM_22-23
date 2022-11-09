Imports System.IO
Imports System.Timers

Public Class formMain

#Region "MÉTODOS"
    Sub Abrir()
        ofdAbrir.Title = "Seleccione el archivo..."
        ofdAbrir.FileName = ""
        ofdAbrir.InitialDirectory = "C:\"
        ofdAbrir.Filter = "Archivo de texto (.txt)|*.txt"
        ofdAbrir.ShowDialog()
        If ofdAbrir.FileName.Length > 0 Then
            Dim verarchivo As New IO.StreamReader(Me.ofdAbrir.FileName)
            Dim formularioEditar As New formEditar
            formularioEditar.MdiParent = Me
            formularioEditar.Text = ofdAbrir.FileName
            formularioEditar.txtCuadro.Text = verarchivo.ReadToEnd
            formularioEditar.Show()
        End If


    End Sub

    Sub Nuevo()
        Dim formularioEditar As New formEditar
        formularioEditar.MdiParent = Me
        ofdAbrir.FileName = "Nuevo fichero de texto.txt"
        formularioEditar.Text = "Sin título"
        formularioEditar.Show()
    End Sub



#End Region

#Region "EVENTOS"


    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitAbrir.Click
        Abrir()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitNuevo.Click
        Nuevo()
    End Sub

    Private Sub toolNuevo_Click(sender As Object, e As EventArgs) Handles toolNuevo.Click
        Nuevo()
    End Sub

    Private Sub toolAbrir_Click(sender As Object, e As EventArgs) Handles toolAbrir.Click
        Abrir()
    End Sub

    Private Sub toolSalir_Click(sender As Object, e As EventArgs) Handles toolSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub



    Private Sub mitFecha_Click(sender As Object, e As EventArgs) Handles mitFecha.Click
        Dim formularioFecha As New formDatePicker
        formularioFecha.MdiParent = Me
        mitFecha.Enabled = False
        formularioFecha.Show()
    End Sub

    Private Sub mitFiguras_Click(sender As Object, e As EventArgs) Handles mitFiguras.Click
        Dim formularioFiguras As New formFiguras
        formularioFiguras.MdiParent = Me
        formularioFiguras.Show()
    End Sub

    Private Sub mitASCII_Click(sender As Object, e As EventArgs) Handles mitASCII.Click
        Dim formularioASCII As New formAscii
        formularioASCII.MdiParent = Me
        formularioASCII.Show()
    End Sub

    Private Sub mitCerrar_Click(sender As Object, e As EventArgs)
        txtCuadro.Visible = False
    End Sub

    Private Sub mitCascada_Click(sender As Object, e As EventArgs) Handles mitCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mitHorizontal_Click(sender As Object, e As EventArgs) Handles mitHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mitVertical_Click(sender As Object, e As EventArgs) Handles mitVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub


#End Region

End Class
