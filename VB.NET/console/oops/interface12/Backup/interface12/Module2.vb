Public Interface con1
    Sub sub1(Byval a as String)
    Function fun1() As String
End Interface
Public Interface con2
    Sub sub1()
End Interface
Class sample
    Implements con1, con2

    Public Sub sub1(ByVal a As String) Implements con1.sub1
        Console.WriteLine("Interface Con 1")
    End Sub
    'Public Function fun1() As String Implements con1.fun1
    '    Return "Func1"
    'End Function
    Public Sub sub1() Implements con2.sub1
        Console.WriteLine("Interface Con 2")
    End Sub
End Class
Module Module2
    Sub main()
        Dim a As New sample()
        a.sub1("interface 1")
        Console.WriteLine(a.fun1())
        a.sub1()
    End Sub
End Module

