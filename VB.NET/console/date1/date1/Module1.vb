Module Module1

    Sub Main()
        Console.WriteLine("today date" + DateTime.Now.ToString)
        Dim DT As DateTime

        DT = New Date(2012, 6, 17)
        Console.WriteLine("Day: " & Day(DT).ToString)
        Console.WriteLine("Month: " & Month(DT))
        Console.WriteLine("Year: " & Year(DT))
        Console.WriteLine("Hour: " & Hour(DT))
        Console.WriteLine("Minute: " & Minute(DT))
        Console.WriteLine("Second: " & Second(DT))
        Console.WriteLine("Today: " & Today)
        Console.WriteLine("Weekday: " & Weekday(DT))
        Console.WriteLine("Weekday: " & DT.DayOfWeek)

    End Sub
End Module


