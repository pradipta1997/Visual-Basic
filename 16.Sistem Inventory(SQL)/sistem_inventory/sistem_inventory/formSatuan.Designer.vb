<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSatuan
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
        Me.lblSatuanJudul = New System.Windows.Forms.Label()
        Me.lblSatuanCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.KodesatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.satuanDataSet = New sistem_inventory.satuanDataSet()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblNamaSatuan = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNamaSatuan = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.satuanTableAdapter = New sistem_inventory.satuanDataSetTableAdapters.satuanTableAdapter()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.satuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.satuanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSatuanJudul
        '
        Me.lblSatuanJudul.BackColor = System.Drawing.Color.Black
        Me.lblSatuanJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSatuanJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatuanJudul.ForeColor = System.Drawing.Color.White
        Me.lblSatuanJudul.Location = New System.Drawing.Point(0, 0)
        Me.lblSatuanJudul.Name = "lblSatuanJudul"
        Me.lblSatuanJudul.Size = New System.Drawing.Size(576, 23)
        Me.lblSatuanJudul.TabIndex = 0
        Me.lblSatuanJudul.Text = "Satuan"
        '
        'lblSatuanCari
        '
        Me.lblSatuanCari.AutoSize = True
        Me.lblSatuanCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatuanCari.Location = New System.Drawing.Point(2, 44)
        Me.lblSatuanCari.Name = "lblSatuanCari"
        Me.lblSatuanCari.Size = New System.Drawing.Size(52, 15)
        Me.lblSatuanCari.TabIndex = 1
        Me.lblSatuanCari.Text = "Satuan"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(60, 44)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(104, 20)
        Me.txtCari.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(168, 43)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.AutoGenerateColumns = False
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodesatuanDataGridViewTextBoxColumn, Me.NamasatuanDataGridViewTextBoxColumn})
        Me.dataGridView.DataSource = Me.satuanBindingSource
        Me.dataGridView.Location = New System.Drawing.Point(-1, 73)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(244, 226)
        Me.dataGridView.TabIndex = 4
        '
        'KodesatuanDataGridViewTextBoxColumn
        '
        Me.KodesatuanDataGridViewTextBoxColumn.DataPropertyName = "kode_satuan"
        Me.KodesatuanDataGridViewTextBoxColumn.HeaderText = "kode_satuan"
        Me.KodesatuanDataGridViewTextBoxColumn.Name = "KodesatuanDataGridViewTextBoxColumn"
        '
        'NamasatuanDataGridViewTextBoxColumn
        '
        Me.NamasatuanDataGridViewTextBoxColumn.DataPropertyName = "nama_satuan"
        Me.NamasatuanDataGridViewTextBoxColumn.HeaderText = "nama_satuan"
        Me.NamasatuanDataGridViewTextBoxColumn.Name = "NamasatuanDataGridViewTextBoxColumn"
        '
        'satuanBindingSource
        '
        Me.satuanBindingSource.DataMember = "satuan"
        Me.satuanBindingSource.DataSource = Me.satuanDataSet
        '
        'satuanDataSet
        '
        Me.satuanDataSet.DataSetName = "satuanDataSet"
        Me.satuanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(268, 121)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(50, 20)
        Me.lblKode.TabIndex = 5
        Me.lblKode.Text = "Kode"
        '
        'lblNamaSatuan
        '
        Me.lblNamaSatuan.AutoSize = True
        Me.lblNamaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaSatuan.Location = New System.Drawing.Point(268, 157)
        Me.lblNamaSatuan.Name = "lblNamaSatuan"
        Me.lblNamaSatuan.Size = New System.Drawing.Size(118, 20)
        Me.lblNamaSatuan.TabIndex = 6
        Me.lblNamaSatuan.Text = "Nama Satuan"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(393, 121)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(127, 20)
        Me.txtKode.TabIndex = 7
        '
        'txtNamaSatuan
        '
        Me.txtNamaSatuan.Location = New System.Drawing.Point(393, 157)
        Me.txtNamaSatuan.Name = "txtNamaSatuan"
        Me.txtNamaSatuan.Size = New System.Drawing.Size(165, 20)
        Me.txtNamaSatuan.TabIndex = 8
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(259, 220)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(334, 220)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(409, 220)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(484, 220)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(484, 260)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 13
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'satuanTableAdapter
        '
        Me.satuanTableAdapter.ClearBeforeFill = True
        '
        'formSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 296)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNamaSatuan)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.lblNamaSatuan)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblSatuanCari)
        Me.Controls.Add(Me.lblSatuanJudul)
        Me.Name = "formSatuan"
        Me.Text = "Form Satuan"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.satuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.satuanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSatuanJudul As Label
    Friend WithEvents lblSatuanCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNamaSatuan As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNamaSatuan As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents satuanDataSet As satuanDataSet
    Friend WithEvents satuanBindingSource As BindingSource
    Friend WithEvents satuanTableAdapter As satuanDataSetTableAdapters.satuanTableAdapter
    Friend WithEvents KodesatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamasatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
