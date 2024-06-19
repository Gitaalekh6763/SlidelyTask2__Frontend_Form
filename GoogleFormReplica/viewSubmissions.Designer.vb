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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
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
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveBorder
        TextBox1.Location = New Point(314, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(301, 29)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveBorder
        TextBox2.Location = New Point(314, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(301, 29)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveBorder
        TextBox3.Location = New Point(314, 206)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(301, 29)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ActiveBorder
        TextBox4.Location = New Point(314, 262)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(301, 29)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ActiveBorder
        TextBox5.Location = New Point(314, 318)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(301, 29)
        TextBox5.TabIndex = 5
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
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "viewSubmissions"
        Text = "viewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
