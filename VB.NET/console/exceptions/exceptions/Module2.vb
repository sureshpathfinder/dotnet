Module Module2
    Sub Main()
        Dim x, y, r As Integer
        Try
            Console.WriteLine("Enter 2 value:")
            x = CInt(Console.ReadLine())
            y = CInt(Console.ReadLine())
            If (y = 0) Then
                Throw New DivideByZeroException
            End If
            Console.WriteLine("Calculation")
            r = x \ y
        Catch er As Exception
            Console.WriteLine("Error Occur")
        Finally
            Console.WriteLine("Finally statement")

        End Try



    End Sub

End Module
