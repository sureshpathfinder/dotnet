Imports System.Threading
Imports System

Module Module1
    Sub TaskA()
        Dim I As Integer
        Lock()

        For I = 0 To 250
            Console.Write("A" & "   ")
            Thread.Sleep(1000)
        Next
        End Lock

        Console.WriteLine(Thread.CurrentThread.Name)
    End Sub
    Sub TaskB()
        Dim I As Integer
        For I = 0 To 10
            Console.Write("B" & "   ")
        Next
        Console.WriteLine()
    End Sub
    Sub TaskC()
        Dim I As Integer
        For I = 0 To 10
            Console.Write("C" & "   ")
        Next
    End Sub

    Sub Main()
        Dim A As New Threading.Thread(AddressOf TaskA)
        Dim B As New Threading.Thread(AddressOf TaskB)
        Dim C As New Threading.Thread(AddressOf TaskC)
        A.Priority = ThreadPriority.Normal
        B.Priority = ThreadPriority.Highest
        C.Priority = ThreadPriority.Lowest

        A.Start()

        A.Name = "S"
        A.Suspend()
        B.Start()

        A.Resume()
        C.Start()





        Console.ReadLine()
    End Sub
End Module
