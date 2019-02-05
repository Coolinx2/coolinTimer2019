Public Class extendTime
    Private Sub submitBtn_Click_1(sender As Object, e As EventArgs) Handles submitBtn.Click
        'Reset the timer using password defined in test.txt local file.
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\CITS2\pwd\timerPwd.txt")
        If pwdBox.Text = fileReader Then
            mainForm.lblTimer.Text = "60"
            'pwdBox.Text = ""
            mainForm.lblTimer.ForeColor = System.Drawing.Color.Green

            Me.Dispose()
        Else
            pwdBox.Text = ""
            MessageBox.Show("Wrong password, only a member of staff can extend the time.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cancelBtn2_Click(sender As Object, e As EventArgs) Handles cancelBtn2.Click
        Me.Dispose()

    End Sub
End Class