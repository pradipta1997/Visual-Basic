Public Class formSatuan

    'Variabel tambahData dipergunakan untuk menentukan tambah atau edit
    'spos dipergunakan untuk  posisi kursor menentukan baris aktif grid pada saat di klik

    Private tambahData As Boolean
    Private spos As Integer

    Private Sub cariSatuan(ByVal sSatuan As String)

        Dim perintah As String

        perintah = "select * from satuan where nama_satuan like '" & Trim(Me.txtCari.Text) & "%'"

        Me.satuanTableAdapter.Adapter.SelectCommand.CommandText = perintah
        Me.satuanTableAdapter.Fill(Me.satuanDataSet.satuan)
        Me.dataGridView.DataSource = satuanDataSet.satuan

    End Sub

    Private Sub formSatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.satuanTableAdapter.Fill(Me.satuanDataSet.satuan)

        clearControl(Me) 'Dipergunakan untuk membersihkan textbox
        setEnabled(Me, False) 'setEnabled menjadi false ke semua object
        tambahData = False 'Variabel awal posisi tidak dalam posisi menambah data
        spos = -1 'Variabel awal posisi baris pada dataGridView

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        cariSatuan(Me.txtCari.Text) 'Mencari berdasarkan text yang di entry

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        cariSatuan(Me.txtCari.Text) 'Mencari berdasarkan text yang di entry

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Close()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        clearControl(Me)
        setEnabled(Me, True)
        tambahData = True
        spos = -1
        Me.txtKode.Focus()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        clearControl(Me)
        setEnabled(Me, False)
        tambahData = False
        spos = -1

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Dim sqlstr As String = ""
        Dim i As Integer = 0
        Dim pesan As String = ""

        If tambahData = True Then

            i = satuanTableAdapter.Insert(Me.txtKode.Text, Me.txtNamaSatuan.Text)

            pesan = "Penyimpanan Data"

        Else

            satuanDataSet.satuan.Item(spos).nama_satuan = Me.txtNamaSatuan.Text

            i = satuanTableAdapter.Update(satuanDataSet.satuan)

            pesan = "Update Data"

        End If

        MessageBox.Show(pesan, "Simpan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cariSatuan(Me.txtCari.Text)
        clearControl(Me)
        setEnabled(Me, False)

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim pesan As String = "Benar data ini akan di hapus ?"
        Dim i As Integer = 0

        If MessageBox.Show(pesan, "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        i = satuanTableAdapter.Delete(Me.txtKode.Text, Me.txtNamaSatuan.Text)

        cariSatuan(Me.txtCari.Text)
        clearControl(Me)
        setEnabled(Me, False)
        Me.dataGridView.Refresh()

    End Sub

    Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick

        spos = e.RowIndex

        Me.txtKode.Text = "" & Me.dataGridView.Rows(spos).Cells(0).Value
        Me.txtNamaSatuan = "" & Me.dataGridView.Rows(spos).Cells(1).Value

        setEnabled(Me, True)
        Me.txtKode.Enabled = False
        tambahData = False
        Me.txtNamaSatuan.Focus()

    End Sub

End Class
