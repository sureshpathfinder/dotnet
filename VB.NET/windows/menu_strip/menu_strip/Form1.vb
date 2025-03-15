Public Class Form1

  
    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub DialogBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogBoxToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()


    End Sub

    

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub DialogboxOwnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogboxOwnToolStripMenuItem.Click
        PrintDialog1.ShowDialog()

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menu.MenuItems.Add("Add menu items")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Menu.MenuItems.Remove(TextBox1.Text)
    End Sub
   

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Form2.Close()

    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        TextBox1.BackColor = Color.Blue
    End Sub

    Private Sub BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        TextBox1.BackColor = Color.Black

    End Sub

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DailogBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailogBoxToolStripMenuItem.Click
        Dialog1.ShowDialog()

    End Sub
End Class
