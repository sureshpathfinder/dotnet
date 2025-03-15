Imports System.Threading
Public Class Form1
    Private t1, t2 As Thread
    Dim i, j As Integer, tname1, tname2 As String

    Sub fun1()
        For i = 1 To 10
            tname1 = Thread.CurrentThread.Name
            AccessControl1()
            Thread.Sleep(1000)
        Next
    End Sub


    Sub AccessControl1()
        If (Me.InvokeRequired) Then
            Me.Invoke(New MethodInvoker(AddressOf accesscontrol1))
        Else
            ListBox1.Items.Add(tname1 & " : " & i)
        End If
    End Sub

    Sub fun2()

        For j = 1 To 20
            tname2 = Thread.CurrentThread.Name
            AccessControl2()
            Thread.Sleep(500)
        Next
    End Sub

    Sub AccessControl2()
        If (Me.InvokeRequired) Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl2))
        Else
            ListBox1.Items.Add(tname2 & " : " & j)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t1 = New Thread(AddressOf fun1)
        t2 = New Thread(AddressOf fun2)

        t1.Name = InputBox("Enter First Thread Name ")
        t2.Name = InputBox("Enter Second Thread Name ")

        t1.Priority = ThreadPriority.BelowNormal

        t1.Start()
        t2.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If t1.ThreadState <> ThreadState.Stopped Then
            t1.Abort()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If t2.ThreadState <> ThreadState.Stopped Then
            t2.Abort()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        t1.Suspend()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        t2.Suspend()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If t1.ThreadState = ThreadState.Suspended Then
            t1.Resume()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If t2.ThreadState = ThreadState.Suspended Then
            t2.Resume()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
