Public Class Form1
    Dim objIA As New IA()
    Private Sub checkGanador()
        Dim i As Integer = 1
        Dim btn As Button
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If objIA.ub(0) = x AndAlso objIA.ub(1) = y Then
                    Dim nombreBtn As String = "btn" & i
                    btn = CType(Me.Controls(nombreBtn), Button)
                    btn.Text = btnx.Text
                    btn.Enabled = False
                End If
                i += 1
            Next
        Next
        If objIA.nGanador = 0 Then
            lblestado.Text = "GANASTE"
        End If
        If objIA.nGanador = 1 Then
            lblestado.Text = "PERDISTE"
        End If
        If objIA.nGanador = -1 AndAlso objIA.tableroCompleto() Then
            lblestado.Text = "EMPATE"
        End If
    End Sub
    Private Sub establecerBoton(x As Integer, y As Integer, indexBtn As Integer)
        If objIA.ntablero(x, y) = -1 Then
            Dim nombreBtn As String = "btn" & indexBtn
            Dim btn As Button = CType(Me.Controls(nombreBtn), Button)
            btn.Text = btno.Text
            btn.Enabled = False
            objIA.pulsaBoton(x, y)
            objIA.nGanador = objIA.ganarPartida()
            checkGanador()
        End If
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        establecerBoton(0, 0, 1)
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        establecerBoton(0, 1, 2)
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        establecerBoton(0, 2, 3)
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        establecerBoton(1, 0, 4)
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        establecerBoton(1, 1, 5)
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        establecerBoton(1, 2, 6)
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        establecerBoton(2, 0, 7)
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        establecerBoton(2, 1, 8)
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        establecerBoton(2, 2, 9)
    End Sub
    Private Sub btnreiniciar_Click(sender As Object, e As EventArgs) Handles btnreiniciar.Click
        Dim i As Integer = 1
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                Dim nombreBtn As String = "btn" & i
                Dim btn As Button = CType(Me.Controls(nombreBtn), Button)
                btn.Text = Nothing
                btn.Enabled = True
                objIA.ntablero(x, y) = -1
                i += 1
            Next
        Next
        lblestado.Text = ""
        objIA.nGanador = -1
    End Sub
End Class
