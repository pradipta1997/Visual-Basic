<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariGambar
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
        Me.lblNamaFileGambar = New System.Windows.Forms.Label()
        Me.txtCariGambar = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.pbTampilGambar = New System.Windows.Forms.PictureBox()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbTampilGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNamaFileGambar
        '
        Me.lblNamaFileGambar.AutoSize = True
        Me.lblNamaFileGambar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaFileGambar.Location = New System.Drawing.Point(58, 47)
        Me.lblNamaFileGambar.Name = "lblNamaFileGambar"
        Me.lblNamaFileGambar.Size = New System.Drawing.Size(128, 15)
        Me.lblNamaFileGambar.TabIndex = 0
        Me.lblNamaFileGambar.Text = "Nama File Gambar"
        '
        'txtCariGambar
        '
        Me.txtCariGambar.Location = New System.Drawing.Point(61, 75)
        Me.txtCariGambar.Name = "txtCariGambar"
        Me.txtCariGambar.Size = New System.Drawing.Size(363, 20)
        Me.txtCariGambar.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(430, 72)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'pbTampilGambar
        '
        Me.pbTampilGambar.Location = New System.Drawing.Point(61, 120)
        Me.pbTampilGambar.Name = "pbTampilGambar"
        Me.pbTampilGambar.Size = New System.Drawing.Size(444, 260)
        Me.pbTampilGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTampilGambar.TabIndex = 3
        Me.pbTampilGambar.TabStop = False
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "OpenFileDialog1"
        '
        'frmCariGambar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(531, 420)
        Me.Controls.Add(Me.pbTampilGambar)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCariGambar)
        Me.Controls.Add(Me.lblNamaFileGambar)
        Me.Name = "frmCariGambar"
        Me.Text = "Form Cari Gambar"
        CType(Me.pbTampilGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaFileGambar As Label
    Friend WithEvents txtCariGambar As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents pbTampilGambar As PictureBox
    Friend WithEvents openFileDialog As OpenFileDialog
End Class
