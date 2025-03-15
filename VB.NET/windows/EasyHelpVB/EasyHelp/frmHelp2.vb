Imports System.IO
Imports System.Xml

Public Class frmHelp2

    Private MyHelpFile As String
    Private XmlDoc As New XmlDocument

    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'init TreeView
        tvHelp.Nodes.Clear()
        tvHelp.ImageList = IconImages
        tabHelp.SelectedTab = ContentsPage

        cmbHeading.Items.Clear()

        MyHelpFile = Application.StartupPath + "\DataFiles\" + "MyHelp2.xml"
        XmlDoc.Load(MyHelpFile)
        LoadHeading()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadHeading()
        ' Add first node (the Root)
        tvHelp.Nodes.Add(New TreeNode(XmlDoc.DocumentElement.Name))
        Dim tNode As New TreeNode
        tNode = tvHelp.Nodes(0)
        ' Add next nodes
        AddNextNodes(XmlDoc.DocumentElement, tNode)
    End Sub

    Private Sub AddNextNodes(ByVal xmlNode As XmlNode, ByVal treeNode As TreeNode)
        Dim xNode As XmlNode
        Dim tNode As TreeNode
        Dim nodeList As XmlNodeList
        If xmlNode.HasChildNodes Then 'The current node has children
            nodeList = xmlNode.ChildNodes
            ' Set all child nodes
            For i As Integer = 0 To nodeList.Count - 1
                xNode = xmlNode.ChildNodes(i)
                ' Get the name of node (we want set the head of help item)
                If xNode.NodeType = XmlNodeType.Element Then
                    ' Add child nodes to TreeView
                    treeNode.Nodes.Add(New TreeNode(xNode.Name))
                    ' Add node name to ComboBox
                    cmbHeading.Items.Add(xNode.Name)
                    cmbHeading.SelectedIndex = 0
                    tNode = treeNode.Nodes(i)
                    ' Add next child nodes if any
                    AddNextNodes(xNode, tNode)
                    ' Set image to the node
                    Dim strName As String = xNode.Name
                    Select Case strName
                        Case "ApplicationHelp" ' Heading
                            tNode.ImageIndex = 0
                            tNode.SelectedImageIndex = 1
                        Case "Methods" ' Heading
                            tNode.ImageIndex = 0
                            tNode.SelectedImageIndex = 1
                        Case "Properties" ' Heading
                            tNode.ImageIndex = 0
                            tNode.SelectedImageIndex = 1
                        Case Else ' other nodes (Pages)
                            tNode.ImageIndex = 2
                            tNode.SelectedImageIndex = 2
                    End Select
                End If
            Next
        End If
        ' We shall Remove Introduction, Methods, Properties from ComboBox: 
        ' We do not want to display the (Introduction) in Index
        cmbHeading.Items.Remove("Introduction")
        ' (Methods) hasn't any help
        cmbHeading.Items.Remove("Methods")
        ' (Properties) hasn't any help
        cmbHeading.Items.Remove("Properties")
    End Sub

    Private Sub ReadHelp(ByVal strNode As String)
        Dim textReader As XmlTextReader = Nothing
        Dim s As String = ""
        Try
            textReader = New XmlTextReader(MyHelpFile)
            While textReader.Read()
                If textReader.Name = strNode Then
                    s = textReader.ReadString()
                    txtHelp.Text = s
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If textReader.EOF Then textReader.Close()
        End Try
    End Sub

    Private Sub tvHelp_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterSelect
        Dim strName As String = e.Node.Text
        ReadHelp(strName)
    End Sub

    Private Sub tvHelp_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterCollapse
        Select Case e.Node.Text
            Case "ApplicationHelp", "Methods", "Properties"
                e.Node.ImageIndex = 0
                e.Node.SelectedImageIndex = 0
        End Select
    End Sub

    Private Sub tvHelp_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvHelp.AfterExpand
        Select Case e.Node.Text
            Case "ApplicationHelp", "Methods", "Properties"
                e.Node.ImageIndex = 1
                e.Node.SelectedImageIndex = 1
        End Select
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
            ReadHelp(strName)
        End If
    End Sub

    Private Sub cmbHeading_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbHeading.MouseDoubleClick
        Dim strName As String = cmbHeading.Text
        ReadHelp(strName)
    End Sub
End Class