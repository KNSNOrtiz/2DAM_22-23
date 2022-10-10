Public Class winMain
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim turismos As Integer = 0
        Dim todoterrenos As Integer = 0
        Dim capTurismos As Integer = 0
        Dim capTodoterrenos As Integer = 0
        Dim necesidades As Integer = 0
        If txtTurismos.Text.Length > 0 And txtTodoterrenos.Text.Length > 0 And txtCapTurismos.Text.Length > 0 And txtCapTodoterr.Text.Length > 0 Then
            Try
                turismos = Int32.Parse(txtTurismos.Text)
                todoterrenos = Int32.Parse(txtTodoterrenos.Text)
                capTurismos = Int32.Parse(txtCapTurismos.Text)
                capTodoterrenos = Int32.Parse(txtCapTodoterr.Text)

            Catch ex As Exception
                MsgBox("Los valores deben ser números enteros.")
                Return
            End Try
            necesidades = turismos * capTurismos + todoterrenos * capTodoterrenos
            lblResultado.Text = String.Format("Las necesidades totales de combustible son de {0} litros", necesidades.ToString)
        Else
            MsgBox("Ningún campo puede estar vacío")
            Return
        End If
    End Sub

    Private Sub winMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        gbxEj1.Visible = False
    End Sub

    Private Sub mitEjercicio1_Click(sender As Object, e As EventArgs) Handles mitEjercicio1.Click
        If gbxEj1.Visible Then
            gbxEj1.Visible = False
        Else
            gbxEj3.Visible = False
            gbxEjercicio2.Visible = False
            gbxEj1.Visible = True
        End If
    End Sub

    Private Sub btnCalcularVolumen_Click(sender As Object, e As EventArgs) Handles btnCalcularVolumen.Click
        Dim diametro As Double = 0
        Dim altura As Double = 0
        Dim volumen As Double = 0
        If txtDiametro.Text.Length > 0 And txtAltura.Text.Length > 0 Then
            Try
                diametro = Double.Parse(txtDiametro.Text)
                altura = Double.Parse(txtAltura.Text)
            Catch ex As Exception
                MsgBox("Los valores deben ser numéricos.")
                Return
            End Try
            volumen = Math.PI * (Math.Pow((diametro / 2), 2)) * altura
            lblVolumen.Text = String.Format("El volumen del cilindro es de {0} metros cúbicos", volumen.ToString("0.000000"))
        Else
            MsgBox("Los dos campos deben tener valores")
            Return
        End If

    End Sub

    Private Sub btnCalcularMedia_Click(sender As Object, e As EventArgs) Handles btnCalcularMedia.Click
        Dim precio1 As Double = 0
        Dim precio2 As Double = 0
        Dim precio3 As Double = 0
        Dim mediaPrecios As Double = 0
        If txtPrecio1.Text.Length > 0 And txtPrecio2.Text.Length > 0 And txtPrecio3.Text.Length > 0 Then
            Try
                precio1 = Double.Parse(txtPrecio1.Text)
                precio2 = Double.Parse(txtPrecio2.Text)
                precio3 = Double.Parse(txtPrecio3.Text)
            Catch ex As Exception
                MsgBox("Los valores deben ser numéricos.")
                Return
            End Try
            mediaPrecios = (precio1 + precio2 + precio3) / 3
            lblMedia.Text = String.Format("El precio medio del producto es de {0} euros", mediaPrecios.ToString("F"))
        Else
            MsgBox("Ninguno de los tres campos puede estar vacío.")
            Return
        End If
    End Sub

    Private Sub mitEjercicio2_Click(sender As Object, e As EventArgs) Handles mitEjercicio2.Click
        If gbxEjercicio2.Visible Then
            gbxEjercicio2.Visible = False
        Else
            gbxEj1.Visible = False
            gbxEj3.Visible = False
            gbxEjercicio2.Visible = True
        End If
    End Sub

    Private Sub mitEjercicio3_Click(sender As Object, e As EventArgs) Handles mitEjercicio3.Click
        If gbxEj3.Visible Then
            gbxEj3.Visible = False
        Else
            gbxEj1.Visible = False
            gbxEjercicio2.Visible = False
            gbxEj3.Visible = True
        End If
    End Sub

    Private Sub mitSalir_Click(sender As Object, e As EventArgs) Handles mitSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
