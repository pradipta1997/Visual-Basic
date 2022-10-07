<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenginputanDataBarang
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
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.comboBoxProductGroup = New System.Windows.Forms.ComboBox()
        Me.txtPrices = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.lblProductGroup = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SplitContainer.Panel1.Controls.Add(Me.lblProduct)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.btnDelete)
        Me.SplitContainer.Panel2.Controls.Add(Me.dataGridView)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnExit)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnNext)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnBack)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnAdd)
        Me.SplitContainer.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer.Panel2.Controls.Add(Me.comboBoxProductGroup)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtPrices)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtProductName)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtProductID)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblPrices)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblProductGroup)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblProductName)
        Me.SplitContainer.Panel2.Controls.Add(Me.lblProductID)
        Me.SplitContainer.Size = New System.Drawing.Size(469, 420)
        Me.SplitContainer.SplitterDistance = 34
        Me.SplitContainer.TabIndex = 0
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProduct.Font = New System.Drawing.Font("Anja Eliane", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProduct.Location = New System.Drawing.Point(188, 9)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(91, 23)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "Product"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(212, 205)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(0, 234)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(469, 148)
        Me.dataGridView.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(397, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(334, 205)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(37, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(295, 205)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(37, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "<<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(152, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(92, 205)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(32, 205)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(310, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'comboBoxProductGroup
        '
        Me.comboBoxProductGroup.Font = New System.Drawing.Font("Anja Eliane", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxProductGroup.FormattingEnabled = True
        Me.comboBoxProductGroup.Location = New System.Drawing.Point(163, 114)
        Me.comboBoxProductGroup.Name = "comboBoxProductGroup"
        Me.comboBoxProductGroup.Size = New System.Drawing.Size(238, 21)
        Me.comboBoxProductGroup.TabIndex = 7
        '
        'txtPrices
        '
        Me.txtPrices.Font = New System.Drawing.Font("Anja Eliane", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrices.Location = New System.Drawing.Point(163, 153)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.Size = New System.Drawing.Size(141, 21)
        Me.txtPrices.TabIndex = 6
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Anja Eliane", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(163, 76)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(238, 21)
        Me.txtProductName.TabIndex = 5
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Anja Eliane", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(163, 39)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(141, 21)
        Me.txtProductID.TabIndex = 4
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Font = New System.Drawing.Font("Anja Eliane", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrices.Location = New System.Drawing.Point(44, 159)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(46, 14)
        Me.lblPrices.TabIndex = 3
        Me.lblPrices.Text = "Prices"
        '
        'lblProductGroup
        '
        Me.lblProductGroup.AutoSize = True
        Me.lblProductGroup.Font = New System.Drawing.Font("Anja Eliane", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGroup.Location = New System.Drawing.Point(44, 121)
        Me.lblProductGroup.Name = "lblProductGroup"
        Me.lblProductGroup.Size = New System.Drawing.Size(99, 14)
        Me.lblProductGroup.TabIndex = 2
        Me.lblProductGroup.Text = "Product Group"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Anja Eliane", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(44, 80)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(98, 14)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Product Name"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Anja Eliane", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(44, 41)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(74, 14)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'frmPenginputanDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 420)
        Me.Controls.Add(Me.SplitContainer)
        Me.Name = "frmPenginputanDataBarang"
        Me.Text = "Form Penginputan Data Barang (Array)"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents lblProduct As Label
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
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
    Friend WithEvents btnDelete As Button
End Class
