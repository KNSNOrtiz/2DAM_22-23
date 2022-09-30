Public Class Form1
    Private Sub radAno_CheckedChanged(sender As Object, e As EventArgs) Handles radAno.CheckedChanged
        txtDesde.Enabled = False
        txtHasta.Enabled = False
    End Sub

    Private Sub radHoy_CheckedChanged(sender As Object, e As EventArgs) Handles radHoy.CheckedChanged
        txtDesde.Enabled = False
        txtHasta.Enabled = False
    End Sub

    Private Sub radRango_CheckedChanged(sender As Object, e As EventArgs) Handles radRango.CheckedChanged
        txtDesde.Enabled = True
        txtHasta.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class
