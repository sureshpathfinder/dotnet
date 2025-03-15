<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MKGrid1 = New AxKGrid.AxMKGrid
        Me.HelpMenu = New System.Windows.Forms.MenuStrip
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.menuLoad = New System.Windows.Forms.ToolStripMenuItem
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.helpMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.menuHelp1 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuHelp2 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdFirst = New System.Windows.Forms.Button
        Me.cmdLast = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrev = New System.Windows.Forms.Button
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdResize = New System.Windows.Forms.Button
        Me.cmdHide = New System.Windows.Forms.Button
        Me.cMenuCol = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Column1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Column10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLock = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdUnlock = New System.Windows.Forms.Button
        Me.cmdShow = New System.Windows.Forms.Button
        Me.cmdHelp1 = New System.Windows.Forms.Button
        Me.cmdHelp2 = New System.Windows.Forms.Button
        CType(Me.MKGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HelpMenu.SuspendLayout()
        Me.cMenuCol.SuspendLayout()
        Me.SuspendLayout()
        '
        'MKGrid1
        '
        Me.MKGrid1.Enabled = True
        Me.MKGrid1.Location = New System.Drawing.Point(100, 27)
        Me.MKGrid1.Name = "MKGrid1"
        Me.MKGrid1.OcxState = CType(resources.GetObject("MKGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MKGrid1.Size = New System.Drawing.Size(462, 255)
        Me.MKGrid1.TabIndex = 0
        '
        'HelpMenu
        '
        Me.HelpMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.helpMenuItem})
        Me.HelpMenu.Location = New System.Drawing.Point(0, 0)
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(577, 24)
        Me.HelpMenu.TabIndex = 2
        Me.HelpMenu.Text = "menuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLoad, Me.menuExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(35, 20)
        Me.menuFile.Text = "Flie"
        '
        'menuLoad
        '
        Me.menuLoad.Name = "menuLoad"
        Me.menuLoad.Size = New System.Drawing.Size(122, 22)
        Me.menuLoad.Text = "Load data"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(122, 22)
        Me.menuExit.Text = "Exit"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelp, Me.menuAbout})
        Me.helpMenuItem.Name = "helpMenuItem"
        Me.helpMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.helpMenuItem.Text = "Help"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelp1, Me.menuHelp2})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(152, 22)
        Me.menuHelp.Text = "Application Help"
        '
        'menuHelp1
        '
        Me.menuHelp1.Name = "menuHelp1"
        Me.menuHelp1.Size = New System.Drawing.Size(161, 22)
        Me.menuHelp1.Text = "Help with code #1"
        '
        'menuHelp2
        '
        Me.menuHelp2.Name = "menuHelp2"
        Me.menuHelp2.Size = New System.Drawing.Size(161, 22)
        Me.menuHelp2.Text = "Help with code #2"
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(152, 22)
        Me.menuAbout.Text = "About"
        '
        'cmdFirst
        '
        Me.cmdFirst.Location = New System.Drawing.Point(13, 296)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(33, 21)
        Me.cmdFirst.TabIndex = 3
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.Location = New System.Drawing.Point(139, 296)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(33, 21)
        Me.cmdLast.TabIndex = 4
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(100, 296)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(33, 21)
        Me.cmdNext.TabIndex = 5
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrev
        '
        Me.cmdPrev.Location = New System.Drawing.Point(52, 296)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(33, 21)
        Me.cmdPrev.TabIndex = 6
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(13, 27)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(73, 21)
        Me.cmdLoad.TabIndex = 7
        Me.cmdLoad.Text = "Load Data"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(489, 296)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(73, 21)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdResize
        '
        Me.cmdResize.Location = New System.Drawing.Point(13, 261)
        Me.cmdResize.Name = "cmdResize"
        Me.cmdResize.Size = New System.Drawing.Size(73, 21)
        Me.cmdResize.TabIndex = 9
        Me.cmdResize.Text = "Resize Cols"
        Me.cmdResize.UseVisualStyleBackColor = True
        '
        'cmdHide
        '
        Me.cmdHide.Location = New System.Drawing.Point(13, 207)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(73, 21)
        Me.cmdHide.TabIndex = 10
        Me.cmdHide.Text = "Hide Col"
        Me.cmdHide.UseVisualStyleBackColor = True
        '
        'cMenuCol
        '
        Me.cMenuCol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Column1ToolStripMenuItem, Me.Column2ToolStripMenuItem, Me.Column3ToolStripMenuItem, Me.Column4ToolStripMenuItem, Me.Column5ToolStripMenuItem, Me.Column6ToolStripMenuItem, Me.Column7ToolStripMenuItem, Me.Column8ToolStripMenuItem, Me.Column9ToolStripMenuItem, Me.Column10ToolStripMenuItem})
        Me.cMenuCol.Name = "cMenueCol"
        Me.cMenuCol.Size = New System.Drawing.Size(133, 224)
        '
        'Column1ToolStripMenuItem
        '
        Me.Column1ToolStripMenuItem.Name = "Column1ToolStripMenuItem"
        Me.Column1ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column1ToolStripMenuItem.Text = "Column #1"
        '
        'Column2ToolStripMenuItem
        '
        Me.Column2ToolStripMenuItem.Name = "Column2ToolStripMenuItem"
        Me.Column2ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column2ToolStripMenuItem.Text = "Column #2"
        '
        'Column3ToolStripMenuItem
        '
        Me.Column3ToolStripMenuItem.Name = "Column3ToolStripMenuItem"
        Me.Column3ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column3ToolStripMenuItem.Text = "Column #3"
        '
        'Column4ToolStripMenuItem
        '
        Me.Column4ToolStripMenuItem.Name = "Column4ToolStripMenuItem"
        Me.Column4ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column4ToolStripMenuItem.Text = "Column #4"
        '
        'Column5ToolStripMenuItem
        '
        Me.Column5ToolStripMenuItem.Name = "Column5ToolStripMenuItem"
        Me.Column5ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column5ToolStripMenuItem.Text = "Column #5"
        '
        'Column6ToolStripMenuItem
        '
        Me.Column6ToolStripMenuItem.Name = "Column6ToolStripMenuItem"
        Me.Column6ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column6ToolStripMenuItem.Text = "Column #6"
        '
        'Column7ToolStripMenuItem
        '
        Me.Column7ToolStripMenuItem.Name = "Column7ToolStripMenuItem"
        Me.Column7ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column7ToolStripMenuItem.Text = "Column #7"
        '
        'Column8ToolStripMenuItem
        '
        Me.Column8ToolStripMenuItem.Name = "Column8ToolStripMenuItem"
        Me.Column8ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column8ToolStripMenuItem.Text = "Column #8"
        '
        'Column9ToolStripMenuItem
        '
        Me.Column9ToolStripMenuItem.Name = "Column9ToolStripMenuItem"
        Me.Column9ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column9ToolStripMenuItem.Text = "Column #9"
        '
        'Column10ToolStripMenuItem
        '
        Me.Column10ToolStripMenuItem.Name = "Column10ToolStripMenuItem"
        Me.Column10ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Column10ToolStripMenuItem.Text = "Column #10"
        '
        'cmdLock
        '
        Me.cmdLock.Location = New System.Drawing.Point(13, 153)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(73, 21)
        Me.cmdLock.TabIndex = 11
        Me.cmdLock.Text = "Lock Col"
        Me.cmdLock.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(13, 117)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(73, 21)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(13, 90)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(73, 21)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(13, 63)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(73, 21)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(13, 117)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(73, 21)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdUnlock
        '
        Me.cmdUnlock.Location = New System.Drawing.Point(12, 180)
        Me.cmdUnlock.Name = "cmdUnlock"
        Me.cmdUnlock.Size = New System.Drawing.Size(73, 21)
        Me.cmdUnlock.TabIndex = 16
        Me.cmdUnlock.Text = "Unlock Cols"
        Me.cmdUnlock.UseVisualStyleBackColor = True
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(13, 234)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(73, 21)
        Me.cmdShow.TabIndex = 17
        Me.cmdShow.Text = "Show Cols"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'cmdHelp1
        '
        Me.cmdHelp1.Location = New System.Drawing.Point(242, 296)
        Me.cmdHelp1.Name = "cmdHelp1"
        Me.cmdHelp1.Size = New System.Drawing.Size(111, 21)
        Me.cmdHelp1.TabIndex = 18
        Me.cmdHelp1.Text = "Help with code #1"
        Me.cmdHelp1.UseVisualStyleBackColor = True
        '
        'cmdHelp2
        '
        Me.cmdHelp2.Location = New System.Drawing.Point(359, 296)
        Me.cmdHelp2.Name = "cmdHelp2"
        Me.cmdHelp2.Size = New System.Drawing.Size(111, 21)
        Me.cmdHelp2.TabIndex = 19
        Me.cmdHelp2.Text = "Help with code #2"
        Me.cmdHelp2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 332)
        Me.Controls.Add(Me.cmdHelp2)
        Me.Controls.Add(Me.cmdHelp1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.cmdUnlock)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdHide)
        Me.Controls.Add(Me.cmdResize)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdLast)
        Me.Controls.Add(Me.cmdFirst)
        Me.Controls.Add(Me.HelpMenu)
        Me.Controls.Add(Me.MKGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        CType(Me.MKGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HelpMenu.ResumeLayout(False)
        Me.HelpMenu.PerformLayout()
        Me.cMenuCol.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MKGrid1 As AxKGrid.AxMKGrid
    Private WithEvents HelpMenu As System.Windows.Forms.MenuStrip
    Private WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuLoad As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrev As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdResize As System.Windows.Forms.Button
    Friend WithEvents cmdHide As System.Windows.Forms.Button
    Friend WithEvents cmdLock As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdUnlock As System.Windows.Forms.Button
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents cMenuCol As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Column1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelp1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelp2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHelp1 As System.Windows.Forms.Button
    Friend WithEvents cmdHelp2 As System.Windows.Forms.Button

End Class
