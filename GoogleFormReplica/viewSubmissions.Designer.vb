<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmissions
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
        Label1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        txtStopwatch = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 21)
        Label1.TabIndex = 0
        Label1.Text = "Aalekh Prasad, Slidely Task 2 - View Submissons"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ActiveBorder
        txtName.Location = New Point(314, 94)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(301, 29)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ActiveBorder
        txtEmail.Location = New Point(314, 150)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(301, 29)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = SystemColors.ActiveBorder
        txtPhoneNumber.Location = New Point(314, 206)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(301, 29)
        txtPhoneNumber.TabIndex = 3
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.BackColor = SystemColors.ActiveBorder
        txtGitHubRepo.Location = New Point(314, 262)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.ReadOnly = True
        txtGitHubRepo.Size = New Size(301, 29)
        txtGitHubRepo.TabIndex = 4
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = SystemColors.ActiveBorder
        txtStopwatch.Location = New Point(314, 318)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(301, 29)
        txtStopwatch.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(185, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 8
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(185, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 42)
        Label5.TabIndex = 9
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(185, 318)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 42)
        Label6.TabIndex = 10
        Label6.Text = "Stopwatch" & vbCrLf & "   time" & vbCrLf
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Gold
        btnPrevious.Location = New Point(94, 422)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(278, 60)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(394, 422)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(278, 60)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' viewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 557)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "viewSubmissions"
        Text = "viewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
