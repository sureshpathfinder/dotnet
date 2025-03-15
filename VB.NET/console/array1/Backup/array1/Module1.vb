Module Module1

    Sub Main()
        Dim a(5), i As Integer


        Console.WriteLine(a.Length)

        Console.WriteLine("Enter 6 values")

        For i = 0 To 5
            a(i) = CInt(Console.ReadLine())

        Next

        Console.WriteLine(vbNewLine + " array")
        For Each i In a
            Console.Write(i & " ")

        Next

        Array.Sort(a)

        Console.WriteLine(vbNewLine + " Sorting")
        For Each i In a
            Console.Write(i & " ")
        Next

        Array.Reverse(a)
        Console.WriteLine(vbNewLine + " Reverse Sorting")
        For Each i In a
            Console.Write(i & " ")

        Next

        Console.WriteLine(Array.Equals(a(0), a(1)))

    End Sub

End Module

