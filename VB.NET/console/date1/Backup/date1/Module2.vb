Module Module2
    Sub main()
        Dim TestDateTime As Date = #1/27/2001 5:04:23 PM#
        Dim TestStr As String

        TestStr = Format(Now(), "Long Time")
        Console.WriteLine(TestStr)
        TestStr = Format(Now(), "Long Date")
        Console.WriteLine(TestStr)
        TestStr = Format(Now(), "D")

        Console.WriteLine(TestStr)
        TestStr = Format(TestDateTime, "h:m:s")
        Console.WriteLine(TestStr)
        TestStr = Format(TestDateTime, "hh:mm:ss tt")
        Console.WriteLine(TestStr)
        TestStr = Format(TestDateTime, "hh tt")
        Console.WriteLine(TestStr)

        TestStr = Format(TestDateTime, "dddd, MMM d yyyy")
        Console.WriteLine(TestStr)
        TestStr = Format(TestDateTime, "HH:mm:ss")
        Console.WriteLine(TestStr)
        TestStr = Format(23)
        Console.WriteLine(TestStr)
        TestStr = Format(5459.4, "##,##0.00")
        Console.WriteLine(TestStr)
        TestStr = Format(334.9, "###0.00")
        Console.WriteLine(TestStr)

        Dim a As Date = Now
        Console.WriteLine(a)
        Console.WriteLine(a.ToLongDateString())

        Console.WriteLine(a.AddDays(3).ToShortDateString())


    End Sub
End Module
