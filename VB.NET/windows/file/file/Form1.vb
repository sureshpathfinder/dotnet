Public Class Form1

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub CasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
