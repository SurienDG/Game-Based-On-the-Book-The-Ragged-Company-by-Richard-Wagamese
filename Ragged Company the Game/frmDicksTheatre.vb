Option Explicit On
Public Class frmDicksTheatre
    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim ResizerForForm As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'code to show the current form...sdg
        Me.Show()
        'starts the splashscreen animation from the file in the given folder...sdg
        AxShockwaveFlash1.Movie = Application.StartupPath & "\swf\DoubleDick.swf"
        AxShockwaveFlash1.Visible = False
        AxShockwaveFlash1.FrameNum = 15
        AxShockwaveFlash1.Playing = False
        AxShockwaveFlash1.ScaleMode = 2
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window...sdg
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        'scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)
        'gets the pictures for the buttons in resources and resizes them to fit the new button sizes...sdg
        Dim LearnMore As New Bitmap(My.Resources.LearnMore, cmdLearnMore.Width, cmdLearnMore.Height)
        Dim Back As New Bitmap(My.Resources.Back, cmdBack.Width, cmdBack.Height)
        'assigns the images to the correct buttons...sdg
        cmdLearnMore.Image = LearnMore
        cmdBack.Image = Back
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'if there is window resize scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form/messagebox...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'code to end the program rather than uses in end because it allows all the windows to be closed first as you not create...sdg
            'errors...sdg
            Application.Exit()
        End If
    End Sub


    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click

        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
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


 

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        'timer used to control the stopping of the adobe shockwave object..sdg
        If AxShockwaveFlash1.CurrentFrame = AxShockwaveFlash1.TotalFrames - 1 Then
            AxShockwaveFlash1.StopPlay()
        End If
        'if the adobe shockwave object has focus gives it back to the back button...sdg
        If AxShockwaveFlash1.Focused Then
            cmdBack.Focus()
        End If
    End Sub

    Private Sub cmdLearnMore_Click(sender As Object, e As EventArgs) Handles cmdLearnMore.Click
        'checks to see if the adobe shockwave object is not visible if it isn't then makes it visible and starts the timer that controls the animation...sdg
        If AxShockwaveFlash1.Visible <> True Then
            AxShockwaveFlash1.Left = 0 - AxShockwaveFlash1.Width
            AxShockwaveFlash1.Visible = True
            tmrAnimation.Start()
        End If



    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        'moves the adobe shockwave object into the correct position then once it is in the correct postion starts the video displayed by the object...sdg
        If AxShockwaveFlash1.Left < 0 Then
            AxShockwaveFlash1.Left += 10
        Else
            If AxShockwaveFlash1.Left <> 0 Then
                AxShockwaveFlash1.Left = 0
            End If
            AxShockwaveFlash1.Playing = True
            tmrAnimation.Stop()
        End If
    End Sub

End Class