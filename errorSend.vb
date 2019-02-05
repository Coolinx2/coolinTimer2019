' Import the System mail functions
Imports System.Net.Mail
Public Class ErrorSend

    Private Sub emailFiller_Click(sender As Object, e As EventArgs) Handles emailFiller.Click
        email.Text = "contact@coolin.co.uk"
    End Sub


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Dispose()
        settings.Close()
    End Sub

    Private Sub survetBtn_Click(sender As Object, e As EventArgs) Handles survetBtn.Click
        'Open the Google survey in an Internet Explorer window on the desktop
        System.Diagnostics.Process.Start("iexplore.exe", "https://goo.gl/forms/h8LZpU1FtPat20Kz1")
    End Sub

    Private Sub sendEmail_Click(sender As Object, e As EventArgs) Handles sendEmail.Click

        Try
            Dim rng As New Random
            Dim number As Integer = rng.Next(1, 1000000000)
            Dim digits As String = number.ToString("D9")
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            ProgressBar1.Value = 10
            SmtpServer.Credentials = New  _
            Net.NetworkCredential("contact@coolin.co.uk", "pf!M998zx")
            SmtpServer.Port = 587
            SmtpServer.Host = "auth.smtp.1and1.co.uk"
            ' SEND form contents to Coolin IT Services
            mail = New MailMessage()
            mail.From = New MailAddress(email.Text)
            mail.To.Add("citserrorreports@coolin.co.uk")
            mail.Subject = "Error report ID number :- " & digits
            mail.Body = "Problem machine = " & problemDevice.Text & vbCrLf & "------------------------------------------------------" & vbCrLf & "Comments/description" & vbCrLf & ".............." & vbCrLf & message.Text
            SmtpServer.Send(mail)
            ' SEND confirmation email to user
            mail = New MailMessage()
            mail.From = New MailAddress("contact@coolin.co.uk")
            ProgressBar1.Value = 70
            mail.To.Add(email.Text)
            mail.Subject = "Error report ID number :- " & digits
            mail.Body = "We have received you email and will be in touch soon." & vbCrLf & "------------------------------------------------------" & vbCrLf & "Problem machine = " & problemDevice.Text & vbCrLf & "------------------------------------------------------" & vbCrLf & "Comments/description" & vbCrLf & ".............." & vbCrLf & message.Text
            SmtpServer.Send(mail)
            ProgressBar1.Value = 100
            MsgBox("The email has been sent and Coolin IT Services will be in touch soon if required. We aim to respond within 7 days.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        message.Text = "Message Was Sent."
        username.Text = ""
        email.Text = ""
        Me.Close()
        settings.Close()
    End Sub

    Private Sub clearForm_Click(sender As Object, e As EventArgs) Handles clearForm.Click
        message.Text = ""
        username.Text = ""
        email.Text = ""
    End Sub
End Class