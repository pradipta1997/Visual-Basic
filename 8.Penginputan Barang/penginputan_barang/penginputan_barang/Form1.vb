Public Class frmPenginputanBarang

    Private Sub isiComboBox()

        'PROCEDURE UNTUK PENGISIAN COMBOBOX PADA "PRODUCT GROUP"

        Me.comboBoxProductGroup.Items.Clear()

        Me.comboBoxProductGroup.Items.Add("ATK")

        Me.comboBoxProductGroup.Items.Add("Komputer")

        Me.comboBoxProductGroup.Items.Add("Meja Kantor")

        Me.comboBoxProductGroup.Items.Add("Kursi")

        Me.comboBoxProductGroup.Items.Add("Air Conditioner")

        Me.comboBoxProductGroup.Items.Add("Wall Sign")

        Me.comboBoxProductGroup.Items.Add("Kabel Internet")

        Me.comboBoxProductGroup.Items.Add("Spanduk")

        Me.comboBoxProductGroup.Items.Add("Sticker")

        Me.comboBoxProductGroup.Items.Add("Spare Part Komputer")

    End Sub

    Private Sub frmPenginputanBarang_Load(sender As Object, e As EventArgs) Handles Me.Load

        'PEMANGGILAN PROCEDURE DARI FILE moduleUtility.vb

        clearControl(Me.SplitContainer1.Panel2)

        setEnabled(Me.SplitContainer1.Panel2, False)

        Call isiComboBox()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'PEMANGGILAN PROCEDURE DARI FILE moduleUtility.vb

        clearControl(Me.SplitContainer1.Panel2)

        setEnabled(Me.SplitContainer1.Panel2, True)

        Me.txtProductID.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If MessageBox.Show("Apakah Anda Ingin Keluar Dari Aplikasi ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub txtProductID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductID.KeyDown

        If checkError(e, Me.errorProvider, txtProductID, "Product ID Tidak Boleh Kosong") = False Then

            setEnter(e, txtProductName, txtProductID)

        Else

            Me.errorProvider.Clear()

            Me.txtProductID.Focus()

        End If

    End Sub

    Private Sub txtProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductName.KeyDown

        If checkError(e, Me.errorProvider, txtProductName, "Product Name Tidak Boleh Kosong") = False Then

            setEnter(e, Me.comboBoxProductGroup, txtProductID)

        Else

            Me.txtProductName.Focus()

        End If

    End Sub

    Private Sub comboBoxProductGroup_KeyDown(sender As Object, e As KeyEventArgs) Handles comboBoxProductGroup.KeyDown

        If checkError(e, Me.errorProvider, comboBoxProductGroup, "Product Group Tidak Boleh Kosong") = False Then

            setEnter(e, Me.txtPrice, txtProductName)

        Else

            Me.comboBoxProductGroup.Focus()

        End If

    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown

        If checkError(e, Me.errorProvider, txtPrice, "Price Tidak Boleh Kosong") = False Then

            setEnter(e, Me.btnAdd, txtPrice)

        Else

            Me.txtPrice.Focus()

        End If

    End Sub
End Class
