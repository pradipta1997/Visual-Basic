<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMulai = New System.Windows.Forms.Label()
        Me.lblKeyboardControl = New System.Windows.Forms.Label()
        Me.lblArahKiri = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJudulScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pictPlayer = New System.Windows.Forms.PictureBox()
        Me.pictMusuh = New System.Windows.Forms.PictureBox()
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictMusuh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMulai
        '
        Me.lblMulai.AutoSize = True
        Me.lblMulai.BackColor = System.Drawing.Color.Gold
        Me.lblMulai.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulai.Location = New System.Drawing.Point(30, 168)
        Me.lblMulai.Name = "lblMulai"
        Me.lblMulai.Size = New System.Drawing.Size(76, 19)
        Me.lblMulai.TabIndex = 0
        Me.lblMulai.Text = "F2 : Mulai"
        '
        'lblKeyboardControl
        '
        Me.lblKeyboardControl.AutoSize = True
        Me.lblKeyboardControl.BackColor = System.Drawing.Color.Gold
        Me.lblKeyboardControl.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyboardControl.Location = New System.Drawing.Point(30, 115)
        Me.lblKeyboardControl.Name = "lblKeyboardControl"
        Me.lblKeyboardControl.Size = New System.Drawing.Size(143, 23)
        Me.lblKeyboardControl.TabIndex = 1
        Me.lblKeyboardControl.Text = "Keyboard Control"
        '
        'lblArahKiri
        '
        Me.lblArahKiri.AutoSize = True
        Me.lblArahKiri.BackColor = System.Drawing.Color.Gold
        Me.lblArahKiri.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArahKiri.Location = New System.Drawing.Point(30, 204)
        Me.lblArahKiri.Name = "lblArahKiri"
        Me.lblArahKiri.Size = New System.Drawing.Size(118, 19)
        Me.lblArahKiri.TabIndex = 2
        Me.lblArahKiri.Text = "LEFT : Arah Kiri"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RIGHT : Arah Kanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TOP : Arah Atas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DOWN : Arah Bawah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gold
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ESC : Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gold
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ENTER : Tembak"
        '
        'lblJudulScore
        '
        Me.lblJudulScore.AutoSize = True
        Me.lblJudulScore.BackColor = System.Drawing.Color.Gold
        Me.lblJudulScore.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulScore.Location = New System.Drawing.Point(30, 429)
        Me.lblJudulScore.Name = "lblJudulScore"
        Me.lblJudulScore.Size = New System.Drawing.Size(57, 19)
        Me.lblJudulScore.TabIndex = 8
        Me.lblJudulScore.Text = "Score :"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Gold
        Me.lblScore.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(104, 429)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(17, 19)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 20
        '
        'pictPlayer
        '
        Me.pictPlayer.BackColor = System.Drawing.Color.Gold
        Me.pictPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictPlayer.Image = Global.game.My.Resources.Resources.Logo_Batman
        Me.pictPlayer.Location = New System.Drawing.Point(295, 419)
        Me.pictPlayer.Name = "pictPlayer"
        Me.pictPlayer.Size = New System.Drawing.Size(45, 40)
        Me.pictPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictPlayer.TabIndex = 10
        Me.pictPlayer.TabStop = False
        '
        'pictMusuh
        '
        Me.pictMusuh.BackColor = System.Drawing.Color.Gold
        Me.pictMusuh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictMusuh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictMusuh.Image = Global.game.My.Resources.Resources.Logo_Joker
        Me.pictMusuh.Location = New System.Drawing.Point(604, 88)
        Me.pictMusuh.Name = "pictMusuh"
        Me.pictMusuh.Size = New System.Drawing.Size(45, 40)
        Me.pictMusuh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictMusuh.TabIndex = 11
        Me.pictMusuh.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.game.My.Resources.Resources.Template_Game_Visual_Basic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 479)
        Me.Controls.Add(Me.pictMusuh)
        Me.Controls.Add(Me.pictPlayer)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblJudulScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblArahKiri)
        Me.Controls.Add(Me.lblKeyboardControl)
        Me.Controls.Add(Me.lblMulai)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmGame"
        Me.Text = "Form Game"
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictMusuh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMulai As Label
    Friend WithEvents lblKeyboardControl As Label
    Friend WithEvents lblArahKiri As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJudulScore As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pictPlayer As PictureBox
    Friend WithEvents pictMusuh As PictureBox
End Class
