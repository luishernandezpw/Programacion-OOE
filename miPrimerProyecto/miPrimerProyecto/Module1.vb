Module Module1

    Sub Main()
        'Clases y objetos
        'Clase Calculadora
        Dim objEjercicios As New Ejercicios()
        'Console.WriteLine("El Mayor es: " + objEjercicios.mayor().ToString())
        'Console.WriteLine("El numero es: " + objEjercicios.par_impar().ToString())
        'Console.WriteLine("El numero es: " + objEjercicios.primo().ToString())
        'objEjercicios.sec_fibonacci()
        Console.WriteLine("El numero en letras es: " + objEjercicios.num_letras().ToString())
        Console.ReadKey()

    End Sub
End Module
