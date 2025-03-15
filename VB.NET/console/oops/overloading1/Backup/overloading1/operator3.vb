Module operator3
    Class sam
        Dim a As Integer
        Public Sub New(ByVal n As Integer)
            a = n
        End Sub
        Public Shared Operator +(ByVal s1 As sam, ByVal s2 As sam) As Long
            Return s1.a + s2.a

        End Operator
        Public Shared Operator -(ByVal s1 As sam, ByVal s2 As sam) As Long
            Return s1.a - s2.a

        End Operator
    End Class
    Sub Main()

        Console.WriteLine("operator overloading")
        Dim s As New sam(3)
        Dim t As New sam(4)
        Console.WriteLine("addition of class object" + (s + t).ToString)
        Console.WriteLine("Subtraction of class object" + (s - t).ToString)
    End Sub

End Module
