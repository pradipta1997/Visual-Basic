<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputNilaiMahasiswa
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
        Me.comboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.comboBoxMataKuliah = New System.Windows.Forms.ComboBox()
        Me.mataKuliahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mataKuliahDataSet = New input_nilai_mahasiswa.mataKuliahDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.lblMataKuliah = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblNilaiMahasiswa = New System.Windows.Forms.Label()
        Me.lblListNilai = New System.Windows.Forms.Label()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.NIMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeMatkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiFormatifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiTugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiUTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaiUASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaimahasiswa2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nilaiMhsDataSet = New input_nilai_mahasiswa.NilaiMhsDataSet()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtFormatif = New System.Windows.Forms.TextBox()
        Me.lblUAS = New System.Windows.Forms.Label()
        Me.lblUTS = New System.Windows.Forms.Label()
        Me.lblTugas = New System.Windows.Forms.Label()
        Me.lblFormatif = New System.Windows.Forms.Label()
        Me.lblNilaiPerMataKuliah = New System.Windows.Forms.Label()
        Me.nilaimahasiswa2TableAdapter = New input_nilai_mahasiswa.NilaiMhsDataSetTableAdapters.nilaimahasiswa2TableAdapter()
        Me.mataKuliahTableAdapter = New input_nilai_mahasiswa.mataKuliahDataSetTableAdapters.reportMhsTableAdapter()
        Me.mahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mahasiswaDataSet = New input_nilai_mahasiswa.mahasiswaDataSet()
        Me.mahasiswaTableAdapter = New input_nilai_mahasiswa.mahasiswaDataSetTableAdapters.mahasiswaTableAdapter()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.mataKuliahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mataKuliahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaimahasiswa2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiMhsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mahasiswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.splitContainer.Panel1.Controls.Add(Me.comboBoxSemester)
        Me.splitContainer.Panel1.Controls.Add(Me.lblSemester)
        Me.splitContainer.Panel1.Controls.Add(Me.comboBoxMataKuliah)
        Me.splitContainer.Panel1.Controls.Add(Me.btnSearch)
        Me.splitContainer.Panel1.Controls.Add(Me.txtNama)
        Me.splitContainer.Panel1.Controls.Add(Me.txtNIM)
        Me.splitContainer.Panel1.Controls.Add(Me.lblMataKuliah)
        Me.splitContainer.Panel1.Controls.Add(Me.lblNama)
        Me.splitContainer.Panel1.Controls.Add(Me.lblNIM)
        Me.splitContainer.Panel1.Controls.Add(Me.lblNilaiMahasiswa)
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
        Me.splitContainer.Panel2.Controls.Add(Me.Label1)
        Me.splitContainer.Panel2.Controls.Add(Me.txtUAS)
        Me.splitContainer.Panel2.Controls.Add(Me.txtUTS)
        Me.splitContainer.Panel2.Controls.Add(Me.txtTugas)
        Me.splitContainer.Panel2.Controls.Add(Me.txtFormatif)
        Me.splitContainer.Panel2.Controls.Add(Me.lblUAS)
        Me.splitContainer.Panel2.Controls.Add(Me.lblUTS)
        Me.splitContainer.Panel2.Controls.Add(Me.lblTugas)
        Me.splitContainer.Panel2.Controls.Add(Me.lblFormatif)
        Me.splitContainer.Panel2.Controls.Add(Me.lblNilaiPerMataKuliah)
        Me.splitContainer.Size = New System.Drawing.Size(546, 443)
        Me.splitContainer.SplitterDistance = 176
        Me.splitContainer.TabIndex = 0
        '
        'comboBoxSemester
        '
        Me.comboBoxSemester.FormattingEnabled = True
        Me.comboBoxSemester.Location = New System.Drawing.Point(425, 125)
        Me.comboBoxSemester.Name = "comboBoxSemester"
        Me.comboBoxSemester.Size = New System.Drawing.Size(106, 21)
        Me.comboBoxSemester.TabIndex = 11
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(444, 106)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(68, 15)
        Me.lblSemester.TabIndex = 10
        Me.lblSemester.Text = "Semester"
        '
        'comboBoxMataKuliah
        '
        Me.comboBoxMataKuliah.DataSource = Me.mataKuliahBindingSource
        Me.comboBoxMataKuliah.DisplayMember = "nama_matkul"
        Me.comboBoxMataKuliah.Enabled = False
        Me.comboBoxMataKuliah.FormattingEnabled = True
        Me.comboBoxMataKuliah.Location = New System.Drawing.Point(155, 124)
        Me.comboBoxMataKuliah.Name = "comboBoxMataKuliah"
        Me.comboBoxMataKuliah.Size = New System.Drawing.Size(251, 21)
        Me.comboBoxMataKuliah.TabIndex = 8
        Me.comboBoxMataKuliah.ValueMember = "kode_matkul"
        '
        'mataKuliahBindingSource
        '
        Me.mataKuliahBindingSource.DataMember = "reportMhs"
        Me.mataKuliahBindingSource.DataSource = Me.mataKuliahDataSet
        '
        'mataKuliahDataSet
        '
        Me.mataKuliahDataSet.DataSetName = "mataKuliahDataSet"
        Me.mataKuliahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(310, 59)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(155, 92)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(251, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtNIM
        '
        Me.txtNIM.Enabled = False
        Me.txtNIM.Location = New System.Drawing.Point(155, 59)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(149, 20)
        Me.txtNIM.TabIndex = 4
        '
        'lblMataKuliah
        '
        Me.lblMataKuliah.AutoSize = True
        Me.lblMataKuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMataKuliah.Location = New System.Drawing.Point(42, 125)
        Me.lblMataKuliah.Name = "lblMataKuliah"
        Me.lblMataKuliah.Size = New System.Drawing.Size(84, 15)
        Me.lblMataKuliah.TabIndex = 3
        Me.lblMataKuliah.Text = "Mata Kuliah"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(42, 92)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(45, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIM.Location = New System.Drawing.Point(42, 63)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(33, 15)
        Me.lblNIM.TabIndex = 1
        Me.lblNIM.Text = "NIM"
        '
        'lblNilaiMahasiswa
        '
        Me.lblNilaiMahasiswa.BackColor = System.Drawing.Color.Black
        Me.lblNilaiMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilaiMahasiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNilaiMahasiswa.Location = New System.Drawing.Point(1, 0)
        Me.lblNilaiMahasiswa.Name = "lblNilaiMahasiswa"
        Me.lblNilaiMahasiswa.Size = New System.Drawing.Size(545, 31)
        Me.lblNilaiMahasiswa.TabIndex = 0
        Me.lblNilaiMahasiswa.Text = "Nilai Mahasiswa"
        Me.lblNilaiMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblListNilai
        '
        Me.lblListNilai.AutoSize = True
        Me.lblListNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListNilai.Location = New System.Drawing.Point(12, 130)
        Me.lblListNilai.Name = "lblListNilai"
        Me.lblListNilai.Size = New System.Drawing.Size(70, 13)
        Me.lblListNilai.TabIndex = 24
        Me.lblListNilai.Text = "LIST NILAI"
        '
        'dataGridView
        '
        Me.dataGridView.AutoGenerateColumns = False
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIMDataGridViewTextBoxColumn, Me.KodeMatkulDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.NilaiFormatifDataGridViewTextBoxColumn, Me.NilaiTugasDataGridViewTextBoxColumn, Me.NilaiUTSDataGridViewTextBoxColumn, Me.NilaiUASDataGridViewTextBoxColumn})
        Me.dataGridView.DataSource = Me.nilaimahasiswa2BindingSource
        Me.dataGridView.Location = New System.Drawing.Point(0, 145)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(546, 118)
        Me.dataGridView.TabIndex = 23
        '
        'NIMDataGridViewTextBoxColumn
        '
        Me.NIMDataGridViewTextBoxColumn.DataPropertyName = "NIM"
        Me.NIMDataGridViewTextBoxColumn.HeaderText = "NIM"
        Me.NIMDataGridViewTextBoxColumn.Name = "NIMDataGridViewTextBoxColumn"
        '
        'KodeMatkulDataGridViewTextBoxColumn
        '
        Me.KodeMatkulDataGridViewTextBoxColumn.DataPropertyName = "Kode_Matkul"
        Me.KodeMatkulDataGridViewTextBoxColumn.HeaderText = "Kode_Matkul"
        Me.KodeMatkulDataGridViewTextBoxColumn.Name = "KodeMatkulDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'NilaiFormatifDataGridViewTextBoxColumn
        '
        Me.NilaiFormatifDataGridViewTextBoxColumn.DataPropertyName = "Nilai_Formatif"
        Me.NilaiFormatifDataGridViewTextBoxColumn.HeaderText = "Nilai_Formatif"
        Me.NilaiFormatifDataGridViewTextBoxColumn.Name = "NilaiFormatifDataGridViewTextBoxColumn"
        '
        'NilaiTugasDataGridViewTextBoxColumn
        '
        Me.NilaiTugasDataGridViewTextBoxColumn.DataPropertyName = "Nilai_Tugas"
        Me.NilaiTugasDataGridViewTextBoxColumn.HeaderText = "Nilai_Tugas"
        Me.NilaiTugasDataGridViewTextBoxColumn.Name = "NilaiTugasDataGridViewTextBoxColumn"
        '
        'NilaiUTSDataGridViewTextBoxColumn
        '
        Me.NilaiUTSDataGridViewTextBoxColumn.DataPropertyName = "Nilai_UTS"
        Me.NilaiUTSDataGridViewTextBoxColumn.HeaderText = "Nilai_UTS"
        Me.NilaiUTSDataGridViewTextBoxColumn.Name = "NilaiUTSDataGridViewTextBoxColumn"
        '
        'NilaiUASDataGridViewTextBoxColumn
        '
        Me.NilaiUASDataGridViewTextBoxColumn.DataPropertyName = "Nilai_UAS"
        Me.NilaiUASDataGridViewTextBoxColumn.HeaderText = "Nilai_UAS"
        Me.NilaiUASDataGridViewTextBoxColumn.Name = "NilaiUASDataGridViewTextBoxColumn"
        '
        'nilaimahasiswa2BindingSource
        '
        Me.nilaimahasiswa2BindingSource.DataMember = "nilaimahasiswa2"
        Me.nilaimahasiswa2BindingSource.DataSource = Me.nilaiMhsDataSet
        '
        'nilaiMhsDataSet
        '
        Me.nilaiMhsDataSet.DataSetName = "NilaiMhsDataSet"
        Me.nilaiMhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(477, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(54, 23)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(401, 116)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(54, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(281, 116)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(54, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(341, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(54, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(221, 116)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAdd.Size = New System.Drawing.Size(54, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(457, 83)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(74, 20)
        Me.txtNilaiAkhir.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nilai Akhir"
        '
        'txtUAS
        '
        Me.txtUAS.Enabled = False
        Me.txtUAS.Location = New System.Drawing.Point(457, 48)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(74, 20)
        Me.txtUAS.TabIndex = 15
        '
        'txtUTS
        '
        Me.txtUTS.Enabled = False
        Me.txtUTS.Location = New System.Drawing.Point(326, 48)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(74, 20)
        Me.txtUTS.TabIndex = 14
        '
        'txtTugas
        '
        Me.txtTugas.Enabled = False
        Me.txtTugas.Location = New System.Drawing.Point(197, 49)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(74, 20)
        Me.txtTugas.TabIndex = 13
        '
        'txtFormatif
        '
        Me.txtFormatif.Enabled = False
        Me.txtFormatif.Location = New System.Drawing.Point(65, 49)
        Me.txtFormatif.Name = "txtFormatif"
        Me.txtFormatif.Size = New System.Drawing.Size(74, 20)
        Me.txtFormatif.TabIndex = 12
        '
        'lblUAS
        '
        Me.lblUAS.AutoSize = True
        Me.lblUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUAS.Location = New System.Drawing.Point(422, 52)
        Me.lblUAS.Name = "lblUAS"
        Me.lblUAS.Size = New System.Drawing.Size(32, 13)
        Me.lblUAS.TabIndex = 11
        Me.lblUAS.Text = "UAS"
        '
        'lblUTS
        '
        Me.lblUTS.AutoSize = True
        Me.lblUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUTS.Location = New System.Drawing.Point(291, 52)
        Me.lblUTS.Name = "lblUTS"
        Me.lblUTS.Size = New System.Drawing.Size(32, 13)
        Me.lblUTS.TabIndex = 10
        Me.lblUTS.Text = "UTS"
        '
        'lblTugas
        '
        Me.lblTugas.AutoSize = True
        Me.lblTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTugas.Location = New System.Drawing.Point(152, 52)
        Me.lblTugas.Name = "lblTugas"
        Me.lblTugas.Size = New System.Drawing.Size(42, 13)
        Me.lblTugas.TabIndex = 9
        Me.lblTugas.Text = "Tugas"
        '
        'lblFormatif
        '
        Me.lblFormatif.AutoSize = True
        Me.lblFormatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatif.Location = New System.Drawing.Point(12, 52)
        Me.lblFormatif.Name = "lblFormatif"
        Me.lblFormatif.Size = New System.Drawing.Size(52, 13)
        Me.lblFormatif.TabIndex = 8
        Me.lblFormatif.Text = "Formatif"
        '
        'lblNilaiPerMataKuliah
        '
        Me.lblNilaiPerMataKuliah.BackColor = System.Drawing.Color.Black
        Me.lblNilaiPerMataKuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilaiPerMataKuliah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNilaiPerMataKuliah.Location = New System.Drawing.Point(1, 0)
        Me.lblNilaiPerMataKuliah.Name = "lblNilaiPerMataKuliah"
        Me.lblNilaiPerMataKuliah.Size = New System.Drawing.Size(545, 31)
        Me.lblNilaiPerMataKuliah.TabIndex = 8
        Me.lblNilaiPerMataKuliah.Text = "Nilai Per Mata Kuliah"
        Me.lblNilaiPerMataKuliah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nilaimahasiswa2TableAdapter
        '
        Me.nilaimahasiswa2TableAdapter.ClearBeforeFill = True
        '
        'mataKuliahTableAdapter
        '
        Me.mataKuliahTableAdapter.ClearBeforeFill = True
        '
        'mahasiswaBindingSource
        '
        Me.mahasiswaBindingSource.DataMember = "mahasiswa"
        Me.mahasiswaBindingSource.DataSource = Me.mahasiswaDataSet
        '
        'mahasiswaDataSet
        '
        Me.mahasiswaDataSet.DataSetName = "mahasiswaDataSet"
        Me.mahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mahasiswaTableAdapter
        '
        Me.mahasiswaTableAdapter.ClearBeforeFill = True
        '
        'frmInputNilaiMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 443)
        Me.Controls.Add(Me.splitContainer)
        Me.Name = "frmInputNilaiMahasiswa"
        Me.Text = "Form Input Nilai Mahasiswa"
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel1.PerformLayout()
        Me.splitContainer.Panel2.ResumeLayout(False)
        Me.splitContainer.Panel2.PerformLayout()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.mataKuliahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mataKuliahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaimahasiswa2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiMhsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mahasiswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents comboBoxMataKuliah As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblMataKuliah As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblNilaiMahasiswa As Label
    Friend WithEvents lblListNilai As Label
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtFormatif As TextBox
    Friend WithEvents lblUAS As Label
    Friend WithEvents lblUTS As Label
    Friend WithEvents lblTugas As Label
    Friend WithEvents lblFormatif As Label
    Friend WithEvents lblNilaiPerMataKuliah As Label
    Friend WithEvents nilaiMhsDataSet As NilaiMhsDataSet
    Friend WithEvents nilaimahasiswa2BindingSource As BindingSource
    Friend WithEvents nilaimahasiswa2TableAdapter As NilaiMhsDataSetTableAdapters.nilaimahasiswa2TableAdapter
    Friend WithEvents NIMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodeMatkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiFormatifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiTugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiUTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaiUASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mataKuliahDataSet As mataKuliahDataSet
    Friend WithEvents mataKuliahBindingSource As BindingSource
    Friend WithEvents mataKuliahTableAdapter As mataKuliahDataSetTableAdapters.reportMhsTableAdapter
    Friend WithEvents comboBoxSemester As ComboBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents mahasiswaBindingSource As BindingSource
    Friend WithEvents mahasiswaDataSet As mahasiswaDataSet
    Friend WithEvents mahasiswaTableAdapter As mahasiswaDataSetTableAdapters.mahasiswaTableAdapter
End Class
