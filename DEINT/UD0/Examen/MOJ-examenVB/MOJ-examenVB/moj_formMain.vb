Public Class moj_formMain

#Region "Ejercicio 1"
    Dim tipoCoche As String
    Dim colorCoche As String

    Sub ActualizarCoche()
        moj_txtCoche.Text = "Coche: " & tipoCoche & " " & colorCoche
    End Sub

    Private Sub moj_rdbGasolina_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbGasolina.CheckedChanged
        If moj_rdbGasolina.Checked Then
            tipoCoche = "Gasolina"
        End If
        ActualizarCoche()
    End Sub

    Private Sub moj_rdbDiesel_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbDiesel.CheckedChanged
        If moj_rdbDiesel.Checked Then
            tipoCoche = "Diesel"
        End If
        ActualizarCoche()
    End Sub

    Private Sub moj_rdbElectrico_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbElectrico.CheckedChanged
        If moj_rdbElectrico.Checked Then
            tipoCoche = "Eléctrico"
        End If
        ActualizarCoche()
    End Sub

    Private Sub moj_rdbNegro_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbNegro.CheckedChanged
        If moj_rdbNegro.Checked Then
            colorCoche = "Negro"
        End If
        ActualizarCoche()
    End Sub

    Private Sub moj_rdbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbBlanco.CheckedChanged
        If moj_rdbBlanco.Checked Then
            colorCoche = "Blanco"
        End If
        ActualizarCoche()
    End Sub

    Private Sub moj_rdbRojo_CheckedChanged(sender As Object, e As EventArgs) Handles moj_rdbRojo.CheckedChanged
        If moj_rdbRojo.Checked Then
            colorCoche = "Rojo"
        End If
        ActualizarCoche()
    End Sub
#End Region


#Region "Ejercicio 2"

    Private Sub moj_btnAnadir_Click(sender As Object, e As EventArgs) Handles moj_btnAnadir.Click
        If moj_txtColor IsNot String.Empty Then
            moj_lbColores.Items.Add(moj_txtColor.Text)
        End If
    End Sub

    Private Sub moj_lbColores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles moj_lbColores.SelectedIndexChanged
        moj_txtColorEscogido.Text = "Escogido: " & moj_lbColores.SelectedItem
    End Sub
#End Region


#Region "Ejercicio 3"
    Private Sub moj_btnCambiarFore_Click(sender As Object, e As EventArgs) Handles moj_btnCambiarFore.Click
        Dim colorLetra As Color
        moj_colDialog.ShowDialog()
        colorLetra = moj_colDialog.Color
        moj_txtEj3.ForeColor = colorLetra
    End Sub

    Private Sub moj_btnCambiarBack_Click(sender As Object, e As EventArgs) Handles moj_btnCambiarBack.Click
        Dim colorLetra As Color
        moj_colDialog.ShowDialog()
        colorLetra = moj_colDialog.Color
        moj_txtEj3.BackColor = colorLetra
    End Sub
#End Region

#Region "Ejercicio 4"
    Dim indice As Integer = 0
    Dim listaImagenes As Bitmap() = {My.Resources.coche_antiguo, My.Resources.coche_dibujo, My.Resources.porsche_model, My.Resources.seat}  '   En este caso he usado esta opción para evitar pérdida de calidad en las imágenes.
    Private Sub moj_btnIniciar_Click(sender As Object, e As EventArgs) Handles moj_btnIniciar.Click
        If moj_timerCoche.Enabled = False Then
            moj_timerCoche.Enabled = True
        End If
    End Sub

    Private Sub moj_btnParar_Click(sender As Object, e As EventArgs) Handles moj_btnParar.Click
        If moj_timerCoche.Enabled Then
            moj_timerCoche.Enabled = False
        End If
    End Sub

    Private Sub moj_timerCoche_Tick(sender As Object, e As EventArgs) Handles moj_timerCoche.Tick
        moj_imgCoche.Image = listaImagenes(indice)
        indice += 1
        If indice = listaImagenes.Count Then
            indice = 0
        End If
    End Sub
