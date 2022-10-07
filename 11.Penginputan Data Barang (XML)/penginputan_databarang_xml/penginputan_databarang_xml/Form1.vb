Imports System
Imports System.Data

Public Class frmPenginputanDataBarangXML

    Private fileXML As String = "../../data/products.xml"

    'Variabel untuk Add dan Edit
    Private isAddNew As Boolean

    Private Sub isiGrid()

        Try

            Dim ds As New DataSet
            'Dim dr As DataRow

            ds.ReadXml(fileXML)
            Me.dataGridView.DataSource = Nothing

            Me.dataGridView.DataSource = ds.Tables(0).DefaultView
            Me.dataGridView.Refresh()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub

        End Try

    End Sub
    Private Function cariData(ByVal sProduct As String) As Boolean

        Dim ds As New DataSet
        Dim dr As DataRowView
        Dim hasil As Boolean = False

        ds.ReadXml(fileXML)
        Dim dv As DataView = ds.Tables(0).DefaultView

        For Each dr In dv

            Dim sHasil As Integer = 0
            sHasil = InStr(sProduct, dr("productid"), CompareMethod.Text)


            If sHasil > 0 Then

                Me.txtProductID.Text = dr("productid")
                Me.txtProductName.Text = dr("productname")
                Me.comboBoxProductGroup.Text = dr("productgroup")
                Me.txtPrices.Text = dr("productprice")

                hasil = True

                Exit For

            End If

        Next

        Return hasil

    End Function
    Private Sub isiComboBox()

        Me.comboBoxProductGroup.Items.Clear()
        With Me.comboBoxProductGroup

            .Items.Add("ATK")
            .Items.Add("KOMPUTER")
            .Items.Add("ALAT KANTOR")

        End With

    End Sub

    Private Sub frmPenginputanDataBarangXML_Load(sender As Object, e As EventArgs) Handles Me.Load

        isiGrid()

        Call isiComboBox()

        isAddNew = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'PEMANGILAN PROCEDURE DARI FILE moduleUtility.vb
        isAddNew = True

        clearControl(Me.splitContainer.Panel2)

        setEnabled(Me.splitContainer.Panel2, True)

        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtProductID.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim ds As New DataSet
        Dim dRow As DataRow
        Dim vRow As DataRowView
        Dim pesan As String = ""

        If MessageBox.Show("Data Tersimpan", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            ds.ReadXml(fileXML)

            If isAddNew = True Then

                If cariData(Me.txtProductID.Text) = True Then

                    MsgBox("Data sudah ada, Isi kode lain", MsgBoxStyle.Critical)
                    Exit Sub

                End If


                dRow = ds.Tables(0).NewRow()

                dRow("productid") = Trim(Me.txtProductID.Text)
                dRow("productname") = Trim(Me.txtProductName.Text)
                dRow("productgroup") = Trim(Me.comboBoxProductGroup.Text)
                dRow("productprice") = Trim(Me.txtPrices.Text)

                ds.Tables(0).Rows.Add(dRow)

                pesan = "Penambahan Data Berhasil"


            Else

                Dim sDataView As DataView = ds.Tables(0).DefaultView

                For Each vRow In sDataView

                    Dim strRequestPath As String = Convert.ToString(vRow("productid")).ToLower()

                    If strRequestPath = Me.txtProductID.Text.ToLower() Then

                        vRow("productname") = Trim(Me.txtProductName.Text)
                        vRow("productgroup") = Trim(Me.comboBoxProductGroup.Text)
                        vRow("productprice") = Trim(Me.txtPrices.Text)

                        pesan = "Update Data Berhasil"

                        Exit For

                    End If

                Next

            End If

            ds.WriteXml(fileXML)

            Call isiGrid()
            MsgBox(pesan, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Penyimpanan Data")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Call btnAdd_Click(Nothing, Nothing)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cariData(Me.txtProductID.Text) = False Then

            MessageBox.Show("Data Tidak Ditemukan", "Data Seacrh", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.btnSave.Enabled = False
            Me.btnCancel.Enabled = False

            setEnabled(Me.splitContainer.Panel2, False)


        Else

            Me.btnSave.Enabled = True
            Me.btnCancel.Enabled = True

            setEnabled(Me.splitContainer.Panel2, True)

            Me.txtProductID.Enabled = False

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are you sure to exit App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

        End If
    End Sub

    Private Sub txtProductID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductID.KeyDown

        'BERFUNGSI UNTUK MENG-CHECK ERROR DAN SET ENTER
        If checkError(e, Me.errorProvider, txtProductID, "Product ID tidak boleh kosong") = False Then

            setEnter(e, txtProductName, txtProductID)

        Else

            Me.errorProvider.Clear()
            Me.txtProductID.Focus()

        End If

    End Sub

    Private Sub txtProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductName.KeyDown

        'BERFUNGSI UNTUK MENG-CHECK ERROR DAN SET ENTER
        If checkError(e, Me.errorProvider, txtProductName, "Product Name tidak boleh kosong") = False Then

            setEnter(e, Me.comboBoxProductGroup, txtProductID)

        Else

            Me.txtProductName.Focus()

        End If

    End Sub

    Private Sub comboBoxProductGroup_KeyDown(sender As Object, e As KeyEventArgs) Handles comboBoxProductGroup.KeyDown

        'BERFUNGSI UNTUK MENG-CHECK ERROR DAN SET ENTER
        If checkError(e, Me.errorProvider, comboBoxProductGroup, "Product Group tidak boleh kosong") = False Then

            setEnter(e, Me.txtPrices, txtProductName)

        Else

            Me.comboBoxProductGroup.Focus()

        End If

    End Sub

    Private Sub txtPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrices.KeyDown

        'BERFUNGSI UNTUK MENG-CHECK ERROR DAN SET ENTER
        If checkError(e, Me.errorProvider, txtPrices, "Prices tidak boleh kosong") = False Then

            setEnter(e, Me.btnAdd, comboBoxProductGroup)

        Else

            Me.txtPrices.Focus()

        End If

    End Sub

    Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick

        Dim pilih As String = ""
        Dim ds As New DataSet

        isAddNew = False

        Me.txtProductID.Text = Me.dataGridView.SelectedCells(0).Value

        Dim vRow As DataRowView

        ds.ReadXml(fileXML)

        Dim sDataView As DataView = ds.Tables(0).DefaultView


        For Each vRow In sDataView

            Dim strRequesPath As String = Convert.ToString(vRow("productid")).ToLower()

            If Me.txtProductID.Text.ToLower() = strRequesPath Then

                Me.txtProductID.Text = vRow("productid")
                Me.txtProductName.Text = vRow("productname")
                Me.comboBoxProductGroup.Text = vRow("productgroup")
                Me.txtPrices.Text = vRow("productprice")

                btnSave.Enabled = True
                btnCancel.Enabled = True

                setEnabled(Me.splitContainer.Panel2, True)

                Me.txtProductID.Enabled = False
                Me.txtProductName.Focus()

                Exit Sub

            End If

        Next

    End Sub
End Class
