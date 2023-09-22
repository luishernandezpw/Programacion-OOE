Module Module1

    Sub Main()
        'realizar un programa en VB.NET que tome las notas Lab1(30%) + Lab2(30%) + P(40%) = NF Computo
        Dim lab1, lab2, parcial, nf As Double

        Console.Write("Lab1: ")
        lab1 = Console.ReadLine()

        Console.Write("Lab2: ")
        lab2 = Console.ReadLine()

        Console.Write("Parcial: ")
        parcial = Console.ReadLine()

        nf = lab1 * 0.3 + lab2 * 0.3 + parcial * 0.4

        Console.WriteLine("NF: " + nf.ToString())

        Console.ReadLine()
    End Sub

End Module
