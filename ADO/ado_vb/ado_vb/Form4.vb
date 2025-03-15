Imports System.Data.SqlClient
Imports System.Data
Public Class Form4
    Dim c As SqlConnection
    Dim cmb As SqlCommandBuilder
    Dim da As SqlDataAdapter

    Dim ds As New DataSet()
    Dim dt As DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        da = New SqlDataAdapter("select * from emp where eid=" + TextBox1.Text, c)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, "emp")

        Dim cr As New CrystalReport2
        cr.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c = New SqlConnection("Data Source=SUNETHRA\ARASU;Initial Catalog=ado;Integrated Security=True")
        
    End Sub
End Class