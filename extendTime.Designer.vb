<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extendTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extendTime))
        Me.cancelBtn2 = New System.Windows.Forms.Button()
        Me.enterPwdlbl = New System.Windows.Forms.Label()
        Me.extendTimeLbl = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.pwdBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cancelBtn2
        '
        Me.cancelBtn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cancelBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn2.Location = New System.Drawing.Point(12, 103)
        Me.cancelBtn2.Name = "cancelBtn2"
        Me.cancelBtn2.Size = New System.Drawing.Size(140, 38)
        Me.cancelBtn2.TabIndex = 9
        Me.cancelBtn2.Text = "Cancel"
        Me.cancelBtn2.UseVisualStyleBackColor = False
        '
        'enterPwdlbl
        '
        Me.enterPwdlbl.AutoSize = True
        Me.enterPwdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterPwdlbl.Location = New System.Drawing.Point(8, 65)
        Me.enterPwdlbl.Name = "enterPwdlbl"
        Me.enterPwdlbl.Size = New System.Drawing.Size(275, 29)
        Me.enterPwdlbl.TabIndex = 8
        Me.enterPwdlbl.Text = "Enter the password here"
        '
        'extendTimeLbl
        '
        Me.extendTimeLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.extendTimeLbl.AutoSize = True
        Me.extendTimeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extendTimeLbl.Location = New System.Drawing.Point(8, 25)
        Me.extendTimeLbl.Name = "extendTimeLbl"
        Me.extendTimeLbl.Size = New System.Drawing.Size(450, 29)
        Me.extendTimeLbl.TabIndex = 7
        Me.extendTimeLbl.Text = "Please enter the administrator password."
        '
        'submitBtn
        '
        Me.submitBtn.BackColor = System.Drawing.Color.Lime
        Me.submitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.Location = New System.Drawing.Point(475, 103)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(140, 38)
        Me.submitBtn.TabIndex = 6
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = False
        '
        'pwdBox
        '
        Me.pwdBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdBox.Location = New System.Drawing.Point(289, 59)
        Me.pwdBox.Name = "pwdBox"
        Me.pwdBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdBox.Size = New System.Drawing.Size(331, 35)
        Me.pwdBox.TabIndex = 5
        Me.pwdBox.UseSystemPasswordChar = True
        '
        'extendTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancelBtn2)
        Me.Controls.Add(Me.enterPwdlbl)
        Me.Controls.Add(Me.extendTimeLbl)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.pwdBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "extendTime"
        Me.Text = "Extend the timer"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelBtn2 As System.Windows.Forms.Button
    Friend WithEvents enterPwdlbl As System.Windows.Forms.Label
    Friend WithEvents extendTimeLbl As System.Windows.Forms.Label
    Friend WithEvents submitBtn As System.Windows.Forms.Button
    Friend WithEvents pwdBox As System.Windows.Forms.TextBox
End Class
