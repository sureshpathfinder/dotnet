Public Class Form1

    

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll, HScrollBar3.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.ForeColor = Color.Yellow
        Label1.Text = TrackBar1.Value
    End Sub

    
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value
    End Sub
End Class
