<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.settingslbl = New System.Windows.Forms.Label()
        Me.changeValueBtn = New System.Windows.Forms.Button()
        Me.changePasswordBtn = New System.Windows.Forms.Button()
        Me.changeValuelbl = New System.Windows.Forms.Label()
        Me.changePasswordlbl = New System.Windows.Forms.Label()
        Me.sendMessage = New System.Windows.Forms.Label()
        Me.sendMsgBtn = New System.Windows.Forms.Button()
        Me.closeExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'settingslbl
        '
        Me.settingslbl.AutoSize = True
        Me.settingslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingslbl.Location = New System.Drawing.Point(9, 9)
        Me.settingslbl.Name = "settingslbl"
        Me.settingslbl.Size = New System.Drawing.Size(694, 48)
        Me.settingslbl.TabIndex = 0
        Me.settingslbl.Text = "Please use the form below to change the timers settings, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to change the password" & _
    " you will need to know the current administrator password."
        '
        'changeValueBtn
        '
        Me.changeValueBtn.BackColor = System.Drawing.Color.Orchid
        Me.changeValueBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeValueBtn.Location = New System.Drawing.Point(286, 128)
        Me.changeValueBtn.Name = "changeValueBtn"
        Me.changeValueBtn.Size = New System.Drawing.Size(417, 46)
        Me.changeValueBtn.TabIndex = 1
        Me.changeValueBtn.Text = "Set a new timer starting value"
        Me.changeValueBtn.UseVisualStyleBackColor = False
        '
        'changePasswordBtn
        '
        Me.changePasswordBtn.BackColor = System.Drawing.Color.Crimson
        Me.changePasswordBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changePasswordBtn.Location = New System.Drawing.Point(324, 76)
        Me.changePasswordBtn.Name = "changePasswordBtn"
        Me.changePasswordBtn.Size = New System.Drawing.Size(379, 46)
        Me.changePasswordBtn.TabIndex = 2
        Me.changePasswordBtn.Text = "Change the admin password"
        Me.changePasswordBtn.UseVisualStyleBackColor = False
        '
        'changeValuelbl
        '
        Me.changeValuelbl.AutoSize = True
        Me.changeValuelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeValuelbl.Location = New System.Drawing.Point(13, 139)
        Me.changeValuelbl.Name = "changeValuelbl"
        Me.changeValuelbl.Size = New System.Drawing.Size(268, 24)
        Me.changeValuelbl.TabIndex = 4
        Me.changeValuelbl.Text = "Change the timer starting value"
        '
        'changePasswordlbl
        '
        Me.changePasswordlbl.AutoSize = True
        Me.changePasswordlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changePasswordlbl.Location = New System.Drawing.Point(9, 87)
        Me.changePasswordlbl.Name = "changePasswordlbl"
        Me.changePasswordlbl.Size = New System.Drawing.Size(305, 24)
        Me.changePasswordlbl.TabIndex = 5
        Me.changePasswordlbl.Text = "Change the administrator password"
        '
        'sendMessage
        '
        Me.sendMessage.AutoSize = True
        Me.sendMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendMessage.Location = New System.Drawing.Point(12, 191)
        Me.sendMessage.Name = "sendMessage"
        Me.sendMessage.Size = New System.Drawing.Size(231, 24)
        Me.sendMessage.TabIndex = 7
        Me.sendMessage.Text = "Send a message to Coolin"
        '
        'sendMsgBtn
        '
        Me.sendMsgBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.sendMsgBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendMsgBtn.Location = New System.Drawing.Point(250, 180)
        Me.sendMsgBtn.Name = "sendMsgBtn"
        Me.sendMsgBtn.Size = New System.Drawing.Size(453, 46)
        Me.sendMsgBtn.TabIndex = 6
        Me.sendMsgBtn.Text = "Send a message"
        Me.sendMsgBtn.UseVisualStyleBackColor = False
        '
        'closeExitBtn
        '
        Me.closeExitBtn.BackColor = System.Drawing.Color.Gray
        Me.closeExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeExitBtn.Location = New System.Drawing.Point(17, 242)
        Me.closeExitBtn.Name = "closeExitBtn"
        Me.closeExitBtn.Size = New System.Drawing.Size(686, 46)
        Me.closeExitBtn.TabIndex = 10
        Me.closeExitBtn.Text = "Close this window"
        Me.closeExitBtn.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeExitBtn)
        Me.Controls.Add(Me.sendMessage)
        Me.Controls.Add(Me.sendMsgBtn)
        Me.Controls.Add(Me.changePasswordlbl)
        Me.Controls.Add(Me.changeValuelbl)
        Me.Controls.Add(Me.changePasswordBtn)
        Me.Controls.Add(Me.changeValueBtn)
        Me.Controls.Add(Me.settingslbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents settingslbl As System.Windows.Forms.Label
    Friend WithEvents changeValueBtn As System.Windows.Forms.Button
    Friend WithEvents changePasswordBtn As System.Windows.Forms.Button
    Friend WithEvents changeValuelbl As System.Windows.Forms.Label
    Friend WithEvents changePasswordlbl As System.Windows.Forms.Label
    Friend WithEvents sendMessage As System.Windows.Forms.Label
    Friend WithEvents sendMsgBtn As System.Windows.Forms.Button
    Friend WithEvents closeExitBtn As System.Windows.Forms.Button
End Class
