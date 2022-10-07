Public Class frmDataMahasiswa
    Private Sub frmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NilaiMhsDataSet.reportMhs' table. You can move, or remove it, as needed.
        Me.reportMhsTableAdapter.Fill(Me.nilaiMhsDataSet.reportMhs)

    End Sub
End Class
