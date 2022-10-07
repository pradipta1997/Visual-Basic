Public Class frmInputNilaiMahasiswa

    Public tambahData As Boolean
    Private Sub frmInputNilaiMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mahasiswaDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.mahasiswaTableAdapter.Fill(Me.mahasiswaDataSet.mahasiswa)
        'TODO: This line of code loads data into the 'MataKuliahDataSet.reportMhs' table. You can move, or remove it, as needed.
        Me.mataKuliahTableAdapter.Fill(Me.mataKuliahDataSet.reportMhs)
        'TODO: This line of code loads data into the 'NilaiMhsDataSet.nilaimahasiswa2' table. You can move, or remove it, as needed.
        Me.nilaimahasiswa2TableAdapter.Fill(Me.nilaiMhsDataSet.nilaimahasiswa2)
        tambahData = False
    End Sub
    Private Sub setEnabledButton(ByVal sVal As Boolean)

        If tambahData = True Then

            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnDelete.Enabled = False
            btnAdd.Enabled = True

        Else

            btnSave.Enabled = True
            btnCancel.Enabled = True

            If Me.txtNIM.Text <> "" Then

                btnDelete.Enabled = True

            Else

                btnDelete.Enabled = False

            End If
            btnAdd.Enabled = True

        End If

    End Sub
    Private Sub tampilGrid()

        Dim sql As String = ""
        sql = "select * from nilaimahasiswa2"

        nilaimahasiswa2TableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text

        nilaimahasiswa2TableAdapter.Adapter.SelectCommand.CommandText = sql

        nilaimahasiswa2TableAdapter.Fill(nilaiMhsDataSet.nilaimahasiswa2)

        Me.dataGridView.DataSource = Nothing
        Me.dataGridView.DataSource = nilaiMhsDataSet.nilaimahasiswa2

    End Sub
    Private Sub cariNIM(ByVal vNIM As String)

        Dim sql As String = ""
        sql = "select * from mahasiswa where NIM='" & vNIM & "'"

        mahasiswaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text

        mahasiswaTableAdapter.Adapter.SelectCommand.CommandText = sql

        mahasiswaTableAdapter.Fill(mahasiswaDataSet.mahasiswa)

        If mahasiswaDataSet.mahasiswa.Rows.Count > 0 Then

            Me.txtNama.Text = mahasiswaDataSet.mahasiswa.Rows(0).Item("Nama")
            Me.comboBoxMataKuliah.Focus()

        Else

            MessageBox.Show("Data dengan NIM tersebut tidak terdaftar", "Cari NIM", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        tambahData = True
        setEnabled(splitContainer.Panel2, True)
        clearControl(Me.splitContainer.Panel2)
        setEnabledButton(True)
        txtNilaiAkhir.Enabled = False
        Me.txtNIM.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim pesan As String = ""

        If MessageBox.Show("Data akan tersimpan", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        If tambahData = True Then

            Me.txtNilaiAkhir.Text = Val(Me.txtFormatif.Text)
            nilaimahasiswa2TableAdapter.InsertQuery(Me.txtNIM.Text, Me.comboBoxMataKuliah.SelectedValue, Me.comboBoxSemester.Text, Val(Me.txtFormatif.Text), Val(Me.txtTugas.Text), Val(Me.txtUTS.Text), Val(Me.txtUAS.Text))

            pesan = "Penyimpanan Data Berhasil"


        Else

            nilaimahasiswa2TableAdapter.UpdtQuery(Val(Me.txtFormatif.Text), Val(Me.txtTugas.Text), Val(Me.txtUTS.Text), Val(Me.txtUAS.Text), Me.txtNIM.Text, Me.comboBoxMataKuliah.SelectedValue, Me.comboBoxSemester.Text)

            pesan = "Update Data Berhasil"

        End If

        MessageBox.Show(pesan, "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

        tampilGrid()
        tambahData = False
        setEnabled(splitContainer.Panel2, False)
        setEnabledButton(False)
        clearControl(Me.splitContainer.Panel2)
        setEnabledButton(False)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Me.txtNIM.Text = "" Then Exit Sub

        If MessageBox.Show("Apakah akan menghapus data ini ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        nilaimahasiswa2TableAdapter.DeleteQuery(txtNIM.Text)

        tampilGrid()
        tambahData = False
        setEnabled(splitContainer.Panel2, False)
        setEnabledButton(False)
        clearControl(Me.splitContainer.Panel2)
        setEnabledButton(False)

    End Sub
End Class
