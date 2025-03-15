Module Module3
    Sub main()
        Dim datTim1 As Date = #2/5/2010#
        Dim datTim2 As Date = #3/2/2011#
        ' Assume Sunday is specified as first day of the week.
        Dim wD As Long = DateDiff(DateInterval.Day, datTim1, datTim2)
        Dim wY As Long = DateDiff(DateInterval.Year, datTim1, datTim2)
        Dim wM As Long = DateDiff(DateInterval.Month, datTim1, datTim2)
        Console.WriteLine("Day=" & wD)
        Console.WriteLine("Year" & wY)
        Console.WriteLine("Month=" & wM)
        Console.WriteLine(Math.Truncate(2.0535))




    End Sub

End Module
