<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formUtamaMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUtamaMDI))
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuGroupProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuSatuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.subMenuSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.subSubMenuDetailPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.subSubMenuPembelianPerGroupProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.subSubMenuPembelianPerProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.subSubMenuPembelianPerSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuRekapitulasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progressBarLoading = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblCopyright = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAdmin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnUser = New System.Windows.Forms.ToolStripButton()
        Me.btnPembelian = New System.Windows.Forms.ToolStripButton()
        Me.btnKeluar = New System.Windows.Forms.ToolStripButton()
        Me.menuStrip.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuMaster, Me.menuTransaksi, Me.menuLaporan, Me.menuHelp})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(694, 24)
        Me.menuStrip.TabIndex = 1
        Me.menuStrip.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'menuMaster
        '
        Me.menuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuGroupProduct, Me.subMenuSatuan, Me.subMenuProduct, Me.ToolStripMenuItem1, Me.subMenuSupplier})
        Me.menuMaster.Name = "menuMaster"
        Me.menuMaster.Size = New System.Drawing.Size(55, 20)
        Me.menuMaster.Text = "Master"
        '
        'subMenuGroupProduct
        '
        Me.subMenuGroupProduct.Name = "subMenuGroupProduct"
        Me.subMenuGroupProduct.Size = New System.Drawing.Size(180, 22)
        Me.subMenuGroupProduct.Text = "Group Product"
        '
        'subMenuSatuan
        '
        Me.subMenuSatuan.Name = "subMenuSatuan"
        Me.subMenuSatuan.Size = New System.Drawing.Size(180, 22)
        Me.subMenuSatuan.Text = "Satuan"
        '
        'subMenuProduct
        '
        Me.subMenuProduct.Name = "subMenuProduct"
        Me.subMenuProduct.Size = New System.Drawing.Size(180, 22)
        Me.subMenuProduct.Text = "Product"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'subMenuSupplier
        '
        Me.subMenuSupplier.Name = "subMenuSupplier"
        Me.subMenuSupplier.Size = New System.Drawing.Size(180, 22)
        Me.subMenuSupplier.Text = "Supplier"
        '
        'menuTransaksi
        '
        Me.menuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuPembelian})
        Me.menuTransaksi.Name = "menuTransaksi"
        Me.menuTransaksi.Size = New System.Drawing.Size(66, 20)
        Me.menuTransaksi.Text = "Transaksi"
        '
        'subMenuPembelian
        '
        Me.subMenuPembelian.Name = "subMenuPembelian"
        Me.subMenuPembelian.Size = New System.Drawing.Size(180, 22)
        Me.subMenuPembelian.Text = "Pembelian"
        '
        'menuLaporan
        '
        Me.menuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuTransaksi, Me.subMenuRekapitulasi})
        Me.menuLaporan.Name = "menuLaporan"
        Me.menuLaporan.Size = New System.Drawing.Size(62, 20)
        Me.menuLaporan.Text = "Laporan"
        '
        'subMenuTransaksi
        '
        Me.subMenuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subSubMenuDetailPembelian, Me.subSubMenuPembelianPerGroupProduct, Me.subSubMenuPembelianPerProduct, Me.subSubMenuPembelianPerSupplier})
        Me.subMenuTransaksi.Name = "subMenuTransaksi"
        Me.subMenuTransaksi.Size = New System.Drawing.Size(180, 22)
        Me.subMenuTransaksi.Text = "Transaksi"
        '
        'subSubMenuDetailPembelian
        '
        Me.subSubMenuDetailPembelian.Name = "subSubMenuDetailPembelian"
        Me.subSubMenuDetailPembelian.Size = New System.Drawing.Size(231, 22)
        Me.subSubMenuDetailPembelian.Text = "Detail Pembelian"
        '
        'subSubMenuPembelianPerGroupProduct
        '
        Me.subSubMenuPembelianPerGroupProduct.Name = "subSubMenuPembelianPerGroupProduct"
        Me.subSubMenuPembelianPerGroupProduct.Size = New System.Drawing.Size(231, 22)
        Me.subSubMenuPembelianPerGroupProduct.Text = "Pembelian Per Group Product"
        '
        'subSubMenuPembelianPerProduct
        '
        Me.subSubMenuPembelianPerProduct.Name = "subSubMenuPembelianPerProduct"
        Me.subSubMenuPembelianPerProduct.Size = New System.Drawing.Size(231, 22)
        Me.subSubMenuPembelianPerProduct.Text = "Pembelian Per Product"
        '
        'subSubMenuPembelianPerSupplier
        '
        Me.subSubMenuPembelianPerSupplier.Name = "subSubMenuPembelianPerSupplier"
        Me.subSubMenuPembelianPerSupplier.Size = New System.Drawing.Size(231, 22)
        Me.subSubMenuPembelianPerSupplier.Text = "Pembelian Per Supplier"
        '
        'subMenuRekapitulasi
        '
        Me.subMenuRekapitulasi.Name = "subMenuRekapitulasi"
        Me.subMenuRekapitulasi.Size = New System.Drawing.Size(180, 22)
        Me.subMenuRekapitulasi.Text = "Rekapitulasi"
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
        Me.subMenuAbout.Size = New System.Drawing.Size(107, 22)
        Me.subMenuAbout.Text = "About"
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblReady, Me.progressBarLoading, Me.lblCopyright, Me.lblAdmin})
        Me.statusStrip.Location = New System.Drawing.Point(0, 389)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(694, 22)
        Me.statusStrip.TabIndex = 2
        Me.statusStrip.Text = "StatusStrip1"
        '
        'lblReady
        '
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(39, 17)
        Me.lblReady.Text = "Ready"
        '
        'progressBarLoading
        '
        Me.progressBarLoading.Name = "progressBarLoading"
        Me.progressBarLoading.Size = New System.Drawing.Size(300, 16)
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(209, 17)
        Me.lblCopyright.Text = "Pradipta Ramadhan | Copyright 2020"
        '
        'lblAdmin
        '
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(131, 17)
        Me.lblAdmin.Text = "- admin/Administrator"
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUser, Me.btnPembelian, Me.btnKeluar})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(694, 25)
        Me.toolStrip.TabIndex = 3
        Me.toolStrip.Text = "ToolStrip1"
        '
        'btnUser
        '
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(50, 22)
        Me.btnUser.Text = "User"
        '
        'btnPembelian
        '
        Me.btnPembelian.Image = CType(resources.GetObject("btnPembelian.Image"), System.Drawing.Image)
        Me.btnPembelian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Size = New System.Drawing.Size(83, 22)
        Me.btnPembelian.Text = "Pembelian"
        '
        'btnKeluar
        '
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(60, 22)
        Me.btnKeluar.Text = "Keluar"
        '
        'formUtamaMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 411)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.menuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "formUtamaMDI"
        Me.Text = "Form Utama MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuMaster As ToolStripMenuItem
    Friend WithEvents subMenuGroupProduct As ToolStripMenuItem
    Friend WithEvents subMenuSatuan As ToolStripMenuItem
    Friend WithEvents subMenuProduct As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents subMenuSupplier As ToolStripMenuItem
    Friend WithEvents menuTransaksi As ToolStripMenuItem
    Friend WithEvents subMenuPembelian As ToolStripMenuItem
    Friend WithEvents menuLaporan As ToolStripMenuItem
    Friend WithEvents subMenuTransaksi As ToolStripMenuItem
    Friend WithEvents subSubMenuDetailPembelian As ToolStripMenuItem
    Friend WithEvents subSubMenuPembelianPerGroupProduct As ToolStripMenuItem
    Friend WithEvents subSubMenuPembelianPerProduct As ToolStripMenuItem
    Friend WithEvents subSubMenuPembelianPerSupplier As ToolStripMenuItem
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents subMenuRekapitulasi As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents subMenuAbout As ToolStripMenuItem
    Friend WithEvents lblReady As ToolStripStatusLabel
    Friend WithEvents progressBarLoading As ToolStripProgressBar
    Friend WithEvents lblCopyright As ToolStripStatusLabel
    Friend WithEvents lblAdmin As ToolStripStatusLabel
    Friend WithEvents btnUser As ToolStripButton
    Friend WithEvents btnPembelian As ToolStripButton
    Friend WithEvents btnKeluar As ToolStripButton
End Class
