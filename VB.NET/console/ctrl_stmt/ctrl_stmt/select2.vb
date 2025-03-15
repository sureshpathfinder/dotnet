
Imports n = System.Console

Module select2

    Sub Main()
        Dim a As Integer
        n.WriteLine("Enter a number between 1 and 4")
        a = CInt(n.ReadLine())

        Select Case a
            Case 1
                n.WriteLine("You entered 1")
            Case 2
                n.WriteLine("You entered 2")
            Case 3
                n.WriteLine("You entered 3")
            Case 4
                n.WriteLine("You entered 4")
            Case Else
                n.WriteLine("ELSE")
        End Select

    End Sub


End Module
