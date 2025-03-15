Public Class Form1
    Dim s As FontStyle



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (CheckBox1.Checked) Then
            Label1.Font.Bold = True

        End If

        If (CheckBox2.Checked) Then

            Label1.Font.Italic = True
        End If

        If (CheckBox3.Checked) Then
            Label1.Font.Underline = True
        End If





    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
