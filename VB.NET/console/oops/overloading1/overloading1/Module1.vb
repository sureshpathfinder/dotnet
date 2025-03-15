Module Module1

    Sub Main()

        Console.WriteLine()
        Console.WriteLine("Method Overloading")
        Dim a As New Class1

        'Method overloading
        Console.WriteLine(a.fun("hello"))
        Console.WriteLine(a.fun(2.3, 4.5))
        Console.WriteLine(a.fun(10))

        'Function  overloading
        Console.WriteLine("Function Overloading")
        disp()
        disp(32)
        Console.WriteLine(disp("End of Program"))

    End Sub
    Public Sub disp()
        Console.WriteLine("NO Parameters")
    End Sub

    Public Sub disp(Byval a as Integer)
        Console.WriteLine("Integer a=" & a)
    End Sub
    Public Function disp(ByVal a As String) As String
        Return a
    End Function

End Module

