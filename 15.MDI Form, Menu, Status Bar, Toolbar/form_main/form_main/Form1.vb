Public Class formMDI
    Private Sub subMenuLatihanForm1_Click(sender As Object, e As EventArgs) Handles subMenuLatihanForm1.Click

        Dim formLatihan1 As New form_latihan_1

        formLatihan1.Show()

        formLatihan1.MdiParent = Me

    End Sub

    Private Sub subMenuTileVertical_Click(sender As Object, e As EventArgs) Handles subMenuTileVertical.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub subMenuTileHorizontal_Click(sender As Object, e As EventArgs) Handles subMenuTileHorizontal.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub subMenuCascade_Click(sender As Object, e As EventArgs) Handles subMenuCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub subMenuExit_Click(sender As Object, e As EventArgs) Handles subMenuExit.Click

        If MessageBox.Show("Apakah Anda ingin keluar dari aplikasi ini ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub subMenuAbout_Click(sender As Object, e As EventArgs) Handles subMenuAbout.Click

        MessageBox.Show("Nama Product :" & Application.ProductName & vbCrLf & "Versi :" & Application.ProductVersion & vbCrLf & "Perusahaan :" & Application.CompanyName, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click




    End Sub

    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click

        Dim formLatihan1 As New form_latihan_1

        formLatihan1.Show()

        formLatihan1.MdiParent = Me

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick

        Dim sTanggal As String

        sTanggal = Format(Now(), "dddd, dd-MMM-yyyy")

        Me.statusStrip.Text = sTanggal

    End Sub
End Class
