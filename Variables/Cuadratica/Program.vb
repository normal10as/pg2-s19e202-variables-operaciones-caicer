Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim a, b, c As Byte
        Dim Resultado As Decimal

        a = 1
        b = 5
        c = 2
        Resultado = (b ^ 2 - 4 * a * c) / 2 * a

        Console.WriteLine(Resultado)
    End Sub
End Module
