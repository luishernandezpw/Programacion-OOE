Public Class Deducciones
    Public isssp, issse, afpp, afpe, isrp, vacacionesp, aguinaldop As Double
    Sub calcular_deducciones(ByVal sueldo As Double, ByVal tiempo As Int16)
        isssp = calcular(sueldo, 0.03)
        issse = calcular(sueldo, 0.075)

        afpp = calcular(sueldo, 0.0625)
        afpe = calcular(sueldo, 0.0775)

        isrp = isr(sueldo - isssp - afpp)
        vacacionesp = vacaciones(sueldo)
        aguinaldop = aguinaldo(sueldo, tiempo)
    End Sub

    Function calcular(ByVal sueldo As Double, ByVal porcentaje As Double)
        Return sueldo * porcentaje
    End Function

    Function isr(ByVal sueldo As Double)
        Dim isrval As Double, tabla(,) = {
            {0.01, 472, 0, 0},
            {472.01, 895.24, 0.1, 17.67},
            {895.25, 2038.1, 0.2, 60},
            {2038.11, 9999999, 0.3, 288.57}
        }
        For i = 0 To 3
            If sueldo >= tabla(i, 0) And sueldo <= tabla(i, 1) Then
                isrval = (sueldo - tabla(i, 0)) * tabla(i, 2) + tabla(i, 3)
            End If
        Next
        Return isrval
    End Function
    Function vacaciones(ByVal sueldo As Double)
        Return sueldo / 2 * 0.3
    End Function
    Function aguinaldo(ByVal sueldo As Double, ByVal tiempo As Int16)
        Dim agui As Double
        Select Case tiempo
            Case 0
                agui = tiempo * 1.1
            Case 1
                agui = sueldo / 30 * 10
            Case 2
                agui = sueldo / 30 * 15
            Case 3
                agui = sueldo / 30 * 18
        End Select
        Return agui
    End Function
End Class
