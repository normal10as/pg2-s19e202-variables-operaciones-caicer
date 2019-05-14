Imports System

Module Program
    Sub Main()
        Dim Resultado As Boolean

        Console.WriteLine("         Operaciones Logicas " & vbLf)
        Console.WriteLine("                AND        " & vbLf)
        Console.WriteLine(" EXP1      |   EXP2    |  EXP1 Y EXP2  |")
        Resultado = True And True
        Console.WriteLine("   V       |     V     |     " & Resultado)
        Resultado = True And False
        Console.WriteLine("   V       |     F     |     " & Resultado)
        Resultado = False And True
        Console.WriteLine("   F       |     V     |     " & Resultado)
        Resultado = False And False
        Console.WriteLine("   F       |     F     |     " & Resultado)
        Console.WriteLine("__________________________________________" & vbLf)

        Console.WriteLine("                OR        " & vbLf)
        Console.WriteLine(" EXP1      |   EXP2    |  EXP1 O EXP2  |")
        Resultado = True Or True
        Console.WriteLine("   V       |     V     |     " & Resultado)
        Resultado = True Or False
        Console.WriteLine("   V       |     F     |     " & Resultado)
        Resultado = False Or True
        Console.WriteLine("   F       |     V     |     " & Resultado)
        Resultado = False Or False
        Console.WriteLine("   F       |     F     |     " & Resultado)
        Console.WriteLine("__________________________________________" & vbLf)

        Console.WriteLine("               XOR        " & vbLf)
        Console.WriteLine(" EXP1      |   EXP2    |  EXP1 y/o EXP2  |")
        Resultado = True Xor True
        Console.WriteLine("   V       |     V     |     " & Resultado)
        Resultado = True Xor False
        Console.WriteLine("   V       |     F     |     " & Resultado)
        Resultado = False Xor True
        Console.WriteLine("   F       |     V     |     " & Resultado)
        Resultado = False Xor False
        Console.WriteLine("   F       |     F     |     " & Resultado)
        Console.WriteLine("__________________________________________" & vbLf)

        Console.WriteLine("          NOT        " & vbLf)
        Console.WriteLine(" EXP1      |  NO EXP1  |")
        Resultado = Not True
        Console.WriteLine("   V       |     " & Resultado)
        Resultado = Not False
        Console.WriteLine("   F       |     " & Resultado)
        Console.WriteLine("_________________________" & vbLf)
    End Sub
End Module
