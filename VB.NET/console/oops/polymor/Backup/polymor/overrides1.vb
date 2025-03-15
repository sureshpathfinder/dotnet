Module overrides1
    Class parent
        Public a As Integer
        Public Sub disp()
            a = 4
            Console.WriteLine("Parent class")

        End Sub
    End Class
    Class derived
        Inherits parent

        Shadows Sub disp()
            Console.WriteLine("Derived class")
            Console.WriteLine("a=" & a)

        End Sub
    End Class
    Sub Main()
        Dim s As New derived()
        s.disp()
        Dim p As New parent()
        p.disp()


    End Sub

End Module
