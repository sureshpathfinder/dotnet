Public Class Form1
    Dim a, b, c As Integer


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = a / b
        MsgBox("Addition=" + c.ToString)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = a - b
        MsgBox("Addition=" + c.ToString)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = a * b
        MsgBox("Addition=" + c.ToString)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = a + b
        MsgBox("Addition=" + c.ToString)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub
End Class
