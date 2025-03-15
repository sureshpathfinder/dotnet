Module jagged2
    Sub main()
        Dim a(2)(), i As Integer
        a(0) = New Integer(3) {3, 4, 23, 7}
        a(1) = New Integer(1) {1, 3}
        a(2) = New Integer(5) {1, 4, 5, 4, 6, 3}

        Console.WriteLine(vbNewLine + "a(0)=")
        For Each i In a(0)
            Console.Write("  " + i.ToString())
        Next

        Console.WriteLine(vbNewLine + "a(1)=")
        For Each i In a(1)
            Console.Write("  " + i.ToString())
        Next

        Console.WriteLine(vbNewLine + "a(2)=")
        For Each i In a(2)

            Console.Write("  " + i.ToString())
        Next


    End Sub

End Module
