'Student Name Taylor Everett
'StuId 21600252
'Date 26/05/2016
'Version 1.0.0

Public Class Form1
    'Values add for sprite to work with timer and scroll
    Dim moveright As Boolean = True
    Dim speed As Integer = 3
    'tells the Start button to continue the Timer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub
    ' timer is set to auto move the sprite right and to loop it back pass the form which is about 650
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If moveright = True Then
            picBox.Left = picBox.Left + speed
        End If
        If picBox.Left >= 700 Then picBox.Left = picBox.Left - 800
    End Sub
    'tells the timer to set to falsh making it stop working
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
    End Sub
    'ends the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    'lets the speed value of the timer change with the scroll bar
    Private Sub srcBar_Scroll(sender As Object, e As ScrollEventArgs) Handles srcBar.Scroll
        speed = srcBar.Value() / 10 + 1
    End Sub
    'Tells to the form to auto start the timer when app is first started
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'tells the submit button to look for a value in both txtboxs to produce a success msgbox
        If txtEmail.TextLength >= 1 And txtPhone.TextLength >= 1 Then
            MessageBox.Show("Success")
        End If
        'tells the submit button to produce a error msgbox if either or both txtboxs are missing info 
        If txtEmail.TextLength = 0 Or txtPhone.TextLength = 0 Then
            MessageBox.Show("Error")
        End If
    End Sub
End Class
