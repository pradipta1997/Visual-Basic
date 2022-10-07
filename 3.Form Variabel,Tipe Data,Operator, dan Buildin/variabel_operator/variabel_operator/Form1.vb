Public Class frmVariabelOperatorBuildin
    Private Sub btnVarString_Click(sender As Object, e As EventArgs) Handles btnVarString.Click

        Dim sNama As String
        Dim sJurusan As String

        sNama = "Pradipta Ramadhan"
        sJurusan = "Informatika Komputer"

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add("Nama Saya: " + sNama)
        Me.isiBoxHasil.Items.Add("Jurusan: " + sJurusan)

    End Sub

    Private Sub btnVarNumeric_Click(sender As Object, e As EventArgs) Handles btnVarNumeric.Click

        Dim sGaji As Double
        Dim sTunjangan As Double
        Dim sPotongan As Double
        Dim sGajiBersih As Double

        sGaji = 3000000
        sTunjangan = 200000
        sPotongan = 100000

        sGajiBersih = (sGaji + sTunjangan) - sPotongan

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add("Gaji Bersih: " + sGajiBersih.ToString())

        'Setelah di Format

        Me.isiBoxHasil.Items.Add("Gaji Bersih: " + Format(sGajiBersih, "#,###,###"))

    End Sub

    Private Sub btnVarDate_Click(sender As Object, e As EventArgs) Handles btnVarDate.Click

        Dim sTanggalLahir As Date

        sTanggalLahir = "30/01/1997"

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add("Tanggal Lahir: " + sTanggalLahir.ToString())

        'Setelah di Format

        Me.isiBoxHasil.Items.Add("Tanggal Lahir: " + Format(sTanggalLahir, "dd-MM-yyyy"))

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) + Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "+" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) - Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "-" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) * Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "x" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) / Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "/" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnBagiInteger_Click(sender As Object, e As EventArgs) Handles btnBagiInteger.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) \ Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "\" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnPangkat_Click(sender As Object, e As EventArgs) Handles btnPangkat.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) ^ Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "^" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click

        Dim sHasil As Single

        sHasil = Val(Me.txtNilai1.Text) Mod Val(Me.txtNilai2.Text)

        Me.isiBoxHasil.Items.Clear()

        Me.isiBoxHasil.Items.Add(Me.txtNilai1.Text & "MOD" & Me.txtNilai2.Text & "=" & Convert.ToString(sHasil))


    End Sub

    Private Sub btnBuildinString_Click(sender As Object, e As EventArgs) Handles btnBuildinString.Click

        'MASUKAN ANGKA,BUKAN HURUF.KARENA TIPE DATA "SINGLE (UNTUK ANGKA)"

        Dim sNilai As Single = Me.txtKataBuildin.Text

        Me.txtHasilBuildin.Text = ""

        Me.txtHasilBuildin.Text = "Buildin String Convert: " & Convert.ToString(sNilai) & vbCrLf

        Me.txtHasilBuildin.Text &= "Buildin String Str: " & Str(sNilai) & vbCrLf

        Me.txtHasilBuildin.Text &= "Buildin String Parse: " & sNilai.ToString() & vbCrLf

    End Sub

    Private Sub btnBuildinNumeric_Click(sender As Object, e As EventArgs) Handles btnBuildinNumeric.Click

        'SETIAP ANGKA YANG KITA MASUKAN,MAKA AKAN DITAMBAHKAN +1

        Dim sKata As String = "001"

        Me.txtHasilBuildin.Text = ""

        Me.txtHasilBuildin.Text = Convert.ToUInt32(Me.txtKataBuildin.Text + Val(sKata)) & vbCrLf

        Me.txtHasilBuildin.Text &= Val(Me.txtKataBuildin.Text + Val(sKata)) & vbCrLf

    End Sub

    Private Sub btnBuildinDate_Click(sender As Object, e As EventArgs) Handles btnBuildinDate.Click

        Dim sTanggalLahir = "01/30/1997"

        Me.txtHasilBuildin.Text = ""

        Me.txtHasilBuildin.Text = "2 hari dari 01/30/1997 Tanggal: "

        DateAdd(DateInterval.Day, 2, Convert.ToDateTime(sTanggalLahir)).ToString()

    End Sub

    Private Sub btnBuildinArray_Click(sender As Object, e As EventArgs) Handles btnBuildinArray.Click

        'INPUTAN BISA BERUPA ANGKA & HURUF SEBANYAK JUMLAH ARRAY

        Dim sKata = Me.txtKataBuildin.Text

        sKata.ToArray()

        Me.txtHasilBuildin.Text = sKata(0).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(1).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(2).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(3).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(4).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(5).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(6).ToString & vbCrLf

        Me.txtHasilBuildin.Text &= sKata(7).ToString & vbCrLf


    End Sub

    Private Sub btnBuildinLeft_Click(sender As Object, e As EventArgs) Handles btnBuildinLeft.Click

        'AKAN DIAMBIL SEBANYAK 2 HURUF DARI KIRI,BISA DIRUBAH VALUE NYA PADA BARIS PROGRAM

        Me.txtHasilBuildin.Text = Microsoft.VisualBasic.Left(Me.txtKataBuildin.Text, 2)

    End Sub

    Private Sub btnBuildinRight_Click(sender As Object, e As EventArgs) Handles btnBuildinRight.Click

        'AKAN DIAMBIL SEBANYAK 2 HURUF DARI KANAN,BISA DIRUBAH VALUE NYA PADA BARIS PROGRAM

        Dim sKata As String

        sKata = InputBox("Masukan Kata :")

        Me.txtHasilBuildin.Text = Microsoft.VisualBasic.Right(sKata, 2)

    End Sub

    Private Sub btnBuildinMid_Click(sender As Object, e As EventArgs) Handles btnBuildinMid.Click

        'UNTUK PENGAMBILAN HURURF YANG BERADA DIANTARA,BISA DIRUBAH VALUE NYA PADA BARIS PROGRAM

        Dim sKata As String = Me.txtKataBuildin.Text

        MessageBox.Show(Microsoft.VisualBasic.Mid(sKata, 1, 2))

    End Sub

    Private Sub btnBuildinUpper_Click(sender As Object, e As EventArgs) Handles btnBuildinUpper.Click

        Me.txtHasilBuildin.Text = Me.txtKataBuildin.Text.ToUpper()

    End Sub

    Private Sub btnBuildinLower_Click(sender As Object, e As EventArgs) Handles btnBuildinLower.Click

        Me.txtHasilBuildin.Text = Me.txtKataBuildin.Text.ToLower()

    End Sub
End Class
