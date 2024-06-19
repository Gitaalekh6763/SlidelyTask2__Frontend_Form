Public Class viewSubmissions
    Private currentIndex As Integer = 0
    Private Sub viewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySubmission(currentIndex)
    End Sub
    Private Sub DisplaySubmission(index As Integer)
        If SubmissionsList.Count > 0 AndAlso index >= 0 AndAlso index < SubmissionsList.Count Then
            Dim submission = SubmissionsList(index)
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhoneNumber.Text = submission.PhoneNumber
            lblGitHubRepo.Text = submission.GitHubRepo
            lblElapsedTime.Text = submission.ElapsedTime.ToString()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < SubmissionsList.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class