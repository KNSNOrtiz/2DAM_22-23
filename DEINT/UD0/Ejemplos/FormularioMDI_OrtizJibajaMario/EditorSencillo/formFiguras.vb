Public Class formFiguras
    Private Sub rbPortatil_CheckedChanged(sender As Object, e As EventArgs) Handles rbPortatil.CheckedChanged
        If rbPortatil.Checked Then
            imgPrincipal.Image = PictureBox1.Image

        End If
    End Sub

    Private Sub rbSatelite_CheckedChanged(sender As Object, e As EventArgs) Handles rbSatelite.CheckedChanged
        If rbSatelite.Checked Then
            imgPrincipal.Image = PictureBox2.Image
        End If
    End Sub

    Private Sub rbFotocopiadora_CheckedChanged(sender As Object, e As EventArgs) Handles rbFotocopiadora.CheckedChanged
        If rbFotocopiadora.Checked Then
            imgPrincipal.Image = PictureBox3.Image
        End If
    End Sub
End Class