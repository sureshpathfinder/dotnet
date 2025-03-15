Imports System.Threading
Module Module5
    Sub Main()
        Dim a As New Thread(AddressOf disp)
        a.Name = "A "

        a.Start()
        Dim b As New Thread(AddressOf disp)
        b.Name = "B "
        b.Start()

    End Sub
    Sub disp()
        Dim i As Integer
        SyncLock Thread.CurrentThread
            For i = 1 To 100
                Console.WriteLine(Thread.CurrentThread.Name & "  : " & i)
            Next
        End SyncLock
    End Sub

End Module
