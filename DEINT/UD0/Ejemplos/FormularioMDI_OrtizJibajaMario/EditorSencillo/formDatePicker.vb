Public Class formDatePicker
    Private Sub controlFecha_ValueChanged(sender As Object, e As EventArgs) Handles controlFecha.ValueChanged
        lblFecha.Text = controlFecha.Text
    End Sub

    Private Sub formDatePicker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CType(MdiParent, formMain).mitFecha.Enabled = True
    End Sub
End Class