Module Module1

    Sub Main()

        Dim SegundaLetra As Char = "a"
        Dim PrimeraLetra As Char = "o"
        Dim Palabra As String
        Dim PosicionInicial As Byte = 1
        Console.WriteLine("ingrese la palabra que quiere compara: ")
        Palabra = Console.ReadLine()
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", PrimeraLetra, Palabra, PosicionInicial)
        Console.WriteLine(InStr(PosicionInicial, Palabra, PrimeraLetra, CompareMethod.Text))
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", SegundaLetra, Palabra, PosicionInicial)
        Console.WriteLine(InStr(PosicionInicial, Palabra, SegundaLetra, CompareMethod.Text))
    End Sub

End Module
