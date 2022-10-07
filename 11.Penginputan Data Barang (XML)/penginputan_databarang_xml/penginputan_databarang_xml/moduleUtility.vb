Module moduleUtility

    Public Sub clearControl(ByVal controls As Control)

        'DIPERGUNAKAN UNTUK MEMBERSIHKAN CONTROL TEXTBOX DAN COMBO PADA FORM

        Dim control As Control = Nothing

        For Each txt As Control In controls.Controls

            If TypeName(txt) = "TextBox" Then

                txt.Text = ""
            End If

            If TypeName(txt) = "ComboBox" Then

                txt.Text = ""
            End If

        Next

    End Sub


    Public Sub setEnabled(ByVal controls As Control, ByVal sValue As Boolean)

        'DIPERGUNAKAN UNTUK FUNGSI ENABLED CONTROL TEXTBOX & COMBOBOX PADA FORM

        Dim control As Control = Nothing

        For Each txt As Control In controls.Controls

            If TypeName(txt) = "TextBox" Then

                txt.Enabled = sValue
            End If

            If TypeName(txt) = "ComboBox" Then

                txt.Enabled = sValue
            End If

        Next

    End Sub

    Public Sub setEnter(ByVal control As System.Windows.Forms.KeyEventArgs, ByVal controlLostFocus As Control, ByVal controlGotFocus As Control)

        'EVENTS SAAT PENEKANAN TOMBOL ENTER PADA FORM

        'Pengkondisian dengan metode (If..ElseIf..End If)
        If control.KeyCode = Keys.Enter Then

            controlLostFocus.Focus()


        ElseIf control.KeyCode = Keys.Up Then

            controlGotFocus.Focus()


        ElseIf control.KeyCode = Keys.Down Then

            controlLostFocus.Focus()

        End If

    End Sub

    Public Function checkError(ByVal key As System.Windows.Forms.KeyEventArgs, ByVal sError As System.Windows.Forms.ErrorProvider, ByVal scontrol As Control, ByVal sValue As String) As Boolean

        'DIPERGUNAKAN UNTUK MENGECEK ERROR PENGISIAN PADA CONTROL FORM

        Dim sHasil As Boolean = False

        sError.Clear()


        'Pengkondisian dengan metode (If.. Then)

        If key.KeyCode = Keys.Enter Then

            If scontrol.Text = "" Then

                sError.SetError(scontrol, sValue)

                sHasil = True

            End If

        End If

        'Function harus selalu diakhir Return <variabel> pada akhir baris program Function
        Return checkError

    End Function

End Module
