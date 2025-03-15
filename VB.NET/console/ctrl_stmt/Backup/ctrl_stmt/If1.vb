Module If1

    Sub Main()
        Dim a As Integer
        a = CInt(Console.ReadLine())
        If a Mod 2 = 0 Then
            Console.WriteLine("A=" & a & "Is a Even Number")
        Else
            Console.WriteLine("A=" & a & "Is a Odd Number")
        End If
    End Sub

End Module
