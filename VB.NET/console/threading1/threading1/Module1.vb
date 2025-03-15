Imports System.Threading
Imports System

Module Module1
    Sub TaskA()
        Dim I As Integer
        For I = 1 To 100
            Console.WriteLine("A  : " & I)
            'Thread.Sleep(1000)
        Next
        'Console.WriteLine(Thread.CurrentThread.Name)
    End Sub
    Sub TaskB()
        Dim I As Integer
        For I = 1 To 100
            Console.WriteLine("B  :  " & I)
        Next

    End Sub
    Sub TaskC()
        Dim I As Integer
        For I = 1 To 100
            Console.WriteLine("C  :  " & I)
        Next
    End Sub

    Sub Main()
        Dim A As New Thread(AddressOf TaskA)
        Dim B As New Thread(AddressOf TaskB)
        Dim C As New Thread(AddressOf TaskC)
        'A.Priority = ThreadPriority.Normal
        'B.Priority = ThreadPriority.Highest
        'C.Priority = ThreadPriority.Lowest

        A.Start()
        A.Name = "S"

        A.Suspend()
        B.Start()

        A.Resume()
        C.Start()
        Console.ReadLine()
    End Sub
End Module
