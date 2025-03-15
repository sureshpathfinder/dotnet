Public Class Form2
    Dim i As Integer


    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim f As Form1

        i += 1
        f.Text = "form" & i
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub HorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
End Class