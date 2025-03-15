Imports System.IO

Module Module1

    Sub Main()
        Dim x, y, r As Integer
        Try
            Console.WriteLine("Enter 2 value:")
            x = CInt(Console.ReadLine())
            y = CInt(Console.ReadLine())
            Console.WriteLine("Calculation")
            r = x \ y

            Dim a() As Integer = {12, 43, 45, 5}
            Console.WriteLine(a(7))

            Dim f As New FileInfo("D:\SSI_SURESH\jar.txt")
            Console.WriteLine(f.Length)

            'Multiple  catch block
        Catch e As DivideByZeroException
            Console.WriteLine("Exception occur")

        Catch m As FileNotFoundException
            Console.WriteLine(m)

            'Rethrow - User doesnt want to handle the error
        Catch s As Exception
            Throw New IndexOutOfRangeException()


        End Try



    End Sub

End Module
