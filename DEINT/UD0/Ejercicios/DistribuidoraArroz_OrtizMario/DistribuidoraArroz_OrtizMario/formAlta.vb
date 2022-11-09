Imports System.Diagnostics.Tracing

Public Class formAlta

    Private Sub CambiarPreview()
        If rdbA.Checked Then
            imgPreview.Image = formMain.listaImagenes.Images(0)
        End If
        If rdbB.Checked Then
            imgPreview.Image = formMain.listaImagenes.Images(1)
        End If
        If rdbC.Checked Then
            imgPreview.Image = formMain.listaImagenes.Images(2)
        End If
    End Sub

    Private Sub formAlta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub rdbA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbA.CheckedChanged
        CambiarPreview()
    End Sub

    Private Sub rdbB_CheckedChanged(sender As Object, e As EventArgs) Handles rdbB.CheckedChanged
        CambiarPreview()
    End Sub

    Private Sub rdbC_CheckedChanged(sender As Object, e As EventArgs) Handles rdbC.CheckedChanged
        CambiarPreview()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim camionTmp As Camion
        Dim nombreCamion As String
        Dim capacidad As Integer
        Dim imagen As Image

        If txtNombre.Text IsNot "" Then
            nombreCamion = txtNombre.Text
        Else
            MsgBox("El nombre del camión no puede estar vacío.")
            Return
        End If

        Try
            capacidad = CInt(txtCapacidad.Text)
            If capacidad < 18000 Or capacidad > 28000 Then
                MsgBox("La capacidad del camión debe ser un valor entero entre 18000 y 28000", MsgBoxStyle.MsgBoxRight, "Error de capacidad")
                Return
            End If
        Catch ex As InvalidCastException
            MsgBox("La capacidad debe ser de un valor válido.", MsgBoxStyle.MsgBoxRight, "Error de tipo")
            Return
        End Try

        imagen = imgPreview.Image

        camionTmp = New Camion(nombreCamion, capacidad, imagen)
        For i = 0 To formMain.listaCamiones.Count - 1
            If camionTmp.Nombre = formMain.listaCamiones.Item(i).Nombre Then
                MsgBox("El camión de nombre " & camionTmp.Nombre & "ya existe en el sistema.")
                Return
            End If
        Next
        formMain.listaCamiones.Add(camionTmp)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class