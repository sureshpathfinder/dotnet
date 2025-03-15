Module optr_2
    Class complex
        Dim a, b As Integer
        Public Sub New(ByVal x As Integer, ByVal y As Integer)
            a = x
            b = y
        End Sub
       
        Public Shared Operator +(ByVal s1 As complex, ByVal s2 As complex) As complex
            Dim r As New complex
            r.a = s1.a + s2.a
            r.b = s1.b + s2.b
            Return r
        End Operator
        Public Shared Operator -(ByVal s1 As complex, ByVal s2 As complex) As complex
            Dim r As New complex
            r.a = s1.a - s2.a
            r.b = s1.b - s2.b
            Return r
        End Operator
        Public Sub disp()
            Console.WriteLine("A=" + a.ToString)
            Console.WriteLine("B=" + b.ToString)
        End Sub
    End Class
    Sub Main()

        Console.WriteLine("operator overloading")
        Dim s As New complex(3, 4)
        Dim t As New complex(4, 3)
        Dim ad As New complex()
        Dim su As New complex()
        s.disp()
        t.disp()
        ad = s + t
        ad.disp()
        su = s - t
        su.disp()


       
    End Sub

End Module
