Public Class frmPenginputanDataBarang

    Public arrayProduct(100, 3) As String
    Public index, no_urut As Integer

    Private Sub isiCombo()

        'COMBOBOX GROUP PRODUCT
        Me.comboBoxProductGroup.Items.Clear()

        Me.comboBoxProductGroup.Items.Add("ATK")
        Me.comboBoxProductGroup.Items.Add("Komputer")
        Me.comboBoxProductGroup.Items.Add("Meja Kantor")
        Me.comboBoxProductGroup.Items.Add("Kursi Kantor")
        Me.comboBoxProductGroup.Items.Add("Air Conditioner")
        Me.comboBoxProductGroup.Items.Add("Spanduk")
        Me.comboBoxProductGroup.Items.Add("Sticker")
        Me.comboBoxProductGroup.Items.Add("Alat Kebersihan Ruangan/Set")
        Me.comboBoxProductGroup.Items.Add("Spare Part Komputer")

    End Sub

    Private Sub bacaGrid()

        'AGAR TAMPIL PADA DATA GRID VIEW
        Dim i As Integer
        Dim no As Integer = 0

        'Penambahan pada kolom
        dataGridView.DataBindings.Clear()
        dataGridView.Columns.Clear()
        dataGridView.Rows.Clear()

        dataGridView.Columns.Add("id", "ID")
        dataGridView.Columns.Add("name", "Prod.Name")
        dataGridView.Columns.Add("groups", "Prod.Group")
        dataGridView.Columns.Add("products", "Prices")

        ReDim Preserve arrayProduct(100, 3)
        no = 0

        For i = 0 To index

            'Penambahan pada baris
            dataGridView.Rows.Add()

            dataGridView.Rows(no).Cells(0).Value = arrayProduct(no, 0).ToString()
            dataGridView.Rows(no).Cells(1).Value = arrayProduct(no, 1).ToString()
            dataGridView.Rows(no).Cells(2).Value = arrayProduct(no, 2).ToString()
            dataGridView.Rows(no).Cells(3).Value = arrayProduct(no, 3).ToString()

            no = no + 1
            i = no

        Next

    End Sub

    Private Sub frmPenginputanDataBarang_Load(sender As Object, e As EventArgs) Handles Me.Load

        'PEMANGGILAN PROCEDURE DARI FILE moduleUtility.vb
        clearControl(Me.SplitContainer.Panel2)

        setEnabled(Me.SplitContainer.Panel2, False)

        Call isiCombo()

        index = 0

        no_urut = 0

    End Sub


    Private Sub txtProductID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductID.KeyDown

        'UNTUK MEMBUAT FUNGSI BAHWA PRODUCT ID TIDAK BOLEH KOSONG DENGAN PERINGATAN ErrorProvider
        If checkError(e, errorProvider, txtProductID, "Product ID Invalid or NULL") = False Then

            setEnter(e, txtProductName, txtProductID)


        Else

            Me.errorProvider.Clear()
            Me.txtProductID.Focus()


        End If

    End Sub


    Private Sub txtProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductName.KeyDown

        'UNTUK MEMBUAT FUNGSI BAHWA PRODUCT NAME TIDAK BOLEH KOSONG DENGAN PERINGATAN ErrorProvider
        If checkError(e, Me.errorProvider, txtProductName, "Product Name Invalid ot NULL") = False Then

            setEnter(e, Me.comboBoxProductGroup, txtProductID)


        Else

            Me.txtProductName.Focus()


        End If

    End Sub


    Private Sub comboBoxProductGroup_KeyDown(sender As Object, e As KeyEventArgs) Handles comboBoxProductGroup.KeyDown

        'UNTUK MEMBUAT FUNGSI BAHWA PRODUCT NAME TIDAK BOLEH KOSONG DENGAN PERINGATAN ErrorProvider
        If checkError(e, Me.errorProvider, comboBoxProductGroup, "Product Group Invalid or NULL") = False Then

            setEnter(e, Me.txtPrices, txtProductName)


        Else

            Me.comboBoxProductGroup.Focus()


        End If

    End Sub

    Private Sub txtPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrices.KeyDown

        'UNTUK MEMBUAT FUNGSI BAHWA PRICES TIDAK BOLEH KOSONG DENGAN PERINGATAN ErrorProvider
        If checkError(e, Me.errorProvider, txtPrices, "Prices Invalid or NULL") = False Then

            setEnter(e, Me.btnAdd, comboBoxProductGroup)


        Else

            Me.txtPrices.Focus()

        End If

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ''PEMANGGILAN PROCEDURE DARI FILE moduleUtility.vb
        clearControl(Me.SplitContainer.Panel2)

        setEnabled(Me.SplitContainer.Panel2, True)

        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True
        Me.txtProductID.Focus()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'UNTUK MEMBUAT FUNGSI SAVE & TERSIMPAN PADA DATA GRID VIEW
        If Trim(Me.txtProductID.Text) = "" Then Exit Sub

        arrayProduct(index, 0) = Trim(Me.txtProductID.Text)
        arrayProduct(index, 1) = Trim(Me.txtProductName.Text)
        arrayProduct(index, 2) = Trim(Me.comboBoxProductGroup.Text)
        arrayProduct(index, 3) = Trim(Me.txtPrices.Text)

        index = index + 1

        bacaGrid()

        clearControl(SplitContainer.Panel2)

        Me.txtProductID.Focus()

    End Sub


    Private Sub btnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCancel.KeyDown

        'PEMANGGILAN PROCEDURE DARI FILE moduleUtility.vb
        clearControl(Me.SplitContainer.Panel2)

        setEnabled(Me.SplitContainer.Panel2, True)

        Me.txtProductID.Focus()

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'UNTUK MEMBUAT FUNGSI CARI PADA DATA GRID VIEW
        If Trim(Me.txtProductID.Text) = "" Then Exit Sub

        'Pembuatan variabel
        Dim i As Integer
        Dim no As Integer = 0
        Dim cari As String = Me.txtProductID.Text
        Dim ditemukan As Boolean = False


        'PENGULANGAN FOR..NEXT & PENGKONDISIAN IF..THEN
        For i = 0 To index

            If LCase(arrayProduct(no, 0)) = LCase(cari) Then

                Me.txtProductID.Text = arrayProduct(no, 0)
                Me.txtProductName.Text = arrayProduct(no, 1)
                Me.comboBoxProductGroup.Text = arrayProduct(no, 2)
                Me.txtPrices.Text = arrayProduct(no, 3)

                no_urut = i

                ditemukan = True

                Exit For


            End If

            i += 1

            no = no + 1

        Next


        If ditemukan = False Then

            MessageBox.Show("Data is Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Me.btnDelete.Enabled = False


        Else

            Me.btnDelete.Enabled = True


        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'UNTUK MEMBUAT FUNGSI NEXT PADA DATA GRID VIEW
        If (no_urut + 2) > index Then Exit Sub

        no_urut += 1

        Me.txtProductID.Text = arrayProduct(no_urut, 0)
        Me.txtProductName.Text = arrayProduct(no_urut, 1)
        Me.comboBoxProductGroup.Text = arrayProduct(no_urut, 2)
        Me.txtPrices.Text = arrayProduct(no_urut, 3)

        Me.btnDelete.Enabled = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'UNTUK MEMBUAT FUNGSI BACK PADA DATA GRID VIEW
        If (no_urut <= 0) Then Exit Sub

        no_urut -= 1

        Me.txtProductID.Text = arrayProduct(no_urut, 0)
        Me.txtProductName.Text = arrayProduct(no_urut, 1)
        Me.comboBoxProductGroup.Text = arrayProduct(no_urut, 2)
        Me.txtPrices.Text = arrayProduct(no_urut, 3)

        Me.btnDelete.Enabled = True

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'UNTUK MEMBUAT FUNGSI KELUAR PADA APLIKASI
        If MessageBox.Show("Are you sure to Exit App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class
