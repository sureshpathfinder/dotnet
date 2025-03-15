Module construct_types
    Sub Main()
        Console.WriteLine("Main Function ")
        Dim m As New sam
        Dim n As New sam(12, 34)
        Dim x As New sam(n)
    End Sub
End Module
Class sam
    Public a As Integer
    Public b As Integer

    Public Sub New(ByVal a As Integer, ByVal b As Integer)
        Me.a = a
        Me.b = b
        disp()
    End Sub
    Public Sub New()
        Console.WriteLine("Default Constructor")
    End Sub
    Public Sub New(ByVal x As sam)
        Dim c = x.a + x.b
        Console.WriteLine("Copy Constructor : " & c)
    End Sub
    Sub disp()
        Console.WriteLine("a : " & a)
        Console.WriteLine("b : " & b)
    End Sub
    Shared Sub New()
        Console.WriteLine("Static/ Shared constructor")
    End Sub
End Class