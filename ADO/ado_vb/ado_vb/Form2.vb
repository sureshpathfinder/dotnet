Imports System.Data.SqlClient
Imports System.Data

Public Class Form2
    Dim c As SqlConnection
    Dim cmb As SqlCommandBuilder
    Dim da As SqlDataAdapter

    Dim ds As New DataSet()
    Dim dt As DataTable

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=SUNETHRA\ARASU;Initial Catalog=ado;Integrated Security=True")
        da = New SqlDataAdapter("select * from emp", c)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, "emp")

        dt = ds.Tables("emp")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("emp")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow
        dr = dt.NewRow()
        dr(0) = TextBox1.Text
        dr(1) = TextBox2.Text
        dr(2) = TextBox3.Text


        dt.Rows.Add(dr)

        da.Update(ds, "emp")

        DataGridView1.DataSource = ds.Tables("emp")
        MessageBox.Show("Row Created")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("emp")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dr() As DataRow

        dr = dt.Select("eid=" + TextBox1.Text)

        If (dr.Length > 0) Then
            '   dr(0).Delete()
            dt.Rows.Remove(dr(0))
            da.Update(ds, "emp")
            MessageBox.Show("Record Deleted")
        Else
            MessageBox.Show("Record Not Found")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dr() As DataRow

        dr = dt.Select("eid=" + TextBox1.Text)


        If (dr.Length > 0) Then

            Dim ch = MsgBox("Are u want to update", MsgBoxStyle.YesNo)
            If (ch = MsgBoxResult.Yes) Then

                dr(0)(1) = TextBox2.Text
                dr(0)(2) = TextBox3.Text
                da.Update(ds, "emp")
                MessageBox.Show("Record Updated")

            End If

        Else
            MessageBox.Show("Record Not Found")
        End If
           

    End Sub
End Class