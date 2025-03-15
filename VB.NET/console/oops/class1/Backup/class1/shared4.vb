Module shared4
    Sub Main()
        Dim s1 As New Static_var1(5, 8)
        'Static_var1.disp(s1)
        'Static_var1.disp(s1)
        'Static_var1.disp(s1)
        s1.print()
        Dim s2 As New Static_var1()
        s2.print()
    End Sub

End Module
Public Class Static_var1
    Public Shared a As Integer
    Public m As Integer
    Public Sub New()

    End Sub

    Public Sub New(ByVal i As Integer, ByVal j As Integer)
        a = i
        m = j

    End Sub
    'Public Shared Sub disp(ByVal s As Static_var1)
    '    a = a + 1
    '    s.m = s.m + 1

    'End Sub
    Public Sub print()
        Console.WriteLine("a=" + a.ToString())
        Console.WriteLine("M=" + m.ToString())
    End Sub

End Class
