<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.loggedInUsername = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StartTimelbl = New System.Windows.Forms.Button()
        Me.sessionStartTimelbl = New System.Windows.Forms.Button()
        Me.extendTimeBtn = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.minimise = New System.Windows.Forms.Button()
        Me.logOffBtn = New System.Windows.Forms.Button()
        Me.sendError = New System.Windows.Forms.Button()
        Me.YouHaveGb = New System.Windows.Forms.GroupBox()
        Me.timeMessageLbl = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.minsLeftLbl = New System.Windows.Forms.Label()
        Me.youHaveLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.logoffTimelbl = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.YouHaveGb.SuspendLayout()
        Me.SuspendLayout()
        '
        'loggedInUsername
        '
        Me.loggedInUsername.BackColor = System.Drawing.Color.AliceBlue
        Me.loggedInUsername.Font = New System.Drawing.Font("Lucida Console", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggedInUsername.Location = New System.Drawing.Point(251, 220)
        Me.loggedInUsername.Name = "loggedInUsername"
        Me.loggedInUsername.Size = New System.Drawing.Size(238, 34)
        Me.loggedInUsername.TabIndex = 29
        Me.loggedInUsername.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.AliceBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(11, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 34)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "User logged in :"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StartTimelbl
        '
        Me.StartTimelbl.BackColor = System.Drawing.Color.AliceBlue
        Me.StartTimelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTimelbl.Location = New System.Drawing.Point(251, 187)
        Me.StartTimelbl.Name = "StartTimelbl"
        Me.StartTimelbl.Size = New System.Drawing.Size(238, 27)
        Me.StartTimelbl.TabIndex = 27
        Me.StartTimelbl.UseVisualStyleBackColor = False
        '
        'sessionStartTimelbl
        '
        Me.sessionStartTimelbl.BackColor = System.Drawing.Color.AliceBlue
        Me.sessionStartTimelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionStartTimelbl.Location = New System.Drawing.Point(11, 187)
        Me.sessionStartTimelbl.Name = "sessionStartTimelbl"
        Me.sessionStartTimelbl.Size = New System.Drawing.Size(238, 27)
        Me.sessionStartTimelbl.TabIndex = 26
        Me.sessionStartTimelbl.Text = "Your session started at : "
        Me.sessionStartTimelbl.UseVisualStyleBackColor = False
        '
        'extendTimeBtn
        '
        Me.extendTimeBtn.BackColor = System.Drawing.Color.Cyan
        Me.extendTimeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extendTimeBtn.Location = New System.Drawing.Point(11, 154)
        Me.extendTimeBtn.Name = "extendTimeBtn"
        Me.extendTimeBtn.Size = New System.Drawing.Size(478, 27)
        Me.extendTimeBtn.TabIndex = 23
        Me.extendTimeBtn.Text = "Click Here To reset the timer to 60 minutes"
        Me.extendTimeBtn.UseVisualStyleBackColor = False
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.AliceBlue
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(140, 123)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(0, 20)
        Me.lblClock.TabIndex = 22
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(26, 123)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(0, 20)
        Me.Datelbl.TabIndex = 21
        '
        'minimise
        '
        Me.minimise.BackColor = System.Drawing.Color.SpringGreen
        Me.minimise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimise.Location = New System.Drawing.Point(251, 119)
        Me.minimise.Name = "minimise"
        Me.minimise.Size = New System.Drawing.Size(238, 29)
        Me.minimise.TabIndex = 20
        Me.minimise.Text = "Click Here To Minimise"
        Me.minimise.UseVisualStyleBackColor = False
        '
        'logOffBtn
        '
        Me.logOffBtn.BackColor = System.Drawing.Color.LightCoral
        Me.logOffBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.logOffBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOffBtn.Location = New System.Drawing.Point(251, 84)
        Me.logOffBtn.Name = "logOffBtn"
        Me.logOffBtn.Size = New System.Drawing.Size(238, 29)
        Me.logOffBtn.TabIndex = 19
        Me.logOffBtn.Text = "Click Here To Log Off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.logOffBtn.UseVisualStyleBackColor = False
        '
        'sendError
        '
        Me.sendError.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.sendError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendError.Location = New System.Drawing.Point(11, 84)
        Me.sendError.Name = "sendError"
        Me.sendError.Size = New System.Drawing.Size(238, 29)
        Me.sendError.TabIndex = 18
        Me.sendError.Text = "Click Here to access settings"
        Me.sendError.UseVisualStyleBackColor = False
        '
        'YouHaveGb
        '
        Me.YouHaveGb.BackColor = System.Drawing.Color.AliceBlue
        Me.YouHaveGb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.YouHaveGb.Controls.Add(Me.timeMessageLbl)
        Me.YouHaveGb.Controls.Add(Me.lblTimer)
        Me.YouHaveGb.Controls.Add(Me.minsLeftLbl)
        Me.YouHaveGb.Controls.Add(Me.youHaveLbl)
        Me.YouHaveGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YouHaveGb.Location = New System.Drawing.Point(12, 12)
        Me.YouHaveGb.Name = "YouHaveGb"
        Me.YouHaveGb.Size = New System.Drawing.Size(477, 66)
        Me.YouHaveGb.TabIndex = 17
        Me.YouHaveGb.TabStop = False
        '
        'timeMessageLbl
        '
        Me.timeMessageLbl.AutoSize = True
        Me.timeMessageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeMessageLbl.Location = New System.Drawing.Point(15, 40)
        Me.timeMessageLbl.Name = "timeMessageLbl"
        Me.timeMessageLbl.Size = New System.Drawing.Size(435, 17)
        Me.timeMessageLbl.TabIndex = 3
        Me.timeMessageLbl.Text = "To get more time please use the buttons below to extend for 1 hour."
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Green
        Me.lblTimer.Location = New System.Drawing.Point(193, 8)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(51, 36)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "60"
        '
        'minsLeftLbl
        '
        Me.minsLeftLbl.AutoSize = True
        Me.minsLeftLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minsLeftLbl.Location = New System.Drawing.Point(279, 15)
        Me.minsLeftLbl.Name = "minsLeftLbl"
        Me.minsLeftLbl.Size = New System.Drawing.Size(110, 24)
        Me.minsLeftLbl.TabIndex = 1
        Me.minsLeftLbl.Text = "Minutes Left"
        '
        'youHaveLbl
        '
        Me.youHaveLbl.AutoSize = True
        Me.youHaveLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.youHaveLbl.Location = New System.Drawing.Point(64, 16)
        Me.youHaveLbl.Name = "youHaveLbl"
        Me.youHaveLbl.Size = New System.Drawing.Size(93, 24)
        Me.youHaveLbl.TabIndex = 0
        Me.youHaveLbl.Text = "You Have"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 29)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = False
        '
        'logoffTimelbl
        '
        Me.logoffTimelbl.AutoSize = True
        Me.logoffTimelbl.Location = New System.Drawing.Point(208, 286)
        Me.logoffTimelbl.Name = "logoffTimelbl"
        Me.logoffTimelbl.Size = New System.Drawing.Size(39, 13)
        Me.logoffTimelbl.TabIndex = 30
        Me.logoffTimelbl.Text = "Label1"
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Enabled = True
        Me.tmrCountDown.Interval = 60000
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.logoffTimelbl)
        Me.Controls.Add(Me.loggedInUsername)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StartTimelbl)
        Me.Controls.Add(Me.sessionStartTimelbl)
        Me.Controls.Add(Me.extendTimeBtn)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.minimise)
        Me.Controls.Add(Me.logOffBtn)
        Me.Controls.Add(Me.sendError)
        Me.Controls.Add(Me.YouHaveGb)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Coolin Desktop Timer"
        Me.YouHaveGb.ResumeLayout(False)
        Me.YouHaveGb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loggedInUsername As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StartTimelbl As System.Windows.Forms.Button
    Friend WithEvents sessionStartTimelbl As System.Windows.Forms.Button
    Friend WithEvents extendTimeBtn As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents Datelbl As System.Windows.Forms.Label
    Friend WithEvents minimise As System.Windows.Forms.Button
    Friend WithEvents logOffBtn As System.Windows.Forms.Button
    Friend WithEvents sendError As System.Windows.Forms.Button
    Friend WithEvents YouHaveGb As System.Windows.Forms.GroupBox
    Friend WithEvents timeMessageLbl As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents minsLeftLbl As System.Windows.Forms.Label
    Friend WithEvents youHaveLbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents logoffTimelbl As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents tmrCountDown As System.Windows.Forms.Timer

End Class
