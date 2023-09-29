Public Class Ejercicios
    ' 1 -> Uno
    ' 2 -> Dos, etc.
    Dim letras As String()() = {
            New String() {"", "Uno ", "Dos ", "Tres ", "Cuatro ", "Cinco ", "Seis ", "Siete ", "Ocho ", "Nueve "},
            New String() {"", "", "", "", "", "", "", "", "", "", "", "Once ", "Doce ", "Trece ", "Catorce ", "Quince ", "Dieciseis ",
                "Diecisiete ", "Dieciocho ", "Diecinueve ", "", "Veintiuno ", "Veintidos ", "Veintitres ", "Veinticuatro ", "Veinticinco ", "Veintiseis ", "Veintisiete ",
                "Veintiocho ", "Veintinueve "},
             New String() {"", "Diez ", "Veinte ", "Treinta ", "Cuarenta ", "Cincuenta ", "Sesenta ", "Setenta ", "Ochenta ", "Noventa "},
             New String() {"Cien ", "Ciento ", "Doscientos ", "Trescientos ", "Cuatrocientos ", "Quinientos ", "Seiscientos ", "Setecientos ",
                "Ochocientos ", "Novecientos "},
            New String() {"", "Mil ", "Millon "}
        }

    'Determine el mayor de 3 numeros 
    Private Function determinarMayor(ByVal m As Double, ByVal i As SByte)
        Console.Write("Ingrese num " + i.ToString() + ": ")
        Dim num = Console.ReadLine()
        If num > m Then
            m = num
        End If

        Return m
    End Function

    Public Function mayor()
        Dim m = 0, i = 1

        For i = 1 To 10
            m = determinarMayor(m, i)
        Next

        Return m
    End Function

    Public Function par_impar()
        Console.Write("Ingrese un Num: ")
        Dim num = Console.ReadLine()

        Dim parImpar = "Impar"
        If num Mod 2 = 0 Then '4/2=2*2=4=0
            parImpar = "Par"
        End If
        Return parImpar
    End Function

    Public Function primo()
        Console.Write("Ingrese un Num: ")
        Dim num = Console.ReadLine()
        Dim i = 1, n = 1

        While i < num And n <= 2
            If num Mod i = 0 Then
                n += 1
            End If
            i += 1
        End While

        Return If(n <= 2, "Es primo", "NO es primo")
    End Function
    Public Sub sec_fibonacci()
        Console.Write("Valor maximo: ")
        Dim max = Console.ReadLine()
        Dim a = 1, b = 0, c = 1
        While c <= max
            c = a + b
            Console.WriteLine(a.ToString() + "+" + b.ToString() + "=" + c.ToString())
            b = a
            a = c
        End While
    End Sub
    Public Function num_letras()
        Console.Write("Numero a Convertir: ")
        Dim num = Console.ReadLine()
        Dim unidades, especiales, decenas, centenas, enlace As String

        If (num.Length = 1) Then
            unidades = obtener_unidades(num)
        End If
        If ((num > 10 And num < 20) Or (num > 20 And num <= 29)) Then
            especiales = letras(1)(num)
        ElseIf (num.Length = 2) Then
            decenas = letras(2)(num.Substring(0, 1))
            unidades = obtener_unidades(num.Substring(1, 1))
            enlace = If(unidades.Length > 1, "Y ", "")
        End If
        If (num.Length = 3) Then
            Dim especial = num.Substring(1, 2)
            centenas = letras(3)(num.Substring(0, 1))

            If ((especial > 10 And especial < 20) Or (especial > 20 And especial <= 29)) Then
                decenas = letras(1)(especial)
            Else
                decenas = letras(2)(num.Substring(1, 1))
                unidades = obtener_unidades(num.Substring(2, 1))
                enlace = If(unidades.Length > 1, "Y ", "")
            End If
        End If
        Return centenas + decenas + enlace + especiales + unidades
    End Function
    Private Function obtener_unidades(num)
        Return letras(0)(num)
    End Function
End Class
