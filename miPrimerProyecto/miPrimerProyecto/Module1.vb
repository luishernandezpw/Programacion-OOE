Module Module1

    Sub Main()
        'realizar un programa en VB.NET que pida la edad y realice la siguiente clasificacion:
        'bebe 0 -2
        'niño 3-11
        'adolescente 12 - 17
        'mayor de edad 18-65
        'Adulto mayor de 66 - 80
        'Larga vida 81 - x

        Try
            Dim edad As Int16

            Console.Write("Edad: ")
            edad = Console.ReadLine()

            Select Case edad
                Case 0 To 2
                    Console.Write("Eres un bebe")

                Case 3 To 11
                    Console.Write("Eres un niño")

                Case 12 To 17
                    Console.Write("Eres un adolescente")

                Case 18 To 65
                    Console.Write("Eres responsable de tus acciones")

                Case 66 To 80
                    Console.Write("Eres un adulto mayor, te ama tu familia")

                Case 81 To 127
                    Console.Write("Larga vidad")

                Case Else
                    Console.Write("Error en la edad")
            End Select
        Catch oError As Exception
            Console.WriteLine("Por favor ingrese solo valores enteros. " + oError.StackTrace)
        End Try
        Console.ReadLine()
    End Sub

End Module
