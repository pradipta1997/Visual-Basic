<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMahasiswa
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
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.comboBoxMataKuliah = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.lblMataKuliah = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.lblDataMahasiswa = New System.Windows.Forms.Label()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.lblNilaiAkhir = New System.Windows.Forms.Label()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtFormatif = New System.Windows.Forms.TextBox()
        Me.lblUAS = New System.Windows.Forms.Label()
        Me.lblUTS = New System.Windows.Forms.Label()
        Me.lblTugas = New System.Windows.Forms.Label()
        Me.lblFormatif = New System.Windows.Forms.Label()
        Me.lblListNilai = New System.Windows.Forms.Label()
        Me.NilaiDataSet = New mahasiswa.nilaiDataSet()
        Me.NilaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NilaiTableAdapter = New mahasiswa.nilaiDataSetTableAdapters.nilaiTableAdapter()
        Me.NimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodematkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiformatifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaitugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiutsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiuasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatakuliahDataSet = New mahasiswa.matakuliahDataSet()
        Me.MatakuliahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatakuliahTableAdapter = New mahasiswa.matakuliahDataSetTableAdapters.matakuliahTableAdapter()
        Me.comboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaDataSet = New mahasiswa.mahasiswaDataSet()
        Me.MahasiswaTableAdapter = New mahasiswa.mahasiswaDataSetTableAdapters.mahasiswaTableAdapter()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatakuliahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatakuliahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer
        '
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.lblSemester)
        Me.splitContainer.Panel1.Controls.Add(Me.comboBoxSemester)
        Me.splitContainer.Panel1.Controls.Add(Me.btnSearch)
        Me.splitContainer.Panel1.Controls.Add(Me.comboBoxMataKuliah)
        Me.splitContainer.Panel1.Controls.Add(Me.txtNama)
        Me.splitContainer.Panel1.Controls.Add(Me.txtNim)
        Me.splitContainer.Panel1.Controls.Add(Me.lblMataKuliah)
        Me.splitContainer.Panel1.Controls.Add(Me.lblNama)
        Me.splitContainer.Panel1.Controls.Add(Me.lblNim)
        Me.splitContainer.Panel1.Controls.Add(Me.lblDataMahasiswa)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.lblListNilai)
        Me.splitContainer.Panel2.Controls.Add(Me.dataGridView)
        Me.splitContainer.Panel2.Controls.Add(Me.btnExit)
        Me.splitContainer.Panel2.Controls.Add(Me.btnDelete)
        Me.splitContainer.Panel2.Controls.Add(Me.btnCancel)
        Me.splitContainer.Panel2.Controls.Add(Me.btnSave)
        Me.splitContainer.Panel2.Controls.Add(Me.btnAdd)
        Me.splitContainer.Panel2.Controls.Add(Me.txtNilaiAkhir)
        Me.splitContainer.Panel2.Controls.Add(Me.lblNilaiAkhir)
        Me.splitContainer.Panel2.Controls.Add(Me.txtUAS)
        Me.splitContainer.Panel2.Controls.Add(Me.txtUTS)
        Me.splitContainer.Panel2.Controls.Add(Me.txtTugas)
        Me.splitContainer.Panel2.Controls.Add(Me.txtFormatif)
        Me.splitContainer.Panel2.Controls.Add(Me.lblUAS)
        Me.splitContainer.Panel2.Controls.Add(Me.lblUTS)
        Me.splitContainer.Panel2.Controls.Add(Me.lblTugas)
        Me.splitContainer.Panel2.Controls.Add(Me.lblFormatif)
        Me.splitContainer.Size = New System.Drawing.Size(607, 459)
        Me.splitContainer.SplitterDistance = 183
        Me.splitContainer.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(324, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'comboBoxMataKuliah
        '
        Me.comboBoxMataKuliah.DataSource = Me.MatakuliahBindingSource
        Me.comboBoxMataKuliah.DisplayMember = "nama_matkul"
        Me.comboBoxMataKuliah.Enabled = False
        Me.comboBoxMataKuliah.FormattingEnabled = True
        Me.comboBoxMataKuliah.Location = New System.Drawing.Point(150, 128)
        Me.comboBoxMataKuliah.Name = "comboBoxMataKuliah"
        Me.comboBoxMataKuliah.Size = New System.Drawing.Size(249, 21)
        Me.comboBoxMataKuliah.TabIndex = 6
        Me.comboBoxMataKuliah.ValueMember = "kode_matkul"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(150, 91)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(249, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(150, 59)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(167, 20)
        Me.txtNim.TabIndex = 4
        '
        'lblMataKuliah
        '
        Me.lblMataKuliah.AutoSize = True
        Me.lblMataKuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMataKuliah.Location = New System.Drawing.Point(53, 134)
        Me.lblMataKuliah.Name = "lblMataKuliah"
        Me.lblMataKuliah.Size = New System.Drawing.Size(84, 15)
        Me.lblMataKuliah.TabIndex = 3
        Me.lblMataKuliah.Text = "Mata Kuliah"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(53, 96)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(45, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNim.Location = New System.Drawing.Point(53, 63)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(33, 15)
        Me.lblNim.TabIndex = 1
        Me.lblNim.Text = "NIM"
        '
        'lblDataMahasiswa
        '
        Me.lblDataMahasiswa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataMahasiswa.Font = New System.Drawing.Font("Hobo Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataMahasiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDataMahasiswa.Location = New System.Drawing.Point(1, 0)
        Me.lblDataMahasiswa.Name = "lblDataMahasiswa"
        Me.lblDataMahasiswa.Size = New System.Drawing.Size(606, 29)
        Me.lblDataMahasiswa.TabIndex = 0
        Me.lblDataMahasiswa.Text = "Data Mahasiswa"
        Me.lblDataMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataGridView
        '
        Me.dataGridView.AutoGenerateColumns = False
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NimDataGridViewTextBoxColumn, Me.KodematkulDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.NilaiformatifDataGridViewTextBoxColumn, Me.NilaitugasDataGridViewTextBoxColumn, Me.NilaiutsDataGridViewTextBoxColumn, Me.NilaiuasDataGridViewTextBoxColumn})
        Me.dataGridView.DataSource = Me.NilaiBindingSource
        Me.dataGridView.Location = New System.Drawing.Point(0, 143)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(607, 128)
        Me.dataGridView.TabIndex = 23
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(517, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 23)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(234, 95)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(169, 95)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(98, 95)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(59, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 95)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(517, 70)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(64, 20)
        Me.txtNilaiAkhir.TabIndex = 17
        '
        'lblNilaiAkhir
        '
        Me.lblNilaiAkhir.AutoSize = True
        Me.lblNilaiAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilaiAkhir.Location = New System.Drawing.Point(435, 72)
        Me.lblNilaiAkhir.Name = "lblNilaiAkhir"
        Me.lblNilaiAkhir.Size = New System.Drawing.Size(73, 15)
        Me.lblNilaiAkhir.TabIndex = 16
        Me.lblNilaiAkhir.Text = "Nilai Akhir"
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(517, 26)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(64, 20)
        Me.txtUAS.TabIndex = 15
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(373, 25)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(64, 20)
        Me.txtUTS.TabIndex = 14
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(234, 24)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(64, 20)
        Me.txtTugas.TabIndex = 13
        '
        'txtFormatif
        '
        Me.txtFormatif.Location = New System.Drawing.Point(93, 23)
        Me.txtFormatif.Name = "txtFormatif"
        Me.txtFormatif.Size = New System.Drawing.Size(64, 20)
        Me.txtFormatif.TabIndex = 12
        '
        'lblUAS
        '
        Me.lblUAS.AutoSize = True
        Me.lblUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUAS.Location = New System.Drawing.Point(477, 28)
        Me.lblUAS.Name = "lblUAS"
        Me.lblUAS.Size = New System.Drawing.Size(34, 15)
        Me.lblUAS.TabIndex = 11
        Me.lblUAS.Text = "UAS"
        '
        'lblUTS
        '
        Me.lblUTS.AutoSize = True
        Me.lblUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUTS.Location = New System.Drawing.Point(333, 26)
        Me.lblUTS.Name = "lblUTS"
        Me.lblUTS.Size = New System.Drawing.Size(34, 15)
        Me.lblUTS.TabIndex = 10
        Me.lblUTS.Text = "UTS"
        '
        'lblTugas
        '
        Me.lblTugas.AutoSize = True
        Me.lblTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTugas.Location = New System.Drawing.Point(182, 24)
        Me.lblTugas.Name = "lblTugas"
        Me.lblTugas.Size = New System.Drawing.Size(46, 15)
        Me.lblTugas.TabIndex = 9
        Me.lblTugas.Text = "Tugas"
        '
        'lblFormatif
        '
        Me.lblFormatif.AutoSize = True
        Me.lblFormatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatif.Location = New System.Drawing.Point(27, 23)
        Me.lblFormatif.Name = "lblFormatif"
        Me.lblFormatif.Size = New System.Drawing.Size(60, 15)
        Me.lblFormatif.TabIndex = 8
        Me.lblFormatif.Text = "Formatif"
        '
        'lblListNilai
        '
        Me.lblListNilai.AutoSize = True
        Me.lblListNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListNilai.Location = New System.Drawing.Point(2, 125)
        Me.lblListNilai.Name = "lblListNilai"
        Me.lblListNilai.Size = New System.Drawing.Size(64, 15)
        Me.lblListNilai.TabIndex = 24
        Me.lblListNilai.Text = "List Nilai"
        '
        'NilaiDataSet
        '
        Me.NilaiDataSet.DataSetName = "nilaiDataSet"
        Me.NilaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NilaiBindingSource
        '
        Me.NilaiBindingSource.DataMember = "nilai"
        Me.NilaiBindingSource.DataSource = Me.NilaiDataSet
        '
        'NilaiTableAdapter
        '
        Me.NilaiTableAdapter.ClearBeforeFill = True
        '
        'NimDataGridViewTextBoxColumn
        '
        Me.NimDataGridViewTextBoxColumn.DataPropertyName = "nim"
        Me.NimDataGridViewTextBoxColumn.HeaderText = "nim"
        Me.NimDataGridViewTextBoxColumn.Name = "NimDataGridViewTextBoxColumn"
        '
        'KodematkulDataGridViewTextBoxColumn
        '
        Me.KodematkulDataGridViewTextBoxColumn.DataPropertyName = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.HeaderText = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.Name = "KodematkulDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'NilaiformatifDataGridViewTextBoxColumn
        '
        Me.NilaiformatifDataGridViewTextBoxColumn.DataPropertyName = "nilai_formatif"
        Me.NilaiformatifDataGridViewTextBoxColumn.HeaderText = "nilai_formatif"
        Me.NilaiformatifDataGridViewTextBoxColumn.Name = "NilaiformatifDataGridViewTextBoxColumn"
        '
        'NilaitugasDataGridViewTextBoxColumn
        '
        Me.NilaitugasDataGridViewTextBoxColumn.DataPropertyName = "nilai_tugas"
        Me.NilaitugasDataGridViewTextBoxColumn.HeaderText = "nilai_tugas"
        Me.NilaitugasDataGridViewTextBoxColumn.Name = "NilaitugasDataGridViewTextBoxColumn"
        '
        'NilaiutsDataGridViewTextBoxColumn
        '
        Me.NilaiutsDataGridViewTextBoxColumn.DataPropertyName = "nilai_uts"
        Me.NilaiutsDataGridViewTextBoxColumn.HeaderText = "nilai_uts"
        Me.NilaiutsDataGridViewTextBoxColumn.Name = "NilaiutsDataGridViewTextBoxColumn"
        '
        'NilaiuasDataGridViewTextBoxColumn
        '
        Me.NilaiuasDataGridViewTextBoxColumn.DataPropertyName = "nilai_uas"
        Me.NilaiuasDataGridViewTextBoxColumn.HeaderText = "nilai_uas"
        Me.NilaiuasDataGridViewTextBoxColumn.Name = "NilaiuasDataGridViewTextBoxColumn"
        '
        'MatakuliahDataSet
        '
        Me.MatakuliahDataSet.DataSetName = "matakuliahDataSet"
        Me.MatakuliahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatakuliahBindingSource
        '
        Me.MatakuliahBindingSource.DataMember = "matakuliah"
        Me.MatakuliahBindingSource.DataSource = Me.MatakuliahDataSet
        '
        'MatakuliahTableAdapter
        '
        Me.MatakuliahTableAdapter.ClearBeforeFill = True
        '
        'comboBoxSemester
        '
        Me.comboBoxSemester.FormattingEnabled = True
        Me.comboBoxSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.comboBoxSemester.Location = New System.Drawing.Point(455, 128)
        Me.comboBoxSemester.Name = "comboBoxSemester"
        Me.comboBoxSemester.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSemester.TabIndex = 8
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(453, 109)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(68, 15)
        Me.lblSemester.TabIndex = 9
        Me.lblSemester.Text = "Semester"
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.MahasiswaDataSet
        '
        'MahasiswaDataSet
        '
        Me.MahasiswaDataSet.DataSetName = "mahasiswaDataSet"
        Me.MahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'frmMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 459)
        Me.Controls.Add(Me.splitContainer)
        Me.Name = "frmMahasiswa"
        Me.Text = "Form Mahasiswa"
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel1.PerformLayout()
        Me.splitContainer.Panel2.ResumeLayout(False)
        Me.splitContainer.Panel2.PerformLayout()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatakuliahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatakuliahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents btnSearch As Button
    Friend WithEvents comboBoxMataKuliah As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblMataKuliah As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblDataMahasiswa As Label
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtFormatif As TextBox
    Friend WithEvents lblUAS As Label
    Friend WithEvents lblUTS As Label
    Friend WithEvents lblTugas As Label
    Friend WithEvents lblFormatif As Label
    Friend WithEvents lblListNilai As Label
    Friend WithEvents NilaiDataSet As nilaiDataSet
    Friend WithEvents NilaiBindingSource As BindingSource
    Friend WithEvents NilaiTableAdapter As nilaiDataSetTableAdapters.nilaiTableAdapter
    Friend WithEvents NimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodematkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiformatifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaitugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiutsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiuasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatakuliahDataSet As matakuliahDataSet
    Friend WithEvents MatakuliahBindingSource As BindingSource
    Friend WithEvents MatakuliahTableAdapter As matakuliahDataSetTableAdapters.matakuliahTableAdapter
    Friend WithEvents lblSemester As Label
    Friend WithEvents comboBoxSemester As ComboBox
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaDataSet As mahasiswaDataSet
    Friend WithEvents MahasiswaTableAdapter As mahasiswaDataSetTableAdapters.mahasiswaTableAdapter
End Class
