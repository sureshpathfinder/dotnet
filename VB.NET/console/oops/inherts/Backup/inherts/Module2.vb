Module Module2

    Sub Main()
        Dim s As New sports(1, "Ravi", "Cricket")
        s.print2()
        s.disp1()

    End Sub

End Module
Public Class student1
    Protected rno As Integer
    Public name As String

    Public Sub New(ByVal rno As Integer, ByVal name As String)
        Me.rno = rno
        Me.name = name
    End Sub
    Public Sub disp1()
        Console.WriteLine("rno=" + rno.ToString)
        Console.WriteLine("name=" + name)
    End Sub
    Public Sub print1()
        Console.WriteLine("Base Class")
    End Sub
End Class
Public Class sports
    Inherits student1


    Public spts As String
    Public Sub New(ByVal id As Integer, ByVal n As String, ByVal sptsn As String)
        MyBase.New(id, n)
        spts = sptsn
    End Sub
    Public Sub print2()
        Console.WriteLine("rno=" & rno)
        MyBase.print1()
        Console.WriteLine("Sports=" & spts)

    End Sub

End Class



