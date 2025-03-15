Module foreach2

    Sub Main()
        Dim a(5) As Integer
        Dim i As Integer



        For i = 0 To 5
            a(i) = CInt(Console.ReadLine())
        Next

       
        'Console.WriteLine(" length= " & Len(a))


        Console.WriteLine("Array of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next
        Console.WriteLine("End of for Each")

        For i = 0 To 5
            Console.Write(a(i) & "  ")
        Next



    End Sub

End Module
