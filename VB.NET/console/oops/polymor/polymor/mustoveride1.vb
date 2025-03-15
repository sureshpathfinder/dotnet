Module mustoveride1
    Sub Main()
        Dim sq As New square1
        sq.disp()
        Console.WriteLine("Square area" & sq.area())


        Dim r As New rectangle1
        r.disp()
        Console.WriteLine("Rectangle area" & r.area())
    End Sub
End Module
MustInherit Class shape1
    Public a As Integer
    Sub disp()
        Console.WriteLine("Enter a Value: ")
        a = CInt(Console.ReadLine())
        Console.WriteLine("A: " & a)
    End Sub
    Public MustOverride Function area() As Integer
End Class

Class square1
    Inherits shape1
    'Public Overrides Function area() As Integer
    '    Return a * a
    'End Function
End Class

Class rectangle1
    Inherits shape1
    Dim b As Integer

    Public Overrides Function area() As Integer
        Console.WriteLine("Enter breadth : ")
        b = CInt(Console.ReadLine())
        Return a * b
    End Function

End Class
