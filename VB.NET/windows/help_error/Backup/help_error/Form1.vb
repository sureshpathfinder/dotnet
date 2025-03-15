Public Class Form1

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "user id should not empty")

        End If
        If (TextBox2.Text = "") Then
            ErrorProvider1.SetError(TextBox2, "pwdshould not empty")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ToolTip1.SetToolTip(TextBox1, "Enter only no")
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        HelpProvider1.SetHelpString(TextBox2, "Enter  pwd")
    End Sub
End Class
