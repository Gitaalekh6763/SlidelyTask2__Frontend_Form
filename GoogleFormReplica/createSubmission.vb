Public Class createSubmission
    Private stopwatch As New Stopwatch()
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim submission As New Submission() With {
           .Name = txtName.Text,
           .Email = txtEmail.Text,
           .PhoneNumber = txtPhoneNumber.Text,
           .GitHubRepo = txtGitHubRepo.Text,
           .ElapsedTime = stopwatch.Elapsed
       }
        SubmissionsList.Add(submission)

        MessageBox.Show("Submission Saved!")
        Me.Close()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub
End Class