Module student4
    Sub main()
       
        Dim s As New student(101, "Ram", 23, "BA")
        s.display()
        Dim a(5) As student
        a(0) = New student(1, "Ravi", 23, "BCA")

        a(1) = New student(2, "Sunil", 23, "BBA")
        a(0).display()
        a(1).display()



    End Sub
  

End Module
Public Class student
    Public rno, age As Integer
    Public name, course As String


    Public Sub New(ByVal x As Integer, ByVal n As String, ByVal a As Integer, ByVal c As String)
        rno = x
        name = n
        age = a
        course = c
    End Sub

    Public Sub display()
        Console.WriteLine("Rno= " + rno.ToString)
        Console.WriteLine("Name=" + name)
        Console.WriteLine("Age=" & age)
        Console.WriteLine("Course=" + course)
    End Sub
End Class

