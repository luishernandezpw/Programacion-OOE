Public Class Form1
    Dim objDeduciones As New Deducciones

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim isssp, afpp, isrp, vacacionesp, aguinaldop, totalDeduciones, sueldoNeto As Double

            objDeduciones.calcular_deducciones(txtSueldo.Text, cboTiempo.SelectedIndex)

            isssp = objDeduciones.isssp
            afpp = objDeduciones.afpp
            isrp = objDeduciones.isrp
            vacacionesp = objDeduciones.vacacionesp
            aguinaldop = objDeduciones.aguinaldop
            totalDeduciones = isssp + afpp + isrp
            sueldoNeto = (txtSueldo.Text - totalDeduciones) + vacacionesp + aguinaldop

            lblIsssEmpresas.Text = "ISSS: " + Math.Round(objDeduciones.issse, 2).ToString()
            lblIsssPersonas.Text = "ISSS: " + Math.Round(isssp, 2).ToString()

            lblAfpEmpresas.Text = "AFP: " + Math.Round(objDeduciones.afpe, 2).ToString()
            lblAfpPersonas.Text = "AFP: " + Math.Round(afpp, 2).ToString()

            lblIsrPersonas.Text = "ISR: " + Math.Round(isrp, 2).ToString()
            lblVacacionesPersonas.Text = "VACACIONES: " + Math.Round(vacacionesp, 2).ToString()
            lblAguinaldoPersonas.Text = "AGUINALDO: " + Math.Round(aguinaldop, 2).ToString()

            lblTotalDeducciones.Text = "TOTAL DEDUCCIONES: " + Math.Round(totalDeduciones, 2).ToString()
            lblSueldoNeto.Text = "SUELDO NETO: " + Math.Round(sueldoNeto, 2).ToString()

            erpDeducciones.SetError(txtSueldo, "")
        Catch ex As Exception
            erpDeducciones.SetError(txtSueldo, "Por favor ingrese su sueldo.")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTiempo.SelectedIndex = 0
    End Sub
End Class
