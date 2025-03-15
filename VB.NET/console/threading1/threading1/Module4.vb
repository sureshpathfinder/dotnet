Imports System.Threading
Module Module4
    Sub task()
        Dim i As Integer

        For i = 1 To 100
            Dim n = Thread.CurrentThread.Name
            Thread.CurrentThread.Sleep(1000)
            Console.WriteLine(n + " : " & i)
            If (i = 50) And (n = "First") Then
                Console.WriteLine("First thread is suspended")
                Thread.CurrentThread.Suspend()
                Console.WriteLine(Thread.CurrentThread.ThreadState)
            End If
        Next
    End Sub
    Sub Main()
        Dim x As New Thread(AddressOf  task)
        x.Priority = ThreadPriority.Lowest
        x.Name = "First"
        x.Start()


        Dim y As New Thread(AddressOf task)
        y.Name = "Second"
        y.Start()
        Dim z As New Thread(AddressOf task)
        z.Priority = ThreadPriority.Highest
        z.Name = "Third"
        z.Start()
    End Sub

End Module
