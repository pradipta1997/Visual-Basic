Public Class frmUjiCobaProcedure

    Private sHarga As Integer = 1200

    Sub tampilPesan(ByVal judul As String, ByVal pesan As String)

        MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub belanjaByRef(ByRef harga As Integer, ByVal bayar As Integer)

        harga -= bayar

    End Sub

    Private Sub belanjaByVal(ByVal harga As Integer, ByVal bayar As Integer)

        harga -= bayar

    End Sub

    Private Sub btnTestProcedureStandart_Click(sender As Object, e As EventArgs) Handles btnTestProcedureStandart.Click

        tampilPesan("Test Procedure Box", "Test Procedure Standart")

    End Sub

    Private Sub btnTestProcedureByVal_Click(sender As Object, e As EventArgs) Handles btnTestProcedureByVal.Click

        belanjaByRef(sHarga, 2000)

        tampilPesan("Test Procedure ByVal", sHarga.ToString)

    End Sub

    Private Sub btnTestProcedureByRef_Click(sender As Object, e As EventArgs) Handles btnTestProcedureByRef.Click

        belanjaByRef(sHarga, 5000)

        tampilPesan("Test Procedure ByRef", sHarga.ToString)

    End Sub
End Class
