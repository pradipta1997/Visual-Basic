<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokumenWord
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
        Me.richTextBox = New System.Windows.Forms.RichTextBox()
        Me.groupBoxFont = New System.Windows.Forms.GroupBox()
        Me.btnFontColor = New System.Windows.Forms.Button()
        Me.checkBoxUnderline = New System.Windows.Forms.CheckBox()
        Me.comboBoxSize = New System.Windows.Forms.ComboBox()
        Me.checkBoxItalic = New System.Windows.Forms.CheckBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.checkBoxBold = New System.Windows.Forms.CheckBox()
        Me.comboBoxFont = New System.Windows.Forms.ComboBox()
        Me.groupBoxMargin = New System.Windows.Forms.GroupBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnJustify = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.groupBoxFile = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpenDocument = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.groupBoxFont.SuspendLayout()
        Me.groupBoxMargin.SuspendLayout()
        Me.groupBoxFile.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'richTextBox
        '
        Me.richTextBox.Location = New System.Drawing.Point(0, 108)
        Me.richTextBox.Name = "richTextBox"
        Me.richTextBox.Size = New System.Drawing.Size(734, 302)
        Me.richTextBox.TabIndex = 0
        Me.richTextBox.Text = ""
        '
        'groupBoxFont
        '
        Me.groupBoxFont.Controls.Add(Me.btnFontColor)
        Me.groupBoxFont.Controls.Add(Me.checkBoxUnderline)
        Me.groupBoxFont.Controls.Add(Me.comboBoxSize)
        Me.groupBoxFont.Controls.Add(Me.checkBoxItalic)
        Me.groupBoxFont.Controls.Add(Me.lblSize)
        Me.groupBoxFont.Controls.Add(Me.checkBoxBold)
        Me.groupBoxFont.Controls.Add(Me.comboBoxFont)
        Me.groupBoxFont.Location = New System.Drawing.Point(10, 9)
        Me.groupBoxFont.Name = "groupBoxFont"
        Me.groupBoxFont.Size = New System.Drawing.Size(242, 93)
        Me.groupBoxFont.TabIndex = 1
        Me.groupBoxFont.TabStop = False
        Me.groupBoxFont.Text = "Font"
        '
        'btnFontColor
        '
        Me.btnFontColor.Location = New System.Drawing.Point(6, 63)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(215, 24)
        Me.btnFontColor.TabIndex = 2
        Me.btnFontColor.Text = "Font Color"
        Me.btnFontColor.UseVisualStyleBackColor = True
        '
        'checkBoxUnderline
        '
        Me.checkBoxUnderline.AutoSize = True
        Me.checkBoxUnderline.Location = New System.Drawing.Point(113, 41)
        Me.checkBoxUnderline.Name = "checkBoxUnderline"
        Me.checkBoxUnderline.Size = New System.Drawing.Size(71, 17)
        Me.checkBoxUnderline.TabIndex = 4
        Me.checkBoxUnderline.Text = "Underline"
        Me.checkBoxUnderline.UseVisualStyleBackColor = True
        '
        'comboBoxSize
        '
        Me.comboBoxSize.FormattingEnabled = True
        Me.comboBoxSize.Location = New System.Drawing.Point(177, 14)
        Me.comboBoxSize.Name = "comboBoxSize"
        Me.comboBoxSize.Size = New System.Drawing.Size(44, 21)
        Me.comboBoxSize.TabIndex = 3
        '
        'checkBoxItalic
        '
        Me.checkBoxItalic.AutoSize = True
        Me.checkBoxItalic.Location = New System.Drawing.Point(59, 41)
        Me.checkBoxItalic.Name = "checkBoxItalic"
        Me.checkBoxItalic.Size = New System.Drawing.Size(48, 17)
        Me.checkBoxItalic.TabIndex = 3
        Me.checkBoxItalic.Text = "Italic"
        Me.checkBoxItalic.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(149, 17)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 4
        Me.lblSize.Text = "Size"
        '
        'checkBoxBold
        '
        Me.checkBoxBold.AutoSize = True
        Me.checkBoxBold.Location = New System.Drawing.Point(6, 41)
        Me.checkBoxBold.Name = "checkBoxBold"
        Me.checkBoxBold.Size = New System.Drawing.Size(47, 17)
        Me.checkBoxBold.TabIndex = 2
        Me.checkBoxBold.Text = "Bold"
        Me.checkBoxBold.UseVisualStyleBackColor = True
        '
        'comboBoxFont
        '
        Me.comboBoxFont.FormattingEnabled = True
        Me.comboBoxFont.Location = New System.Drawing.Point(6, 14)
        Me.comboBoxFont.Name = "comboBoxFont"
        Me.comboBoxFont.Size = New System.Drawing.Size(135, 21)
        Me.comboBoxFont.TabIndex = 2
        '
        'groupBoxMargin
        '
        Me.groupBoxMargin.Controls.Add(Me.btnPaste)
        Me.groupBoxMargin.Controls.Add(Me.btnCut)
        Me.groupBoxMargin.Controls.Add(Me.btnCopy)
        Me.groupBoxMargin.Controls.Add(Me.btnJustify)
        Me.groupBoxMargin.Controls.Add(Me.btnCenter)
        Me.groupBoxMargin.Controls.Add(Me.btnRight)
        Me.groupBoxMargin.Controls.Add(Me.btnLeft)
        Me.groupBoxMargin.Location = New System.Drawing.Point(267, 9)
        Me.groupBoxMargin.Name = "groupBoxMargin"
        Me.groupBoxMargin.Size = New System.Drawing.Size(222, 93)
        Me.groupBoxMargin.TabIndex = 2
        Me.groupBoxMargin.TabStop = False
        Me.groupBoxMargin.Text = "Margin"
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(146, 63)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(65, 23)
        Me.btnPaste.TabIndex = 8
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.Location = New System.Drawing.Point(76, 63)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(65, 23)
        Me.btnCut.TabIndex = 7
        Me.btnCut.Text = "Cut"
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(6, 63)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(65, 23)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnJustify
        '
        Me.btnJustify.Location = New System.Drawing.Point(162, 15)
        Me.btnJustify.Name = "btnJustify"
        Me.btnJustify.Size = New System.Drawing.Size(49, 23)
        Me.btnJustify.TabIndex = 5
        Me.btnJustify.Text = "Justify"
        Me.btnJustify.UseVisualStyleBackColor = True
        '
        'btnCenter
        '
        Me.btnCenter.Location = New System.Drawing.Point(110, 15)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(49, 23)
        Me.btnCenter.TabIndex = 5
        Me.btnCenter.Text = "Center"
        Me.btnCenter.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(58, 15)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(49, 23)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(6, 15)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(49, 23)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'groupBoxFile
        '
        Me.groupBoxFile.Controls.Add(Me.btnExit)
        Me.groupBoxFile.Controls.Add(Me.btnSave)
        Me.groupBoxFile.Controls.Add(Me.btnOpenDocument)
        Me.groupBoxFile.Location = New System.Drawing.Point(495, 9)
        Me.groupBoxFile.Name = "groupBoxFile"
        Me.groupBoxFile.Size = New System.Drawing.Size(208, 93)
        Me.groupBoxFile.TabIndex = 3
        Me.groupBoxFile.TabStop = False
        Me.groupBoxFile.Text = "File"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 27)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(52, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(87, 27)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(52, 42)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpenDocument
        '
        Me.btnOpenDocument.Location = New System.Drawing.Point(6, 20)
        Me.btnOpenDocument.Name = "btnOpenDocument"
        Me.btnOpenDocument.Size = New System.Drawing.Size(75, 57)
        Me.btnOpenDocument.TabIndex = 4
        Me.btnOpenDocument.Text = "Open Document"
        Me.btnOpenDocument.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'frmDokumenWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 442)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.groupBoxFile)
        Me.Controls.Add(Me.groupBoxMargin)
        Me.Controls.Add(Me.groupBoxFont)
        Me.Controls.Add(Me.richTextBox)
        Me.Name = "frmDokumenWord"
        Me.Text = "Form Document Word"
        Me.groupBoxFont.ResumeLayout(False)
        Me.groupBoxFont.PerformLayout()
        Me.groupBoxMargin.ResumeLayout(False)
        Me.groupBoxFile.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents richTextBox As RichTextBox
    Friend WithEvents groupBoxFont As GroupBox
    Friend WithEvents comboBoxSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents checkBoxBold As CheckBox
    Friend WithEvents comboBoxFont As ComboBox
    Friend WithEvents checkBoxItalic As CheckBox
    Friend WithEvents checkBoxUnderline As CheckBox
    Friend WithEvents btnFontColor As Button
    Friend WithEvents groupBoxMargin As GroupBox
    Friend WithEvents btnPaste As Button
    Friend WithEvents btnCut As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnJustify As Button
    Friend WithEvents btnCenter As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents groupBoxFile As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpenDocument As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
