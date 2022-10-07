<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUjiCobaProcedure
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
        Me.btnTestProcedureStandart = New System.Windows.Forms.Button()
        Me.lblUjiCobaStandarProcedure = New System.Windows.Forms.Label()
        Me.lblUjiCobaByValProcedure = New System.Windows.Forms.Label()
        Me.lblUjiCobaByRefProcedure = New System.Windows.Forms.Label()
        Me.btnTestProcedureByVal = New System.Windows.Forms.Button()
        Me.btnTestProcedureByRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTestProcedureStandart
        '
        Me.btnTestProcedureStandart.Location = New System.Drawing.Point(10, 37)
        Me.btnTestProcedureStandart.Name = "btnTestProcedureStandart"
        Me.btnTestProcedureStandart.Size = New System.Drawing.Size(199, 23)
        Me.btnTestProcedureStandart.TabIndex = 0
        Me.btnTestProcedureStandart.Text = "Test Procedure Standart"
        Me.btnTestProcedureStandart.UseVisualStyleBackColor = True
        '
        'lblUjiCobaStandarProcedure
        '
        Me.lblUjiCobaStandarProcedure.AutoSize = True
        Me.lblUjiCobaStandarProcedure.BackColor = System.Drawing.Color.Maroon
        Me.lblUjiCobaStandarProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUjiCobaStandarProcedure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUjiCobaStandarProcedure.Location = New System.Drawing.Point(9, 18)
        Me.lblUjiCobaStandarProcedure.Name = "lblUjiCobaStandarProcedure"
        Me.lblUjiCobaStandarProcedure.Size = New System.Drawing.Size(202, 16)
        Me.lblUjiCobaStandarProcedure.TabIndex = 3
        Me.lblUjiCobaStandarProcedure.Text = "Uji Coba Standar Procedure"
        '
        'lblUjiCobaByValProcedure
        '
        Me.lblUjiCobaByValProcedure.AutoSize = True
        Me.lblUjiCobaByValProcedure.BackColor = System.Drawing.Color.Maroon
        Me.lblUjiCobaByValProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUjiCobaByValProcedure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUjiCobaByValProcedure.Location = New System.Drawing.Point(7, 120)
        Me.lblUjiCobaByValProcedure.Name = "lblUjiCobaByValProcedure"
        Me.lblUjiCobaByValProcedure.Size = New System.Drawing.Size(230, 16)
        Me.lblUjiCobaByValProcedure.TabIndex = 4
        Me.lblUjiCobaByValProcedure.Text = "Uji Coba ByVal Pada Procedure"
        '
        'lblUjiCobaByRefProcedure
        '
        Me.lblUjiCobaByRefProcedure.AutoSize = True
        Me.lblUjiCobaByRefProcedure.BackColor = System.Drawing.Color.Maroon
        Me.lblUjiCobaByRefProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUjiCobaByRefProcedure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUjiCobaByRefProcedure.Location = New System.Drawing.Point(7, 217)
        Me.lblUjiCobaByRefProcedure.Name = "lblUjiCobaByRefProcedure"
        Me.lblUjiCobaByRefProcedure.Size = New System.Drawing.Size(231, 16)
        Me.lblUjiCobaByRefProcedure.TabIndex = 5
        Me.lblUjiCobaByRefProcedure.Text = "Uji Coba ByRef Pada Procedure"
        '
        'btnTestProcedureByVal
        '
        Me.btnTestProcedureByVal.Location = New System.Drawing.Point(10, 139)
        Me.btnTestProcedureByVal.Name = "btnTestProcedureByVal"
        Me.btnTestProcedureByVal.Size = New System.Drawing.Size(199, 23)
        Me.btnTestProcedureByVal.TabIndex = 6
        Me.btnTestProcedureByVal.Text = "Test Procedure ByVal"
        Me.btnTestProcedureByVal.UseVisualStyleBackColor = True
        '
        'btnTestProcedureByRef
        '
        Me.btnTestProcedureByRef.Location = New System.Drawing.Point(12, 236)
        Me.btnTestProcedureByRef.Name = "btnTestProcedureByRef"
        Me.btnTestProcedureByRef.Size = New System.Drawing.Size(199, 23)
        Me.btnTestProcedureByRef.TabIndex = 7
        Me.btnTestProcedureByRef.Text = "Test Procedure ByRef"
        Me.btnTestProcedureByRef.UseVisualStyleBackColor = True
        '
        'frmUjiCobaProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.lathian_procedure.My.Resources.Resources.deadpoll2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(275, 267)
        Me.Controls.Add(Me.btnTestProcedureByRef)
        Me.Controls.Add(Me.btnTestProcedureByVal)
        Me.Controls.Add(Me.lblUjiCobaByRefProcedure)
        Me.Controls.Add(Me.lblUjiCobaByValProcedure)
        Me.Controls.Add(Me.lblUjiCobaStandarProcedure)
        Me.Controls.Add(Me.btnTestProcedureStandart)
        Me.Name = "frmUjiCobaProcedure"
        Me.Text = "Form Uji Coba Procedure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTestProcedureStandart As Button
    Friend WithEvents lblUjiCobaStandarProcedure As Label
    Friend WithEvents lblUjiCobaByValProcedure As Label
    Friend WithEvents lblUjiCobaByRefProcedure As Label
    Friend WithEvents btnTestProcedureByVal As Button
    Friend WithEvents btnTestProcedureByRef As Button
End Class
