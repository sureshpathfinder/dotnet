Public Class Class1
    Public Function fun(ByVal a As String) As String
        Console.Write("String=")
        Return a
    End Function
    Public Function fun(ByVal a As Integer) As Integer

        Console.Write("Integer=")
        Return a
    End Function
    Public Function fun(ByVal a As Double, ByVal b As Double) As Double
        Console.Write("Double=")
        Return a + b
    End Function

End Class


