Public Class Form1
    Public s As FontStyle
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = Label1.Font.Style
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(CheckBox1.Text)
        MsgBox(RadioButton1.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            s += FontStyle.Bold
        Else
            s -= FontStyle.Bold
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, s)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            s += FontStyle.Italic
        Else
            s -= FontStyle.Italic
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, s)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            s += FontStyle.Underline
        Else
            s -= FontStyle.Underline
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, s)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.ForeColor = Color.DarkRed
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.ForeColor = Color.Green

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.ForeColor = Color.Blue
    End Sub
End Class
