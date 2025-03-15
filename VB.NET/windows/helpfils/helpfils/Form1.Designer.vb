<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClose = New System.Windows.Forms.Button
        Me.IconImages = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.txtHelp = New System.Windows.Forms.TextBox
        Me.tabHelp = New System.Windows.Forms.TabControl
        Me.ContentsPage = New System.Windows.Forms.TabPage
        Me.tvHelp = New System.Windows.Forms.TreeView
        Me.IndexPage = New System.Windows.Forms.TabPage
        Me.cmbHeading = New System.Windows.Forms.ComboBox
        Me.lblHint = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabHelp.SuspendLayout()
        Me.ContentsPage.SuspendLayout()
        Me.IndexPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(569, 372)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'IconImages
        '
        Me.IconImages.ImageStream = CType(resources.GetObject("IconImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconImages.TransparentColor = System.Drawing.Color.Transparent
        Me.IconImages.Images.SetKeyName(0, "Book1.ICO")
        Me.IconImages.Images.SetKeyName(1, "Book2.ICO")
        Me.IconImages.Images.SetKeyName(2, "Page.ICO")
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(168, 296)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtHelp
        '
        Me.txtHelp.Location = New System.Drawing.Point(325, 12)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelp.Size = New System.Drawing.Size(320, 352)
        Me.txtHelp.TabIndex = 8
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.ContentsPage)
        Me.tabHelp.Controls.Add(Me.IndexPage)
        Me.tabHelp.Location = New System.Drawing.Point(45, 12)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.SelectedIndex = 0
        Me.tabHelp.Size = New System.Drawing.Size(264, 352)
        Me.tabHelp.TabIndex = 7
        '
        'ContentsPage
        '
        Me.ContentsPage.BackColor = System.Drawing.SystemColors.Control
        Me.ContentsPage.Controls.Add(Me.tvHelp)
        Me.ContentsPage.Location = New System.Drawing.Point(4, 22)
        Me.ContentsPage.Name = "ContentsPage"
        Me.ContentsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ContentsPage.Size = New System.Drawing.Size(256, 326)
        Me.ContentsPage.TabIndex = 0
        Me.ContentsPage.Text = "Contents"
        '
        'tvHelp
        '
        Me.tvHelp.Location = New System.Drawing.Point(8, 20)
        Me.tvHelp.Name = "tvHelp"
        Me.tvHelp.Size = New System.Drawing.Size(242, 288)
        Me.tvHelp.TabIndex = 0
        '
        'IndexPage
        '
        Me.IndexPage.BackColor = System.Drawing.SystemColors.Control
        Me.IndexPage.Controls.Add(Me.btnDisplay)
        Me.IndexPage.Controls.Add(Me.cmbHeading)
        Me.IndexPage.Controls.Add(Me.lblHint)
        Me.IndexPage.Location = New System.Drawing.Point(4, 22)
        Me.IndexPage.Name = "IndexPage"
        Me.IndexPage.Padding = New System.Windows.Forms.Padding(3)
        Me.IndexPage.Size = New System.Drawing.Size(256, 326)
        Me.IndexPage.TabIndex = 1
        Me.IndexPage.Text = "Index"
        '
        'cmbHeading
        '
        Me.cmbHeading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbHeading.FormattingEnabled = True
        Me.cmbHeading.Location = New System.Drawing.Point(16, 32)
        Me.cmbHeading.Name = "cmbHeading"
        Me.cmbHeading.Size = New System.Drawing.Size(226, 264)
        Me.cmbHeading.Sorted = True
        Me.cmbHeading.TabIndex = 1
        '
        'lblHint
        '
        Me.lblHint.Location = New System.Drawing.Point(16, 8)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(120, 23)
        Me.lblHint.TabIndex = 0
        Me.lblHint.Text = "Type Keyword to find:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(45, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Populate TreeView with MyHelp1.xml"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 416)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.tabHelp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabHelp.ResumeLayout(False)
        Me.ContentsPage.ResumeLayout(False)
        Me.IndexPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents IconImages As System.Windows.Forms.ImageList
    Private WithEvents btnDisplay As System.Windows.Forms.Button
    Private WithEvents txtHelp As System.Windows.Forms.TextBox
    Private WithEvents tabHelp As System.Windows.Forms.TabControl
    Private WithEvents ContentsPage As System.Windows.Forms.TabPage
    Private WithEvents tvHelp As System.Windows.Forms.TreeView
    Private WithEvents IndexPage As System.Windows.Forms.TabPage
    Private WithEvents cmbHeading As System.Windows.Forms.ComboBox
    Private WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
