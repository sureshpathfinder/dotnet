Module Module1

    Sub Main()
        Dim c As New Class1(3)
        'c.geta(3)
        c.sample()
        Console.WriteLine(c.fun("Function"))

    End Sub

End Module
Public Class Class1
    Protected a As Integer
    Public Sub New(ByVal x As Integer)
        a = x
    End Sub

    'Public Sub geta(ByVal x As Integer)
    '    a = x
    'End Sub
    Public Sub sample()
        Console.WriteLine("Welcome to sub procedure")
        Console.WriteLine("a=" + a.ToString)
    End Sub
    Public Function fun(ByVal a As String) As String
        Console.WriteLine("welcome")
        Return a
    End Function
End Class
