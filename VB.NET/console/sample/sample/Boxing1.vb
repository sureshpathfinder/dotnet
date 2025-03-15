Module Boxing1
    Sub Main()
        Dim a As Integer = 3

        'Boxing
        Dim o As Object
        o = a

        'Unboxing

        Dim m As Integer
        m = CInt(o)

        Console.WriteLine("a=" & a)
        Console.WriteLine("o=" & o)
        Console.WriteLine("m=" & m)


    End Sub
End Module
