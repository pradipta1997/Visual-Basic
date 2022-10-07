<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPembelian
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
        Me.lblPembelian = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.supplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.supplierDataSet3 = New sistem_inventory.supplierDataSet3()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.lblTotalUang = New System.Windows.Forms.Label()
        Me.txtTotalUang = New System.Windows.Forms.TextBox()
        Me.lblDetailPembelian = New System.Windows.Forms.Label()
        Me.lblKodeProduct = New System.Windows.Forms.Label()
        Me.lblNamaProduct = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblHargaSatuan = New System.Windows.Forms.Label()
        Me.lblJumlahUang = New System.Windows.Forms.Label()
        Me.txtKodeProduct = New System.Windows.Forms.TextBox()
        Me.txtNamaProduct = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.txtJumlahUang = New System.Windows.Forms.TextBox()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.transaksiID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_uang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambahDetail = New System.Windows.Forms.Button()
        Me.btnSimpanDetail = New System.Windows.Forms.Button()
        Me.btnTambahPembelian = New System.Windows.Forms.Button()
        Me.panelDetail = New System.Windows.Forms.Panel()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnHapusDetail = New System.Windows.Forms.Button()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.btnEditPembelian = New System.Windows.Forms.Button()
        Me.btnHapusPembelian = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.btnTambahTransaksi = New System.Windows.Forms.Button()
        Me.supplierTableAdapter = New sistem_inventory.supplierDataSet3TableAdapters.supplierTableAdapter()
        Me.detailPembelianDataSet4 = New sistem_inventory.detailPembelianDataSet4()
        Me.detailPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_pembelianTableAdapter = New sistem_inventory.detailPembelianDataSet4TableAdapters.detail_pembelianTableAdapter()
        Me.headerPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.headerPembelianDataSet5 = New sistem_inventory.headerPembelianDataSet5()
        Me.header_pembelianTableAdapter = New sistem_inventory.headerPembelianDataSet5TableAdapters.header_pembelianTableAdapter()
        Me.productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productDataSet6 = New sistem_inventory.productDataSet6()
        Me.productTableAdapter = New sistem_inventory.productDataSet6TableAdapters.productTableAdapter()
        CType(Me.supplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supplierDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetail.SuspendLayout()
        CType(Me.detailPembelianDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detailPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerPembelianDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPembelian
        '
        Me.lblPembelian.BackColor = System.Drawing.Color.Black
        Me.lblPembelian.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPembelian.ForeColor = System.Drawing.Color.White
        Me.lblPembelian.Location = New System.Drawing.Point(0, 0)
        Me.lblPembelian.Name = "lblPembelian"
        Me.lblPembelian.Size = New System.Drawing.Size(756, 23)
        Me.lblPembelian.TabIndex = 0
        Me.lblPembelian.Text = "Pembelian"
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.Location = New System.Drawing.Point(32, 53)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(91, 15)
        Me.lblTransaksi.TabIndex = 1
        Me.lblTransaksi.Text = "No.Transaksi"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(32, 108)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(59, 15)
        Me.lblTanggal.TabIndex = 2
        Me.lblTanggal.Text = "Tanggal"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(418, 53)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(61, 15)
        Me.lblSupplier.TabIndex = 3
        Me.lblSupplier.Text = "Supplier"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(418, 106)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(81, 15)
        Me.lblKeterangan.TabIndex = 4
        Me.lblKeterangan.Text = "Keterangan"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.Location = New System.Drawing.Point(129, 51)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.txtNoTransaksi.TabIndex = 5
        '
        'dateTimePicker
        '
        Me.dateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimePicker.Location = New System.Drawing.Point(129, 104)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker.TabIndex = 6
        '
        'comboBoxSupplier
        '
        Me.comboBoxSupplier.DataSource = Me.supplierBindingSource
        Me.comboBoxSupplier.DisplayMember = "nama_supplier"
        Me.comboBoxSupplier.FormattingEnabled = True
        Me.comboBoxSupplier.Location = New System.Drawing.Point(505, 50)
        Me.comboBoxSupplier.Name = "comboBoxSupplier"
        Me.comboBoxSupplier.Size = New System.Drawing.Size(200, 21)
        Me.comboBoxSupplier.TabIndex = 7
        Me.comboBoxSupplier.ValueMember = "kode_supplier"
        '
        'supplierBindingSource
        '
        Me.supplierBindingSource.DataMember = "supplier"
        Me.supplierBindingSource.DataSource = Me.supplierDataSet3
        '
        'supplierDataSet3
        '
        Me.supplierDataSet3.DataSetName = "supplierDataSet3"
        Me.supplierDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(505, 104)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(200, 44)
        Me.txtKeterangan.TabIndex = 8
        '
        'lblTotalUang
        '
        Me.lblTotalUang.AutoSize = True
        Me.lblTotalUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUang.Location = New System.Drawing.Point(511, 166)
        Me.lblTotalUang.Name = "lblTotalUang"
        Me.lblTotalUang.Size = New System.Drawing.Size(77, 15)
        Me.lblTotalUang.TabIndex = 9
        Me.lblTotalUang.Text = "Total Uang"
        '
        'txtTotalUang
        '
        Me.txtTotalUang.Location = New System.Drawing.Point(595, 165)
        Me.txtTotalUang.Name = "txtTotalUang"
        Me.txtTotalUang.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalUang.TabIndex = 10
        '
        'lblDetailPembelian
        '
        Me.lblDetailPembelian.BackColor = System.Drawing.Color.Black
        Me.lblDetailPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailPembelian.ForeColor = System.Drawing.Color.White
        Me.lblDetailPembelian.Location = New System.Drawing.Point(0, 0)
        Me.lblDetailPembelian.Name = "lblDetailPembelian"
        Me.lblDetailPembelian.Size = New System.Drawing.Size(732, 23)
        Me.lblDetailPembelian.TabIndex = 11
        Me.lblDetailPembelian.Text = "Detail Pembelian"
        '
        'lblKodeProduct
        '
        Me.lblKodeProduct.AutoSize = True
        Me.lblKodeProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeProduct.Location = New System.Drawing.Point(5, 29)
        Me.lblKodeProduct.Name = "lblKodeProduct"
        Me.lblKodeProduct.Size = New System.Drawing.Size(93, 15)
        Me.lblKodeProduct.TabIndex = 12
        Me.lblKodeProduct.Text = "Kode Product"
        '
        'lblNamaProduct
        '
        Me.lblNamaProduct.AutoSize = True
        Me.lblNamaProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaProduct.Location = New System.Drawing.Point(97, 29)
        Me.lblNamaProduct.Name = "lblNamaProduct"
        Me.lblNamaProduct.Size = New System.Drawing.Size(98, 15)
        Me.lblNamaProduct.TabIndex = 13
        Me.lblNamaProduct.Text = "Nama Product"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlah.Location = New System.Drawing.Point(294, 29)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(54, 15)
        Me.lblJumlah.TabIndex = 14
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblHargaSatuan
        '
        Me.lblHargaSatuan.AutoSize = True
        Me.lblHargaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHargaSatuan.Location = New System.Drawing.Point(383, 29)
        Me.lblHargaSatuan.Name = "lblHargaSatuan"
        Me.lblHargaSatuan.Size = New System.Drawing.Size(95, 15)
        Me.lblHargaSatuan.TabIndex = 15
        Me.lblHargaSatuan.Text = "Harga Satuan"
        '
        'lblJumlahUang
        '
        Me.lblJumlahUang.AutoSize = True
        Me.lblJumlahUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUang.Location = New System.Drawing.Point(609, 29)
        Me.lblJumlahUang.Name = "lblJumlahUang"
        Me.lblJumlahUang.Size = New System.Drawing.Size(92, 15)
        Me.lblJumlahUang.TabIndex = 16
        Me.lblJumlahUang.Text = "Jumlah Uang"
        '
        'txtKodeProduct
        '
        Me.txtKodeProduct.Location = New System.Drawing.Point(8, 47)
        Me.txtKodeProduct.Name = "txtKodeProduct"
        Me.txtKodeProduct.Size = New System.Drawing.Size(90, 20)
        Me.txtKodeProduct.TabIndex = 17
        '
        'txtNamaProduct
        '
        Me.txtNamaProduct.Location = New System.Drawing.Point(99, 47)
        Me.txtNamaProduct.Name = "txtNamaProduct"
        Me.txtNamaProduct.ReadOnly = True
        Me.txtNamaProduct.Size = New System.Drawing.Size(195, 20)
        Me.txtNamaProduct.TabIndex = 18
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(295, 47)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(90, 20)
        Me.txtJumlah.TabIndex = 19
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Enabled = False
        Me.txtHargaSatuan.Location = New System.Drawing.Point(386, 47)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(112, 20)
        Me.txtHargaSatuan.TabIndex = 20
        '
        'txtJumlahUang
        '
        Me.txtJumlahUang.Enabled = False
        Me.txtJumlahUang.Location = New System.Drawing.Point(612, 47)
        Me.txtJumlahUang.Name = "txtJumlahUang"
        Me.txtJumlahUang.Size = New System.Drawing.Size(112, 20)
        Me.txtJumlahUang.TabIndex = 21
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transaksiID, Me.kode_product, Me.nama_product, Me.jumlah, Me.harga_satuan, Me.discount, Me.jumlah_uang})
        Me.dataGridView.Location = New System.Drawing.Point(18, 73)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(695, 83)
        Me.dataGridView.TabIndex = 22
        '
        'transaksiID
        '
        Me.transaksiID.HeaderText = "Transaksi ID"
        Me.transaksiID.Name = "transaksiID"
        Me.transaksiID.Visible = False
        '
        'kode_product
        '
        Me.kode_product.HeaderText = "Kode Product"
        Me.kode_product.Name = "kode_product"
        '
        'nama_product
        '
        Me.nama_product.HeaderText = "Nama Product"
        Me.nama_product.Name = "nama_product"
        Me.nama_product.Width = 156
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'harga_satuan
        '
        Me.harga_satuan.HeaderText = "Harga Satuan"
        Me.harga_satuan.Name = "harga_satuan"
        '
        'discount
        '
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        '
        'jumlah_uang
        '
        Me.jumlah_uang.HeaderText = "Jumlah Uang"
        Me.jumlah_uang.Name = "jumlah_uang"
        '
        'btnTambahDetail
        '
        Me.btnTambahDetail.Location = New System.Drawing.Point(16, 162)
        Me.btnTambahDetail.Name = "btnTambahDetail"
        Me.btnTambahDetail.Size = New System.Drawing.Size(91, 23)
        Me.btnTambahDetail.TabIndex = 23
        Me.btnTambahDetail.Text = "Tambah Detail"
        Me.btnTambahDetail.UseVisualStyleBackColor = True
        '
        'btnSimpanDetail
        '
        Me.btnSimpanDetail.Location = New System.Drawing.Point(108, 162)
        Me.btnSimpanDetail.Name = "btnSimpanDetail"
        Me.btnSimpanDetail.Size = New System.Drawing.Size(91, 23)
        Me.btnSimpanDetail.TabIndex = 24
        Me.btnSimpanDetail.Text = "Simpan Detail"
        Me.btnSimpanDetail.UseVisualStyleBackColor = True
        '
        'btnTambahPembelian
        '
        Me.btnTambahPembelian.Location = New System.Drawing.Point(27, 398)
        Me.btnTambahPembelian.Name = "btnTambahPembelian"
        Me.btnTambahPembelian.Size = New System.Drawing.Size(113, 33)
        Me.btnTambahPembelian.TabIndex = 25
        Me.btnTambahPembelian.Text = "Tambah Pembelian"
        Me.btnTambahPembelian.UseVisualStyleBackColor = True
        '
        'panelDetail
        '
        Me.panelDetail.Controls.Add(Me.txtDiscount)
        Me.panelDetail.Controls.Add(Me.btnHapusDetail)
        Me.panelDetail.Controls.Add(Me.lblDiscount)
        Me.panelDetail.Controls.Add(Me.lblDetailPembelian)
        Me.panelDetail.Controls.Add(Me.lblKodeProduct)
        Me.panelDetail.Controls.Add(Me.lblNamaProduct)
        Me.panelDetail.Controls.Add(Me.lblJumlah)
        Me.panelDetail.Controls.Add(Me.btnSimpanDetail)
        Me.panelDetail.Controls.Add(Me.lblHargaSatuan)
        Me.panelDetail.Controls.Add(Me.btnTambahDetail)
        Me.panelDetail.Controls.Add(Me.lblJumlahUang)
        Me.panelDetail.Controls.Add(Me.dataGridView)
        Me.panelDetail.Controls.Add(Me.txtKodeProduct)
        Me.panelDetail.Controls.Add(Me.txtJumlahUang)
        Me.panelDetail.Controls.Add(Me.txtNamaProduct)
        Me.panelDetail.Controls.Add(Me.txtHargaSatuan)
        Me.panelDetail.Controls.Add(Me.txtJumlah)
        Me.panelDetail.Location = New System.Drawing.Point(12, 202)
        Me.panelDetail.Name = "panelDetail"
        Me.panelDetail.Size = New System.Drawing.Size(732, 192)
        Me.panelDetail.TabIndex = 28
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(499, 47)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(112, 20)
        Me.txtDiscount.TabIndex = 26
        '
        'btnHapusDetail
        '
        Me.btnHapusDetail.Location = New System.Drawing.Point(200, 162)
        Me.btnHapusDetail.Name = "btnHapusDetail"
        Me.btnHapusDetail.Size = New System.Drawing.Size(91, 23)
        Me.btnHapusDetail.TabIndex = 25
        Me.btnHapusDetail.Text = "Hapus Detail"
        Me.btnHapusDetail.UseVisualStyleBackColor = True
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(496, 29)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(63, 15)
        Me.lblDiscount.TabIndex = 26
        Me.lblDiscount.Text = "Discount"
        '
        'btnEditPembelian
        '
        Me.btnEditPembelian.Location = New System.Drawing.Point(146, 398)
        Me.btnEditPembelian.Name = "btnEditPembelian"
        Me.btnEditPembelian.Size = New System.Drawing.Size(113, 33)
        Me.btnEditPembelian.TabIndex = 29
        Me.btnEditPembelian.Text = "Edit Pembelian"
        Me.btnEditPembelian.UseVisualStyleBackColor = True
        '
        'btnHapusPembelian
        '
        Me.btnHapusPembelian.Location = New System.Drawing.Point(265, 398)
        Me.btnHapusPembelian.Name = "btnHapusPembelian"
        Me.btnHapusPembelian.Size = New System.Drawing.Size(113, 33)
        Me.btnHapusPembelian.TabIndex = 30
        Me.btnHapusPembelian.Text = "Hapus Pembelian"
        Me.btnHapusPembelian.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.Red
        Me.btnSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.Location = New System.Drawing.Point(634, 398)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(113, 33)
        Me.btnSelesai.TabIndex = 31
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = False
        '
        'btnTambahTransaksi
        '
        Me.btnTambahTransaksi.Location = New System.Drawing.Point(20, 163)
        Me.btnTambahTransaksi.Name = "btnTambahTransaksi"
        Me.btnTambahTransaksi.Size = New System.Drawing.Size(113, 33)
        Me.btnTambahTransaksi.TabIndex = 32
        Me.btnTambahTransaksi.Text = "Tambah Transaksi"
        Me.btnTambahTransaksi.UseVisualStyleBackColor = True
        '
        'supplierTableAdapter
        '
        Me.supplierTableAdapter.ClearBeforeFill = True
        '
        'detailPembelianDataSet4
        '
        Me.detailPembelianDataSet4.DataSetName = "detailPembelianDataSet4"
        Me.detailPembelianDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detailPembelianBindingSource
        '
        Me.detailPembelianBindingSource.DataMember = "detail_pembelian"
        Me.detailPembelianBindingSource.DataSource = Me.detailPembelianDataSet4
        '
        'detail_pembelianTableAdapter
        '
        Me.detail_pembelianTableAdapter.ClearBeforeFill = True
        '
        'headerPembelianBindingSource
        '
        Me.headerPembelianBindingSource.DataMember = "header_pembelian"
        Me.headerPembelianBindingSource.DataSource = Me.headerPembelianDataSet5
        '
        'headerPembelianDataSet5
        '
        Me.headerPembelianDataSet5.DataSetName = "headerPembelianDataSet5"
        Me.headerPembelianDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'header_pembelianTableAdapter
        '
        Me.header_pembelianTableAdapter.ClearBeforeFill = True
        '
        'productBindingSource
        '
        Me.productBindingSource.DataMember = "product"
        Me.productBindingSource.DataSource = Me.productDataSet6
        '
        'productDataSet6
        '
        Me.productDataSet6.DataSetName = "productDataSet6"
        Me.productDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productTableAdapter
        '
        Me.productTableAdapter.ClearBeforeFill = True
        '
        'formPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 434)
        Me.Controls.Add(Me.btnTambahTransaksi)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnHapusPembelian)
        Me.Controls.Add(Me.btnEditPembelian)
        Me.Controls.Add(Me.panelDetail)
        Me.Controls.Add(Me.btnTambahPembelian)
        Me.Controls.Add(Me.txtTotalUang)
        Me.Controls.Add(Me.lblTotalUang)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.comboBoxSupplier)
        Me.Controls.Add(Me.dateTimePicker)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblTransaksi)
        Me.Controls.Add(Me.lblPembelian)
        Me.Name = "formPembelian"
        Me.Text = "formPembelian"
        CType(Me.supplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supplierDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetail.ResumeLayout(False)
        Me.panelDetail.PerformLayout()
        CType(Me.detailPembelianDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detailPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerPembelianDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPembelian As Label
    Friend WithEvents lblTransaksi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents txtNoTransaksi As TextBox
    Friend WithEvents dateTimePicker As DateTimePicker
    Friend WithEvents comboBoxSupplier As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents lblTotalUang As Label
    Friend WithEvents txtTotalUang As TextBox
    Friend WithEvents lblDetailPembelian As Label
    Friend WithEvents lblKodeProduct As Label
    Friend WithEvents lblNamaProduct As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblHargaSatuan As Label
    Friend WithEvents lblJumlahUang As Label
    Friend WithEvents txtKodeProduct As TextBox
    Friend WithEvents txtNamaProduct As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHargaSatuan As TextBox
    Friend WithEvents txtJumlahUang As TextBox
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnTambahDetail As Button
    Friend WithEvents btnSimpanDetail As Button
    Friend WithEvents btnTambahPembelian As Button
    Friend WithEvents panelDetail As Panel
    Friend WithEvents btnHapusDetail As Button
    Friend WithEvents btnEditPembelian As Button
    Friend WithEvents btnHapusPembelian As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents btnTambahTransaksi As Button
    Friend WithEvents supplierDataSet3 As supplierDataSet3
    Friend WithEvents supplierBindingSource As BindingSource
    Friend WithEvents supplierTableAdapter As supplierDataSet3TableAdapters.supplierTableAdapter
    Friend WithEvents detailPembelianDataSet4 As detailPembelianDataSet4
    Friend WithEvents detailPembelianBindingSource As BindingSource
    Friend WithEvents detail_pembelianTableAdapter As detailPembelianDataSet4TableAdapters.detail_pembelianTableAdapter
    Friend WithEvents transaksiID As DataGridViewTextBoxColumn
    Friend WithEvents kode_product As DataGridViewTextBoxColumn
    Friend WithEvents nama_product As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_uang As DataGridViewTextBoxColumn
    Friend WithEvents headerPembelianBindingSource As BindingSource
    Friend WithEvents headerPembelianDataSet5 As headerPembelianDataSet5
    Friend WithEvents header_pembelianTableAdapter As headerPembelianDataSet5TableAdapters.header_pembelianTableAdapter
    Friend WithEvents productBindingSource As BindingSource
    Friend WithEvents productDataSet6 As productDataSet6
    Friend WithEvents productTableAdapter As productDataSet6TableAdapters.productTableAdapter
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblDiscount As Label
End Class
