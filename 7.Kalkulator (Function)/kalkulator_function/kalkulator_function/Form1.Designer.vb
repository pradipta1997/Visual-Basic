<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKalkulatorFunction
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
        Me.lblNilai1 = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblNilai2 = New System.Windows.Forms.Label()
        Me.textBoxNilai1 = New System.Windows.Forms.TextBox()
        Me.textBoxNilai2 = New System.Windows.Forms.TextBox()
        Me.comboBoxOperator = New System.Windows.Forms.ComboBox()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.textBoxHasil = New System.Windows.Forms.TextBox()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNilai1
        '
        Me.lblNilai1.AutoSize = True
        Me.lblNilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilai1.Location = New System.Drawing.Point(43, 37)
        Me.lblNilai1.Name = "lblNilai1"
        Me.lblNilai1.Size = New System.Drawing.Size(49, 15)
        Me.lblNilai1.TabIndex = 0
        Me.lblNilai1.Text = "Nilai 1"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(135, 37)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(63, 15)
        Me.lblOperator.TabIndex = 1
        Me.lblOperator.Text = "Operator"
        '
        'lblNilai2
        '
        Me.lblNilai2.AutoSize = True
        Me.lblNilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilai2.Location = New System.Drawing.Point(244, 37)
        Me.lblNilai2.Name = "lblNilai2"
        Me.lblNilai2.Size = New System.Drawing.Size(49, 15)
        Me.lblNilai2.TabIndex = 2
        Me.lblNilai2.Text = "Nilai 2"
        '
        'textBoxNilai1
        '
        Me.textBoxNilai1.Location = New System.Drawing.Point(35, 68)
        Me.textBoxNilai1.Name = "textBoxNilai1"
        Me.textBoxNilai1.Size = New System.Drawing.Size(61, 20)
        Me.textBoxNilai1.TabIndex = 3
        '
        'textBoxNilai2
        '
        Me.textBoxNilai2.Location = New System.Drawing.Point(236, 68)
        Me.textBoxNilai2.Name = "textBoxNilai2"
        Me.textBoxNilai2.Size = New System.Drawing.Size(61, 20)
        Me.textBoxNilai2.TabIndex = 4
        '
        'comboBoxOperator
        '
        Me.comboBoxOperator.FormattingEnabled = True
        Me.comboBoxOperator.Items.AddRange(New Object() {"+", "-", "*", "/", "^", "MOD"})
        Me.comboBoxOperator.Location = New System.Drawing.Point(124, 67)
        Me.comboBoxOperator.Name = "comboBoxOperator"
        Me.comboBoxOperator.Size = New System.Drawing.Size(87, 21)
        Me.comboBoxOperator.TabIndex = 5
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasil.Location = New System.Drawing.Point(43, 130)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(40, 15)
        Me.lblHasil.TabIndex = 6
        Me.lblHasil.Text = "Hasil"
        '
        'textBoxHasil
        '
        Me.textBoxHasil.Location = New System.Drawing.Point(89, 129)
        Me.textBoxHasil.Name = "textBoxHasil"
        Me.textBoxHasil.Size = New System.Drawing.Size(122, 20)
        Me.textBoxHasil.TabIndex = 7
        '
        'btnHasil
        '
        Me.btnHasil.Location = New System.Drawing.Point(222, 116)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Size = New System.Drawing.Size(75, 44)
        Me.btnHasil.TabIndex = 8
        Me.btnHasil.Text = "Hasil"
        Me.btnHasil.UseVisualStyleBackColor = True
        '
        'frmKalkulatorFunction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 193)
        Me.Controls.Add(Me.btnHasil)
        Me.Controls.Add(Me.textBoxHasil)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.comboBoxOperator)
        Me.Controls.Add(Me.textBoxNilai2)
        Me.Controls.Add(Me.textBoxNilai1)
        Me.Controls.Add(Me.lblNilai2)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.lblNilai1)
        Me.Name = "frmKalkulatorFunction"
        Me.Text = "Form Kalkulator Function"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNilai1 As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblNilai2 As Label
    Friend WithEvents textBoxNilai1 As TextBox
    Friend WithEvents textBoxNilai2 As TextBox
    Friend WithEvents comboBoxOperator As ComboBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents textBoxHasil As TextBox
    Friend WithEvents btnHasil As Button
End Class
