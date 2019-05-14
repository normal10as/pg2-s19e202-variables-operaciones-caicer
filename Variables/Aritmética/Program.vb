Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As UInteger
        Dim c, d, x As Double
        a = 10
        b = 16
        c = 25.52
        d = 33.82
        x = a + b
        Console.Write("suma de entero con entero: 10 + 16 = " & x & vbCrLf)
        x = a * b
        Console.Write("producto de entero con entero: 10 * 16 = " & x & vbCrLf)
        x = a / c
        Console.Write("division de entero con punto flotante: 10 / 25.52 = " & x & vbCrLf)
        x = c - d
        Console.Write("resta de punto flotante con punto flotante: 25.52 - 33.82 = " & x & vbCrLf)
    End Sub
End Module
