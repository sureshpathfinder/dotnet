Module Module1

    Sub Main()
        Dim s As New pjts(1, "Ravi")

        s.disp()

    End Sub

End Module
Public Class student
    Friend rno As Integer
    Public name As String

    Public Sub New(ByVal id As Integer, ByVal n As String)
        rno = id
        name = n
    End Sub
 
End Class
Class pjts
    Inherits student
    Public Sub New(ByVal id1 As Integer, ByVal n1 As String)
        MyBase.New(id1, n1)
    End Sub

    Public Sub disp()
        Console.WriteLine("rno=" + rno.ToString)
        Console.WriteLine("name=" + name)
    End Sub

End Class
