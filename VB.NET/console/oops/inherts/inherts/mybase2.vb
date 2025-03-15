Module mybase2
    Sub Main()
        Dim m As New derived(12, 45)
        m.print()
        m.Disp()

    End Sub

End Module
Class baseclass
    Public a As Integer
    Sub New(Byval x As Integer)
        a = x
    End Sub
    Public Sub print()
        a = 2
        Console.WriteLine("Base a:" & a)
    End Sub

End Class
Class derived
    Inherits baseclass
    Public Shadows a As Integer
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x)
        a = y
    End Sub


    Sub Disp()
        MyBase.print()
        a = 23
        Console.WriteLine("A: " & a)
        Console.WriteLine("Base a :" & MyBase.a)

    End Sub
End Class
Class sam
    Inherits derived

End Class