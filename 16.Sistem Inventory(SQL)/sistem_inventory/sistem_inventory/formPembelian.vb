Public Class formPembelian

    Public vTambahPembelian As Boolean
    Public vTambahDetail As Boolean
    Public vBaris As Integer

    Private Sub formPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet6.product' table. You can move, or remove it, as needed.
        Me.productTableAdapter.Fill(Me.productDataSet6.product)
        'TODO: This line of code loads data into the 'HeaderPembelianDataSet5.header_pembelian' table. You can move, or remove it, as needed.
        Me.header_pembelianTableAdapter.Fill(Me.headerPembelianDataSet5.header_pembelian)
        'TODO: This line of code loads data into the 'DetailPembelianDataSet4.detail_pembelian' table. You can move, or remove it, as needed.
        Me.detail_pembelianTableAdapter.Fill(Me.detailPembelianDataSet4.detail_pembelian)
        'TODO: This line of code loads data into the 'SupplierDataSet3.supplier' table. You can move, or remove it, as needed.
        Me.supplierTableAdapter.Fill(Me.supplierDataSet3.supplier)

        Call loadDataGrid()

        Me.supplierTableAdapter.Fill(Me.supplierDataSet3.supplier)

        Call inisialPembelian()

    End Sub

    Private Sub inisialPembelian()

        vTambahPembelian = False
        vTambahDetail = False
        vBaris = -1

        Call clearControl(Me)
        Call clearControl(Me.panelDetail)

        setEnabled(Me, False)
        setEnabledButton(False)

        Me.dateTimePicker.Value = Now

    End Sub
    Private Sub setEnabledButton(ByVal isEnabled As Boolean)

        If vTambahPembelian = True Then

            btnEditPembelian.Enabled = True
            btnHapusPembelian.Enabled = True

            Me.panelDetail.Enabled = True

            btnTambahPembelian.Enabled = True

        Else

            btnEditPembelian.Enabled = True
            btnHapusPembelian.Enabled = True

            Me.panelDetail.Enabled = False

            btnTambahPembelian.Enabled = True

        End If

    End Sub
    Private Sub loadDataGrid()

        Dim sql As String = ""
        Dim i As Integer = 0
        Dim jumUang As Double = 0

        sql = "select * from detail_pembelian where transaksiID = '" & Me.txtNoTransaksi.Text & "'"

        detail_pembelianTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        detail_pembelianTableAdapter.Adapter.SelectCommand.CommandText = sql

        Me.detail_pembelianTableAdapter.Fill(Me.detailPembelianDataSet4.detail_pembelian)

        dataGridView.Rows.Clear()

        If detailPembelianDataSet4.detail_pembelian.Rows.Count > 0 Then

            For i = 0 To detailPembelianDataSet4.detail_pembelian.Rows.Count - 1

                dataGridView.Rows.Add()

                With Me.dataGridView.Rows(i)

                    .Cells(0).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("transaksiID")

                    .Cells(1).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("kode_product")

                    .Cells(2).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("nama_product")

                    .Cells(3).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("jumlah")

                    .Cells(4).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("harga")

                    .Cells(5).Value = "" &
                        detailPembelianDataSet4.detail_pembelian(i).Item("discount")

                    jumUang = Val(detailPembelianDataSet4.detail_pembelian(i).Item("jumlah")) *
                              Val(detailPembelianDataSet4.detail_pembelian(i).Item("harga")) -
                              (Val(detailPembelianDataSet4.detail_pembelian(i).Item("discount") / 100) *
                              Val(detailPembelianDataSet4.detail_pembelian(i).Item("harga")))

                    .Cells(6).Value = jumUang

                End With

            Next

        End If

    End Sub
    Private Function loadDataHeader(ByVal vTransaksiID As String) As Boolean

        Dim sql As String = ""

        If vTransaksiID = "" Then

            sql = "select * from header_pembelian "

        Else

            sql = "select * from header_pembelian where transaksiID = '" & vTransaksiID & "'"

        End If

        Call setEnabled(Me, True)


        header_pembelianTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        header_pembelianTableAdapter.Adapter.SelectCommand.CommandText = sql
        Me.header_pembelianTableAdapter.Fill(Me.headerPembelianDataSet5.header_pembelian)


        If headerPembelianDataSet5.header_pembelian.Rows.Count > 0 Then

            Me.txtNoTransaksi.Text = "" &
                headerPembelianDataSet5.header_pembelian.Rows(0).Item("transaksiID")

            Me.dateTimePicker.Value = "" &
                headerPembelianDataSet5.header_pembelian.Rows(0).Item("tanggal")

            Me.supplierTableAdapter.Fill(Me.supplierDataSet3.supplier)
            Me.comboBoxSupplier.SelectedValue =
                headerPembelianDataSet5.header_pembelian.Rows(0).Item("kode_supplier")
            Me.comboBoxSupplier.Refresh()

            Me.txtKeterangan.Text = "" &
                headerPembelianDataSet5.header_pembelian.Rows(0).Item("keterangan")


            Call loadDataGrid()

            Me.txtTotalUang.Text = cariTotalUang()

            Return True

        Else

            Return False

        End If

    End Function
    Private Function cariTotalUang() As Double

        Dim i As Integer
        Dim vTotal As Double = 0

        For i = 0 To Me.dataGridView.Rows.Count - 1

            vTotal = vTotal + Val(Me.dataGridView.Rows(i).Cells(6).Value)

        Next

        Return vTotal

    End Function
    Private Function cariProductToGrid(ByVal vProductID As String, ByVal returnsFields As String) As String

        Dim sql As String = ""

        sql = "select * from product where kode_product = '" & vProductID & "'"

        productTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        productTableAdapter.Adapter.SelectCommand.CommandText = sql

        Me.productTableAdapter.Fill(Me.productDataSet6.product)

        If productDataSet6.product.Rows.Count > 0 Then

            Return "" & productDataSet6.product.Rows(0).Item(returnsFields)

        Else

            Return ""

        End If

    End Function
    Private Sub cariProductToDetail(ByVal vProductID As String)

        Dim sql As String = ""

        sql = "select * from product where kode_product = '" & vProductID & "'"

        productTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        productTableAdapter.Adapter.SelectCommand.CommandText = sql

        Me.productTableAdapter.Fill(Me.productDataSet6.product)

        If productDataSet6.product.Rows.Count > 0 Then

            Me.txtNamaProduct.Text = "" & productDataSet6.product.Rows(0).Item("nama_product")
            Me.txtHargaSatuan.Text = "" & productDataSet6.product.Rows(0).Item("harga_beli")
            Me.txtJumlah.Focus()

        Else

            MsgBox("Product tidak terdaftar,isi kode lainnya", MsgBoxStyle.Critical)

            Me.txtKodeProduct.Focus()

        End If

    End Sub
    Private Sub hitungJumlahUang()

        Dim i As Integer = 0
        Me.txtJumlahUang.Text = (Val(Me.txtJumlah.Text) * Val(Me.txtHargaSatuan.Text)) - (((Me.txtDiscount.Text) / 100) * Val(Me.txtHargaSatuan.Text))

    End Sub
    Private Function isiNoTransaksi() As String

        Dim sql As String = ""
        Dim no As Integer = 0
        Dim noUrut As String = ""
        Dim ds As New DataSet

        sql = "select max(Right(transaksiID,5)) as no from header_pembelian"

        header_pembelianTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
        header_pembelianTableAdapter.Adapter.SelectCommand.CommandText = sql

        headerPembelianDataSet5.header_pembelian.Clear()
        headerPembelianDataSet5.header_pembelian.Reset()

        Me.header_pembelianTableAdapter.Fill(Me.headerPembelianDataSet5.header_pembelian)

        If headerPembelianDataSet5.header_pembelian.Rows.Count > 0 Then

            no = Val(headerPembelianDataSet5.header_pembelian.Rows(0).Item("no")) + 1

            Select Case Len(Trim(Str(no)))
                Case 1
                    noUrut = "0000"

                Case 2
                    noUrut = "000"

                Case 3
                    noUrut = "00"

                Case 4
                    noUrut = "0"
            End Select

            noUrut = "" & noUrut & no


        Else

            noUrut = "00001"


        End If

        noUrut = "BL-" & Format(Me.dateTimePicker.Value, "yyyyMMdd") & "-" & noUrut

        Return noUrut

    End Function
    Private Sub simpanDataHeader()

        header_pembelianTableAdapter.Insert(Me.txtNoTransaksi.Text, Format(Me.dateTimePicker.Value, "yyyy-MM-dd"), Me.comboBoxSupplier.SelectedValue, Me.txtKeterangan.Text)

    End Sub
    Private Sub simpanDataDetail()

        detail_pembelianTableAdapter.Insert(Me.txtNoTransaksi.Text, Me.txtKodeProduct.Text, Val(Me.txtJumlah.Text), Val(Me.txtHargaSatuan.Text), Val(txtDiscount.Text))

    End Sub

    Private Sub btnTambahPembelian_Click(sender As Object, e As EventArgs) Handles btnTambahPembelian.Click

        vTambahPembelian = True
        vTambahDetail = True
        vBaris = -1

        setEnabled(Me, True)
        setEnabledButton(True)

        clearControl(Me)
        clearControl(Me.panelDetail)

        Me.dateTimePicker.Value = Now
        Me.txtNoTransaksi.Text = isiNoTransaksi()

        Call loadDataGrid()

        Me.comboBoxSupplier.Focus()

    End Sub

    Private Sub txtKodeProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeProduct.KeyDown

        If e.KeyCode = Keys.Return Then

            Call cariProductToDetail(Me.txtKodeProduct.Text)

        End If

    End Sub

    Private Sub txtJumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyDown

        If e.KeyCode = Keys.Return Then

            If Val(Me.txtJumlah.Text) > 0 Then

                Me.txtDiscount.Focus()

            Else

                MsgBox("Isi angka tidak boleh kosong", MsgBoxStyle.Critical)

                Me.txtJumlah.Focus()

            End If

        End If

    End Sub

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown

        If e.KeyCode = Keys.Return Then

            Call hitungJumlahUang()
            Me.btnSimpanDetail.Focus()

        End If

    End Sub

    Private Sub btnSimpanDetail_Click(sender As Object, e As EventArgs) Handles btnSimpanDetail.Click

        Dim pesan As String = "Benar akan menyimpan data ini ?"

        If MsgBox(pesan, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        If loadDataHeader(Me.txtNoTransaksi.Text) = False Then

            Call simpanDataHeader()

        End If

        Call simpanDataDetail()
        Call loadDataGrid()

        Me.txtTotalUang.Text = cariTotalUang()

        MsgBox("Penyimpanan Berhasil", MsgBoxStyle.Information)

        btnTambahDetail_Click(Nothing, Nothing)

    End Sub

    Private Sub btnTambahDetail_Click(sender As Object, e As EventArgs) Handles btnTambahDetail.Click

        vTambahPembelian = False
        vTambahDetail = True

        Call clearControl(Me.panelDetail)

        Me.txtKodeProduct.Focus()

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Dim pesan As String = "Benar akan keluar dari aplikasi ini ?"

        If MsgBox(pesan, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Me.Close()

    End Sub

    Private Sub btnEditPembelian_Click(sender As Object, e As EventArgs) Handles btnEditPembelian.Click

        Dim pesan As String = ""

        pesan = InputBox("Masukan nomor transaksi yang akan di edit", "Edit Transaksi")

        If pesan > "" Then

            If loadDataHeader(pesan) = True Then

                vTambahPembelian = False
                vTambahDetail = True

                clearControl(Me.panelDetail)

                Me.txtNoTransaksi.Enabled = False

                Call loadDataGrid()

                panelDetail.Enabled = True

                Me.txtKodeProduct.Focus()

            Else

                MsgBox("Data Transaksi ID : " & pesan & "tidak terdaftar", MsgBoxStyle.Critical)

                Exit Sub

            End If

        End If

    End Sub

    Private Sub btnHapusPembelian_Click(sender As Object, e As EventArgs) Handles btnHapusPembelian.Click

        Dim pesan As String = "Benar akan di hapus data ini "

        If MsgBox(pesan, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        header_pembelianTableAdapter.Delete(Me.txtNoTransaksi.Text, Format(dateTimePicker.Value, "yyyy-MM-dd"), Me.comboBoxSupplier.SelectedValue, Me.txtKeterangan.Text)

        vTambahPembelian = False
        vTambahDetail = False

        clearControl(Me)
        clearControl(Me.panelDetail)

        Me.txtNoTransaksi.Enabled = False

        Call loadDataGrid()

        panelDetail.Enabled = True
    End Sub


    Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick

        If Me.dataGridView.Rows.Count <= 0 Then Exit Sub

        Dim pos As Integer = e.RowIndex

        Me.txtKodeProduct.Text = "" & dataGridView.Rows(pos).Cells(1).Value

        cariProductToDetail(Me.txtKodeProduct.Text)

        Me.txtHargaSatuan.Text = "" & dataGridView.Rows(pos).Cells(4).Value
        Me.txtDiscount.Text = "" & dataGridView.Rows(pos).Cells(5).Value
        Me.txtJumlah.Text = "" & dataGridView.Rows(pos).Cells(3).Value

        Me.txtJumlahUang.Text = Val(txtJumlah.Text) * Val(txtHargaSatuan.Text) - ((Val(txtDiscount.Text) / 100) * Val(txtHargaSatuan.Text))


    End Sub
End Class