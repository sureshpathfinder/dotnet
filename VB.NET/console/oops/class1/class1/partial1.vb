Module partial1
    Sub Main()
        Dim o As New sample()
        o.disp()
        o.disp1()
    End Sub

End Module
'Inner class
Partial Class sample
    Sub disp()
        Console.WriteLine("Disp procedure")
    End Sub

End Class

Partial Class sample
    Sub disp1()
        Console.WriteLine("disp 1 ")
    End Sub
End Class