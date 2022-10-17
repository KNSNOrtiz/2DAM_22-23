Public Class formEjercicio9
    Dim x As Integer
    Dim y As Integer
    Dim rad As Double

    Public Property posX As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            If value <= 100 Then
                value = 100
            End If
            x = value
        End Set
    End Property
    Public Property posY As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            If value < 120 Then
                value = 120
            End If
            y = value
        End Set
    End Property
    Public Property Radio As Double
        Get
            Return rad
        End Get
        Set(value As Double)
            If value <= 0 Then
                value = 1
            End If
            If value > 200 Then
                value = 200
            End If
            rad = value
        End Set
    End Property
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            posX = tbxPosX.Text
            posY = tbxPosY.Text
        Catch ex As InvalidCastException
            MsgBox("ERROR: Los campos de coordenadas deben ser de tipo entero", MsgBoxStyle.MsgBoxRight, "Error en campos")
            Return
        End Try
        Try
            Radio = tbxRadio.Text
        Catch ex As InvalidCastException
            MsgBox("ERROR: El radio debe ser de tipo numérico", MsgBoxStyle.MsgBoxRight, "Error en radio")
        End Try
        Me.DialogResult = DialogResult.OK
    End Sub
End Class