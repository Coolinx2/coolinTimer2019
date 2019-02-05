<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setTimerValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setTimerValue))
        Me.currentValuelbl = New System.Windows.Forms.Label()
        Me.newValuelbl = New System.Windows.Forms.Label()
        Me.currentValue = New System.Windows.Forms.Label()
        Me.setTimerValuebtn = New System.Windows.Forms.Button()
        Me.currentPwdcheck = New System.Windows.Forms.TextBox()
        Me.closeExitbtn = New System.Windows.Forms.Button()
        Me.pwdlbl = New System.Windows.Forms.Label()
        Me.newValue = New System.Windows.Forms.NumericUpDown()
        CType(Me.newValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentValuelbl
        '
        Me.currentValuelbl.AutoSize = True
        Me.currentValuelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentValuelbl.Location = New System.Drawing.Point(12, 18)
        Me.currentValuelbl.Name = "currentValuelbl"
        Me.currentValuelbl.Size = New System.Drawing.Size(147, 24)
        Me.currentValuelbl.TabIndex = 0
        Me.currentValuelbl.Text = "Current Value = "
        '
        'newValuelbl
        '
        Me.newValuelbl.AutoSize = True
        Me.newValuelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newValuelbl.Location = New System.Drawing.Point(17, 72)
        Me.newValuelbl.Name = "newValuelbl"
        Me.newValuelbl.Size = New System.Drawing.Size(199, 24)
        Me.newValuelbl.TabIndex = 1
        Me.newValuelbl.Text = "New Value, in minutes"
        '
        'currentValue
        '
        Me.currentValue.AutoSize = True
        Me.currentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentValue.Location = New System.Drawing.Point(190, 18)
        Me.currentValue.Name = "currentValue"
        Me.currentValue.Size = New System.Drawing.Size(25, 24)
        Me.currentValue.TabIndex = 3
        Me.currentValue.Text = "..."
        '
        'setTimerValuebtn
        '
        Me.setTimerValuebtn.BackColor = System.Drawing.Color.Red
        Me.setTimerValuebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setTimerValuebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.setTimerValuebtn.Location = New System.Drawing.Point(276, 200)
        Me.setTimerValuebtn.Name = "setTimerValuebtn"
        Me.setTimerValuebtn.Size = New System.Drawing.Size(249, 54)
        Me.setTimerValuebtn.TabIndex = 4
        Me.setTimerValuebtn.Text = "Set the new timer value"
        Me.setTimerValuebtn.UseVisualStyleBackColor = False
        '
        'currentPwdcheck
        '
        Me.currentPwdcheck.Location = New System.Drawing.Point(194, 132)
        Me.currentPwdcheck.Name = "currentPwdcheck"
        Me.currentPwdcheck.Size = New System.Drawing.Size(331, 20)
        Me.currentPwdcheck.TabIndex = 11
        '
        'closeExitbtn
        '
        Me.closeExitbtn.BackColor = System.Drawing.Color.Aqua
        Me.closeExitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeExitbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closeExitbtn.Location = New System.Drawing.Point(21, 200)
        Me.closeExitbtn.Name = "closeExitbtn"
        Me.closeExitbtn.Size = New System.Drawing.Size(249, 54)
        Me.closeExitbtn.TabIndex = 12
        Me.closeExitbtn.Text = "Close and exit"
        Me.closeExitbtn.UseVisualStyleBackColor = False
        '
        'pwdlbl
        '
        Me.pwdlbl.AutoSize = True
        Me.pwdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdlbl.Location = New System.Drawing.Point(17, 127)
        Me.pwdlbl.Name = "pwdlbl"
        Me.pwdlbl.Size = New System.Drawing.Size(159, 24)
        Me.pwdlbl.TabIndex = 13
        Me.pwdlbl.Text = "Current Password"
        '
        'newValue
        '
        Me.newValue.Location = New System.Drawing.Point(222, 75)
        Me.newValue.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.newValue.Name = "newValue"
        Me.newValue.Size = New System.Drawing.Size(303, 20)
        Me.newValue.TabIndex = 14
        '
        'setTimerValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.newValue)
        Me.Controls.Add(Me.pwdlbl)
        Me.Controls.Add(Me.closeExitbtn)
        Me.Controls.Add(Me.currentPwdcheck)
        Me.Controls.Add(Me.setTimerValuebtn)
        Me.Controls.Add(Me.currentValue)
        Me.Controls.Add(Me.newValuelbl)
        Me.Controls.Add(Me.currentValuelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setTimerValue"
        Me.Text = "Set the Timer starting value"
        CType(Me.newValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents currentValuelbl As System.Windows.Forms.Label
    Friend WithEvents newValuelbl As System.Windows.Forms.Label
    Friend WithEvents currentValue As System.Windows.Forms.Label
    Friend WithEvents setTimerValuebtn As System.Windows.Forms.Button
    Friend WithEvents currentPwdcheck As System.Windows.Forms.TextBox
    Friend WithEvents closeExitbtn As System.Windows.Forms.Button
    Friend WithEvents pwdlbl As System.Windows.Forms.Label
    Friend WithEvents newValue As System.Windows.Forms.NumericUpDown
End Class
