Imports System.ComponentModel

Public Class formMain

    Public Shared listaCamiones As New BindingList(Of Camion)()


    Private Sub timerFechaHora_Tick(sender As Object, e As EventArgs) Handles timerFechaHora.Tick
        txtFechaHora.Text = "Fecha y hora actuales: " & DateTime.Now.ToString

    End Sub

    Private Sub formMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim camionA As New Camion("Camión A", 18000, listaImagenes.Images(0))
        txtFechaHora.Text = "Fecha y hora actuales: " & DateTime.Now.ToString
        listaCamiones.Add(camionA)
        lbCamiones.DataSource = listaCamiones
    End Sub

    Private Sub itemAlta_Click(sender As Object, e As EventArgs) Handles itemAlta.Click
        formAlta.ShowDialog()
    End Sub

    Private Sub lbCamiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCamiones.SelectedIndexChanged
        If listaCamiones.Count > 0 Then
            Dim camionTmp = CType(lbCamiones.SelectedItem, Camion)
            imgCamion.Image = camionTmp.Imagen
        Else
            imgCamion.Image = Nothing
        End If


    End Sub

    Private Sub hbarSaca_ValueChanged(sender As Object, e As EventArgs) Handles hbarSaca.ValueChanged
        txtPesoSaca.Text = "Peso de la saca: " & hbarSaca.Value
    End Sub

    Private Sub itemBaja_Click(sender As Object, e As EventArgs) Handles itemBaja.Click
        If lbCamiones.Items.Count > 1 Then
            Dim resultado As MsgBoxResult = MsgBox("Se va a eliminar el camión " & listaCamiones(lbCamiones.SelectedIndex).Nombre & " . ¿Seguro?", MsgBoxStyle.YesNo, "Baja de camión")
            If resultado = MsgBoxResult.Yes Then
                listaCamiones.RemoveAt(lbCamiones.SelectedIndex)
            End If
        Else
            MsgBox("Debe haber mínimo un camión. No es posible dar todos de baja.", MsgBoxStyle.OkOnly, "Error de baja")
        End If
    End Sub

    Private Sub itemCargar_Click(sender As Object, e As EventArgs) Handles itemCargar.Click
        formCargar.ShowDialog()
    End Sub
End Class
