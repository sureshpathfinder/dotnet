Module properties1
    Sub Main()
        Dim x As New sample()
        'x.h = CInt(Console.ReadLine())
        Console.WriteLine("A: " & x.h)

    End Sub
End Module
Class sample
    Private a As Integer
    Sub New()
        a = 23
    End Sub

    Public ReadOnly Property h()
        Get
            Return a
        End Get
        'Set(ByVal value)
        '    a = value
        'End Set
    End Property

End Class