Public Class student
    Public rno, m(2), total As Integer
    Dim Avg As Double
    Public name As String
    Public Sub New()

    End Sub
    Public Sub get1(ByVal x As Integer, ByVal n As String, ByVal m1 As Integer, ByVal m2 As Integer, ByVal m3 As Integer)
        rno = x
        name = n
        m(0) = m1
        m(1) = m2
        m(2) = m3

    End Sub
    Public Sub display()
        Console.WriteLine("Rno" + rno.ToString)
        Console.WriteLine("Name" + name)
        Console.WriteLine("Subject 1" + m(0).ToString)
        Console.WriteLine("Subject 2" + m(1).ToString)
        Console.WriteLine("Subject 3" + m(2).ToString)

    End Sub
    Public Function calc_total() As Integer
        Console.WriteLine("Total")
        total = 0
        Dim i As Integer
        For i = 0 To 2
            total = total + m(i)
        Next
        Return total

    End Function
    Public Function average() As Double


        Console.WriteLine("Average")
        Avg = total / 3
        Return Avg
    End Function

End Class