#End Region

    Private Sub Ejercicio1()
        If moj_gbxEjercicio1.Visible = False Then
            moj_gbxEjercicio1.Visible = True
            moj_txtEstado.Text = "Ejercicio 1"
        End If
        moj_gbxEjercicio2.Visible = False
        moj_gbxEjercicio3.Visible = False
        moj_gbxEjercicio4.Visible = False
    End Sub
    Private Sub Ejercicio2()
        If moj_gbxEjercicio2.Visible = False Then
            moj_gbxEjercicio2.Visible = True
            moj_txtEstado.Text = "Ejercicio 2"
        End If
        moj_gbxEjercicio1.Visible = False
        moj_gbxEjercicio3.Visible = False
        moj_gbxEjercicio4.Visible = False
    End Sub

    Private Sub Ejercicio3()
        If moj_gbxEjercicio3.Visible = False Then
            moj_gbxEjercicio3.Visible = True
            moj_txtEstado.Text = "Ejercicio 3"
        End If
        moj_gbxEjercicio1.Visible = False
        moj_gbxEjercicio2.Visible = False
        moj_gbxEjercicio4.Visible = False
    End Sub
    Private Sub Ejercicio4()
        If moj_gbxEjercicio4.Visible = False Then
            moj_gbxEjercicio4.Visible = True
            moj_txtEstado.Text = "Ejercicio 4"
        End If
        moj_gbxEjercicio1.Visible = False
        moj_gbxEjercicio2.Visible = False
        moj_gbxEjercicio3.Visible = False

    End Sub

    Private Sub moj_itemSalir_Click(sender As Object, e As EventArgs) Handles moj_itemSalir.Click
        Dim resultado As MsgBoxResult = MsgBox("Se va a cerrar el programa. ¿Estás seguro?", MsgBoxStyle.YesNo, "Cierre del programa")
        If resultado = MsgBoxResult.Yes Then
            Me.Close()
            Me.Dispose()
        Else
            Return
        End If

    End Sub
    Private Sub moj_itemInfo_Click(sender As Object, e As EventArgs) Handles moj_itemInfo.Click
        moj_formInfo.ShowDialog()
    End Sub

    Private Sub moj_itemEjercicio1_Click(sender As Object, e As EventArgs) Handles moj_itemEjercicio1.Click
        Ejercicio1()
    End Sub

    Private Sub moj_itemEjercicio2_Click(sender As Object, e As EventArgs) Handles moj_itemEjercicio2.Click
        Ejercicio2()
    End Sub

    Private Sub moj_itemEjercicio3_Click(sender As Object, e As EventArgs) Handles moj_itemEjercicio3.Click
        Ejercicio3()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        Ejercicio4()
    End Sub

    Private Sub moj_toolEj1_Click(sender As Object, e As EventArgs) Handles moj_toolEj1.Click
        Ejercicio1()
    End Sub

    Private Sub moj_toolEj2_Click(sender As Object, e As EventArgs) Handles moj_toolEj2.Click
        Ejercicio2()
    End Sub

    Private Sub moj_toolEj3_Click(sender As Object, e As EventArgs) Handles moj_toolEj3.Click
        Ejercicio3()
    End Sub

    Private Sub moj_toolEj4_Click(sender As Object, e As EventArgs) Handles moj_toolEj4.Click
        Ejercicio4()
    End Sub

    Private Sub moj_formMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        moj_toolEj1.Image = moj_listaIconos.Images(0)
        moj_toolEj2.Image = moj_listaIconos.Images(1)
        moj_toolEj3.Image = moj_listaIconos.Images(2)
        moj_toolEj4.Image = moj_listaIconos.Images(3)
    End Sub

    Private Sub moj_itemAnadirColor_Click(sender As Object, e As EventArgs) Handles moj_itemAnadirColor.Click
        MsgBox(moj_itemAnadirColor.Text)
    End Sub

    Private Sub moj_itemColorAleatorio_Click(sender As Object, e As EventArgs) Handles moj_itemColorAleatorio.Click
        MsgBox(moj_itemColorAleatorio.Text)
    End Sub

    Private Sub moj_itemStock_Click(sender As Object, e As EventArgs) Handles moj_itemStock.Click
        MsgBox(moj_itemColorAleatorio.Text)
    End Sub
End Class
