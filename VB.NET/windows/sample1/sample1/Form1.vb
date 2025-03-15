Public Class Form1
    Dim a As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = MsgBox("Hello World", Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel, "Dailog box")
        If (a = Microsoft.VisualBasic.MsgBoxResult.Yes) Then
            MsgBox("yes")
        ElseIf (a = Microsoft.VisualBasic.MsgBoxResult.No) Then
            MsgBox("NO")
        ElseIf (a = Microsoft.VisualBasic.MsgBoxResult.Cancel) Then
            MsgBox("Cancel")
        End If
    End Sub
End Class
