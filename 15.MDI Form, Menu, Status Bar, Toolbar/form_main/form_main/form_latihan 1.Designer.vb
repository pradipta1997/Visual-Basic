<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_latihan_1
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
        Me.lblTextFormLatihan1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTextFormLatihan1
        '
        Me.lblTextFormLatihan1.AutoSize = True
        Me.lblTextFormLatihan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFormLatihan1.Location = New System.Drawing.Point(219, 109)
        Me.lblTextFormLatihan1.Name = "lblTextFormLatihan1"
        Me.lblTextFormLatihan1.Size = New System.Drawing.Size(223, 25)
        Me.lblTextFormLatihan1.TabIndex = 0
        Me.lblTextFormLatihan1.Text = "Text Form Latihan 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_latihan_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(641, 329)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTextFormLatihan1)
        Me.DoubleBuffered = True
        Me.Name = "form_latihan_1"
        Me.Text = "Form Latihan 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTextFormLatihan1 As Label
    Friend WithEvents Button1 As Button
End Class
