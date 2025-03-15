Public Class menustrip

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim s As String
        OpenFileDialog1.ShowDialog()

        OpenFileDialog1.InitialDirectory = "D:"
        OpenFileDialog1.Filter = "Text File|*.txt"
        s = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(s)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub menustrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class