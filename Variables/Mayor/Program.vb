Imports System
Imports System.Math

Module Program
    Sub Main(args As String())
        Dim valor1, valor2, valor3 As Integer
        Console.WriteLine("ingrese el 1er valor")
        valor1 = Console.ReadLine()
        Console.WriteLine("ingrese el 2do valor")
        valor2 = Console.ReadLine()
        Console.WriteLine("ingrese el 3er valor")
        valor3 = Console.ReadLine()

        If (Max(valor1, valor2) = Max(valor1, valor3)) Then
            Console.WriteLine("el valor maximo es " & valor1)
        End If
        If (Max(valor2, valor3) = Max(valor1, valor2)) Then
            Console.WriteLine("el valor maximo es " & valor2)
        End If
        If (Max(valor2, valor3) = Max(valor1, valor3)) Then
            Console.WriteLine("el valor maximo es " & valor3)
        End If
    End Sub
End Module
