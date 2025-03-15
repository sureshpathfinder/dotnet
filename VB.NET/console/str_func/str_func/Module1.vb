Module Module1

    Sub Main()
        Dim s As String = "Hello"

        'Length()
        Console.WriteLine("length of s=" & s.Length())

        ''Len = .Length
        'Mid = .SubString
        'Replace = .Replace
        'InStr = .IndexOf
        'UCase = .ToUpper
        'LCase = .ToLower
        'Split = .Split
        'Join = .Join

        Console.WriteLine("Lower case of s=" & LCase(s))
        Console.WriteLine("Lower case of s=" & s.ToLower())

        Console.WriteLine("Upper case of s=" & UCase(s))
        Console.WriteLine("Upper case of s=" & s.ToUpper())

        Dim s1 As String = "Hello Welcome to ssi"
        Console.WriteLine("Substring of s1=" & s1.Substring(8))
        Console.WriteLine("Substring of s1=" & s1.Substring(8, 6))

        Dim r As String = "good Eveving"
        Console.WriteLine("Index of g of r=" & r.IndexOf("g"))
        Console.WriteLine("LastIndex of g of r=" & r.LastIndexOf("g"))

        Console.WriteLine("Replace of s1=" & r.Replace("good", "hello"))

        Dim a As String = "welcome"
        Dim b As String = "Welcome"

        Console.WriteLine("Reverse of a=" & StrReverse(a))

        Console.WriteLine("Compare of a,b=" & String.Compare(a, b, True))

        Console.WriteLine("Compare of a,b=" & String.Equals(a, b))

        Dim s2, s3 As String
        s2 = "Hello Welcome to ssi"
        For Each s3 In s2.Split("e")
            Console.WriteLine("s3=" & s3)
        Next

        Dim x As String
        Dim y() As String = {"hello", "welcome", "end"}

        x = String.Join("-", y)
        Console.WriteLine("x=" & x)

        Dim c As String = "  Hello . "
        Console.WriteLine("Trim of c=" & c.Trim())

        Dim f As Double = 34.45646
        Console.WriteLine(Format(f, "0.00"))
        Console.ReadKey()
    End Sub

End Module
