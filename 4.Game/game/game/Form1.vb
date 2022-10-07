Public Class frmGame

    'Variabel_OffsetPoint DIPERGUNAKAN UNTUK POSISI MOUSE,PADA SAAT MENGGERAKAN FORM

    Private _OffsetPoint As Point

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.pictMusuh.Top = 70
        Me.pictMusuh.Left = 220
        Me.pictPlayer.Focus()

    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'EVENT FORM PADA SAAT TERJADINYA PENEKANAN TOMBOL DI KEYBOARD
        'PENGKONDISIAN DENGAN MENGGUNAKAN METODE (SELECT..CASE)

        Select Case e.KeyCode
            Case Keys.F2
                Me.Timer1.Enabled = True

            Case Keys.Left
                Me.pictPlayer.Left -= 10

            Case Keys.Right
                Me.pictPlayer.Left += 10

            Case Keys.Up
                Me.pictPlayer.Top -= 10

            Case Keys.Down
                Me.pictPlayer.Top += 10

            Case Keys.Return
                Me.Timer2.Enabled = True

            Case Keys.Escape
                Me.Close()

        End Select


        'PENGKONDISIAN DENGAN MENGGUNAKAN METODE (IF..THEN)

        If Me.pictPlayer.Location.X >= 600 Then
            Me.pictPlayer.Left = 600
        End If

        If Me.pictPlayer.Location.X <= 210 Then
            Me.pictPlayer.Left = 210
        End If

        If Me.pictPlayer.Location.Y >= 400 Then
            Me.pictPlayer.Top = 400
        End If

        If Me.pictPlayer.Location.Y <= 60 Then
            Me.pictPlayer.Top = 60
        End If

    End Sub

    Private Sub frmGame_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        'MouseDown DIPERGUNAKAN SAAT TERJADI PENEKANAN PADA TOMBOL MOUSE

        If (e.Button = MouseButtons.Left) Then

            Dim formBorderWidth As Integer = SystemInformation.FrameBorderSize.Width

            Dim formBorderHeight As Integer = SystemInformation.FrameBorderSize.Height
            _OffsetPoint = New Point(-(e.X + formBorderWidth), -(e.Y + formBorderHeight))

        End If

    End Sub

    Private Sub frmGame_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If (e.Button = MouseButtons.Left) Then

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(_OffsetPoint.X, _OffsetPoint.Y)
            Location = mousePos

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim random As New Random()
        pictMusuh.Left = random.Next(200, 600)

        If pictMusuh.Top = Me.pictPlayer.Top Then

            lblScore.Text = Val(lblScore.Text) + 1

            MessageBox.Show("Joker is Dead!", "Pop-up Box")

            Me.Timer1.Enabled = False

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Me.pictPlayer.Location.Y <= 70 Then

            pictPlayer.Visible = False

            Me.pictPlayer.Top = 400

            System.Threading.Thread.Sleep(100)

            Me.pictPlayer.Visible = True

            Me.Timer2.Enabled = False

        End If

        Me.pictPlayer.Top -= 10

    End Sub
End Class
