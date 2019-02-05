Imports System.IO
Public Class setAdminPwd
    Private Sub setAdminPwdbtn_Click(sender As Object, e As EventArgs) Handles setAdminPwdbtn.Click
        'Set the administrator password
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\CITS2\pwd\timerPwd.txt")
        If currentPwdcheck.Text = fileReader Then
            If File.Exists("C:\CITS2\pwd\timerPwd.txt") Then
                Dim newPassword As String
                newPassword = newPwdset.Text
                Dim sWriter As New System.IO.StreamWriter("C:\CITS2\pwd\timerPwd.txt", False)
                sWriter.Write(newPassword)
                sWriter.Close()
            End If
            MessageBox.Show("The password has been reset", "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Incorrect current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub closeExitbtn_Click(sender As Object, e As EventArgs) Handles closeExitbtn.Click
        Me.Close()
    End Sub
End Class