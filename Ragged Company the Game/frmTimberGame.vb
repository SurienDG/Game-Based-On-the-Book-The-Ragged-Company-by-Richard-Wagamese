Option Explicit On
Public Class frmTimberGame
    'variable to store the locations of the videos that will be played...sdg
    Dim Images() As String = {"\swf\TimberGame\Plane.swf", "\swf\TimberGame\Truck.swf", "\swf\TimberGame\House.swf", "\swf\TimberGame\FerrisWheel.swf", "\swf\TimberGame\BaseBallBat.swf", "\swf\TimberGame\Beer.swf", "\swf\TimberGame\Fish.swf"}
    'variable to store whether an image has been used already...sdg
    Dim Used(Images.Length) As Boolean
    'variables to store the currents words and letters...sdg
    Dim Letter As Char = "0"
    Dim Word As String
    Dim Words() As String = {"Plane", "Truck", "House", "Ferris Wheel", "Bat", "Beer", "Fish"}
    Dim Counter As Byte = 0
    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim ResizerForForm As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initializes all the used variables as false...sdg
        For counter As Byte = 0 To Used.Length - 1
            Used(counter) = False
        Next
        'code to show the current form...sdg
        Me.Show()
        'randomizes the variable...sdg
        Randomize()
        'creates a random variable to choose which item the user gets to guess...sdg
        Dim Random As Byte = Math.Round(Rnd() * (Images.Length - 1))
        Used(Random) = True
        AxShockwaveFlash1.Movie = Application.StartupPath & Images(Random)
        Letter = Images(Random)(16)
        Word = Words(Random)
        'makes the adobe shockwave object visible...sdg
        AxShockwaveFlash1.Visible = True
        AxShockwaveFlash1.Playing = False
        AxShockwaveFlash1.ScaleMode = 2
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window this way instead of using the maximize animation...sdg
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        'scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)

    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'assigns the images to the correct buttons...sdg
        ResizerForForm.ResizeAllControls(Me)
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'uses this to exit the program rather then end because this prevents breaks due to not closing all windows properly...sdg
            Application.Exit()
        End If
    End Sub
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmTimberWorkshop.Show()
        frmTimberWorkshop.Opacity = 0
        frmTimberWorkshop.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmTimberWorkshop.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTimberWorkshop.Refresh()

        Next
        Me.Opacity = 1
        Me.Close()
    End Sub



    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        'allows the level to start and lets the user enter input if the start button is pressed...sdg
        cmdConfirm.Enabled = True
        cmdStart.Enabled = False
        AxShockwaveFlash1.Play()
        cmdConfirm.Focus()
        tmrAnimation.Start()
        lblStartsWithValue.Text = Letter
    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        'if the video is over and the user hasn't guessed yet tells the user to go to the next one or ends if there are none left...sdg
        If AxShockwaveFlash1.CurrentFrame = AxShockwaveFlash1.TotalFrames - 1 Then
            'increases the counter for the number of questions...sdg
            Counter += 1
            'if the number of questions hasn't been exceeded allows the user to go to the next one...sdg
            If Counter < Images.Length Then

                'stops the video if it's playing...sdg
                AxShockwaveFlash1.StopPlay()
                'stops the timer asociated with it...sdg
                tmrAnimation.Stop()
                MsgBox("You didn't get this one try the next one")
                Dim Random As Byte = Math.Round(Rnd() * (Images.Length - 1))
                While Used(Random) = True
                    Random = Math.Round(Rnd() * (Images.Length - 1))
                End While
                'randomly selects a new question so the user can play again...sdg
                Used(Random) = True
                Letter = Images(Random)(16)
                Word = Words(Random)
                AxShockwaveFlash1.Movie = Application.StartupPath & Images(Random)
                AxShockwaveFlash1.StopPlay()
                cmdConfirm.Enabled = False
                cmdStart.Enabled = True
                lblStartsWithValue.Text = ""

            Else
                AxShockwaveFlash1.StopPlay()
                tmrAnimation.Stop()
                MsgBox("You got it. The game has ended your final score is: " + lblScoreValue.Text)
                'declares a variable for user response to play again check...sdg
                Dim Response As Byte
                Response = MsgBox("Do you want to play again?", 20, "Play Again")
                'if the user decides to play again creates a new instance of the form and closes the old one...sdg
                If Response = 6 Then
                    Dim frmTimberGame = New frmTimberGame
                    Me.Close()
                    frmTimberGame.Show()
                Else
                    'if the player chooeses no goes back to the previous form...sdg
                    mnuBack.PerformClick()
                End If
            End If
        End If
        'if the focus is set on the video then sets it to one of the enabled buttons instead...sdg
        If AxShockwaveFlash1.Focused Then
            If cmdConfirm.Enabled = True Then
                cmdConfirm.Focus()
            Else
                cmdStart.Focus()
            End If

        End If
    End Sub


    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        'checks to see if the word the user enters is correct if it is then either goes to the next or displays the user score
        'and asks him if you want to play again...sdg
        If (UCase(Word) = UCase(txtInput.Text)) Then

            'increases the counter for the number of questions...sdg
            Counter += 1
            'if the number of questions hasn't been exceeded allows the user to go to the next one...sdg
            If Counter < Images.Length Then
                'stops the video if it's playing...sdg
                AxShockwaveFlash1.StopPlay()
                'stops the timer asociated with it...sdg
                tmrAnimation.Stop()
                MsgBox("You got it try the next one")
                If AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 120 Then
                    lblScoreValue.Text += 200
                ElseIf AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 100 Then
                    lblScoreValue.Text += 150
                ElseIf AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 50 Then
                    lblScoreValue.Text += 50
                Else
                    lblScoreValue.Text += 10
                End If
                Dim Random As Byte = Math.Round(Rnd() * (Images.Length - 1))
                While Used(Random) = True
                    Random = Math.Round(Rnd() * (Images.Length - 1))
                End While
                'randomly selects a new question so the user can play again...sdg
                Used(Random) = True
                Letter = Images(Random)(16)
                Word = Words(Random)
                AxShockwaveFlash1.Movie = Application.StartupPath & Images(Random)
                AxShockwaveFlash1.StopPlay()
                cmdConfirm.Enabled = False
                cmdStart.Enabled = True
                lblStartsWithValue.Text = ""
            Else
                AxShockwaveFlash1.StopPlay()
                tmrAnimation.Stop()
                If AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 120 Then
                    lblScoreValue.Text += 200
                ElseIf AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 100 Then
                    lblScoreValue.Text += 150
                ElseIf AxShockwaveFlash1.CurrentFrame < AxShockwaveFlash1.TotalFrames - 50 Then
                    lblScoreValue.Text += 50
                Else
                    lblScoreValue.Text += 10
                End If

                MsgBox("You got it. The game has ended your final score is: " + lblScoreValue.Text)
                'declares a variable for user response to play again check...sdg
                Dim Response As Byte
                Response = MsgBox("Do you want to play again?", 20, "Play Again")
                If Response = 6 Then
                    Dim frmTimberGame = New frmTimberGame
                    Me.Close()
                    frmTimberGame.Show()
                Else
                    'if the player chooeses no goes back to the previous form...sdg
                    mnuBack.PerformClick()
                End If
            End If
        Else
            'gives the user a response if they get it wrong...sdg
            MsgBox("Sorry that is not the answer try again")
        End If
    End Sub


    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuInstructions.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmTimberGameInstructions.Show()
        frmTimberGameInstructions.Opacity = 0
        frmTimberGameInstructions.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmTimberGameInstructions.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTimberGameInstructions.Refresh()
        Next
        Me.Opacity = 1
        Me.Close()
    End Sub
End Class