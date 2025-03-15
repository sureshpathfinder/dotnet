Module Module1
    'Multiple declaration
    Delegate Sub func1()
    Public Delegate Sub func2(ByVal a As Integer, ByVal b As Integer)
    Delegate Function Sam()
    Function sample() As String
        Return "Delegate function"
    End Function
    Sub disp()
        Console.WriteLine("Delegate Function")
    End Sub
    Sub print()
        Console.WriteLine("Print sub procedure")
    End Sub
    Public Sub add(ByVal a As Integer, ByVal b As Integer)
        Console.WriteLine("a +b : " & (a + b))
    End Sub
    Public Sub subract(ByVal a As Integer, ByVal b As Integer)
        Console.WriteLine("a -b : " & (a - b))
    End Sub


    Sub Main()
        Dim x As func1
        x = New func1(AddressOf disp)
        x.Invoke()
        x = New func1(AddressOf print)
        x.Invoke()

        Dim y As func2
        y = New func2(AddressOf add)
        y.Invoke(12, 4)
        y = New func2(AddressOf subract)
        y.Invoke(23, 56)

        Dim m As Sam
        m = New Sam(AddressOf sample)
        Dim a = m.Invoke()
        Console.WriteLine(a)
    End Sub

End Module
