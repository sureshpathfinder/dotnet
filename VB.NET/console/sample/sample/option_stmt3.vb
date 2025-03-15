Option Compare Text
Option Explicit Off
Option Strict On
Module option_stmt3

    Sub Main()
        'Text for Option Compare Text
        Dim a, b As String
        a = "hello"
        b = "HELLO"

        If a = b Then
            Console.WriteLine("Equal")
        Else
            Console.WriteLine("Not Equal")
        End If

        ''Text for Option  Explicit Off
        i = 10
        Console.WriteLine("i=" + i.ToString)

        ''Text for Option  Strict On

        Dim m As Integer, n As Double
        n = 23.65
        m = n
        'm = CInt(n)
        Console.WriteLine("m=" + m.ToString)
        Console.ReadKey()
    End Sub
End Module
