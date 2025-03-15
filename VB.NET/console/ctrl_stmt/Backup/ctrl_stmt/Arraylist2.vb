Imports System.Collections
Module Arraylist2
    Sub Main()
        Dim a As New ArrayList()
        Dim i As String

        a.Add("Monday")
        a.Add("Tuesday")
        a.Add("Wednesday")
        Console.WriteLine("ArrayList of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next

        a.Remove("Monday")
        Console.WriteLine("ArrayList of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next

        a.RemoveAt(1)
        Console.WriteLine("ArrayList of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next

        a.Insert(1, "Friday")
        Console.WriteLine("ArrayList of a")
        For Each i In a
            Console.Write(i.ToString + " ")
        Next






    End Sub

End Module
