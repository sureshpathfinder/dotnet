Imports System.IO
Module Module1

    Sub Main()
        Dim f As FileInfo

        f = New FileInfo("D:\SSI_SURESH\sample.txt")
        Console.WriteLine("Creation time=" & f.CreationTime())
        Console.WriteLine("Exist or not=" & f.FullName())
        Console.WriteLine("File  f.Attributes=" & f.Attributes)
        Console.WriteLine("Length=" & f.Length)

        File.Copy("D:\SSI_SURESH\sample.txt", "D:\SSI_SURESH\sample3.txt")

        Dim s As String
        s = File.ReadAllText("D:\SSI_SURESH\sample.txt")
        Console.WriteLine(s)

    End Sub

End Module
