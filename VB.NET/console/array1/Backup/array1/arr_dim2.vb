Module arr_dim2
    Sub Main()
        Dim a(2, 2), i, j As Integer
        'a(0, 0) = 21
        'a(0, 1) = 22
        'a(0, 2) = 23
        Console.WriteLine("Enter the Array ")
        For i = 0 To 1
            For j = 0 To 1
                a(i, j) = CInt(Console.ReadLine())
            Next j
        Next i


        Console.WriteLine("Array of a=")
        For Each i In a
            Console.Write("  " + i.ToString)
        Next

        Console.WriteLine(vbNewLine + "Array of a=")
        For i = 0 To 1
            For j = 0 To 1
                Console.Write("  " + a(i, j).ToString)
            Next j

            Console.WriteLine()
        Next i


    End Sub

End Module
