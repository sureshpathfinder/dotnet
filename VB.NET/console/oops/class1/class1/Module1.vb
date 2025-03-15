Module Module1

    Sub Main()
        Dim e As New Employee(1, "Sunil")
        ' e.getdata(1, "Sunil")
        e.disp()

        Dim a(10) As Employee

        Console.WriteLine("Employee 1: ")
        a(0) = New Employee(1, "Sunil")
        a(0).disp()

        Console.WriteLine("Employee 2: ")
        a(0) = New Employee(2, "Arun")
        a(0).disp()

        Console.WriteLine("Employee 3: ")
        a(0) = New Employee(3, "Jaya")
        a(0).disp()

    End Sub

End Module

