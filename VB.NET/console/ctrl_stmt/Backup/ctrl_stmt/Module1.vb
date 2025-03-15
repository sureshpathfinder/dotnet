Module Module1
    Sub Main()
        Dim n, a, i As Integer
        For a = 5 To 1 Step -1
            For i = a To 1 Step -1
                Console.Write(i & " ")
            Next i
            Console.WriteLine()
        Next a
        For n = 10 To 1 Step -2
            Console.WriteLine("  " & n)
        Next


    End Sub

End Module
