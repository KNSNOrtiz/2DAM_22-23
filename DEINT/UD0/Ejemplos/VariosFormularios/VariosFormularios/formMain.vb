Public Class formMain
    Private Sub mitEjercicio1_Click(sender As Object, e As EventArgs) Handles mitEjercicio1.Click
        FormEj1.Show()
    End Sub

    Private Sub btnFocus1_Click(sender As Object, e As EventArgs) Handles btnFocus1.Click
        If FormEj1.Visible Then
            FormEj1.Activate()
        End If
    End Sub

    Private Sub btnFocus2_Click(sender As Object, e As EventArgs) Handles btnFocus2.Click
        If formEj2.Visible Then
            formEj2.Activate()
        End If
    End Sub
End Class
