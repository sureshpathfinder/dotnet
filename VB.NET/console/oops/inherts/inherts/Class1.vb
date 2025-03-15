Module Class1

    Sub Main()
        Dim s As New detail()
        s.getname(1, "Sunil")
        s.disp()



    End Sub

End Module
Public Class customer
    Friend cno As Integer
    Public name As String

    Public Sub getname(ByVal id As Integer, ByVal n As String)
        cno = id
        name = n
    End Sub


End Class
Class detail
    Inherits customer
    Public pname As String

    Public Sub disp()
        pname = "PayRoll"
        Console.WriteLine("Derived name=" + pname)

        Console.WriteLine("rno=" + cno.ToString)
        Console.WriteLine("name=" + name)
    End Sub



End Class
