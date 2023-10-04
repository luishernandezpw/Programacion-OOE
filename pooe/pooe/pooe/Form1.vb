Public Class Form1
    Dim objConversor As New Conversor()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarConversor(0)
    End Sub
    Sub cambiarConversor(ByVal tipo As SByte)
        cboDeConversor.Items.Clear()
        cboAConversor.Items.Clear()

        cboDeConversor.Items.AddRange(objConversor.etiquetas(tipo))
        cboAConversor.Items.AddRange(objConversor.etiquetas(tipo))
    End Sub

    Private Sub cboTipoConversor_TextChanged(sender As Object, e As EventArgs) Handles cboTipoConversor.TextChanged
        cambiarConversor(cboTipoConversor.SelectedIndex())
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        lblRespuestaConversor.Text = Math.Round(objConversor.convertir(
            cboTipoConversor.SelectedIndex, cboDeConversor.SelectedIndex, cboAConversor.SelectedIndex, txtCantidadConversor.Text
        ), 2).ToString() + " " + objConversor.etiquetas(cboTipoConversor.SelectedIndex)(cboAConversor.SelectedIndex)
    End Sub
End Class
