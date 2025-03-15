Imports System.Collections
Module ienum1
    Sub Main()
        Dim a As New ArrayList()
        a.Add(0)
        a.Add(1)
        a.Add(2)

        a.Add(3)
        a.Add(4)
        a.Add(5)
        Dim o As Object

        Console.WriteLine("Collection a: ")
        For Each o In a
            Console.Write(o & ", ")
        Next
        Dim i As IEnumerator

        i = a.GetEnumerator()
        Console.WriteLine("By Using Enumerator: ")
        While i.MoveNext()
            Console.WriteLine(i.Current)
        End While

        i = a.GetEnumerator(2, 3)
        Console.WriteLine("By Using Enumerator: ")
        While i.MoveNext()
            Console.WriteLine(i.Current)
        End While

    End Sub

End Module
