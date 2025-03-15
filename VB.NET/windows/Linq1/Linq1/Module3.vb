Module Module3
    Sub Main()
        Dim numbers = {0, 1, 2, 3, 4, 5}
        Dim words = {"zero", "one", "two", "three", "four", "five"}

        Dim l = From num In numbers
                         Where num < 3
                        Select words(num)

        Console.WriteLine("Number less than three")

        For Each n As Object In l
            Console.WriteLine(n)
        Next

        Console.ReadLine()

    End Sub


End Module
