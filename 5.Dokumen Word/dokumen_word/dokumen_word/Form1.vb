Public Class frmDokumenWord
    Private Sub frmDokumenWord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'BUAT UKURAN FONT

        Dim i As Integer = 6

        Me.comboBoxSize.Items.Clear()

        'looping for
        For i = 6 To 100
            Me.comboBoxSize.Items.Add(Trim(Str(i)))
        Next

        '-----------------------------------------------------------------------------------------

        'MENAMPILKAN FONT SYSTEM

        Dim installed_fonts As New Drawing.Text.InstalledFontCollection

        Me.comboBoxFont.Items.Clear()

        'looping for..each
        For Each font_family As FontFamily In installed_fonts.Families

            comboBoxFont.Items.Add(font_family.Name)

        Next font_family


        comboBoxSize.SelectedIndex = 0

    End Sub

    Private Sub comboBoxFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxFont.SelectedIndexChanged

        Dim mStyle As New System.Drawing.FontStyle

        Dim ukuran As Integer = 10


        'PENGKONDISIAN UNTUK CHECKBOX FONT
        If Me.checkBoxBold.Checked = True Then

            mStyle = mStyle + FontStyle.Bold
        End If

        If Me.checkBoxItalic.Checked = True Then

            mStyle = mStyle + FontStyle.Italic
        End If

        If Me.checkBoxUnderline.Checked = True Then

            mStyle = mStyle + FontStyle.Underline
        End If


        'PENGKONDISIAN UNTUK UKURAN DEFAULT FONT
        If Trim(comboBoxSize.Text) > "" Then

            ukuran = Val(comboBoxSize.Text)
        End If


        Dim fntFont As System.Drawing.Font = New Font(Me.comboBoxFont.Text, ukuran, mStyle, System.Drawing.GraphicsUnit.Point, 178, False)

        If comboBoxFont.Text > "" Then

            richTextBox.SelectionFont = fntFont
        End If

    End Sub

    Private Sub comboBoxSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSize.SelectedIndexChanged

        Call comboBoxFont_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub checkBoxBold_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxBold.CheckedChanged

        Call comboBoxFont_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub checkBoxItalic_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxItalic.CheckedChanged

        Call comboBoxFont_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub checkBoxUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxUnderline.CheckedChanged

        Call comboBoxFont_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        richTextBox.Copy()

    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click

        richTextBox.Paste()

    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click

        richTextBox.Cut()

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        richTextBox.SelectionAlignment = HorizontalAlignment.Left

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        richTextBox.SelectionAlignment = HorizontalAlignment.Right

    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click

        richTextBox.SelectionAlignment = HorizontalAlignment.Center

    End Sub

    Private Sub btnJustify_Click(sender As Object, e As EventArgs) Handles btnJustify.Click

        richTextBox.SelectionAlignment = HorizontalAlignment.Right + HorizontalAlignment.Left

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim mPath

        Me.SaveFileDialog.DefaultExt = "richTextFile"

        SaveFileDialog.ShowDialog()

        mPath = SaveFileDialog.FileName

        richTextBox.SaveFile(mPath)

        MessageBox.Show("Save Successful")

    End Sub

    Private Sub btnOpenDocument_Click(sender As Object, e As EventArgs) Handles btnOpenDocument.Click

        OpenFileDialog.DefaultExt = "richTextFile"

        OpenFileDialog.ShowDialog()

        richTextBox.LoadFile(OpenFileDialog.FileName)

    End Sub

    Private Sub btnFontColor_Click(sender As Object, e As EventArgs) Handles btnFontColor.Click

        ColorDialog.ShowDialog()

        richTextBox.SelectionColor = ColorDialog.Color

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class
