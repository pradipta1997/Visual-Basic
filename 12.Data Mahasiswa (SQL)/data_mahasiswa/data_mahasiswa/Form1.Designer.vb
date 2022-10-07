<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataMahasiswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataMahasiswa))
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.nilaiMhsDataSet = New data_mahasiswa.NilaiMhsDataSet()
        Me.reportMhsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportMhsTableAdapter = New data_mahasiswa.NilaiMhsDataSetTableAdapters.reportMhsTableAdapter()
        Me.KodematkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamatkulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BobotformatifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BobottugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BobotutsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BobotuasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDataMataKuliahMahasiswa = New System.Windows.Forms.Label()
        Me.bindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiMhsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportMhsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridView
        '
        Me.dataGridView.AllowUserToOrderColumns = True
        Me.dataGridView.AutoGenerateColumns = False
        Me.dataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodematkulDataGridViewTextBoxColumn, Me.NamamatkulDataGridViewTextBoxColumn, Me.BobotformatifDataGridViewTextBoxColumn, Me.BobottugasDataGridViewTextBoxColumn, Me.BobotutsDataGridViewTextBoxColumn, Me.BobotuasDataGridViewTextBoxColumn})
        Me.dataGridView.DataSource = Me.reportMhsBindingSource
        Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView.GridColor = System.Drawing.Color.SpringGreen
        Me.dataGridView.Location = New System.Drawing.Point(0, 51)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(642, 261)
        Me.dataGridView.TabIndex = 0
        '
        'nilaiMhsDataSet
        '
        Me.nilaiMhsDataSet.DataSetName = "NilaiMhsDataSet"
        Me.nilaiMhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportMhsBindingSource
        '
        Me.reportMhsBindingSource.DataMember = "reportMhs"
        Me.reportMhsBindingSource.DataSource = Me.nilaiMhsDataSet
        '
        'reportMhsTableAdapter
        '
        Me.reportMhsTableAdapter.ClearBeforeFill = True
        '
        'KodematkulDataGridViewTextBoxColumn
        '
        Me.KodematkulDataGridViewTextBoxColumn.DataPropertyName = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.HeaderText = "kode_matkul"
        Me.KodematkulDataGridViewTextBoxColumn.Name = "KodematkulDataGridViewTextBoxColumn"
        '
        'NamamatkulDataGridViewTextBoxColumn
        '
        Me.NamamatkulDataGridViewTextBoxColumn.DataPropertyName = "nama_matkul"
        Me.NamamatkulDataGridViewTextBoxColumn.HeaderText = "nama_matkul"
        Me.NamamatkulDataGridViewTextBoxColumn.Name = "NamamatkulDataGridViewTextBoxColumn"
        '
        'BobotformatifDataGridViewTextBoxColumn
        '
        Me.BobotformatifDataGridViewTextBoxColumn.DataPropertyName = "bobot_formatif"
        Me.BobotformatifDataGridViewTextBoxColumn.HeaderText = "bobot_formatif"
        Me.BobotformatifDataGridViewTextBoxColumn.Name = "BobotformatifDataGridViewTextBoxColumn"
        '
        'BobottugasDataGridViewTextBoxColumn
        '
        Me.BobottugasDataGridViewTextBoxColumn.DataPropertyName = "bobot_tugas"
        Me.BobottugasDataGridViewTextBoxColumn.HeaderText = "bobot_tugas"
        Me.BobottugasDataGridViewTextBoxColumn.Name = "BobottugasDataGridViewTextBoxColumn"
        '
        'BobotutsDataGridViewTextBoxColumn
        '
        Me.BobotutsDataGridViewTextBoxColumn.DataPropertyName = "bobot_uts"
        Me.BobotutsDataGridViewTextBoxColumn.HeaderText = "bobot_uts"
        Me.BobotutsDataGridViewTextBoxColumn.Name = "BobotutsDataGridViewTextBoxColumn"
        '
        'BobotuasDataGridViewTextBoxColumn
        '
        Me.BobotuasDataGridViewTextBoxColumn.DataPropertyName = "bobot_uas"
        Me.BobotuasDataGridViewTextBoxColumn.HeaderText = "bobot_uas"
        Me.BobotuasDataGridViewTextBoxColumn.Name = "BobotuasDataGridViewTextBoxColumn"
        '
        'lblDataMataKuliahMahasiswa
        '
        Me.lblDataMataKuliahMahasiswa.AutoSize = True
        Me.lblDataMataKuliahMahasiswa.BackColor = System.Drawing.Color.SkyBlue
        Me.lblDataMataKuliahMahasiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDataMataKuliahMahasiswa.Font = New System.Drawing.Font("Cooper Std Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataMataKuliahMahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.lblDataMataKuliahMahasiswa.Name = "lblDataMataKuliahMahasiswa"
        Me.lblDataMataKuliahMahasiswa.Size = New System.Drawing.Size(306, 23)
        Me.lblDataMataKuliahMahasiswa.TabIndex = 1
        Me.lblDataMataKuliahMahasiswa.Text = "Data Mata Kuliah Mahasiswa"
        '
        'bindingNavigator
        '
        Me.bindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bindingNavigator.BindingSource = Me.reportMhsBindingSource
        Me.bindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.bindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripTextBox1})
        Me.bindingNavigator.Location = New System.Drawing.Point(0, 23)
        Me.bindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNavigator.Name = "bindingNavigator"
        Me.bindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNavigator.Size = New System.Drawing.Size(642, 25)
        Me.bindingNavigator.TabIndex = 2
        Me.bindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'frmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 312)
        Me.Controls.Add(Me.bindingNavigator)
        Me.Controls.Add(Me.lblDataMataKuliahMahasiswa)
        Me.Controls.Add(Me.dataGridView)
        Me.Name = "frmDataMahasiswa"
        Me.Text = "Form Data Mahasiswa"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiMhsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportMhsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNavigator.ResumeLayout(False)
        Me.bindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents nilaiMhsDataSet As NilaiMhsDataSet
    Friend WithEvents reportMhsBindingSource As BindingSource
    Friend WithEvents reportMhsTableAdapter As NilaiMhsDataSetTableAdapters.reportMhsTableAdapter
    Friend WithEvents KodematkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamamatkulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BobotformatifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BobottugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BobotutsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BobotuasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblDataMataKuliahMahasiswa As Label
    Friend WithEvents bindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
