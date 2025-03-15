Public Class Form1
    Dim a As String




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then
            a = RadioButton1.Text
        ElseIf (RadioButton2.Checked) Then
            a = RadioButton2.Text
        End If

        If (CheckBox1.Checked) Then
            a += vbNewLine + CheckBox1.Text
        End If
        If (CheckBox2.Checked) Then
            a += vbNewLine + CheckBox2.Text
        End If
        If (CheckBox3.Checked) Then
            a += vbNewLine + CheckBox3.Text
        End If


        TextBox1.Text = a
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
