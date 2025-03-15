Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String

        For Each s In ListBox1.SelectedItems
            Label1.Text += vbNewLine + s
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As String
        a = InputBox("Enter a Value")
        If ListBox1.Items.Contains(a) Then
            ListBox1.Items.Remove(a)
        Else
            MsgBox("Invalid Input")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String
        a = InputBox("Enter a Value")
        ComboBox1.Items.Add(a)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Integer
        a = InputBox("Enter a Value")
        If a >= 0 And a < ListBox1.Items.Count Then
            ListBox1.Items.RemoveAt(a)
        Else
            MsgBox("Invalid Input")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("D:/bsuresh/personals/7 wonders/img12.jpg")
    End Sub
End Class
