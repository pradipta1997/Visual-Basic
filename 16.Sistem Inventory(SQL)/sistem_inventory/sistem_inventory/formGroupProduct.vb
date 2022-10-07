Public Class formGroupProduct

    Public posBaris As Integer 'Variabel ini dipergunakan untuk mengetahui posisi baris saat di klik

    Private Sub isiProduct(ByVal nama As String)

        Dim sqlstr As String = ""
        Dim ds As New DataSet

        sqlstr = "select * from group_product"

        If nama > "" Then

            sqlstr += "where nama_group like '" & nama & "%"

        End If

        Me.group_productTableAdapter.Adapter.SelectCommand.CommandText = sqlstr
        Me.group_productTableAdapter.Fill(Me.groupProductDataSet.group_product)

        dataGridView.DataSource = groupProductDataSet.group_product

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        Call isiProduct(txtCari.Text)

    End Sub

    Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick

        posBaris = e.RowIndex

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()
        Me.groupproductBindingSource.EndEdit()
        Me.group_productTableAdapter.Update(groupProductDataSet.group_product)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        If posBaris > Me.dataGridView.Rows.Count Then Exit Sub

        Dim groups As String = groupProductDataSet.Tables(0).Rows(posBaris).Item(0)
        Dim nama As String = groupProductDataSet.Tables(0).Rows(posBaris).Item(1)

        Me.Validate()
        Me.groupproductBindingSource.EndEdit()
        Me.group_productTableAdapter.Delete(groups, nama)

    End Sub

End Class