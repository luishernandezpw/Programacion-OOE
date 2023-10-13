Public Class IA
    Public ntablero(,) As Integer = New Integer(2, 2) {{-1, -1, -1}, {-1, -1, -1}, {-1, -1, -1}}
    Public nGanador As Integer = -1
    Public ub() As Integer = New Integer(1) {}
    Public Sub pulsaBoton(ByVal x As Integer, ByVal y As Integer)
        If ntablero(x, y) = -1 AndAlso nGanador = -1 Then
            ntablero(x, y) = 0
            nGanador = ganarPartida()
            ponerFichaOrdenador()
        End If
    End Sub
    Public Function ganarPartida() As Integer
        If ntablero(0, 0) <> -1 AndAlso ntablero(0, 0) = ntablero(1, 1) AndAlso ntablero(0, 0) = ntablero(2, 2) Then
            Return ntablero(0, 0)
        End If
        If ntablero(0, 2) <> -1 AndAlso ntablero(0, 2) = ntablero(1, 1) AndAlso ntablero(0, 2) = ntablero(2, 0) Then
            Return ntablero(0, 2)
        End If
        For i As Integer = 0 To 2
            If ntablero(i, 0) <> -1 AndAlso ntablero(i, 0) = ntablero(i, 1) AndAlso ntablero(i, 0) = ntablero(i, 2) Then
                Return ntablero(i, 0)
            End If
            If ntablero(0, i) <> -1 AndAlso ntablero(0, i) = ntablero(1, i) AndAlso ntablero(0, i) = ntablero(2, i) Then
                Return ntablero(0, i)
            End If
        Next
        Return -1
    End Function
    Public Function tableroCompleto() As Boolean
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If ntablero(x, y) = -1 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Public Function finPartida() As Boolean
        Return tableroCompleto() OrElse ganarPartida() <> -1
    End Function
    Public Sub ponerFichaOrdenador()
        If Not finPartida() Then
            Dim f As Integer = 0, c As Integer = 0, aux As Integer
            Dim v As Integer = Integer.MinValue
            For x As Integer = 0 To 2
                For y As Integer = 0 To 2
                    If ntablero(x, y) = -1 Then
                        ntablero(x, y) = 1
                        aux = min()
                        If aux > v Then
                            v = aux
                            f = x
                            c = y
                        End If
                        ntablero(x, y) = -1
                    End If
                Next
            Next
            ntablero(f, c) = 1
            ub(0) = f
            ub(1) = c
        End If
    End Sub
    Private Function max() As Integer
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return -1
            Else
                Return 0
            End If
        End If
        Dim v As Integer = Integer.MinValue
        Dim aux As Integer = 0
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If ntablero(x, y) = -1 Then
                    ntablero(x, y) = 1
                    aux = min()
                    If aux > v Then
                        v = aux
                    End If
                    ntablero(x, y) = -1
                End If
            Next
        Next
        Return v
    End Function
    Private Function min() As Integer
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return 1
            Else
                Return 0
            End If
        End If
        Dim v As Integer = Integer.MaxValue
        Dim aux As Integer = 0
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If ntablero(x, y) = -1 Then
                    ntablero(x, y) = 0
                    aux = max()
                    If aux < v Then
                        v = aux
                    End If
                    ntablero(x, y) = -1
                End If
            Next
        Next
        Return v
    End Function
End Class
