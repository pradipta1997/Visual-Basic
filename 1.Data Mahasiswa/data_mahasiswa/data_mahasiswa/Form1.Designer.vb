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
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtJurusan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnIsiLagi = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.lblDataMahasiswa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIM.Location = New System.Drawing.Point(35, 60)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(35, 16)
        Me.lblNIM.TabIndex = 0
        Me.lblNIM.Text = "NIM"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(35, 114)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(49, 16)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJurusan.Location = New System.Drawing.Point(35, 166)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(62, 16)
        Me.lblJurusan.TabIndex = 2
        Me.lblJurusan.Text = "Jurusan"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(123, 60)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(100, 20)
        Me.txtNIM.TabIndex = 3
        '
        'txtJurusan
        '
        Me.txtJurusan.Location = New System.Drawing.Point(123, 162)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(210, 20)
        Me.txtJurusan.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(123, 114)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(210, 20)
        Me.txtNama.TabIndex = 5
        '
        'btnIsiLagi
        '
        Me.btnIsiLagi.Location = New System.Drawing.Point(123, 217)
        Me.btnIsiLagi.Name = "btnIsiLagi"
        Me.btnIsiLagi.Size = New System.Drawing.Size(75, 23)
        Me.btnIsiLagi.TabIndex = 6
        Me.btnIsiLagi.Text = "Isi Lagi"
        Me.btnIsiLagi.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(214, 217)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 7
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'lblDataMahasiswa
        '
        Me.lblDataMahasiswa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataMahasiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDataMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataMahasiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDataMahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.lblDataMahasiswa.Name = "lblDataMahasiswa"
        Me.lblDataMahasiswa.Size = New System.Drawing.Size(406, 24)
        Me.lblDataMahasiswa.TabIndex = 8
        Me.lblDataMahasiswa.Text = "Data Mahasiswa"
        '
        'frmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 294)
        Me.Controls.Add(Me.lblDataMahasiswa)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnIsiLagi)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIM)
        Me.Name = "frmDataMahasiswa"
        Me.Text = "Form Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNIM As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnIsiLagi As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents lblDataMahasiswa As Label
End Class
