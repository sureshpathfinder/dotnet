Module Module1
    Public Delegate Sub func()
    Public Sub add()
        Console.WriteLine("Delegate Function")
    End Sub

    Sub Main()
        Dim f As func
        
        f = New func(AddressOf add)
        f.Invoke()
    End Sub

End Module
