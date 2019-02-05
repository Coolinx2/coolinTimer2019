Public Class settings


    Private Sub sendMsgBtn_Click(sender As Object, e As EventArgs) Handles sendMsgBtn.Click
        ErrorSend.Show()
    End Sub

    Private Sub closeExitBtn_Click(sender As Object, e As EventArgs) Handles closeExitBtn.Click
        Me.Close()
    End Sub

    Private Sub changeValueBtn_Click(sender As Object, e As EventArgs) Handles changeValueBtn.Click
        setTimerValue.Show()
    End Sub

    Private Sub changePasswordBtn_Click(sender As Object, e As EventArgs) Handles changePasswordBtn.Click
        setAdminPwd.show()
    End Sub
End Class