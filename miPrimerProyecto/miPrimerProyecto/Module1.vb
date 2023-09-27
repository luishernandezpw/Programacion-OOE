Module Module1

    Sub Main()
        'Clases y objetos
        'Clase estudiante
        'Objeto objEstudiante
        Dim objEstudiante As New estudiante()

        Console.Write("Ingrese su codigo: ")
        objEstudiante.setCodigo(Console.ReadLine())

        Console.Write("Ingrese su nombre: ")
        objEstudiante.setNombre(Console.ReadLine())

        Console.Write("Edad: ")
        objEstudiante.setEdad(Console.ReadLine())

        Console.Write("Act 1: ")
        objEstudiante.setAct1(Console.ReadLine())

        Console.Write("Act 2: ")
        objEstudiante.setAct2(Console.ReadLine())

        Console.Write("Act 3: ")
        objEstudiante.setAct3(Console.ReadLine())

        Console.Write("Act 4: ")
        objEstudiante.setAct4(Console.ReadLine())

        Console.Write("Act 5: ")
        objEstudiante.setAct5(Console.ReadLine())

        Console.Write("Act 6: ")
        objEstudiante.setAct6(Console.ReadLine())

        Console.Write("Act 7: ")
        objEstudiante.setAct7(Console.ReadLine())

        Console.Write("Act 8: ")
        objEstudiante.setAct8(Console.ReadLine())

        Console.WriteLine("Hola, " + objEstudiante.getNombre + ", edad: " +
                          objEstudiante.getEdad.ToString() + ", NF: " + Math.Round(objEstudiante.calcularNf(), 1).ToString())

        Console.ReadKey()

    End Sub


    Class estudiante
        Dim codigo, nombre As String
        Dim edad As SByte
        Dim act1, act2, act3, act4, act5, act6, act7, act8 As Double

        Public Sub setCodigo(ByVal cod As String)
            Me.codigo = cod
        End Sub
        Public Function getCodigo()
            Return Me.codigo
        End Function

        Public Sub setNombre(ByVal nomb As String)
            Me.nombre = nomb
        End Sub
        Public Function getNombre()
            Return Me.nombre
        End Function

        Public Sub setEdad(ByVal ed As String)
            If (ed >= 0) Then
                Me.edad = ed
            Else
                Console.WriteLine("No se aceptan valores negativos")
            End If

        End Sub
        Public Function getEdad()
            Return Me.edad
        End Function

        Public Sub setAct1(ByVal act1 As String)
            If (act1 >= 0 And act1 <= 10) Then
                Me.act1 = act1
            Else
                Console.WriteLine("Solo notas entre 0.0 y 10.0")
            End If
        End Sub
        Public Function getAct1()
            Return Me.act1
        End Function
        Public Sub setAct2(ByVal act2 As String)
            Me.act2 = act2
        End Sub
        Public Function getAct2()
            Return Me.act2
        End Function
        Public Sub setAct3(ByVal act3 As String)
            Me.act3 = act3
        End Sub
        Public Function getAct3()
            Return Me.act3
        End Function
        Public Sub setAct4(ByVal act4 As String)
            Me.act4 = act4
        End Sub
        Public Function getAct4()
            Return Me.act4
        End Function
        Public Sub setAct5(ByVal act5 As String)
            Me.act5 = act5
        End Sub
        Public Function getAct5()
            Return Me.act5
        End Function
        Public Sub setAct6(ByVal act6 As String)
            Me.act6 = act6
        End Sub
        Public Function getAct6()
            Return Me.act6
        End Function
        Public Sub setAct7(ByVal act7 As String)
            Me.act7 = act7
        End Sub
        Public Function getAct7()
            Return Me.act7
        End Function
        Public Sub setAct8(ByVal act8 As String)
            Me.act8 = act8
        End Sub
        Public Function getAct8()
            Return Me.act8
        End Function
        Public Function calcularNf()
            Return (Me.act1 + Me.act2 + Me.act3 + Me.act4 + Me.act5 + Me.act6 + Me.act7 + Me.act8) / 8
        End Function
    End Class
End Module
