Public Class frmMain

    Private Sub LoadData()
        Try
            ' Database file for Grid
            Dim MyDataFile As String = Application.StartupPath + "\DataFiles\" + "MyMarket.mdb"
            ' give table name
            Dim MyTable As String = "Customers"
            ' Load the grid with data
            MKGrid1.LoadGridFromTable(MyDataFile, MyTable)
            'Fill ComboBox at column #5 by (CityName) Field from (Cities) Table,
            ' to edit (City) Field in (Customers) Table.
            MKGrid1.BindDataCombo(5, "Cities", "CityName", "City")
            'Fill ComboBox at column #6 by (CountryName) Field from (Countries) Table,
            ' to edit (Country) Field in (Customers) Table.
            MKGrid1.BindDataCombo(6, "Countries", "CountryName", "Country")
        Catch
            MessageBox.Show("Found Error, try again", "MKGrid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        MKGrid1.AllowUserResizing = KGrid.AllowResizeConst.GridResizeBoth
        SetButtons(False)
    End Sub

    Private Sub SetButtons(ByVal bVal As Boolean)
        cmdUpdate.Enabled = bVal
        cmdCancel.Visible = bVal
        cmdCancel.Enabled = bVal
        cmdAdd.Enabled = Not bVal
        cmdDelete.Enabled = Not bVal
        cmdDelete.Visible = Not bVal
        cmdFirst.Enabled = Not bVal
        cmdPrev.Enabled = Not bVal
        cmdNext.Enabled = Not bVal
        cmdLast.Enabled = Not bVal
        cmdResize.Enabled = Not bVal
        cmdLock.Enabled = Not bVal
        cmdUnlock.Enabled = Not bVal
        cmdHide.Enabled = Not bVal
        cmdShow.Enabled = Not bVal
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetButtons(True)
        cmdUpdate.Enabled = False
        cmdCancel.Enabled = False
    End Sub

    Private Sub menuLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuLoad.Click
        LoadData()
    End Sub

    Private Sub menuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub menuHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelp1.Click
        Dim fHelp As frmHelp1 = New frmHelp1()
        fHelp.ShowDialog()  ' Show frmHelp1
    End Sub

    Private Sub menuHelp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelp2.Click
        Dim fHelp As frmHelp2 = New frmHelp2()
        fHelp.ShowDialog()  ' Show frmHelp2
    End Sub

    Private Sub cmdHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp1.Click
        Dim fHelp As frmHelp1 = New frmHelp1()
        fHelp.ShowDialog()  ' Show frmHelp1
    End Sub

    Private Sub cmdHelp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp2.Click
        Dim fHelp As frmHelp2 = New frmHelp2()
        fHelp.ShowDialog()  ' Show frmHelp2
    End Sub

    Private Sub menuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuAbout.Click
        Dim Msg As String = "This program for using TreeView to create easy help." _
            & vbLf & "by: Mostafa Kaisoun" _
            & vbLf & "m_kaisoun@hotmail.com"
        MessageBox.Show(Msg, "Easy Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        LoadData()
    End Sub

    Private Sub cmdFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        MKGrid1.FirstRecord()
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        MKGrid1.PreviousRecord()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        MKGrid1.NextRecord()
    End Sub

    Private Sub cmdLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        MKGrid1.LastRecord()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        SetButtons(True)
        MKGrid1.AddNewRecord()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        MKGrid1.DeleteRecord()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        MKGrid1.SaveRecord()
        If MKGrid1.IsRecordSave Then
            SetButtons(False)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        MKGrid1.CancelSaveRecord()
        SetButtons(False)
    End Sub

    Private Sub cmdHide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHide.Click
        Dim ColNumber As Integer = MKGrid1.Col
        MKGrid1.set_ColumnHidden(ColNumber, True)
        Dim strHint As String = "Column #" & ColNumber.ToString() & " become hidden"
        MessageBox.Show(strHint)
    End Sub

    Private Sub cmdShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        For c As Integer = 1 To MKGrid1.Cols - 1
            If MKGrid1.get_ColumnHidden(c) = True Then
                MKGrid1.set_ColumnHidden(c, False)
            End If
        Next
    End Sub

    Private Sub cmdLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Dim ColNumber As Integer = MKGrid1.Col
        MKGrid1.set_ColumnLocked(ColNumber, True)
        Dim strHint As String = "Column #" & ColNumber.ToString() & " has been locked"
        MessageBox.Show(strHint)
    End Sub

    Private Sub cmdUnlock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUnlock.Click
        For c As Integer = 1 To MKGrid1.Cols - 1
            If MKGrid1.get_ColumnLocked(c) = True Then
                MKGrid1.set_ColumnLocked(c, False)
            End If
        Next
    End Sub

    Private Sub cmdResize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdResize.Click
        MKGrid1.ResizeGridColumns()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub
End Class
