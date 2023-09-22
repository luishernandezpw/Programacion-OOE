Module Module1

    Sub Main()
        'realizar un programa en VB.NET que solicite dos numeros al usuario y muestre la suma de ellos.
        Dim num1, num2, respuesta As Double

        Console.Write("Num 1:")
        num1 = Console.ReadLine()

        Console.Write("Num 2: ")
        num2 = Console.ReadLine()

        respuesta = num1 + num2

        Console.WriteLine("La suma es: " + respuesta.ToString())

        Console.ReadLine()
    End Sub

End Module
