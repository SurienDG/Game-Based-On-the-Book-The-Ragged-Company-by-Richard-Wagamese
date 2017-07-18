Option Explicit On
Public Class frmHomeScreen
    'creates object to use for resizing the form controls...sdg
    Dim WindowResizer As New Resizer

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'if hasn't reached the final stage of the splash allows the user a chance to skip if they press a key...sdg
        If AxShockwaveFlash1.CurrentFrame <> AxShockwaveFlash1.TotalFrames - 30 Then
            Dim Response As Byte = MsgBox("Are you sure you want to skip?", 20, "Skip")
            If Response = 6 Then
                AxShockwaveFlash1.FrameNum = AxShockwaveFlash1.TotalFrames - 30
            End If
        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Show()
        'enables the timer...sdg
        tmrMain.Enabled = True
        'plays the intro music
        My.Computer.Audio.Play(My.Resources.Mathieu_Lamontagne__Emmanuel_Toledo___10___Intermde,
        AudioPlayMode.BackgroundLoop)
        'starts the splashscreen animation from the file in the given folder...sdg
        AxShockwaveFlash1.Movie = Application.StartupPath & "\Intro.swf"
        'sets the scale mode so the video fits the screen...sdg
        AxShockwaveFlash1.ScaleMode = 2
        'gets the current dimensions of all the controls...sdg
        WindowResizer.FindAllControls(Me)
        'makes the screen full screen, it is done this way so that the maximize animation doesn't disrupt the opacity animation
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        'scales all controls to fit the new dimension...sdg
        WindowResizer.ResizeAllControls(Me)
        'variable with scaled image so that it fits the enter house button...sdg
        Dim EnterTheHouse As New Bitmap(My.Resources.EnterHouse, cmdEnterHouse.Width, cmdEnterHouse.Height)
        'assigns the image to the enter house button...sdg
        cmdEnterHouse.Image = EnterTheHouse
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'checks to see if form is resized if it scales all controls and their positions...sdg
        WindowResizer.ResizeAllControls(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        'stops the animation and allows the user to move on when the frames are over...sdg
        If AxShockwaveFlash1.CurrentFrame = AxShockwaveFlash1.TotalFrames - 30 Then
            AxShockwaveFlash1.StopPlay()
            cmdEnterHouse.Show()
            cmdEnterHouse.Focus()
            ptcPressAnyKey.Hide()
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'exits the application closing all windows is an alternative to end that is
            'better because it closes all windows before exiting to prevent errors...sdg
            Application.Exit()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEnterHouse.Click
        'good transition to next form through the use of forms fading in and out...sdg
        frmTheHouseMap.Show()
        frmTheHouseMap.Opacity = 0
        frmTheHouseMap.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmTheHouseMap.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTheHouseMap.Refresh()

        Next
        'stops the audio and hides current form...sdg
        My.Computer.Audio.Stop()
        Me.Opacity = 1
        Me.Hide()
    End Sub

End Class