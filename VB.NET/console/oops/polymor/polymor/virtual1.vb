Module virtual1
    Sub Main()
        Dim sq As New square
        sq.disp()
        Console.WriteLine("Square area" & sq.area())


        Dim r As New rectangle
        r.disp()
        Console.WriteLine("Rectangle area" & r.area())
    End Sub
End Module
Class shape
   Public a As Integer
    Sub disp()
        Console.WriteLine("Enter a Value: ")
        a = CInt(Console.ReadLine())
        Console.WriteLine("A: " & a)
    End Sub
    Public Overridable Function area() As Integer
        Console.WriteLine("Shape Area is Calculated")
    End Function
End Class

Class square
    Inherits shape
    Public Overrides Function area() As Integer
        Return a * a
    End Function
End Class

Class rectangle
    Inherits shape
    Dim b As Integer

    Public Overrides Function area() As Integer
        Console.WriteLine("Enter breadth : ")
        b = CInt(Console.ReadLine())
        Return a * b
    End Function

End Class
