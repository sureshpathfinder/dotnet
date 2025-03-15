Imports System.Collections.Generic
Module List1

    Sub Main()
        Dim l As New List(Of Integer)
        l.Add(1)
        l.Add(2)
        l.Add(4)
        l.Add(52)

        Dim o As Object

        For Each o In l
            Console.WriteLine(o)
        Next

    End Sub

End Module
