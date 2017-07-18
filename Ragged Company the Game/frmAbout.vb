Option Explicit On


Public Class frmAbout
    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim ResizerForForm As New Resizer
    'event for when the back button is pressed..sdg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmTheHouseMap.Show()
        frmTheHouseMap.Opacity = 0
        frmTheHouseMap.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmTheHouseMap.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTheHouseMap.Refresh()
        Next
        Me.Opacity = 1
        Me.Close()
    End Sub
    'event for when the exit buttoon is pressed..sdg
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit message box...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'exits the form using by closing all windows to prevent possible errors from not closing all the forms...sdg
            Application.Exit()
        End If
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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