Public Class Form1
    Dim LabelArray(6) As Label
    Dim TextBoxArray(6) As TextBox
    Dim activa As Integer = 1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 6
            LabelArray(i) = New Label
            TextBoxArray(i) = New TextBox
            LabelArray(i).Text = "Dato " & i
            LabelArray(i).Width = 120 : TextBoxArray(i).Width = 100
            LabelArray(i).Height = 30 : TextBoxArray(i).Height = 30
            TextBoxArray(i).AutoSize = False
            LabelArray(i).TextAlign = ContentAlignment.MiddleCenter
            LabelArray(i).BorderStyle = BorderStyle.FixedSingle
            LabelArray(i).Font = New Font("Arial", 10, FontStyle.Bold)
            LabelArray(i).Location = New Point(100, i * 50)
            TextBoxArray(i).Location = New Point(260, i * 50)
            Me.Controls.Add(LabelArray(i)) : Me.Controls.Add(TextBoxArray(i))
        Next
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer
        For i = 1 To 6
            LabelArray(i).Enabled = False
            TextBoxArray(i).Enabled = False
            TextBoxArray(activa).BorderStyle = BorderStyle.Fixed3D
        Next
        LabelArray(activa).Enabled = True
        TextBoxArray(activa).Enabled = True
        activa += 1
        If activa = 7 Then activa = 1

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
    End Sub
End Class
