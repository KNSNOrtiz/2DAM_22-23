Public Class formMain
    Private Sub btnAvion_Click(sender As Object, e As EventArgs) Handles btnAvion.Click
        If formEj1.Visible = False Then
            formEj1.ShowDialog()
        End If
    End Sub
End Class