Public Class frmDataMahasiswa
    Private Sub btnIsiLagi_Click(sender As Object, e As EventArgs) Handles btnIsiLagi.Click

        txtNIM.Text = ""
        txtNama.Text = ""
        txtJurusan.Text = ""

        'Agar kursor berada di (txtNIM),maka gunakan fungsi (Focus)

        txtNIM.Focus()

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        'Menampilkan Pesan

        MessageBox.Show("Anda akan keluar dari aplikasi Data Mahasiswa", "Selesai", MessageBoxButtons.OK)

        Me.Close()

    End Sub
End Class
