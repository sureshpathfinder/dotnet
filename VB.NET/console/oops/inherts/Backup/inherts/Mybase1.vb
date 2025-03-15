Module Mybase1
    Sub Main()
        Dim m As New child()
        m.getdata(1, "Sunil")
        m.getname("Ram")
        m.print()


    End Sub

End Module
Public Class emp
    Public eid As Integer
    Public name As String
    Public Sub getdata(ByVal id As Integer, ByVal n As String)
        eid = id
        name = n
    End Sub
End Class
Public Class child
    Inherits emp
    Private Shadows name As String

    Public Sub getname(ByVal c As String)
        name = c
    End Sub
    Public Sub print()
        Console.WriteLine("Emp id=" & eid)
        Console.WriteLine("Emp Name=" + MyBase.name)
        Console.WriteLine("Emp Child Name=" + name)
    End Sub
End Class