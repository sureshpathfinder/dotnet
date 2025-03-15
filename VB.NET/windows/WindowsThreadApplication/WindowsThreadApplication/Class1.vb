Imports System.Threading

Public Class Class1
    Private Runs As Integer = 0

    Public Sub CountUp()
        Do While (Runs < 10)
            Monitor.Enter(Me)
            Dim Temp As Integer = Runs
            Temp += 1
            Console.WriteLine(Thread.CurrentThread.Name & " " & Temp)
            Thread.Sleep(1000)
            Runs = Temp
            Monitor.Exit(Me)
        Loop
    End Sub
    Public Sub RunThreads()
        Dim t2 As Thread = New Thread(AddressOf CountUp)
        t2.Name = "t2"
        Dim t3 As Thread = New Thread(AddressOf CountUp)
        t3.Name = "t3"
        t2.Start()
        t3.Start()
    End Sub
End Class
		