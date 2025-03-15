Module Module1

    Sub Main()
        Dim e As New Employee()
        Dim p As Person
        Dim b As New Person()


        e.Name = "John Doe"
        e.Address = "123 Main St."
        e.City = "Toledo"
        e.State = "OH"
        e.ZIP = "48312"
        e.Salary = 43912

        p = e
        p.Print()
        p = b
        p.Print()

    End Sub

End Module
Class Person
    Public Name As String
    Public Address As String
    Public City As String
    Public State As String
    Public ZIP As String

    Overridable Sub Print()
        Console.WriteLine(Name)
        Console.WriteLine(Address)
        Console.WriteLine(City & ", " & State & " " & ZIP)
    End Sub
End Class

Class Employee
    Inherits Person
    Public Salary As Integer

    Overrides Sub Print()
        Console.WriteLine(Name)
        Console.WriteLine(Address)
        Console.WriteLine(City & ", " & State & " " & ZIP)
        Console.WriteLine("Salary = " & Salary)
    End Sub


End Class

