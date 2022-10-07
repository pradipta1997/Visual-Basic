<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenerapanArrayList
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
        Me.btnCheckArrayList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheckArrayList
        '
        Me.btnCheckArrayList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckArrayList.Location = New System.Drawing.Point(85, 66)
        Me.btnCheckArrayList.Name = "btnCheckArrayList"
        Me.btnCheckArrayList.Size = New System.Drawing.Size(154, 23)
        Me.btnCheckArrayList.TabIndex = 0
        Me.btnCheckArrayList.Text = "Check ArrayList"
        Me.btnCheckArrayList.UseVisualStyleBackColor = True
        '
        'frmPenerapanArrayList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(327, 159)
        Me.Controls.Add(Me.btnCheckArrayList)
        Me.Name = "frmPenerapanArrayList"
        Me.Text = "Forn Penerapan ArrayList"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheckArrayList As Button
End Class
