Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class winMain
    Dim graficar As System.Drawing.Graphics = Me.CreateGraphics()
    Dim color As New System.Drawing.Pen(System.Drawing.Color.Black)
    Dim maxAncho As Integer = Me.Width
    Dim maxAlto As Integer = Me.Height

    Private Sub Limpiar()
        If lblDiametro.Visible Then
            lblDiametro.Visible = False
            lblArea.Visible = False
            lblCircunferencia.Visible = False
        End If
        graficar.Clear(Me.BackColor)
    End Sub

    Private Sub DibujarLineas()
        maxAncho = Me.Width
        maxAlto = Me.Height
        Dim GenerarNum As Random = New Random
        Dim p1 As Point = New Point(GenerarNum.Next(maxAncho), GenerarNum.Next(maxAlto))
        Dim p2 As Point = New Point(GenerarNum.Next(maxAncho), GenerarNum.Next(maxAlto))
        color = New System.Drawing.Pen(System.Drawing.Color.FromArgb(GenerarNum.Next(256), GenerarNum.Next(256), GenerarNum.Next(256)))
        graficar.DrawLine(color, p1, p2)
    End Sub

    Private Sub PantallaCompleta()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        graficar = Me.CreateGraphics()
    End Sub
    Private Sub mitLimpiar_Click(sender As Object, e As EventArgs) Handles mitLimpiar.Click
        Limpiar()
    End Sub

    Private Sub mitEj1_Click(sender As Object, e As EventArgs) Handles mitEj1.Click
        Limpiar()
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Black)
        graficar = Me.CreateGraphics
        Dim separacionX As Integer = 10
        For i As Integer = 1 To 10
            graficar.DrawEllipse(color, separacionX, 140, 50, 50)
            separacionX += 5
        Next
    End Sub

    Private Sub mitEj2_Click(sender As Object, e As EventArgs) Handles mitEj2.Click
        Limpiar()
        Randomize()
        graficar = Me.CreateGraphics
        maxAncho = Me.Width
        maxAlto = Me.Height
        DibujarLineas()
    End Sub



    Private Sub mitEj3_Click(sender As Object, e As EventArgs) Handles mitEj3.Click
        Limpiar()
        color = New System.Drawing.Pen(System.Drawing.Color.Black)
        Dim anguloInicial As Integer = 0
        Dim anguloSiguiente As Integer = 0
        Dim xInicial As Integer = 1
        For i As Integer = 1 To 10
            graficar.DrawArc(color, 200, 200, i * 5, i * 5, 0, 360)
            anguloInicial = anguloSiguiente
            anguloSiguiente += 180
        Next

    End Sub

    Private Sub mitEj4_Click(sender As Object, e As EventArgs) Handles mitEj4.Click
        Limpiar()
        Randomize()
        maxAlto = Me.Height
        maxAncho = Me.Width
        graficar = Me.CreateGraphics()
        Dim GenerarNum As Random = New Random
        Dim p1 As Point = New Point(GenerarNum.Next(maxAncho), GenerarNum.Next(maxAlto))
        Dim lBrush As New SolidBrush(System.Drawing.Color.Black)
        graficar.DrawString("Aguacate", New Font(FontFamily.Families(GenerarNum.Next(FontFamily.Families.Length)), GenerarNum.Next(8, 25), FontStyle.Regular), lBrush, p1)
    End Sub

    Private Sub mitEj5_Click(sender As Object, e As EventArgs) Handles mitEj5.Click
        Limpiar()
        Randomize()
        graficar = Me.CreateGraphics()
        Dim GenerarNum As Random = New Random
        Dim palabra As String = InputBox("Introduce una palabra:", "Ejercicio 5")
        Dim colorBrush As Color = System.Drawing.Color.FromArgb(GenerarNum.Next(256), GenerarNum.Next(256), GenerarNum.Next(256))
        Dim lBrush As New SolidBrush(colorBrush)
        Dim estiloFuente As FontStyle = GenerarNum.Next(9)
        graficar.DrawString(palabra, New Font(FontFamily.Families(GenerarNum.Next(FontFamily.Families.Length)), GenerarNum.Next(8, 25), estiloFuente), lBrush, New Point(50, 50))
    End Sub

    Private Sub mitEj6_Click(sender As Object, e As EventArgs) Handles mitEj6.Click
        Limpiar()
        Dim colorRelleno As SolidBrush = New SolidBrush(System.Drawing.Color.White)
        graficar = Me.CreateGraphics()
        Dim x As Integer
        Dim y As Integer
        For i As Integer = 1 To 8
            x = 30
            y += 50
            If colorRelleno.Color = System.Drawing.Color.Black Then
                colorRelleno.Color = System.Drawing.Color.White
            Else
                colorRelleno.Color = System.Drawing.Color.Black
            End If
            For j As Integer = 1 To 8
                If colorRelleno.Color = System.Drawing.Color.Black Then
                    colorRelleno.Color = System.Drawing.Color.White
                Else
                    colorRelleno.Color = System.Drawing.Color.Black
                End If
                graficar.FillRectangle(colorRelleno, x, y, 50, 50)
                x += 50
            Next
        Next
    End Sub

    Private Sub mitEj8_Click(sender As Object, e As EventArgs) Handles mitEj8.Click
        Limpiar()
        maxAlto = Me.Height
        maxAncho = Me.Width
        Randomize()
        Dim GenerarNum As Random = New Random
        Dim numTriangulos As Integer
        graficar = Me.CreateGraphics()
        Try
            numTriangulos = InputBox("Nº de triángulos a dibujar:", "Ejercicio 8", "1")
        Catch ex As InvalidCastException
            MsgBox("ERROR: Se debe introducir un número válido.", MsgBoxStyle.MsgBoxRight, "Error de tipo")
            Return
        End Try
        Dim x As Integer = 40
        Dim y As Integer = 60
        Dim p1, p2, p3 As Point
        Dim altura As Integer = 60
        Dim desplazamiento As Integer = 30
        For i As Integer = 1 To numTriangulos
            Dim colorRelleno As SolidBrush = New SolidBrush(System.Drawing.Color.FromArgb(GenerarNum.Next(256), GenerarNum.Next(256), GenerarNum.Next(256)))
            p1 = New Point(x, y)
            p2 = New Point(x - desplazamiento, y + altura)
            p3 = New Point(x + desplazamiento, y + altura)
            Dim puntosTriangulo() As Point = {p1, p2, p3}
            graficar.FillPolygon(colorRelleno, puntosTriangulo)
            If x + 60 >= maxAncho Then
                y += 100
                x = 40
            Else
                x += 60
            End If

        Next

    End Sub

    Private Sub mitEj9_Click(sender As Object, e As EventArgs) Handles mitEj9.Click     '   Puede ser necesario darle dos veces al ejercicio para que se muestre el círculo.
        Limpiar()
        graficar = Me.CreateGraphics()
        color = New System.Drawing.Pen(System.Drawing.Color.Black)
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim radio As Double = 0
        Dim diametro As Double = 0
        Dim area As Double = 0
        Dim circunferencia As Double = 0
        If formEjercicio9.ShowDialog() = DialogResult.OK Then
            x = formEjercicio9.posX
            y = formEjercicio9.posY
            radio = formEjercicio9.Radio
            diametro = Math.Pow(radio, 2)
            area = Math.Round(Math.PI * diametro, 2)
            circunferencia = Math.Round(2 * Math.PI * radio, 2)
        End If
        lblDiametro.Text = "Diámetro: " + diametro.ToString
        lblArea.Text = "Área: " + area.ToString
        lblCircunferencia.Text = "Circunferencia: " + circunferencia.ToString
        lblDiametro.Visible = True
        lblArea.Visible = True
        lblCircunferencia.Visible = True
        graficar.DrawEllipse(color, x, y, CInt(radio), CInt(radio))
    End Sub

    Private Sub mitEj10_Click(sender As Object, e As EventArgs) Handles mitEj10.Click
        Limpiar()
        PantallaCompleta()
        For i As Integer = 0 To 50
            DibujarLineas()
        Next
        Thread.Sleep(2000)  '   De no pausar el programa, las líneas se borran automáticamente y no da tiempo a verlas. No he podido averiguar por qué.
    End Sub

    Private Sub winMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
        End If
    End Sub
End Class
