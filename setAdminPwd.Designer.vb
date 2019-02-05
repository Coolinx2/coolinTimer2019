<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setAdminPwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setAdminPwd))
        Me.pwdlbl = New System.Windows.Forms.Label()
        Me.closeExitbtn = New System.Windows.Forms.Button()
        Me.currentPwdcheck = New System.Windows.Forms.TextBox()
        Me.setAdminPwdbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newPwdset = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'pwdlbl
        '
        Me.pwdlbl.AutoSize = True
        Me.pwdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdlbl.Location = New System.Drawing.Point(12, 9)
        Me.pwdlbl.Name = "pwdlbl"
        Me.pwdlbl.Size = New System.Drawing.Size(159, 24)
        Me.pwdlbl.TabIndex = 21
        Me.pwdlbl.Text = "Current Password"
        '
        'closeExitbtn
        '
        Me.closeExitbtn.BackColor = System.Drawing.Color.Aqua
        Me.closeExitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeExitbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closeExitbtn.Location = New System.Drawing.Point(12, 105)
        Me.closeExitbtn.Name = "closeExitbtn"
        Me.closeExitbtn.Size = New System.Drawing.Size(249, 54)
        Me.closeExitbtn.TabIndex = 20
        Me.closeExitbtn.Text = "Close and exit"
        Me.closeExitbtn.UseVisualStyleBackColor = False
        '
        'currentPwdcheck
        '
        Me.currentPwdcheck.Location = New System.Drawing.Point(189, 14)
        Me.currentPwdcheck.Name = "currentPwdcheck"
        Me.currentPwdcheck.Size = New System.Drawing.Size(382, 20)
        Me.currentPwdcheck.TabIndex = 19
        '
        'setAdminPwdbtn
        '
        Me.setAdminPwdbtn.BackColor = System.Drawing.Color.Red
        Me.setAdminPwdbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setAdminPwdbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.setAdminPwdbtn.Location = New System.Drawing.Point(292, 105)
        Me.setAdminPwdbtn.Name = "setAdminPwdbtn"
        Me.setAdminPwdbtn.Size = New System.Drawing.Size(279, 54)
        Me.setAdminPwdbtn.TabIndex = 18
        Me.setAdminPwdbtn.Text = "Set the new admin password"
        Me.setAdminPwdbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "New Password"
        '
        'newPwdset
        '
        Me.newPwdset.Location = New System.Drawing.Point(189, 79)
        Me.newPwdset.Name = "newPwdset"
        Me.newPwdset.Size = New System.Drawing.Size(382, 20)
        Me.newPwdset.TabIndex = 22
        '
        'setAdminPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 177)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newPwdset)
        Me.Controls.Add(Me.pwdlbl)
        Me.Controls.Add(Me.closeExitbtn)
        Me.Controls.Add(Me.currentPwdcheck)
        Me.Controls.Add(Me.setAdminPwdbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setAdminPwd"
        Me.Text = "Set the administrator password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pwdlbl As System.Windows.Forms.Label
    Friend WithEvents closeExitbtn As System.Windows.Forms.Button
    Friend WithEvents currentPwdcheck As System.Windows.Forms.TextBox
    Friend WithEvents setAdminPwdbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newPwdset As System.Windows.Forms.TextBox
End Class
