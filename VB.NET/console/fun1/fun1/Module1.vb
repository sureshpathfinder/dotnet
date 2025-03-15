Module Module1

    Sub Main()
        
        sample1()
        Console.WriteLine(sam("Welcome"))

    End Sub
    Public Sub sample1()
        Console.WriteLine("hello")
    End Sub
    Public Function sam(ByVal a As String) As String
        Return a
    End Function

End Module
