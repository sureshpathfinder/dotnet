Module structs1
    Structure emp
        Public sno As Integer
        Dim name As String
        Dim sal As Integer
        Sub disp()
            Console.WriteLine("sno=" & sno)
            Console.WriteLine("name=" & name)
            Console.WriteLine("salary=" & sal)
        End Sub
    End Structure
    Sub Main()
        Dim e As New emp()
        e.sno = 1
        e.name = "Sunil"
        e.sal = 20000
        e.disp()
    End Sub
End Module
