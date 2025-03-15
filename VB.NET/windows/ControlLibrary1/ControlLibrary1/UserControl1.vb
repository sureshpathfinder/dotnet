Public Class UserControl1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static f As Boolean
        If f = True Then
            Me.TextBox1.Visible = True
            Me.TextBox2.Visible = False
        Else
            Me.TextBox1.Visible = False
            Me.TextBox2.Visible = True
        End If
        f = Not f
    End Sub

    Public Property first() As String
        Get
            Return (Me.TextBox1.Text)
        End Get
        Set(ByVal value As String)
            Me.TextBox1.Text = value
        End Set
    End Property
    Public Property second() As String
        Get
            Return (Me.TextBox2.Text)
        End Get
        Set(ByVal value As String)
            Me.TextBox2.Text = value
        End Set
    End Property


End Class
