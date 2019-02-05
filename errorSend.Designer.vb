<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorSend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorSend))
        Me.ReportErrors = New System.Windows.Forms.GroupBox()
        Me.emailFiller = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.TextBox()
        Me.problemDevice = New System.Windows.Forms.ListBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.sendErrorInsruct = New System.Windows.Forms.Label()
        Me.survetBtn = New System.Windows.Forms.Button()
        Me.clearForm = New System.Windows.Forms.Button()
        Me.sendEmail = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ReportErrors.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportErrors
        '
        Me.ReportErrors.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportErrors.Controls.Add(Me.emailFiller)
        Me.ReportErrors.Controls.Add(Me.Label5)
        Me.ReportErrors.Controls.Add(Me.Label4)
        Me.ReportErrors.Controls.Add(Me.email)
        Me.ReportErrors.Controls.Add(Me.username)
        Me.ReportErrors.Controls.Add(Me.Label3)
        Me.ReportErrors.Controls.Add(Me.message)
        Me.ReportErrors.Controls.Add(Me.problemDevice)
        Me.ReportErrors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportErrors.Location = New System.Drawing.Point(12, 121)
        Me.ReportErrors.Name = "ReportErrors"
        Me.ReportErrors.Size = New System.Drawing.Size(908, 201)
        Me.ReportErrors.TabIndex = 5
        Me.ReportErrors.TabStop = False
        '
        'emailFiller
        '
        Me.emailFiller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.emailFiller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailFiller.Location = New System.Drawing.Point(188, 140)
        Me.emailFiller.Name = "emailFiller"
        Me.emailFiller.Size = New System.Drawing.Size(335, 45)
        Me.emailFiller.TabIndex = 11
        Me.emailFiller.Text = "Click here if you don't have an email address"
        Me.emailFiller.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(185, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Your email address please"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Your name please"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(185, 108)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(338, 23)
        Me.email.TabIndex = 8
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(185, 43)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(338, 23)
        Me.username.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Please give as much detail as you can."
        '
        'message
        '
        Me.message.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.message.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message.Location = New System.Drawing.Point(529, 43)
        Me.message.Multiline = True
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(372, 142)
        Me.message.TabIndex = 1
        Me.message.Text = "Type anywhere within this box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'problemDevice
        '
        Me.problemDevice.BackColor = System.Drawing.Color.Coral
        Me.problemDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.problemDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.problemDevice.FormattingEnabled = True
        Me.problemDevice.Items.AddRange(New Object() {"SCROLL TO SELECT ISSUE", "----------------------------", "Installation", "Uninstallation", "Crashing", "---------------------", "Comment", "---------------------", "Suggestion", "---------------------", "Other applications", "---------------------", "General Query", "---------------------", "Anything else, please describe", "", ""})
        Me.problemDevice.Location = New System.Drawing.Point(7, 20)
        Me.problemDevice.Name = "problemDevice"
        Me.problemDevice.Size = New System.Drawing.Size(172, 171)
        Me.problemDevice.TabIndex = 0
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Aqua
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(266, 328)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(344, 77)
        Me.cancelBtn.TabIndex = 11
        Me.cancelBtn.Text = "Close and exit this form."
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'sendErrorInsruct
        '
        Me.sendErrorInsruct.AutoSize = True
        Me.sendErrorInsruct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sendErrorInsruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendErrorInsruct.Location = New System.Drawing.Point(15, 9)
        Me.sendErrorInsruct.Name = "sendErrorInsruct"
        Me.sendErrorInsruct.Size = New System.Drawing.Size(598, 100)
        Me.sendErrorInsruct.TabIndex = 9
        Me.sendErrorInsruct.Text = resources.GetString("sendErrorInsruct.Text")
        Me.sendErrorInsruct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'survetBtn
        '
        Me.survetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.survetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.survetBtn.Location = New System.Drawing.Point(618, 9)
        Me.survetBtn.Name = "survetBtn"
        Me.survetBtn.Size = New System.Drawing.Size(302, 100)
        Me.survetBtn.TabIndex = 12
        Me.survetBtn.Text = "Complete a Google survey"
        Me.survetBtn.UseVisualStyleBackColor = False
        '
        'clearForm
        '
        Me.clearForm.BackColor = System.Drawing.Color.Aqua
        Me.clearForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearForm.Location = New System.Drawing.Point(12, 328)
        Me.clearForm.Name = "clearForm"
        Me.clearForm.Size = New System.Drawing.Size(224, 77)
        Me.clearForm.TabIndex = 15
        Me.clearForm.Text = "Clear the form"
        Me.clearForm.UseVisualStyleBackColor = False
        '
        'sendEmail
        '
        Me.sendEmail.BackColor = System.Drawing.Color.LimeGreen
        Me.sendEmail.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendEmail.Location = New System.Drawing.Point(644, 328)
        Me.sendEmail.Name = "sendEmail"
        Me.sendEmail.Size = New System.Drawing.Size(276, 77)
        Me.sendEmail.TabIndex = 16
        Me.sendEmail.Text = "Send your message"
        Me.sendEmail.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 412)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(908, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'ErrorSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 448)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.sendEmail)
        Me.Controls.Add(Me.clearForm)
        Me.Controls.Add(Me.survetBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.sendErrorInsruct)
        Me.Controls.Add(Me.ReportErrors)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErrorSend"
        Me.Text = "Send a message to Coolin IT Services"
        Me.ReportErrors.ResumeLayout(False)
        Me.ReportErrors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportErrors As System.Windows.Forms.GroupBox
    Friend WithEvents emailFiller As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents message As System.Windows.Forms.TextBox
    Friend WithEvents problemDevice As System.Windows.Forms.ListBox
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents sendErrorInsruct As System.Windows.Forms.Label
    Friend WithEvents survetBtn As System.Windows.Forms.Button
    Friend WithEvents clearForm As System.Windows.Forms.Button
    Friend WithEvents sendEmail As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
