<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fiveLeft
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fiveLeft))
        Me.info10lbl = New System.Windows.Forms.Label()
        Me.tenLeftlbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'info10lbl
        '
        Me.info10lbl.AutoSize = True
        Me.info10lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info10lbl.Location = New System.Drawing.Point(141, 207)
        Me.info10lbl.Name = "info10lbl"
        Me.info10lbl.Size = New System.Drawing.Size(411, 25)
        Me.info10lbl.TabIndex = 11
        Me.info10lbl.Text = "You will need the password to extend the time."
        '
        'tenLeftlbl
        '
        Me.tenLeftlbl.AutoSize = True
        Me.tenLeftlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenLeftlbl.Location = New System.Drawing.Point(27, 17)
        Me.tenLeftlbl.Name = "tenLeftlbl"
        Me.tenLeftlbl.Size = New System.Drawing.Size(639, 138)
        Me.tenLeftlbl.TabIndex = 8
        Me.tenLeftlbl.Text = "You have 5 minutes left, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "there will not be another message. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please save your " & _
    "work."
        Me.tenLeftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(235, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 46)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Extend the time."
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(235, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "OK close this message"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'fiveLeft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 353)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.info10lbl)
        Me.Controls.Add(Me.tenLeftlbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fiveLeft"
        Me.Text = "Five Minutes left"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info10lbl As System.Windows.Forms.Label
    Friend WithEvents tenLeftlbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
