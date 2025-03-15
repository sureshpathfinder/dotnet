Public Class sports1
    Inherits student

    Dim s_name As String
    Public Sub get_Name(ByVal sn As String, ByVal x As Integer, ByVal n As String, ByVal m1 As Integer, ByVal m2 As Integer, ByVal m3 As Integer)


        s_name = sn
        get1(x, n, m1, m2, m3)



    End Sub

    Public Sub cricket()
        Console.WriteLine("Rno=" + rno.ToString)
        Console.WriteLine("Name=" + name)
        Console.WriteLine("Sports name=" + s_name)




    End Sub

End Class

