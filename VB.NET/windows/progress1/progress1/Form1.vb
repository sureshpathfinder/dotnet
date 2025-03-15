Public Class Form1
    Dim i As Integer = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Label1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = i
        i = i + 1
        Label1.Text = "Remaining  " + CStr(100 - i)
        If (i >= 100) Then
            Timer1.Stop()
        End If
    End Sub
End Class
