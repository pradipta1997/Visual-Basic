Public Class formUtamaMDI
    Private Sub subMenuSatuan_Click(sender As Object, e As EventArgs) Handles subMenuSatuan.Click

        Dim f As New formSatuan
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub subMenuPembelian_Click(sender As Object, e As EventArgs) Handles subMenuPembelian.Click

        Dim f As New formPembelian
        f.MdiParent = Me
        f.Show()

    End Sub
End Class