Public Class formJam

    'tick akan digunakan untuk menarik 60 tanda untuk setiap kedua pada jam
    Dim tick As Integer = 270

    'tick2 akan digunakan untuk menarik 12 tanda pada setiap jam pada jam
    Dim tick2 As Integer = 270

    Private Sub formJam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 900
        Me.Height = 600

        lbl1.Location = New Point(505, 203)
        lbl2.Location = New Point(561, 261)
        lbl3.Location = New Point(592, 335)
        lbl4.Location = New Point(561, 404)
        lbl5.Location = New Point(505, 464)
        lbl6.Location = New Point(430, 489)
        lbl7.Location = New Point(357, 463)
        lbl8.Location = New Point(305, 408)
        lbl9.Location = New Point(272, 334)
        lbl10.Location = New Point(302, 259)
        lbl11.Location = New Point(354, 200)
        lbl12.Location = New Point(430, 177)

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        'timer1 will draw the hands of the clock

        'convert seconds to angles
        Dim seconds As Integer = (Now.Second * 6) + 270

        'convert minutes to angles
        Dim minutes As Integer = (Now.Minute * 6) + 270

        'convert hours to angles
        Dim hours As Integer = (Now.Hour * 30) + 270

        'text lebel will hold the current time
        lblJam.Text = Format(Now, "dddd,dd-MM-yyyy HH:mm:ss")



        'creating graphics
        Dim g As Graphics
        g = Me.CreateGraphics

        'creating pens
        Dim hour As New Pen(Color.Blue)
        Dim hour2 As New Pen(Color.White)
        Dim second As New Pen(Color.Black)
        Dim minute As New Pen(Color.Red)
        Dim minute2 As New Pen(Color.White)

        Dim white As New Pen(Color.White)
        Dim circle As New Pen(Color.Black)

        'assigning pens width
        hour.Width = 8
        hour2.Width = 10
        second.Width = 1
        minute.Width = 4
        minute2.Width = 4
        white.Width = 10
        circle.Width = 5


        'drawing the hands of the clock and their locations
        g.DrawPie(hour2, 319, 219, 240, 240, hours - 30, 360)
        g.DrawPie(minute2, 289, 189, 300, 300, minutes - 6, 360)
        g.DrawPie(Pens.White, 269, 169, 340, 340, seconds - 6, 360)
        g.DrawPie(hour, 319, 219, 240, 240, hours, 360)
        g.DrawEllipse(white, 319, 219, 240, 240)
        g.DrawPie(minute, 289, 189, 300, 300, minutes, 360)
        g.DrawEllipse(white, 289, 189, 300, 300)
        g.DrawPie(second, 269, 169, 340, 340, seconds, 360)
        g.DrawEllipse(white, 269, 169, 340, 340)

        'draw a circle around the clock
        g.DrawEllipse(circle, 249, 149, 380, 380)


    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick

        'timer2 will draw the shape of the clock adn the marks

        tick += 6
        tick2 += 30

        Dim g As Graphics
        Dim hoursMarks As New Pen(Color.Black)

        hoursMarks.Width = 5

        g = Me.CreateGraphics


        g.DrawPie(Pens.Black, 249, 149, 380, 380, tick, 360)
        g.DrawPie(hoursMarks, 249, 149, 380, 380, tick2, 360)
        g.DrawEllipse(Pens.White, 269, 169, 340, 340)
        g.FillEllipse(Brushes.White, 269, 169, 340, 340)

        If tick > 800 Then

            'drawing the shape is done and the timer will stop
            timer2.Stop()

            tick = 270
            tick2 = 270

        End If

    End Sub
End Class
