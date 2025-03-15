Public Class Class2
    Public a, b As Integer
    Public Sub New()
        Console.WriteLine("Default Constructor")
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        a = x
        b = y

    End Sub
    'Public Sub class2()
    '    Console.WriteLine("constructor")
    'End Sub
    Public Sub New(ByVal x As Integer)

        Console.WriteLine("INTEGER x=" & x)
        
    End Sub
    Public Sub New(ByVal x As String, ByVal y As String)

        Console.WriteLine("String x=" & x)
        Console.WriteLine("String Y=" & y)

    End Sub
    Public Sub New(ByVal c As Class2)
        Dim z As Integer
        z = c.a + c.b
        Console.WriteLine("z=" & z)

    End Sub





End Class
