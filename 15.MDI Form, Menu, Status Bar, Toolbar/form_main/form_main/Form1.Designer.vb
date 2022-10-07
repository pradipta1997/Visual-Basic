<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMDI))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuLatihanForm1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuLatihanForm2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.subMenuLatihanForm3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuLatihanForm4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.subMenuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnHome = New System.Windows.Forms.ToolStripButton()
        Me.btnProject = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.statusStripTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuForm, Me.menuWindows, Me.menuHelp})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(551, 24)
        Me.menuStrip.TabIndex = 1
        Me.menuStrip.Text = "menuStrip"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'subMenuExit
        '
        Me.subMenuExit.Name = "subMenuExit"
        Me.subMenuExit.Size = New System.Drawing.Size(180, 22)
        Me.subMenuExit.Text = "Exit"
        '
        'menuForm
        '
        Me.menuForm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuLatihanForm1, Me.subMenuLatihanForm2, Me.ToolStripMenuItem1, Me.subMenuLatihanForm3, Me.subMenuLatihanForm4})
        Me.menuForm.Name = "menuForm"
        Me.menuForm.Size = New System.Drawing.Size(47, 20)
        Me.menuForm.Text = "Form"
        '
        'subMenuLatihanForm1
        '
        Me.subMenuLatihanForm1.Name = "subMenuLatihanForm1"
        Me.subMenuLatihanForm1.Size = New System.Drawing.Size(180, 22)
        Me.subMenuLatihanForm1.Text = "Latihan Form 1"
        '
        'subMenuLatihanForm2
        '
        Me.subMenuLatihanForm2.Name = "subMenuLatihanForm2"
        Me.subMenuLatihanForm2.Size = New System.Drawing.Size(180, 22)
        Me.subMenuLatihanForm2.Text = "Latihan Form 2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'subMenuLatihanForm3
        '
        Me.subMenuLatihanForm3.Name = "subMenuLatihanForm3"
        Me.subMenuLatihanForm3.Size = New System.Drawing.Size(180, 22)
        Me.subMenuLatihanForm3.Text = "Latihan Form 3"
        '
        'subMenuLatihanForm4
        '
        Me.subMenuLatihanForm4.Name = "subMenuLatihanForm4"
        Me.subMenuLatihanForm4.Size = New System.Drawing.Size(180, 22)
        Me.subMenuLatihanForm4.Text = "Latihan Form 4"
        '
        'menuWindows
        '
        Me.menuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuTileVertical, Me.subMenuTileHorizontal, Me.ToolStripMenuItem2, Me.subMenuCascade})
        Me.menuWindows.Name = "menuWindows"
        Me.menuWindows.Size = New System.Drawing.Size(68, 20)
        Me.menuWindows.Text = "Windows"
        '
        'subMenuTileVertical
        '
        Me.subMenuTileVertical.Name = "subMenuTileVertical"
        Me.subMenuTileVertical.Size = New System.Drawing.Size(180, 22)
        Me.subMenuTileVertical.Text = "Tile Vertical"
        '
        'subMenuTileHorizontal
        '
        Me.subMenuTileHorizontal.Name = "subMenuTileHorizontal"
        Me.subMenuTileHorizontal.Size = New System.Drawing.Size(180, 22)
        Me.subMenuTileHorizontal.Text = "Tile Horizontal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'subMenuCascade
        '
        Me.subMenuCascade.Name = "subMenuCascade"
        Me.subMenuCascade.Size = New System.Drawing.Size(180, 22)
        Me.subMenuCascade.Text = "Cascade"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "Help"
        '
        'subMenuAbout
        '
        Me.subMenuAbout.Name = "subMenuAbout"
        Me.subMenuAbout.Size = New System.Drawing.Size(180, 22)
        Me.subMenuAbout.Text = "About"
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHome, Me.btnProject, Me.btnExit})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(551, 25)
        Me.toolStrip.TabIndex = 2
        Me.toolStrip.Text = "ToolStrip1"
        '
        'btnHome
        '
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(60, 22)
        Me.btnHome.Text = "Home"
        '
        'btnProject
        '
        Me.btnProject.Image = CType(resources.GetObject("btnProject.Image"), System.Drawing.Image)
        Me.btnProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(64, 22)
        Me.btnProject.Text = "Project"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 22)
        Me.btnExit.Text = "Exit"
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusStripTanggal})
        Me.statusStrip.Location = New System.Drawing.Point(0, 346)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(551, 22)
        Me.statusStrip.TabIndex = 3
        Me.statusStrip.Text = "statusStrip"
        '
        'statusStripTanggal
        '
        Me.statusStripTanggal.AutoSize = False
        Me.statusStripTanggal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.statusStripTanggal.Name = "statusStripTanggal"
        Me.statusStripTanggal.Size = New System.Drawing.Size(200, 17)
        Me.statusStripTanggal.Text = "Tanggal :"
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'formMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 368)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.menuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "formMDI"
        Me.Text = "Form MDI"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents subMenuExit As ToolStripMenuItem
    Friend WithEvents menuForm As ToolStripMenuItem
    Friend WithEvents subMenuLatihanForm1 As ToolStripMenuItem
    Friend WithEvents subMenuLatihanForm2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents subMenuLatihanForm3 As ToolStripMenuItem
    Friend WithEvents subMenuLatihanForm4 As ToolStripMenuItem
    Friend WithEvents menuWindows As ToolStripMenuItem
    Friend WithEvents subMenuTileVertical As ToolStripMenuItem
    Friend WithEvents subMenuTileHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents subMenuCascade As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents subMenuAbout As ToolStripMenuItem
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents btnHome As ToolStripButton
    Friend WithEvents btnProject As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents statusStripTanggal As ToolStripStatusLabel
    Friend WithEvents timer As Timer
End Class
