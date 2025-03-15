Imports System.Console
Module Module1

    Sub Main()
        Dim OneObj As New One()

        'creating objects of class One and Two
        OneObj.disp()
        OneObj.multiply()
        OneObj.disp("test")
        
    End Sub

End Module
Public Class One
    Implements Test, Test1
    'implementing interface in class One

    Public i As Double = 12
    Public j As Double = 12.17

    Public Sub disp(ByVal a As String) Implements Test.disp
        'implementing the method specified in interface
        WriteLine("sum of i+j is" & i + j & " interface name=" + a)

    End Sub

    Public Function multiply() As Double Implements Test.Multiply
        'implementing the method specified in interface

        WriteLine("Multiply =" & i * j)

    End Function
    Public Sub disp() Implements Test1.disp
        WriteLine("Welcome to Interfaces Test2")


    End Sub

End Class

Public Interface Test1
    Sub disp()

End Interface



