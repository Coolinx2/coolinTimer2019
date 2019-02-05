Public Class setTimerValue
    Private Sub setTimerValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentValue.Text = mainForm.lblTimer.Text
    End Sub

    Private Sub setTimerValuebtn_Click(sender As Object, e As EventArgs) Handles setTimerValuebtn.Click
        'Set a new timer value after correct password entered.
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\CITS2\pwd\timerPwd.txt")
        If currentPwdcheck.Text = fileReader Then
            mainForm.lblTimer.Text = newValue.Text
        Else
            MessageBox.Show("Wrong password, only an administrator can change the timer.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        settings.Close()
        Me.Close()
    End Sub

    Private Sub closeExitbtn_Click(sender As Object, e As EventArgs) Handles closeExitbtn.Click
        settings.Close()
        Me.Close()
    End Sub
End Class