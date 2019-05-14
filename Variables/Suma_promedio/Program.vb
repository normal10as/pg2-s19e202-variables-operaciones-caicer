Imports System
Imports System.Math

Module Program
    Sub Main()
        Dim valor1, valor2, valor3, valor4, suma As Integer
        Console.WriteLine("ingrese valor 1")
        valor1 = Console.ReadLine
        Console.WriteLine("ingrese valor 2")
        valor2 = Console.ReadLine
        Console.WriteLine("ingrese valor 3")
        valor3 = Console.ReadLine
        Console.WriteLine("ingrese valor 4")
        valor4 = Console.ReadLine
        suma = valor1 + valor2 + valor3 + valor4
        Console.WriteLine(suma)
        suma = suma / 4
        Console.WriteLine(suma)
    End Sub
End Module
