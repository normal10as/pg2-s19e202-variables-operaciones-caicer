Imports System
Imports System.DateTime

Module Program
    Sub Main()
        Dim Nombre, LugarNacimiento, NombreCalle As String
        Dim DNI, DistanciaCiudad, ProfundidadMar, AlturaCalle, Monto As Integer
        Dim FechaNacimiento As Date
        Dim EsArgentino As Boolean
        Dim Temperatura, Altura, PesoProducto As Byte
        Dim Habitantes As Decimal
        Nombre = "Enzo"
        DNI = 34365050
        LugarNacimiento = "Posadas"
        FechaNacimiento = #10/4/1992#
        Altura = 173
        EsArgentino = True
        Temperatura = 24
        NombreCalle = "Tripoli"
        AlturaCalle = 3600
        DistanciaCiudad = 100
        ProfundidadMar = 10
        Habitantes = 4000000
        PesoProducto = 3
        Monto = 120
        Console.WriteLine(Nombre & " " & DNI & " " & FechaNacimiento & " " & LugarNacimiento & " " & Altura & " " & EsArgentino)
        Console.WriteLine(Temperatura & " " & NombreCalle & " " & AlturaCalle & " " & DistanciaCiudad)
        Console.WriteLine(ProfundidadMar & " " & Habitantes & " " & PesoProducto & " " & Monto)
    End Sub
End Module
