Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim c As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        c.Open()
        cmd = New SqlCommand("insert into emp values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ")", c)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Data Inserted")
        Else
            MsgBox("Data Inserted Error")
        End If
        c.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=SUNETHRA\ARASU;Initial Catalog=ado;Integrated Security=True")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer

        c.Open()
        cmd = New SqlCommand("delete from emp where eid=" + TextBox1.Text, c)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Data Deleted")
        Else
            MsgBox("Data Deleted Error")
        End If
        c.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer

        c.Open()
        cmd = New SqlCommand("update emp ename='" + TextBox2.Text + "', salary=" + TextBox3.Text + "where eid=" + TextBox1.Text, c)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Data Inserted")
        Else
            MsgBox("Data Inserted Error")
        End If
        c.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        c.Open()
        cmd = New SqlCommand("select * from emp", c)

        dr = cmd.ExecuteReader()
        While dr.Read()
            ListBox1.Items.Add(dr(0))
            ListBox2.Items.Add(dr("ename"))
            ListBox3.Items.Add(dr(2))

        End While
        c.Close()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim s, v As String
        v = ListBox1.SelectedItem.ToString()

        s = ListBox1.SelectedIndex.ToString()
        ListBox1.Items.RemoveAt(s)
        ListBox2.Items.RemoveAt(s)
        ListBox3.Items.RemoveAt(s)

        Dim i As Integer
        c.Open()
        cmd = New SqlCommand("delete from emp where eid=" + v, c)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Data Deleted")
        Else
            MsgBox("Data Deleted Error")
        End If
        c.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim o As Object

        c.Open()
        cmd = New SqlCommand("select count(eid) from emp", c)
        o = cmd.ExecuteScalar()
        MsgBox("No of data is =" & o.ToString())
        c.Close()

    End Sub
End Class
