Imports System.IO
Imports System.Runtime.CompilerServices

Public Class formEditar
    Sub Guardar()
        sfdGuardar.Title = "Guardar archivo..."
        sfdGuardar.InitialDirectory = CType(MdiParent, formMain).ofdAbrir.FileName
        sfdGuardar.Filter = "Archivo de texto (.txt)|*.txt"
        sfdGuardar.FileName = CType(MdiParent, formMain).ofdAbrir.FileName
        sfdGuardar.ValidateNames = True
        Dim resultado As DialogResult = sfdGuardar.ShowDialog()
        If resultado = DialogResult.OK Then
            If sfdGuardar.FileName.Length > 0 Then
                Try
                    Dim guardararchivo As IO.StreamWriter
                    guardararchivo = New IO.StreamWriter(sfdGuardar.FileName)
                    guardararchivo.WriteLine(txtCuadro.Text)
                    guardararchivo.Close()
                Catch ex As IOException
                    MsgBox("No se ha guardado el archivo.")
                End Try
            End If
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

    Sub Imprimir()
        pdImprimir.DocumentName = sfdGuardar.FileName
        ppdImprimir.Document = pdImprimir
        If ppdImprimir.ShowDialog() = DialogResult.OK Then
            pdImprimir.Print()
        End If
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolGuardar.Click
        Guardar()
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

    Private Sub txtCuadro_TextChanged(sender As Object, e As EventArgs) Handles txtCuadro.TextChanged
        lblCaracteres.Text = "Caracteres: " & txtCuadro.TextLength
        lblLinea.Text = "Líneas: " & txtCuadro.Lines.Length
    End Sub

    Private Sub formEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As MsgBoxResult = MsgBox("Se va a cerrar el archivo " & Me.Text & " ¿Quieres guardar los datos?", MsgBoxStyle.YesNoCancel, "Cierre del fichero")
        If resultado = MsgBoxResult.Yes Then
            Guardar()
        ElseIf resultado = MsgBoxResult.Cancel Then
            e.Cancel = True
        End If

    End Sub

    Private Sub toolImprimir_Click(sender As Object, e As EventArgs) Handles toolImprimir.Click
        Imprimir()
    End Sub

    Private Sub pdImprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdImprimir.PrintPage
        Dim caracteresPorPagina As Integer = 0
        Dim lineasPorPagina As Integer = 0
        Dim textoAImprimir As String = txtCuadro.Text
        e.Graphics.MeasureString(textoAImprimir, txtCuadro.font, e.MarginBounds.Size, StringFormat.GenericTypographic, caracteresPorPagina, lineasPorPagina)
        e.Graphics.DrawString(textoAImprimir, Me.Font, New SolidBrush(txtCuadro.ForeColor), e.MarginBounds, StringFormat.GenericTypographic)
        textoAImprimir = textoAImprimir.Substring(caracteresPorPagina)
        e.HasMorePages = (textoAImprimir.Length > 0)

    End Sub
End Class