Module Module1

    Sub Main()
        'realizar un programa en VB.NET que pida una table de multiplicar y la genere:
        '7x1 = 7
        '7x2 = 14 ...
        While (True)
            Try
                Dim ntabla, i As SByte
                Console.Write("Tabla Multiplicar: ")
                ntabla = Console.ReadLine()

                For i = 1 To 10
                    Console.WriteLine(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
                Next

                Console.Write("Deseas salir presiona (s), sino enter: ")
                Dim salir = Console.ReadLine()
                If (salir.ToLower() = "s") Then
                    Exit While
                End If
            Catch oError As Exception
                Console.WriteLine("Por favor ingrese solo valores enteros. " + oError.StackTrace)
            End Try
        End While
    End Sub

End Module
