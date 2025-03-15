Module opertor1
    Sub main()
        Dim a, b, c As Integer
        a = 2
        b = 5
        c = a + b
        Console.WriteLine("Addition=" + c.ToString)
        c = a - b
        Console.WriteLine("Subtraction=" + c.ToString)
        c = a * b
        Console.WriteLine("Multiplication=" + c.ToString)
        c = a / b
        Console.WriteLine("Divition=" + c.ToString)
        'c = a And b
        'Console.WriteLine("And=" + c.ToString)
        c = a Or b
        Console.WriteLine("Or=" + c.ToString)
        c = a ^ 2
        Console.WriteLine("2 Power 2=" + c.ToString)
        c = a Mod b
        Console.WriteLine("2 modules 5=" + c.ToString)
        Console.ReadKey()

    End Sub
End Module
