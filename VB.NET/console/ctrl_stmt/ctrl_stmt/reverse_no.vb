Module reverse_no
    Sub main()
        Dim s, n, r As Integer
        s = 0
        'n = 563
        Console.WriteLine("Enter the number")
        n = CInt(Console.ReadLine())
        While (n > 0)
            r = n Mod 10
            s = (s * 10) + r
            n = n / 10
        End While
        Console.WriteLine("Sum of number" & s)
    End Sub


End Module
