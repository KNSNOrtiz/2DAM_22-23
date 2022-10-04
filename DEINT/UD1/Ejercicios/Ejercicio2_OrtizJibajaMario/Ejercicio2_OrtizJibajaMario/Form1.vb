Public Class Form1
    Dim saco As Integer = 1
    Dim camion As Integer = 1
    Dim cargaCamion As Integer? = 0
    Dim cargaSaco As Integer? = 0
    Const MAXCARGA As Integer = 28000
    Const MINCARGA As Integer = 18000
    Const MAXSACA As Integer = 9000
    Const MINSACA As Integer = 3000
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Do While (camion < 20)
            Try
                Dim respuesta As String
                respuesta = InputBox("Introduzca la capacidad del camión nº" + camion.ToString + " en kgs", "Dato capacidad")
                If respuesta = "" Then
                    Me.Close()
                    Me.Dispose()
                    Exit Do
                End If
                cargaCamion = respuesta
                If cargaCamion > MAXCARGA Or cargaCamion < MINCARGA Then
                    MsgBox("La capacidad del camión debe estar enre 18000 y 28000 kgs")
                    cargaCamion = 0
                Else
                    Do While (cargaCamion > 0)
                        respuesta = InputBox("Introduzca el peso de la saca nº" + saco.ToString + " en kgs", "Dato capacidad")
                        If respuesta = "" Then
                            Me.Close()
                            Me.Dispose()
                            Exit Do
                        End If
                        cargaSaco = respuesta
                        If cargaSaco > MAXSACA Or cargaSaco < MINSACA Then
                            MsgBox("La capacidad del saco debe estar entre 3000 y 9000 kgs")
                            cargaSaco = 0
                        Else
                            If ((cargaCamion - cargaSaco) < 0) Then
                                Exit Do
                            End If
                            MsgBox("Cargue la saca nº " + saco.ToString)
                            cargaCamion -= cargaSaco
                            saco += 1
                        End If
                    Loop
                    MsgBox("Despache el camión nº " + camion.ToString + " y ponga a cargar el camión nº " + (camion + 1).ToString)
                    camion += 1
                End If
            Catch ex As InvalidCastException
                MsgBox("Tipo introducido no válido")
                Continue Do
            End Try
        Loop
        lblInfo.Text = "No cargue esta saca. Despache el camión 20. FINALIZADA LA CARGA DEL DÍA"

    End Sub
End Class
