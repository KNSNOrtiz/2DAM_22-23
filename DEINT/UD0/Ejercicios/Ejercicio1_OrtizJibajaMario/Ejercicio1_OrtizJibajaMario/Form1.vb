Imports System.Threading
Public Class Form1
    Dim unidades As Integer = 1000

    Private Sub Form1_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Thread.Sleep(1000)
        Do While unidades >= 200
            Try
                Dim entrega As String = InputBox("Introduzca el número de uds entregadas:", "Dato entrega")
                unidades -= Convert.ToInt32(entrega)
                lblUnidades.Text = "Se pueden hacer entregas. Quedan " + unidades.ToString + " unidades."
            Catch

            End Try
        Loop
        If unidades < 200 Then
            lblUnidades.Text = "El inventario ha bajado de 200 unidades. Debe comunicarlo."
        End If
    End Sub



End Class
