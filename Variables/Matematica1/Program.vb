Imports System
Imports System.Math

Module Program
    Sub Main()
        Dim Numero As Integer
        Console.WriteLine("Ingrese un numero: ")
        Numero = Console.ReadLine()
        Console.WriteLine("el valor absoluto del numero ingresado es " & Abs(Numero))
        Console.WriteLine("la decima potenia del valor ingresado es " & Pow(Numero, 10))
        Console.WriteLine("la raaiz cuadrada de valor ingresado es " & Sqrt(Numero))
    End Sub
End Module
