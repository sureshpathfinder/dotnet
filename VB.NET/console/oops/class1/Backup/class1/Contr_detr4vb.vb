Module Contr_detr4vb
    Public Sub main()
        Dim a As New Const_destr(2, "hello")
        a.disp()

    End Sub

End Module
Public Class Const_destr

    Public rno As Integer
    Public name As String
    Public Sub New(ByVal rno As Integer, ByVal name As String)
        Me.rno = rno
        Me.name = name
    End Sub

    Public Sub disp()
        Console.WriteLine("Rno= " + rno.ToString)
        Console.WriteLine("Name=" + name)
    End Sub
    Protected Overrides Sub Finalize()
        ' Destructor to free unmanaged resources 
        MyBase.Finalize()
        Console.WriteLine("Deleted")
    End Sub
End Class