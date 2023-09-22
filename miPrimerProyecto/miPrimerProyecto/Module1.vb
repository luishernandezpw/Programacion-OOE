Module Module1

    Sub Main()
        Dim nombre As String
        nombre = "Luis Hernandez"

        Dim edad As SByte
        edad = 35

        Dim cum As Double
        cum = 9.5

        Dim gustaProgramar As Boolean 'True o False
        gustaProgramar = True

        Console.Write("Mi nombre es: " + nombre + "; Mi edad: " + edad.ToString() + "; Me gusta programar: " +
                      gustaProgramar.ToString() + "; Mi CUM: " + cum.ToString()) ' 25 => "25"

        Console.ReadLine()
    End Sub

End Module
