Module inherit1
    Sub Main()
        'Square area
        Dim s As New square()
        s.disp()
        s.area()
        'Cube Area

        Dim c As New cube()
        c.disp()
        c.area()
        c.cube_area()
    End Sub

End Module
Class shape
    Protected a As Integer
    Public Sub disp()
        a = CInt(Console.ReadLine())
        Console.WriteLine("Shape value : " & a)
    End Sub
End Class
Class square
    Inherits shape
    Public sq As Integer

    Public Sub area()
        sq = a * a
        Console.WriteLine("Area of square : " & sq)
    End Sub
End Class
Class cube
    Inherits square
    Public Sub cube_area()
        Console.WriteLine("Cube area  : " & (sq * a))
    End Sub
End Class