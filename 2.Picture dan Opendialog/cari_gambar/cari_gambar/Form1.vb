Public Class frmCariGambar
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        Me.openFileDialog.Title = "Pilih Gambar"
        Me.openFileDialog.FileName = ""
        Me.openFileDialog.Filter = "Semua File gambar|*.gif|*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png|
        (Semua file)|*.*"

        Me.openFileDialog.ShowDialog()
        Me.txtCariGambar.Text = Me.openFileDialog.FileName
        Me.pbTampilGambar.ImageLocation = Me.txtCariGambar.Text

    End Sub
End Class
