Module Module2
    Sub Main()
        Dim numbers = {2, 1, 34, 5, 8, 13, 21, 33}

        Dim lessThanTen = From num In numbers _
                         Where num Mod 2 = 0 _
                        Select num

        Console.WriteLine("Even number: ")

        For Each n As Object In lessThanTen
            Console.WriteLine(n)
        Next

        Console.ReadLine()

    End Sub


End Module
