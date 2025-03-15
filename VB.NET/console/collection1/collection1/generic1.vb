Imports System.Collections.Generic
Module generic1
    Sub Main()
        Dim d As New Dictionary(Of Integer, String)()
        d.Add(1, "One")
        d.Add(2, "Two")
        d.Add(3, "Three")

        Dim x As KeyValuePair(of Integer,String)
        For Each x In d
            Console.WriteLine(x.Key & " : " & x.Value)
        Next

    End Sub

End Module

