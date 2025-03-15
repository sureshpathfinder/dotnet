Module typecasting3
    Sub main()
        Dim i As Integer = 20
        'Implicit type casting
        Dim s As Long
        s = i
        Console.WriteLine("s=" + s.ToString)

        'Explicit type casting
        'Dim d As Double
        'd = CDbl(l)
        'Console.WriteLine("a=" + a.ToString)

        'Console.WriteLine("d=" + d.ToString)

        Dim a As Char
        a = ChrW(i)

        Console.WriteLine("a=" + a)
    End Sub


End Module
