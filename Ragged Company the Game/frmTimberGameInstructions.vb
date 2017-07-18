Option Explicit On
Public Class frmTimberGameInstructions



    'creates a new class object for the resizer used to resize all elements of the form
    Dim ResizerForForm As New Resizer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'opens the exit message box...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'closes the application by closing all windows to prevent breaks that would caused with just doing end...sdg
            Application.Exit()
        End If
    End Sub
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmTimberGame.Show()
        frmTimberGame.Opacity = 0
        frmTimberGame.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmTimberGame.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTimberGame.Refresh()
        Next
        Me.Opacity = 1
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window this way instead of using maximize as to avoid annoying maximize animation...sdg
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        ' Me.WindowState = FormWindowState.Maximized
        'scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)
    End Sub
End Class
