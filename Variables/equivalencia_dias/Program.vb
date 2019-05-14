Imports System

Module Program
    Sub Main()
        Dim DiaSemana, HoraDia, MinutoHora As Byte
        Dim numero As Integer

        DiaSemana = 7
        HoraDia = 24
        MinutoHora = 60

        Console.WriteLine("ingrese numero: ")
        numero = Console.ReadLine()
        Console.WriteLine("semana N: ")
        DiaSemana = numero / DiaSemana
        Console.WriteLine(DiaSemana)
        Console.WriteLine("horas N: ")
        Console.WriteLine(numero * HoraDia)
        Console.WriteLine("minutos N: ")
        Console.WriteLine(numero * MinutoHora)

    End Sub
End Module
