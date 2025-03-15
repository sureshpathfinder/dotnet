Public Class Employee
    Public eid As Integer
    Public ename As String
    Public Sub New(ByVal x As Integer, ByVal n As String)
        eid = x
        ename = n
    End Sub

    'Friend Sub getdata(ByVal x As Integer, ByVal n As String)
    '    eid = x
    '    ename = n
    'End Sub
    Friend Sub disp()
        Console.WriteLine("Welcome to Class")
        Console.WriteLine("Eid=" & eid)
        Console.WriteLine("Ename=" & ename)
    End Sub

End Class
