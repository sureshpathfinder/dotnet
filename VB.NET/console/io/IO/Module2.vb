Imports System.IO
'NameSpace required to be imported to work with files
Module Module2
    Sub Main()
        Dim fs1 As New FileStream("D:\SSI_SURESH\sample.txt", FileMode.Open, FileAccess.Read)
        Dim fs As New FileStream("D:\SSI_SURESH\sample3.txt", FileMode.Create, FileAccess.Write)
        Dim s As New StreamWriter(fs)
        Dim sr As New StreamReader(fs1)
        Dim str As String

        While True
            str = sr.ReadLine()
            If str = "" Then
                Exit While
            Else
                s.WriteLine(str)
            End If
        End While

        s.Close()
        sr.Close()
        fs.Close()
        fs1.Close()

        Console.WriteLine("File copied successfully")

    End Sub
End Module

