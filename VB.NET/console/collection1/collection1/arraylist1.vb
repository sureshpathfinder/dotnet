Imports System.Collections
Module arraylist1
    Sub Main()
        Dim a As New ArrayList()
        a.Add("One")
        a.Add("Two")
        a.Add("Three")
        'a.Add(23)
        a.Insert(3, "Four")
        Dim o As Object

        Console.WriteLine("Collection a: ")
        For Each o In a
            Console.Write(o & ", ")
        Next
        a.Remove("one")
        a.RemoveAt(2)
        Console.WriteLine("\n After remove")
        For Each o In a
            Console.Write(o.ToString() & "    ")
        Next

        a.Sort()
        Console.WriteLine("\n After sorting")
        For Each o In a
            Console.Write(o.ToString() & "    ")
        Next

    End Sub

End Module
