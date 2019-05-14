Imports System
Imports System.Math

Module Program
    Sub Main()
        Dim Resto As Double
        Console.WriteLine("ingrese un valor con decimal ")
        Resto = Console.ReadLine()
        Console.WriteLine("valor aproximado por exceso " & Ceiling(Resto))
        Console.WriteLine("valor aproximado por defecto " & Floor(Resto))
        Console.WriteLine("valor redondeado " & Round(Resto))
    End Sub
End Module
