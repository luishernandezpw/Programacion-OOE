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
            Dim edad As SByte

            Console.Write("Edad: ")
            edad = Console.ReadLine()

            If (edad < 0) Then
                Console.WriteLine("Error en la edad")
            ElseIf (edad <= 2) Then
                Console.WriteLine("Eres un bebe")
            ElseIf (edad <= 11) Then
                Console.WriteLine("Eres un niño")
            ElseIf (edad <= 17) Then
                Console.WriteLine("Eres un adolescente")
            ElseIf (edad <= 65) Then
                Console.WriteLine("Eres un adulto, tienes responsablidades")
            ElseIf (edad <= 80) Then
                Console.WriteLine("Adulto mayor, te ama tu familia ")
            ElseIf (edad > 80) Then
                Console.WriteLine("Larga vidad...")
            End If
        Catch oError As Exception
            Console.WriteLine("Por favor ingrese solo valores enteros. " + oError.Message)
        End Try
        Console.ReadLine()
    End Sub

End Module
