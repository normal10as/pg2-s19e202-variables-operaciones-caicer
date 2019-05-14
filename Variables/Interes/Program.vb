Imports System
Module Program
    Sub Main()
        Dim monto, porcentaje, interes As Decimal
        Dim tiempo As Integer
        Console.Write("ingrese monto: ")
        monto = Console.ReadLine()
        Console.Write("ingresar interes anual: ")
        porcentaje = Console.ReadLine()
        Console.Write("ingrese dias: ")
        tiempo = Console.ReadLine()
        interes = (monto * porcentaje * tiempo) / (360 * 100)
        Console.Write("intereses anual: " & interes)
    End Sub
End Module
