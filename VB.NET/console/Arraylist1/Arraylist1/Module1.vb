Imports System.Collections
Module Module1

    Sub Main()
        Dim i As Object

        Dim a As New ArrayList
        a.Add(3)
        a.Add(4)
        a.Add(5)
        a.Add("Sunil")

        For Each i In a
            Console.WriteLine("  " & i)
        Next
        Console.WriteLine("End")
        a.Remove(4)

        a.RemoveAt(0)

        For Each i In a
            Console.WriteLine("  " & i)
        Next






    End Sub

End Module
