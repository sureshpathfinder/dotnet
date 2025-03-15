Imports System.Data.SqlClient

Imports System.Data

Public Class Form1
    Dim c As SqlConnection
    Dim cmb As SqlCommandBuilder
    Dim da As SqlDataAdapter

    Dim ds As New DataSet()
    Dim dt As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAMDataSet.emp' table. You can move, or remove it, as needed.

        c = New SqlConnection("Data Source=SUNETHRA\ARASU;Initial Catalog=sample1;Integrated Security=True")
        da = New SqlDataAdapter("select * from emp", c)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, "emp")

        dt = ds.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow
        dr = dt.NewRow()

        dr(0) = CInt(DataGridView1.CurrentRow.Cells(0).Value)
        dr(1) = DataGridView1.CurrentRow.Cells(1).Value

        dr(2) = CInt(DataGridView1.CurrentRow.Cells(2).Value)

        dt.Rows.Add(dr)

        da.Update(ds, "emp")
        MessageBox.Show("Row Created")
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("emp")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dr() As DataRow

        dr = dt.Select("eid=" + TextBox1.Text)

        If (dr.Length > 0) Then
            dr(0)(1) = DataGridView1.CurrentRow.Cells(1).Value
            dr(0)(2) = DataGridView1.CurrentRow.Cells(2).Value
            da.Update(ds, "emp")
            MessageBox.Show("Record Updated")
        Else

            MessageBox.Show("Record Not Found")
        End If
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("emp")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dr() As DataRow

        dr = dt.Select("eid=" + TextBox1.Text)

        If (dr.Length > 0) Then
            'dt.Rows.Remove(dr(0))
            dr(0).Delete()

            da.Update(ds, "emp")
            MessageBox.Show("Record Deleted")
        Else
            MessageBox.Show("Record Not Found")
        End If
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ds.Tables("emp")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridView1.DataSource = dt
    End Sub
End Class

       
