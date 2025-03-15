Module Module1

    Structure Employee
        'declaring a structure named Employee
        Dim EmpName As String
        Dim EmpDesignation As String
        Dim EmpCity As String
        Dim EmpSal As Double
        Dim EmpId As Integer
        'declaring five fields of different data types in the structure
    End Structure

    Sub Main()
        Dim san As New Employee()
        'creating an instance of Employee
        san.EmpName = "Sandeep"
        san.EmpDesignation = "Software Developer"
        san.EmpCity = "Sydney"
        san.EmpSal = 60000
        san.EmpId = 2707
        'assigning values to member variables 
        Console.WriteLine("EmpName" + " " + san.EmpName)
        Console.WriteLine("EmpDesignation" + " " + san.EmpDesignation)
        Console.WriteLine("EmpCity" + " " + san.EmpCity)
        Console.WriteLine("EmpSalary" + " " + san.EmpSal.ToString)
        Console.WriteLine("EmpID" + " " + san.EmpId.ToString)
        'accessing member variables with the period/dot operator

    End Sub
End Module
