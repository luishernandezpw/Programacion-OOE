Public Class Form1
    Dim objMedia = New Media()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblMedia.Text = "Media Aritmetica: " + Math.Round(objMedia.calcularMedia(txtSerie.Text), 2).ToString()
    End Sub
End Class
