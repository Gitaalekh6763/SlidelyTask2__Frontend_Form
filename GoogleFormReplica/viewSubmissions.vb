Imports System.Net.Http
Imports Newtonsoft.Json

Public Class viewSubmissions

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub viewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions(currentIndex)
        DisplaySubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmissions(index As Integer) As Task
        Try
            Using client As New HttpClient()
                Dim url As String = $"http://localhost:3000/read?index={index}"
                Dim response = Await client.GetStringAsync(url)
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            txtName.Text = submissions(index).Name
            txtEmail.Text = submissions(index).Email
            txtPhoneNumber.Text = submissions(index).Phone
            txtGitHubRepo.Text = submissions(index).github_link
            txtStopwatch.Text = submissions(index).Stopwatch_time

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property github_link As String
    Public Property Stopwatch_time As String
End Class
