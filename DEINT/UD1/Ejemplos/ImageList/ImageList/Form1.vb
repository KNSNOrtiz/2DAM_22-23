Public Class Form1
    Private Sub rdbImg1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImg1.CheckedChanged
        PictureBox1.Image = imliListado.Images(0)
    End Sub

    Private Sub rdbImg2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImg2.CheckedChanged
        PictureBox1.Image = imliListado.Images(1)
    End Sub
End Class
