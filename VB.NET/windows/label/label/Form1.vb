Public Class Form1
    Dim a, b, c As Integer
    Dim s1 As String = TextBox1.Text
    Dim s2 As String = TextBox2.Text

   

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = CInt(s1)
        b = CInt(s2)
        c = a + b
        MsgBox("Addition=" + c.ToString)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = CInt(s1)
        b = CInt(s2)
        c = a - b
        MsgBox("Subtraction=" + c.ToString)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = CInt(s1)
        b = CInt(s2)
        c = a * b
        MsgBox("Multiplication=" + c.ToString)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = CInt(s1)
        b = CInt(s2)
        c = a / b
        MsgBox("Division=" + c.ToString)
    End Sub
End Class
