Module Module3
    Sub Main()
        Dim t1 As test2
        t1 = New Sam
        t1.disp()

        Dim t2 As test3
        t2 = New Sam()
        t2.disp()
        'Dim s As New Sam()
        's.disp()
        's.disp1()

    End Sub
End Module
Interface test2
    Sub disp()
End Interface
Interface test3
    Sub disp()
End Interface
Class Sam
    Implements test2, test3
    Public Sub disp() Implements test2.disp
        Console.WriteLine("welcome it is test interface")
    End Sub

    Public Sub disp1() Implements test3.disp
        Console.WriteLine("It is test 3 interface")
    End Sub
End Class

