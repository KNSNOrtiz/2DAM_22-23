Public Class Form1
    Private Sub chkInterfaces_CheckedChanged(sender As Object, e As EventArgs) Handles chkInterfaces.CheckedChanged
        If chkInterfaces.Checked Then
            lstAsignaturas.Items.Add(chkInterfaces.Text)
        Else
            lstAsignaturas.Items.Remove(chkInterfaces.Text)
        End If
    End Sub

    Private Sub chkAndroid_CheckedChanged(sender As Object, e As EventArgs) Handles chkAndroid.CheckedChanged
        If chkAndroid.Checked Then
            lstAsignaturas.Items.Add(chkAndroid.Text)
        Else
            lstAsignaturas.Items.Remove(chkAndroid.Text)
        End If
    End Sub

    Private Sub chkBadat_CheckedChanged(sender As Object, e As EventArgs) Handles chkBadat.CheckedChanged
        If chkBadat.Checked Then
            lstAsignaturas.Items.Add(chkBadat.Text)
        Else
            lstAsignaturas.Items.Remove(chkBadat.Text)
        End If
    End Sub

    Private Sub lnkGoogle_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGoogle.LinkClicked
        System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://www.google.es/")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lstAsignaturas.Visible Then
            lstAsignaturas.Visible = False
        Else
            lstAsignaturas.Visible = True
        End If

    End Sub

    Private Sub btnReloj_Click(sender As Object, e As EventArgs) Handles btnReloj.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub
End Class
