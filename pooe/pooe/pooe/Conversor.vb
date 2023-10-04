Public Class Conversor
    Public etiquetas As String()() = {
        New String() {"Dolar", "Euro", "Quetzal", "Lempiras", "Colon SV", "Cordoba", "Colon CR"},
        New String() {"Metro", "Cm", "Pulgada", "Pies", "Varas", "Yardas", "Km", "Millas"},
        New String() {"Dia", "Segundos", "Minutos", "Horas", "Semana", "Mes", "Año", "Decada", "Siglo"}
    }
    Private valores As Double()() = {
        New Double() {1, 0.96, 7.86, 24.67, 8.75, 36.6, 536.29},
        New Double() {1, 100, 39.37, 3.28, 1.196308, 1.0936, 0.001, 0.000621371},
        New Double() {1, 86400, 1440, 24, 0.142857, 0.0328767, 0.0027397280024383558, 0.00027397280024383559, 0.000027397280024383559}
    }
    Public Function convertir(ByVal tipo As SByte, ByVal de As SByte, ByVal a As SByte, ByVal cantidad As Double)
        Return valores(tipo)(a) / valores(tipo)(de) * cantidad
    End Function
End Class
