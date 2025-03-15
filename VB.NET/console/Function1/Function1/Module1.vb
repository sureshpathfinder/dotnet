Module Module1

    Sub Main()
        Dim a, b As Integer
        a = 2
        b = 3

        sample1()
        Console.WriteLine(sam("Welcome"))
        Console.WriteLine("ADD of 2+3=" + add(a, b).ToString)

        Console.WriteLine("Before Swapping a=" & a & "b=" & b)
        swap(a, b)
        Console.WriteLine("After Swapping a=" & a & "b=" & b)

    End Sub
    Public Sub sample1()
        Console.WriteLine("hello")
    End Sub
    Public Function sam(ByVal a As String) As String

        Return a
    End Function
    Public Function add(ByVal a As Integer, ByVal b As Integer) As Long
        Return (a + b)
    End Function

    Public Sub swap(ByRef a As Integer, ByRef b As Integer)
        Dim c As Integer
        c = a
        a = b
        b = c

    End Sub

End Module
