Module Module6
    Sub Main()
        Dim words = {"zero", "one", "two", "three", "four", "five"}

        Dim v = From w In words
              Where w.StartsWith("o") Select w

        For Each i As Object In v
            Console.WriteLine("StartsWith('o') : " & i)
        Next

    End Sub

End Module
