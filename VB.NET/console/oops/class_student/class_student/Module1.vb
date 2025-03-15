Module Module1

    Sub Main()
        Dim s As New sports1()


        s.get_Name("cricket", 101, "Sunil", 23, 45, 67)
        s.display()
        Console.WriteLine(s.calc_total())
        Console.WriteLine(s.average())
        Console.WriteLine("rno=" + s.rno)

        s.cricket()


    End Sub

End Module
