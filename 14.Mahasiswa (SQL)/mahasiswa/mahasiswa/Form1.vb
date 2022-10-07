Public Class frmMahasiswa

    Public tambahData As Boolean

    Private Sub frmMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MahasiswaDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.MahasiswaDataSet.mahasiswa)
        'TODO: This line of code loads data into the 'MatakuliahDataSet.matakuliah' table. You can move, or remove it, as needed.
        Me.MatakuliahTableAdapter.Fill(Me.MatakuliahDataSet.matakuliah)
        'TODO: This line of code loads data into the 'NilaiDataSet.nilai' table. You can move, or remove it, as needed.
        Me.NilaiTableAdapter.Fill(Me.NilaiDataSet.nilai)

        tambahData = False

    End Sub
    Private Sub setEnabledButton(ByVal sval As Boolean)

        If tambahData = True Then

            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnDelete.Enabled = False
            btnAdd.Enabled = True

        Else

            btnSave.Enabled = True
            btnCancel.Enabled = True

            If Me.txtNim.Text <> "" Then

                btnDelete.Enabled = True

            Else

                btnDelete.Enabled = False

            End If

            btnAdd.Enabled = True

        End If

    End Sub
    Private Sub cariNim(ByVal vNim As String)

        Dim sql As String = ""
        sql = "select * from mahasiswa where nim = '" & vNim & "'"

        MahasiswaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        MahasiswaTableAdapter.Adapter.SelectCommand.CommandText = sql
        MahasiswaTableAdapter.Fill(MahasiswaDataSet.mahasiswa)

        If MahasiswaDataSet.mahasiswa.Rows.Count > 0 Then

            Me.txtNama.Text = MahasiswaDataSet.mahasiswa.Rows(0).Item("nama")
            Me.comboBoxMataKuliah.Focus()

        Else

            MessageBox.Show("Data dengan NIM tersebut tidak terdaftar", "Cari NIM", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub

        End If

    End Sub
    Private Sub tampilGrid()

        Dim sql As String = ""
        sql = "select * from nilai"

        NilaiTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        NilaiTableAdapter.Adapter.SelectCommand.CommandText = sql
        NilaiTableAdapter.Fill(NilaiDataSet.nilai)

        Me.dataGridView.DataSource = Nothing
        Me.dataGridView.DataSource = NilaiDataSet.nilai

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        tambahData = True
        setEnabled(splitContainer.Panel2, True)
        clearControl(Me.splitContainer.Panel2)
        setEnabledButton(True)
        txtNilaiAkhir.Enabled = False
        Me.txtNim.Focus()

    End Sub

    Private Sub txtNim_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNim.KeyDown

        If e.KeyCode = Keys.Return Then

            Call cariNim(Me.txtNim.Text)

        End If

    End Sub

    Private Sub comboBoxMataKuliah_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboBoxMataKuliah.SelectedValueChanged

        If Me.comboBoxMataKuliah.Text > "" Then

            Me.comboBoxSemester.Focus()

        End If

    End Sub

    Private Sub comboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSemester.SelectedIndexChanged

        If Me.comboBoxSemester.Text > "" Then

            Me.txtFormatif.Focus()

        End If

    End Sub

    Private Sub txtFormatif_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormatif.KeyDown

        If e.KeyCode = Keys.Return Then

            If Me.txtFormatif.Text > "" Then

                Me.txtTugas.Focus()

            End If

        End If

    End Sub

    Private Sub txtTugas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTugas.KeyDown

        If e.KeyCode = Keys.Return Then

            If Me.txtTugas.Text > "" Then

                Me.txtUTS.Focus()

            End If

        End If

    End Sub

    Private Sub txtUTS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUTS.KeyDown

        If e.KeyCode = Keys.Return Then

            If Me.txtUAS.Text > "" Then

                Me.txtUAS.Focus()

            End If

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim pesan As String = ""

        If MessageBox.Show("Benar akan simpan data ini", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        If tambahData = True Then

            Me.txtNilaiAkhir.Text = Val(Me.txtFormatif.Text)

            NilaiTableAdapter.InsertQuery(Me.txtNim.Text, Me.comboBoxMataKuliah.SelectedValue, Me.comboBoxSemester.Text, Val(Me.txtFormatif.Text), Val(Me.txtTugas.Text), Val(Me.txtUTS.Text), Val(Me.txtUAS.Text))

            pesan = "Penyimpanan Data Berhasil"

        Else

            NilaiTableAdapter.UpdateQuery(Val(Me.txtFormatif.Text), Val(Me.txtTugas.Text), Val(Me.txtUTS.Text), Val(Me.txtUAS.Text), Me.txtNim.Text, Me.comboBoxMataKuliah.SelectedValue, Me.comboBoxSemester.Text)

            pesan = "Update data berhasil"

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

        If Me.txtNim.Text = "" Then Exit Sub

        If MessageBox.Show("Benar akan menghapus data ini ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        NilaiTableAdapter.DeleteQuery(Me.txtNim.Text)
        tampilGrid()
        tambahData = False
        setEnabled(splitContainer.Panel2, False)
        setEnabledButton(False)
        clearControl(Me.splitContainer.Panel2)
        setEnabledButton(False)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If MessageBox.Show("Benar akan keluar dari aplikasi ini ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Exit Sub

    End Sub
End Class
