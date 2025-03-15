Module jagged2
    Sub main()
        Dim a(2)(), i As Integer
        a(0) = New Integer(3) {1, 3, 4, 6}
        a(1) = New Integer(1) {1, 3}
        a(2) = New Integer(2) {1, 4, 5}
        'For i = 0 To 2
        '    For j = 0 To a(i).Length
        '        a(0)(j) = CInt(Console.ReadLine())

        '    Next
        'Next

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
