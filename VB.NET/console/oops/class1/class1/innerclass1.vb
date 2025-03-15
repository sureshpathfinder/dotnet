Module innerclass1
    Sub Main()
        Dim o As New outer()
        o.print()
        Dim i As New outer.innerclass()
        i.Disp()
    End Sub
End Module
Class outer
    Shared a, b As Integer

    Class innerclass
        Public c As Integer

        Sub Disp()
            Console.WriteLine("Addition : " + (a + b))
        End Sub
    End Class

    Sub print()
        Console.WriteLine(i.c)
    End Sub
End Class