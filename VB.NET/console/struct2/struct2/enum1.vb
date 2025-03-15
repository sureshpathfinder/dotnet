Module enum1
    Enum week
        mon
        tue
        wed
        thur = 5
        fri
        sat = 0
        sun
    End Enum
    Sub Main()
        Dim a As Integer
        a = week.sun

        Console.WriteLine("a=" & a)
    End Sub

End Module
