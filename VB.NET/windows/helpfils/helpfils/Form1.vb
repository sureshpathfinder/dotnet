Imports System.Xml

Public Class Form1

    Private MyHelpFile As String
    Private XmlDoc As New XmlDocument

    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'init TreeView
        tvHelp.Nodes.Clear()
        tvHelp.ImageList = IconImages
        tabHelp.SelectedTab = ContentsPage

        cmbHeading.Items.Clear()

        'MyHelpFile = Application.StartupPath + "\DataFiles\" + "MyHelp1.xml"
        MyHelpFile = "C:\Documents and Settings\THENNARASU\Desktop\helpfils\helpfils\bin\Release\DataFiles\" + "MyHelp1.xml"
        XmlDoc.Load(MyHelpFile)
        LoadTreeView()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadTreeView()
        Dim xNodeList As XmlNodeList
        Dim xNode As XmlNode
        Dim strNode As String

        Try
            ' set root node of TreeView.
            tvHelp.Nodes.Add("Application Help")
            tvHelp.Nodes(0).Tag = "AppHelp"
            tvHelp.Nodes(0).ImageIndex = 0
            tvHelp.Nodes(0).SelectedImageIndex = 0

            ' set Introduction node to TreeView.
            tvHelp.Nodes(0).Nodes.Add("Introduction")
            tvHelp.Nodes(0).Nodes(0).Tag = "Introduction"
            tvHelp.Nodes(0).Nodes(0).ImageIndex = 2
            tvHelp.Nodes(0).Nodes(0).SelectedImageIndex = 2

            ' set Methods node to TreeView.
            tvHelp.Nodes(0).Nodes.Add("Methods")
            tvHelp.Nodes(0).Nodes(1).Tag = "Methods"
            tvHelp.Nodes(0).Nodes(1).ImageIndex = 0
            tvHelp.Nodes(0).Nodes(1).SelectedImageIndex = 0

            ' set Properties node to TreeView.
            tvHelp.Nodes(0).Nodes.Add("Properties")
            tvHelp.Nodes(0).Nodes(2).Tag = "Properties"
            tvHelp.Nodes(0).Nodes(2).ImageIndex = 0
            tvHelp.Nodes(0).Nodes(2).SelectedImageIndex = 0

            ' set all Method nodes to TreeView.
            xNodeList = XmlDoc.SelectNodes("//Method")
            For Each xNode In xNodeList
                strNode = xNode.SelectSingleNode("title").InnerText
                tvHelp.Nodes(0).Nodes(1).Nodes.Add(strNode)
                ' add Method title to ComboBox
                cmbHeading.Items.Add(strNode)
            Next

            ' set Method nodes image
            For i As Integer = 0 To tvHelp.Nodes(0).Nodes(1).Nodes.Count - 1
                tvHelp.Nodes(0).Nodes(1).Nodes(i).ImageIndex = 2
                tvHelp.Nodes(0).Nodes(1).Nodes(i).SelectedImageIndex = 2
            Next

            ' set all Property nodes to TreeView.
            xNodeList = XmlDoc.SelectNodes("//Property")
            For Each xNode In xNodeList
                strNode = xNode.SelectSingleNode("title").InnerText
                tvHelp.Nodes(0).Nodes(2).Nodes.Add(strNode)
                ' add Property title to ComboBox
                cmbHeading.Items.Add(strNode)
            Next
            ' set Property nodes image
            For i As Integer = 0 To tvHelp.Nodes(0).Nodes(2).Nodes.Count - 1
                tvHelp.Nodes(0).Nodes(2).Nodes(i).ImageIndex = 2
                tvHelp.Nodes(0).Nodes(2).Nodes(i).SelectedImageIndex = 2
            Next

            cmbHeading.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DisplayHelp(ByVal strName As String)
        Dim xNode As XmlNode
        Dim strHelp As String

        ' if user click any title
        xNode = XmlDoc.SelectSingleNode("//*[title='" + strName + "']")
        strHelp = xNode.InnerText
        txtHelp.Text = strHelp
    End Sub

    Private Sub tvHelp_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterSelect
        Dim strName As String = e.Node.Text
        Select Case strName
            Case "Application Help", "Methods", "Properties"
                Exit Sub
            Case Else
                DisplayHelp(strName)
        End Select
    End Sub

    Private Sub tvHelp_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterCollapse
        e.Node.ImageIndex = 0
    End Sub

    Private Sub tvHelp_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterExpand
        e.Node.ImageIndex = 1
    End Sub

    Private Sub tvHelp_BeforeExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvHelp.BeforeExpand
        ' We want only one node expands
        For i As Integer = 0 To tvHelp.Nodes(0).GetNodeCount(False) - 1
            tvHelp.Nodes(0).Nodes(i).Collapse()
        Next
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim strName As String = cmbHeading.Text
        Dim strTemp As String
        Dim strTempLower As String
        Dim FoundItem As Boolean = False

        ' if user type Keyword:
        For i As Integer = 0 To cmbHeading.Items.Count - 1
            strTemp = cmbHeading.Items(i).ToString()
            strTempLower = strTemp.ToLower()
            If strTempLower.StartsWith(strName.ToLower()) Then
                strName = cmbHeading.Items(i).ToString()
                FoundItem = True
                Exit For
            End If
        Next

        If FoundItem Then
            cmbHeading.Text = strName
            DisplayHelp(strName)
        End If
    End Sub

    Private Sub cmbHeading_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbHeading.MouseDoubleClick
        Dim strName As String = cmbHeading.Text
        DisplayHelp(strName)
    End Sub
End Class
