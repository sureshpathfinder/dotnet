Module Module3
    Sub Main()
        Dim m, Age As Integer
        Try
            m = CInt(Console.ReadLine())
            m = m / 0
            If (m > 100) Then
                Throw New marks(m)
            End If

            Age = CInt(Console.ReadLine())
            If (Age < 10) Then
                Throw New Agee(Age)
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        ''m = m / 0
    End Sub

End Module
Class marks
    Inherits Exception
    Dim x As Integer
    Sub New(ByVal a As Integer)
        x = a
    End Sub
    Public Overrides Function ToString() As String
        Return "Marks exception  :  " & x
    End Function
End Class

Class Agee
    Inherits Exception
    Dim x As Integer
    Sub New(ByVal a As Integer)
        x = a
    End Sub
    Public Overrides Function ToString() As String
        Return "Under Age  :  " & x
    End Function
End Class

