Imports System.IO
Module Module3
    Sub Main()
        Dim a As New DirectoryInfo("D:\SSI_SURESH\library\hibernate_src")

        Dim d As Object
        Console.WriteLine("Directories in ssisuresh directory: ")
        For Each d In a.GetDirectories()
            Console.WriteLine("     " & d.ToString())
        Next

        Console.WriteLine(a.Exists)
        Console.WriteLine(a.Parent)
        Console.WriteLine(a.Name)
        Console.WriteLine(a.Root)
        Console.WriteLine(a.FullName)
    End Sub

End Module
