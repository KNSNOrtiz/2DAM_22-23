Public Class Form1
    Private Sub btnHolaUp_Click(sender As Object, e As EventArgs) Handles btnHolaUp.Click
        If lblHola.Top <= 0 Then
            lblHola.Top = 0
        End If
        lblHola.Top -= 10
    End Sub

    Private Sub btnHolaLeft_Click(sender As Object, e As EventArgs) Handles btnHolaLeft.Click
        If lblHola.Left <= 0 Then
            lblHola.Left = 0
        End If
        lblHola.Left -= 10
    End Sub

    Private Sub btnHolaDown_Click(sender As Object, e As EventArgs) Handles btnHolaDown.Click
        If lblHola.Top >= (Me.Height - (lblHola.Height * 3)) Then
            lblHola.Top = Me.Height - (lblHola.Height * 3)
        End If
        lblHola.Top += 10
    End Sub

    Private Sub btnHolaRight_Click(sender As Object, e As EventArgs) Handles btnHolaRight.Click
        If lblHola.Left >= (Me.Width - (lblHola.Width * 1.5)) Then
            lblHola.Left = Me.Width - (lblHola.Width * 1.5)
        End If
        lblHola.Left += 10
    End Sub

    Private Sub btnCambiarColor_Click(sender As Object, e As EventArgs) Handles btnCambiarColor.Click
        Me.BackColor = Color.Aquamarine
    End Sub

    Private Sub btnFormUp_Click(sender As Object, e As EventArgs) Handles btnFormUp.Click
        Me.Top -= 5
    End Sub

    Private Sub btnFormLeft_Click(sender As Object, e As EventArgs) Handles btnFormLeft.Click
        Me.Left -= 5
    End Sub

    Private Sub btnFormRight_Click(sender As Object, e As EventArgs) Handles btnFormRight.Click
        Me.Left += 5
    End Sub

    Private Sub btnFormDwn_Click(sender As Object, e As EventArgs) Handles btnFormDwn.Click
        Me.Top += 5
    End Sub
End Class
