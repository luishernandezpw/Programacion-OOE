Public Class Media
    Public Function calcularMedia(ByVal serie As String)
        Dim valores() = serie.Split(",")
        Dim mediaA = 0
        For i = 0 To valores.Length - 1
            mediaA += valores(i)
        Next
        Return mediaA / valores.Length
    End Function

End Class
