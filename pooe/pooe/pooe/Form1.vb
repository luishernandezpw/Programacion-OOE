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
        Try
            lblRespuestaConversor.Text = Math.Round(objConversor.convertir(
                        cboTipoConversor.SelectedIndex, cboDeConversor.SelectedIndex, cboAConversor.SelectedIndex, txtCantidadConversor.Text
                    ), 2).ToString() + " " + objConversor.etiquetas(cboTipoConversor.SelectedIndex)(cboAConversor.SelectedIndex)
            limpiarError()
        Catch ex As InvalidCastException
            limpiarError()
            erpConversor.SetError(txtCantidadConversor, "Por favor ingrese la cantidad a convertir.")
        Catch ex As Exception
            limpiarError()
            If cboTipoConversor.Text = "" Then
                erpConversor.SetError(cboTipoConversor, "Por favor seleccione el tipo de conversor a realizar")
            ElseIf cboDeConversor.Text = "" Then
                erpConversor.SetError(cboDeConversor, "Por favor seleccione 'DE' que opcion desea convertir")
            ElseIf cboAConversor.Text = "" Then
                erpConversor.SetError(cboAConversor, "Por favor seleccione 'A' que desea convertir")
            ElseIf txtCantidadConversor.Text = "" Then
                erpConversor.SetError(txtCantidadConversor, "Por favor ingrese la cantidad a convertir.")
            End If
        End Try

    End Sub
    Private Sub limpiarError()
        erpConversor.SetError(cboTipoConversor, "")
        erpConversor.SetError(cboDeConversor, "")
        erpConversor.SetError(cboAConversor, "")
        erpConversor.SetError(txtCantidadConversor, "")
    End Sub
End Class
