Module Module4
    Sub Main()
        Dim d, d2 As DateTime
        d = Now
        Console.WriteLine("d : " & d)
        Console.WriteLine("d.Date  : " & d.Date)
        Console.WriteLine("d.Year: " & d.Year)
        Console.WriteLine("d : " & d.AddDays(3))
        Console.WriteLine("d : " & d.AddYears(1))
        Console.WriteLine("d : " & d.DayOfYear)

        Console.WriteLine("d.IsLeapYear() : " & DateTime.IsLeapYear(d.Year))
        Console.WriteLine("d.ToLongDateString() : " & d.ToLongDateString())
        Console.WriteLine("d.ToShortDateString() : " & d.ToShortDateString())
        Console.WriteLine("d.ToLongTimeString() : " & d.ToLongTimeString())
        d2 = New DateTime(2012, 3, 4)
        Console.WriteLine("Compare: " & Date.Compare(d, d2))
        Console.WriteLine("Equals : " & Date.Equals(d, d2))

    End Sub

End Module
