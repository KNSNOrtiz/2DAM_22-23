Public Class formAscii
    Private Sub barraAscii_Scroll(sender As Object, e As ScrollEventArgs) Handles barraAscii.Scroll
        Try
            lblSimbolo.Text = Chr(barraAscii.Value)
            lblNumero.Text = "Valor ASCII: " & barraAscii.Value
        Catch ex As Exception
            Return
        End Try

    End Sub
End Class