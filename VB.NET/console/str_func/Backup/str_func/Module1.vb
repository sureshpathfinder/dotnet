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

        Dim r As String = "Good Eveving"
        Console.WriteLine("Index of Eve of r=" & r.IndexOf("Eve"))

        Console.WriteLine("Replace of s1=" & r.Replace("Good", "hello"))

        Dim a As String = "welcome"
        Dim b As String = "Welcome"

        Console.WriteLine("Reverse of a=" & StrReverse(a))

        Console.WriteLine("Compare of a,b=" & String.Compare(a, b))


        Console.WriteLine("Compare of a,b=" & String.Equals(a, b))

        Dim s2, s3 As String
        s2 = "Hello Welcome to ssi"
        For Each s3 In s2.Split("e")
            Console.WriteLine("s3=" & s3)
        Next

        Dim x As String
        Dim y() As String = {"hello", "welcome"}

        x = String.Join("-", y)
        Console.WriteLine("x=" & x)

        Dim c As String = "  Hello . "
        Console.WriteLine("Trim of c=" & c.Trim())


















    End Sub

End Module
