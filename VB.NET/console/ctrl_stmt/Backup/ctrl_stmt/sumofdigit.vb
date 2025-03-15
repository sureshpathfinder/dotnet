Module sumofdigit
    Sub main()
        Dim s, n, r As Integer
        s = 0
        'n = 563
        n = CInt(Console.ReadLine())
        While (n > 0)
            r = n Mod 10
            s = s + r
            n = n / 10
        End While
        Console.WriteLine("Sum of number" & s)
    End Sub

End Module
