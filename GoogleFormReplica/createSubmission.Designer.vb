<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createSubmission
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
        btnNext = New Button()
        btnPrevious = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtGitHubRepo = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label1 = New Label()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(160, 446)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(476, 60)
        btnNext.TabIndex = 25
        btnNext.Text = "SUBMIT (CTRL + S)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Gold
        btnPrevious.Location = New Point(172, 377)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(261, 43)
        btnPrevious.TabIndex = 24
        btnPrevious.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(174, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 42)
        Label5.TabIndex = 22
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(174, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 21
        Label4.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(174, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 20
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 19
        Label2.Text = "Name"
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.BackColor = SystemColors.ButtonHighlight
        txtGitHubRepo.Location = New Point(303, 291)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(301, 29)
        txtGitHubRepo.TabIndex = 17
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = SystemColors.ButtonHighlight
        txtPhoneNumber.Location = New Point(303, 235)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(301, 29)
        txtPhoneNumber.TabIndex = 16
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonHighlight
        txtEmail.Location = New Point(303, 179)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(301, 29)
        txtEmail.TabIndex = 15
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ButtonHighlight
        txtName.Location = New Point(303, 123)
        txtName.Name = "txtName"
        txtName.Size = New Size(301, 29)
        txtName.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(205, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 21)
        Label1.TabIndex = 13
        Label1.Text = "Aalekh Prasad, Slidely Task 2 - Create Submisson"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ActiveBorder
        TextBox5.Location = New Point(439, 385)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(137, 29)
        TextBox5.TabIndex = 26
        ' 
        ' createSubmission
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 662)
        Controls.Add(TextBox5)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "createSubmission"
        Text = "createSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
