Module Module1

    Sub Main()
        'realizar un programa en VB.NET que pida la edad y realice la siguiente clasificacion:
        'bebe 0 -2
        'niño 3-11
        'adolescente 12 - 17
        'mayor de edad 18-65
        'Adulto mayor de 66 - 80
        'Larga vida 81 - x
        While (True)
            Try
                Dim edad As Int16
                Console.Write("Edad: ")
                edad = Console.ReadLine()

                Select Case edad
                    Case 0 To 2
                        Console.WriteLine("Eres un bebe")

                    Case 3 To 11
                        Console.WriteLine("Eres un niño")

                    Case 12 To 17
                        Console.WriteLine("Eres un adolescente")

                    Case 18 To 65
                        Console.WriteLine("Eres responsable de tus acciones")

                    Case 66 To 80
                        Console.WriteLine("Eres un adulto mayor, te ama tu familia")

                    Case 81 To 127
                        Console.WriteLine("Larga vidad")

                    Case Else
                        Console.WriteLine("Error en la edad")
                End Select

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
