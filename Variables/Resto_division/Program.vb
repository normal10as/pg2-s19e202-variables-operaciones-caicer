Imports System

Module Program
    Sub Main()
        Console.WriteLine("ingrese un numero")
        Dim resto, numero As Integer
        numero = Console.ReadLine()
        resto = numero Mod 2
        Console.WriteLine("resto: ")
        Console.WriteLine(resto)
    End Sub
End Module
