Option Explicit On
Public Class frmDiggersShop
    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim ResizerForForm As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'code to show the current form...sdg
        Me.Show()
        'starts the splashscreen animation from the file in the given folder...sdg
        AxShockwaveFlash1.Movie = Application.StartupPath & "\swf\Digger.swf"
        AxShockwaveFlash1.Visible = False
        AxShockwaveFlash1.Playing = False
        AxShockwaveFlash1.ScaleMode = 2
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window...sdg
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        ' Me.WindowState = FormWindowState.Maximized
        'scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)
        'gets the pictures for the buttons in resources and resizes them to fit the new button sizes...sdg
        Dim DiggerInfo As New Bitmap(My.Resources.InfoTimber, cmdDiggerInfo.Width, cmdDiggerInfo.Height)
        Dim Back As New Bitmap(My.Resources.Back, cmdBack.Width, cmdBack.Height)
        Dim PlayGame As New Bitmap(My.Resources.PlayGame, cmdStartGame.Width, cmdStartGame.Height)
        'assigns the images to the correct buttons...sdg
        cmdDiggerInfo.Image = DiggerInfo
        cmdBack.Image = Back
        cmdStartGame.Image = PlayGame
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
            'exits the application by closing all windows instead of by using end so that there are no errors from having windows open...sdg
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
        'after the video is finished playing shows the start of the game button..sdg
        If AxShockwaveFlash1.CurrentFrame = AxShockwaveFlash1.TotalFrames - 1 Then
            If AxShockwaveFlash1.Playing = True Then
                cmdStartGame.Show()
                cmdStartGame.Focus()
            End If
            'if the movie is over stops it so it doesn't loop...sdg
            AxShockwaveFlash1.StopPlay()
        End If
        'sets the focus to the back button if the adobe shockwave file has focus so that user can continue to switch focus of the buttons with tab...sdg
        If AxShockwaveFlash1.Focused Then
            cmdBack.Focus()
        End If
    End Sub

    Private Sub cmdLearnMore_Click(sender As Object, e As EventArgs) Handles cmdDiggerInfo.Click
        'if the adobe shock wave object isn't visible then makes it visible...sdg
        If AxShockwaveFlash1.Visible <> True Then
            AxShockwaveFlash1.Left = 0 - AxShockwaveFlash1.Width
            AxShockwaveFlash1.Visible = True
            tmrAnimation.Start()
        End If


    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        'moves the adobe shockwave object onto the screen, if it is on the screen then starts playing the the video...sdg
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



    Private Sub cmdStartGame_Click(sender As Object, e As EventArgs) Handles cmdStartGame.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmCatchingGames.Show()
        frmCatchingGames.Opacity = 0
        frmCatchingGames.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmCatchingGames.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmCatchingGames.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    
End Class