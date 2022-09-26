Public Class Form1
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim respuesta
        respuesta = MsgBox("¿Seguro que quieres cancelar?", vbYesNo, "Cancelar")
        If respuesta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim respuesta
        respuesta = InputBox("DNI a buscar: ", "Buscar", "123456789Z")
        MsgBox("Quieres buscar: " + respuesta)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class
