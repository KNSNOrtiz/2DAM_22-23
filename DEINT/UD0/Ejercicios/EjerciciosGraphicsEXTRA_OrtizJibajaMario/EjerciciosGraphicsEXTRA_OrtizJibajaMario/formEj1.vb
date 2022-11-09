Imports System.Linq.Expressions

Public Class formEj1
    Sub Iniciar()
        pbxAvion.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Sub Derecha()
        If pbxAvion.Left < Me.Width - pbxAvion.Width Then
            pbxAvion.Left += 10
        End If
    End Sub

    Sub Abajo()
        If pbxAvion.Top < Me.Height - pbxAvion.Height * 2 Then
            pbxAvion.Top += 10
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Iniciar()
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        Abajo()
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        Derecha()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Abajo()
    End Sub

    Private Sub btnAutoDerecha_Click(sender As Object, e As EventArgs) Handles btnAutoDerecha.Click
        If Timer2.Enabled Then
            Timer2.Enabled = False
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub btnAutoAbajo_Click(sender As Object, e As EventArgs) Handles btnAutoAbajo.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Derecha()
    End Sub
End Class
