Imports System.DirectoryServices.ActiveDirectory
Imports System.Threading

Public Class formCargar

    Dim capacidadSaca As Integer = formMain.hbarSaca.Value
    Dim cargaActual As Integer = 0
    Dim cargaTotal As Integer = 0
    Dim numSacos As Integer = 0
    Dim numCamiones As Integer = 0
    Dim camion As Camion


    Private Sub ComenzarCamion()
        imgCamion.Image = camion.Imagen
        imgCamion.Visible = True
        timerEmpezar.Enabled = True
        txtInformacion.Text = "El camión " & camion.Nombre & " va a comenzar a cargarse."

    End Sub

    Private Sub ComenzarCarga()
        timerEmpezar.Enabled = False
        imgSaco.Image = imgAuxLleno.Image
        pgbCarga.Maximum = capacidadSaca
        pgbCarga.Step = capacidadSaca / 5
        timerCarga.Enabled = True
        txtInformacion.Text = "El camión " & camion.Nombre & " se está cargando."
    End Sub

    Private Sub Iniciar()
        imgSaco.Image = imgAuxLleno.Image
        camion = cbxCamiones.SelectedItem
        ComenzarCamion()
    End Sub

    Private Sub formCargar_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cbxCamiones.DataSource = formMain.listaCamiones
        cbxCamiones.SelectedIndex = formMain.lbCamiones.SelectedIndex
        MsgBox("En esta demo se van a cargar un total de 5 camiones.", MsgBoxStyle.OkOnly, "INFORMACIÓN")
        Iniciar()
    End Sub

    Private Sub Reiniciar()
        If numCamiones = 5 Then
            MsgBox("Se han cargado un total de " & cargaTotal & " kg de arroz.", MsgBoxStyle.OkOnly, "Fin de la jornada")
            Me.Dispose()
        Else
            imgCamion.Visible = False
            imgCamion.Left = 0
            numSacos = 0
            cargaActual = 0
            txtNumSaco.Text = "Nº Sacos: " & numSacos
            txtInformacion.Text = "Selecciona un camión de la lista para comenzar la carga."
            cbxCamiones.Enabled = True
        End If


    End Sub


    Private Sub timerCarga_Tick(sender As Object, e As EventArgs) Handles timerCarga.Tick
        If ((cargaActual + capacidadSaca) <= camion.Capacidad) Then
            If pgbCarga.Value < pgbCarga.Maximum Then
                pgbCarga.PerformStep()
                If txtCargando.Visible Then
                    txtCargando.Visible = False
                Else
                    txtCargando.Visible = True
                End If
            Else
                pgbCarga.Value = 0
                cargaActual += capacidadSaca
                numSacos += 1
            End If
            txtNumSaco.Text = "Nº Sacos: " & numSacos
        Else

            imgSaco.Image = imgAuxVacio.Image
            cargaTotal += cargaActual
            timerCarga.Enabled = False
            timerDepartir.Enabled = True
        End If
    End Sub

    Private Sub timerEmpezar_Tick(sender As Object, e As EventArgs) Handles timerEmpezar.Tick
        If imgCamion.Left < imgSaco.Left Then
            imgCamion.Left += 1
        Else
            ComenzarCarga()
        End If
    End Sub

    Private Sub timerDepartir_Tick(sender As Object, e As EventArgs) Handles timerDepartir.Tick
        txtInformacion.Text = "El camión " & camion.Nombre & " no puede cargar otro saco más. Departiendo."
        If imgCamion.Left < Me.Width Then
            imgCamion.Left += 1
        Else
            numCamiones += 1
            txtNumCamion.Text = "Nº camión: " & numCamiones
            timerDepartir.Enabled = False
            Reiniciar()
        End If
    End Sub

    Private Sub cbxCamiones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCamiones.SelectedIndexChanged
        camion = cbxCamiones.SelectedItem
        Iniciar()
    End Sub

    Private Sub formCargar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class