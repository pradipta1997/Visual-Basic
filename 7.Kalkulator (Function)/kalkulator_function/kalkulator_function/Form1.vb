Public Class frmKalkulatorFunction

    'Function untuk menghitung hasil sesuai dengan operator yang dipilih.
    'Parameter op adalah parameter inputan untuk operator (+,-,*,/,^,MOD).
    'Parameter n1 adalah parameter inputan untuk Nilai/Angka 0-9.
    'Parameter n2 adalah parameter inputan untuk Nilai/Angka 0-9.


    'CONTOH PEMANGGILAN
    'call lihatHasil("+",1,2).

    'Maksudnya adalah pemanggilan fungsi (lihatHasil) dengan memasukan_
    'parameter (+) dan inputan (1) untuk parameter (n1) dan inputan (2)_
    'untuk parameter (n2), jika diuraikan sebagai berikut (1+2).


    Function lihatHasil(ByVal op As String, ByVal n1 As Double, ByVal n2 As Double) As Double

        'Saat kita menggunakan Function maka harus ada Return<variabel> diakhir baris program Function.

        Dim hasil As Double

        Select Case Trim(op)

            Case "+"
                hasil = n1 + n2

            Case "-"
                hasil = n1 - n2

            Case "*"
                hasil = n1 * n2

            Case "/"
                hasil = n1 / n2

            Case "^"
                hasil = n1 ^ n2

            Case "MOD"
                hasil = n1 Mod n2

        End Select

        Return hasil

    End Function

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click

        textBoxHasil.Text = lihatHasil(Me.comboBoxOperator.Text, Val(textBoxNilai1.Text), Val(textBoxNilai2.Text))

    End Sub
End Class
