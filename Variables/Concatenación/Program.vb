Imports System
Imports System.DateTime

Module Program
    Sub Main()
        Dim NombreEmpresa, CalleEmpresa, Concatenado As String
        Dim AlturaCalleEmpresa As Integer
        Dim FechaInicio As Date

        Console.WriteLine("Ingrese el Nombre de la Empresa: ")
        NombreEmpresa = Console.ReadLine
        Console.WriteLine("Ingrese el Nombre de la calle de la Empresa: ")
        CalleEmpresa = Console.ReadLine
        Console.WriteLine("Ingrese la Altura de la Empresa")
        AlturaCalleEmpresa = Console.ReadLine()
        Console.WriteLine("Ingrese la Fecha de inicio de la Empresa")
        FechaInicio = Console.ReadLine()
        Concatenado = (NombreEmpresa & " " & CalleEmpresa & " " & AlturaCalleEmpresa & " " & FechaInicio)
        Console.WriteLine(NombreEmpresa & " " & CalleEmpresa & " " & AlturaCalleEmpresa & " " & FechaInicio)
        Console.WriteLine(Concatenado)
    End Sub
End Module
