Imports System.IO

Public Class mainForm
    ' Load Main Form and show the Accept rules form, also show the date
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'acceptMsg.Show()
        Datelbl.Text = Date.Now.ToString("dd/MM/yyyy")
        'Log each logon to local location, save date and time in text file.
        StartTimelbl.Text = TimeString
        loggedInUsername.Text = Environment.UserName
        loggedInUsername.ForeColor = System.Drawing.Color.Red
        My.Computer.FileSystem.CreateDirectory("C:\CITS2\logging\")
        My.Computer.FileSystem.CreateDirectory("C:\CITS2\pwd\")
        'Set the password one time on first start
        Dim pwdFile As String = String.Format("C:\CITS2\pwd\timerPwd.txt")
        If File.Exists("C:\CITS2\pwd\timerPwd.txt") Then
        Else
            File.AppendAllText(pwdFile, String.Format("Pa$$w0rd"))
        End If
        Dim getUsername As String = (Environ$("Username"))
        Dim machineName As String = Environment.MachineName
        'Create file and log logon time and machine name
        Dim strFile As String = String.Format("C:\CITS2\logging\LogonLog_{0}{1}.txt", DateTime.Today.ToString("dd-MMM-yyyy"), getUsername, " - ", machineName)
        File.AppendAllText(strFile, String.Format("User logged in at -- {0}{1}{2}{3}{4}", StartTimelbl.Text, " - ", " on ", machineName, Environment.NewLine))

    End Sub

    'Start the timer countdown and show count-down
    Private Sub tmrCountDown_Tick(sender As Object, e As EventArgs) Handles tmrCountDown.Tick
        'Timer warning message boxes prompt at 10 and 5 mins left of 1 hour.
        Dim a As Integer
        Dim b As Integer
        a = lblTimer.Text
        b = 1
        lblTimer.Text = a - b
        If lblTimer.Text = "10" Then
            lblTimer.ForeColor = System.Drawing.Color.Red
            tenLeft.Show()
        End If
        If lblTimer.Text = "5" Then
            fiveLeft.Show()
        End If
        'Shutdown /l (logoff) if Timer lbl shows as less than 0
        If lblTimer.Text = "0" Or lblTimer.Text <= "0" Then
            Process.Start("Shutdown", "-L")
            Dim getUsername As String = (Environ$("Username"))
            Dim machineName As String = Environment.MachineName

            logoffTimelbl.Text = TimeString
            'Create file and log logoff time
            Dim strFile As String = String.Format("C:\CITS2\logging\LogoffLog_{0}{1}.txt", DateTime.Today.ToString("dd-MMM-yyyy"), getUsername, " - ", machineName)
            File.AppendAllText(strFile, String.Format("User logged off at -- {0}{1}{2}{3}{4}", logoffTimelbl.Text, " - ", " on ", machineName, Environment.NewLine))
            'Then Process.Start("Shutdown", "-L")
        End If
        ' Check if 1 hour has passed to account for PC sleeping and timer going past 0 to minus time
        'if timestart = timestart plus 1 hour then
        'If lblTimer.Text <= -1 Then
        'Process.Start("Shutdown", "-L")
        'MsgBox("Time is less than 0")
        'End If
    End Sub
    ' Minimise the Main Form window
    Private Sub minimise_Click(sender As Object, e As EventArgs) Handles minimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ' Not in use -- image button to website for assistance & contact details
    Private Sub CoolinITServices_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = "http://coolin.co.uk"
        Process.Start(webAddress)
    End Sub

    Private Sub logOffBtn_Click(sender As Object, e As EventArgs) Handles logOffBtn.Click
        'Log off on button click
        Process.Start("Shutdown", "-L")
    End Sub

    Private Sub senderror_Click(sender As Object, e As EventArgs) Handles sendError.Click
        'Send an error report
        settings.Show()
    End Sub

    Private Sub extendTimeBtn_Click(sender As Object, e As EventArgs) Handles extendTimeBtn.Click
        'Extend the timer using locally sourced password text file
        extendTime.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = TimeOfDay
    End Sub

End Class
