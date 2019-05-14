Module Module1

    Sub Main()
        Dim teststring As String
        teststring = "Shopping List"
        Console.WriteLine("Reemplazar en '{0}' la o por la i", teststring)
        Console.WriteLine(Replace(teststring, "o", "i"))

        Dim palabra, dos, uno As String
        palabra = "prueba"
        dos = "hola"
        Console.WriteLine("reemplazar en '{0}' la '{1}'", palabra, dos)
        Console.WriteLine(Replace(palabra, palabra, dos))

        Console.WriteLine("ingrese una palabra: Aunque la cadena sea de oro, sirve para lo mismo.")
        uno = Console.ReadLine()
        Console.WriteLine("ingrese otra palabra: ")
        dos = Console.ReadLine()
        palabra = "Aunque la cadena sea de oro, sirve para lo mismo."
        Console.WriteLine("Se reemplazara en '{0}' la palabra '{1}' por la palabra '{2}' ", palabra, uno, dos)
        Console.WriteLine(Replace(palabra, uno, dos))

    End Sub

End Module
