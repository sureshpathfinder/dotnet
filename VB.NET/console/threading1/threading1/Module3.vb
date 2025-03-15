Imports System.Threading
Module Module3
    Sub Main()
        Dim x As New Thread(AddressOf TaskA)
        x.Priority = ThreadPriority.Lowest
        x.Start()

        Dim y As New Thread(AddressOf TaskB)
        y.Start()
        Dim z As New Thread(AddressOf TaskC)
        z.Priority = ThreadPriority.Highest
        z.Start()
    End Sub

End Module
