Imports System.Collections

Module Hashtable1
    Sub Main()
        Dim a As New Hashtable()
        a.Add(1, "One")
        a.Add(2, "Two")
        a.Add(3, "Three")
        a.Remove(2)

        Dim d As DictionaryEntry


        Console.WriteLine("Collection a: ")
        For Each d In a
            Console.WriteLine(d.Key & "= " & d.Value)
        Next


    End Sub
End Module
