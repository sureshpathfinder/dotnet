Module foreach2

    Sub Main()
        Dim a() As Integer = {1, 3, 4, 2, 56, 34, 90}
        Dim i As Integer
        Console.WriteLine("Array of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next
        Console.WriteLine("End of for Each")

        For i = 1 To 5
            Console.Write(a(i) & "  ")
        Next



    End Sub

End Module
