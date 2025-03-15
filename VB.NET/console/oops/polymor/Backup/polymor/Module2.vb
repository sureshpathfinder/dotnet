Module Module2
    Sub Main()
        Dim abs As New AbstractOne()
        'creating an instance of AbstractOne
        Console.WriteLine("Sum is" & " " & abs.Add())
        Console.WriteLine("Multiplication is" & " " & abs.Mul())
        'displaying output


    End Sub
End Module
Public MustInherit Class Class1
    Public MustOverride Function Add() As Integer
    Public MustOverride Function Mul() As Integer
    'declaring two abstract members with MustOverride keyword

End Class
Public Class AbstractOne
    Inherits Class1
    'implementing the abstract class by inheriting
    Dim i As Integer = 20
    Dim j As Integer = 30
    'declaring two integers

    Public Overrides Function Add() As Integer
        Return i + j
    End Function
    'implementing the add method

    Public Overrides Function Mul() As Integer
        Return i * j
    End Function
    'implementing the mul method

End Class