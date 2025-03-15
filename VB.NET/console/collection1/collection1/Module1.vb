Imports System.Collections

Module Module1

    Sub Main()
        Dim d As New Dictionary(Of Integer, emp)
        Dim e1 As New emp(1, "Sunil")
        Dim e2 As New emp(2, "Arun")
        Dim e3 As New emp(3, "Ram")
        d.Add(e1.eid, e1)
        d.Add(e2.eid, e2)
        d.Add(e3.eid, e3)

        Dim x As KeyValuePair(Of Integer, emp)
        For Each x In d
            Console.WriteLine(x.Key & " : " & x.Value.ename)
        Next
    End Sub

End Module
Class emp
    Public eid As Integer
    Public ename As String

    Public Sub New(ByVal i As Integer, ByVal n As String)
        eid = i
        ename = n
    End Sub

End Class


