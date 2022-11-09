Public Class Form1
    Private Sub btnLineas_Click(sender As Object, e As EventArgs) Handles btnLineas.Click
        Dim graficar As System.Drawing.Graphics
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Red)
        graficar = Me.CreateGraphics
        graficar.DrawLine(color, 10, 20, 60, 80)
        Dim punto1 As New Point(80, 20)
        Dim punto2 As New Point(100, 30)
        Dim punto3 As New Point(110, 40)
        Dim punto4 As New Point(70, 50)
        Dim curva As Point() = {punto1, punto2, punto3, punto4}
        graficar.DrawCurve(color, curva)

    End Sub

    Private Sub btnRectangulos_Click(sender As Object, e As EventArgs) Handles btnRectangulos.Click
        Dim graficar As System.Drawing.Graphics
        Dim relleno As New SolidBrush(System.Drawing.Color.Salmon)
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Green)
        graficar = Me.CreateGraphics
        graficar.FillRectangle(relleno, 400, 10, 430, 100)
        Dim punto1 As New Point(500, 140)
        Dim punto2 As New Point(460, 180)
        Dim punto3 As New Point(460, 220)
        Dim punto4 As New Point(500, 260)
        Dim punto5 As New Point(540, 260)
        Dim punto6 As New Point(580, 220)
        Dim punto7 As New Point(580, 180)
        Dim punto8 As New Point(540, 140)
        Dim curva As Point() = {punto1, punto2, punto3, punto4,
         punto5, punto6, punto7, punto8}
        graficar.FillPolygon(relleno, curva, Drawing2D.FillMode.Winding)
        graficar.DrawEllipse(color, 10, 140, 100, 60)

    End Sub
End Class
