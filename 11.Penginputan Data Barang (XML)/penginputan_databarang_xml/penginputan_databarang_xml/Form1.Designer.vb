<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenginputanDataBarangXML
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
        Me.lblProductData = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductGroup = New System.Windows.Forms.Label()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtPrices = New System.Windows.Forms.TextBox()
        Me.comboBoxProductGroup = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.groupBoxControls = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        Me.groupBoxControls.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.splitContainer.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.splitContainer.Panel1.Controls.Add(Me.lblProductData)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.splitContainer.Panel2.Controls.Add(Me.dataGridView)
        Me.splitContainer.Panel2.Controls.Add(Me.groupBoxControls)
        Me.splitContainer.Panel2.Controls.Add(Me.btnSearch)
        Me.splitContainer.Panel2.Controls.Add(Me.comboBoxProductGroup)
        Me.splitContainer.Panel2.Controls.Add(Me.txtPrices)
        Me.splitContainer.Panel2.Controls.Add(Me.txtProductName)
        Me.splitContainer.Panel2.Controls.Add(Me.txtProductID)
        Me.splitContainer.Panel2.Controls.Add(Me.lblPrices)
        Me.splitContainer.Panel2.Controls.Add(Me.lblProductGroup)
        Me.splitContainer.Panel2.Controls.Add(Me.lblProductName)
        Me.splitContainer.Panel2.Controls.Add(Me.lblProductID)
        Me.splitContainer.Size = New System.Drawing.Size(459, 435)
        Me.splitContainer.SplitterDistance = 44
        Me.splitContainer.TabIndex = 0
        '
        'lblProductData
        '
        Me.lblProductData.AutoSize = True
        Me.lblProductData.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductData.Location = New System.Drawing.Point(162, 10)
        Me.lblProductData.Name = "lblProductData"
        Me.lblProductData.Size = New System.Drawing.Size(134, 32)
        Me.lblProductData.TabIndex = 0
        Me.lblProductData.Text = "Product Data"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(34, 37)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(60, 17)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(34, 81)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(76, 17)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Product Name"
        '
        'lblProductGroup
        '
        Me.lblProductGroup.AutoSize = True
        Me.lblProductGroup.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGroup.Location = New System.Drawing.Point(34, 125)
        Me.lblProductGroup.Name = "lblProductGroup"
        Me.lblProductGroup.Size = New System.Drawing.Size(81, 17)
        Me.lblProductGroup.TabIndex = 2
        Me.lblProductGroup.Text = "Product Group"
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrices.Location = New System.Drawing.Point(34, 170)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(40, 17)
        Me.lblPrices.TabIndex = 3
        Me.lblPrices.Text = "Prices"
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Bebas Neue", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(136, 33)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(140, 22)
        Me.txtProductID.TabIndex = 4
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Bebas Neue", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(136, 76)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(220, 22)
        Me.txtProductName.TabIndex = 5
        '
        'txtPrices
        '
        Me.txtPrices.Font = New System.Drawing.Font("Bebas Neue", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrices.Location = New System.Drawing.Point(136, 165)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.Size = New System.Drawing.Size(140, 22)
        Me.txtPrices.TabIndex = 6
        '
        'comboBoxProductGroup
        '
        Me.comboBoxProductGroup.Font = New System.Drawing.Font("Bebas Neue", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxProductGroup.FormattingEnabled = True
        Me.comboBoxProductGroup.Location = New System.Drawing.Point(136, 121)
        Me.comboBoxProductGroup.Name = "comboBoxProductGroup"
        Me.comboBoxProductGroup.Size = New System.Drawing.Size(220, 23)
        Me.comboBoxProductGroup.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(282, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'groupBoxControls
        '
        Me.groupBoxControls.Controls.Add(Me.btnExit)
        Me.groupBoxControls.Controls.Add(Me.btnNext)
        Me.groupBoxControls.Controls.Add(Me.btnBack)
        Me.groupBoxControls.Controls.Add(Me.btnDelete)
        Me.groupBoxControls.Controls.Add(Me.btnCancel)
        Me.groupBoxControls.Controls.Add(Me.btnSave)
        Me.groupBoxControls.Controls.Add(Me.btnAdd)
        Me.groupBoxControls.Location = New System.Drawing.Point(37, 204)
        Me.groupBoxControls.Name = "groupBoxControls"
        Me.groupBoxControls.Size = New System.Drawing.Size(401, 51)
        Me.groupBoxControls.TabIndex = 9
        Me.groupBoxControls.TabStop = False
        Me.groupBoxControls.Text = "Controls"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(62, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(118, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(174, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(248, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(37, 23)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "<<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(285, 18)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(37, 23)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataGridView.Location = New System.Drawing.Point(0, 261)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(459, 126)
        Me.dataGridView.TabIndex = 10
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'frmPenginputanDataBarangXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 435)
        Me.Controls.Add(Me.splitContainer)
        Me.Name = "frmPenginputanDataBarangXML"
        Me.Text = "Form Penginputan Data Barang (XML)"
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel1.PerformLayout()
        Me.splitContainer.Panel2.ResumeLayout(False)
        Me.splitContainer.Panel2.PerformLayout()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        Me.groupBoxControls.ResumeLayout(False)
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents lblProductData As Label
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents groupBoxControls As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents comboBoxProductGroup As ComboBox
    Friend WithEvents txtPrices As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblPrices As Label
    Friend WithEvents lblProductGroup As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents errorProvider As ErrorProvider
End Class
