Module Module1

    Sub Main()
        'Clases y objetos
        'Clase Calculadora
        Dim objCal As New Calculadora()

        Console.Write("Num 1: ")
        objCal.num1 = Console.ReadLine()

        Console.Write("Num 2: ")
        objCal.num2 = Console.ReadLine()

        Console.WriteLine("Suma: " + objCal.sumar().ToString() + ", Resta: " + objCal.restar().ToString())

        Console.ReadKey()

    End Sub
End Module
