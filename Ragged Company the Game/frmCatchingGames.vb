Option Explicit On
Public Class frmCatchingGames
    'defines the array of picture boxes...sdg
    Dim Items(4) As PictureBox
    'array for picture boxes being displayed...sdg
    Dim ShowingItems(0) As PictureBox
    'number of elements in the picture box array...sdg
    Dim Elements As Byte
    'variable to create a new class object from the resizer class which will be used for resizing the screen...sdg
    Dim ResizerForForm As New Resizer
    'variable to store where the last variable was placed to prevent overlap
    Dim PreviousLocation = 0
    'constants to store the index for where an item exists in the array
    Const Beer = 1
    Const Bike = 3
    Const Radio = 2
    Const Cigar = 0
    'event for character movement in the game...sdg
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'moves the character in a certain direction depending on what the arrow key is pressed...sdg
        'safe guards in place to prevent the user from moving off the screen...sdg
        If e.KeyCode = Keys.Right Then
            For move As Byte = 1 To 20
                If ptcCatcher.Left + ptcCatcher.Width = Me.Width - 10 Then
                    Exit For
                End If
                ptcCatcher.Left += 1
            Next
        ElseIf e.KeyCode = Keys.Left Then

            For move As Byte = 1 To 20

                If ptcCatcher.Left = 0 Then
                    Exit For
                End If
                ptcCatcher.Left -= 1
            Next
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form/messagebox...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        'if the user decides to exit then exits the application...sdg
        If Response = 6 Then
            'uses this line to exit as opposed to end as this is better practice as it closes all the windows first so as not to 
            'create errors ...sdg
            Application.Exit()
        End If
    End Sub




    Private Sub frmCatchingGames_Load(sender As Object, e As EventArgs) Handles Me.Load
        'randoms the the random variables...sdg
        Randomize()
        'creates new picture boxes for each item...sdg
        For counter As Byte = 0 To 3
            Items(counter) = New PictureBox
        Next
        'assigns a picture to each picture box...sdg
        Items(1) = ptcBeer
        Items(3) = ptcBike
        Items(2) = ptcRadio
        Items(0) = ptcCigar
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window...sdg
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        'scales all the controls using their sizes and positions to maintain aspect ratio...sdg
        ResizerForForm.ResizeAllControls(Me)
        'sets the starting position for the items...sdg
        PreviousLocation = Width * 0.05
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmDiggersShop.Show()
        frmDiggersShop.Opacity = 0
        frmDiggersShop.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmDiggersShop.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmDiggersShop.Refresh()

        Next
        'resets the opacity of the current form...sdg
        Me.Opacity = 1
        'closes the current window...sdg
        Me.Close()


    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        'sets the timer interval to one...sdg
        tmrMain.Interval = 1
        'boundary for creating new elements...sdg
        If (Elements < 6) Then
            'adds one to the number of elements...sdg
            Elements += 1
            'sets the showing items size to the size of the number of elements...sdg
            ReDim Preserve ShowingItems(Elements)
            'variable to store random value...sdg
            Dim RandomVariable As Byte
            'checks to see what level the player is on to decide which items can be created...sdg
            If Val(lblLevelValue.Text) >= 4 Then
                RandomVariable = Math.Round(Rnd() * 3)
            ElseIf Val(lblLevelValue.Text) >= 3 Then
                RandomVariable = Math.Round(Rnd() * 2)
            ElseIf Val(lblLevelValue.Text) >= 2 Then
                RandomVariable = Math.Round(Rnd() * 1)
            ElseIf Val(lblLevelValue.Text) >= 1 Then
                RandomVariable = 0
            End If
            'assigns the new randomw picture to the showing items arrray
            ShowingItems(Elements - 1) = New PictureBox()
            ShowingItems(Elements - 1).Width = Items(RandomVariable).Width
            ShowingItems(Elements - 1).Height = Items(RandomVariable).Height
            ShowingItems(Elements - 1).Image = Items(RandomVariable).Image
            'variable to store the random starting point of the of the item generated...sdg
            Dim RandomPoint As Point
            'if more then one element then moves object into next column...sdg
            If Elements - 2 >= 0 Then
                PreviousLocation += Me.Width * 0.2
                'places element at a random height...sdg
                RandomPoint = New Point(PreviousLocation, Math.Round(Rnd() * (Me.Height * 0.2)))
            Else
                RandomPoint = New Point(PreviousLocation, 0)
            End If
            'assigns the random location to the item in the array...sdg
            ShowingItems(Elements - 1).Location = RandomPoint
            ShowingItems(Elements - 1).Show()
            'sets the picture size property to StretchImage...sdg
            ShowingItems(Elements - 1).SizeMode = PictureBoxSizeMode.StretchImage
            'adds the new control to the form...sdg
            Controls.Add(ShowingItems(Elements - 1))
        End If
    End Sub

    Private Sub tmrMoving_Tick(sender As Object, e As EventArgs) Handles tmrMoving.Tick
        'if all items are placed sets the previous location to 0...sdg
        If (PreviousLocation = (Me.Width * 0.2) * 5) Then
            PreviousLocation = 0
        End If
        'checks to see if elements actually exist now...sdg
        If Elements - 1 >= 0 Then
            'goes through all elements in the showing items array and moves them down...sdg
            For counter As Byte = 0 To Elements - 1
                'line of code commented out was used for debugging by outputting to console...sdg
                'Debug.WriteLine(ShowingItems(Elements - 1).Top)

                'if statement to check which item is being moved so that it can either be moved faster or slower...sdg
                If ShowingItems(counter).Image Is Items(Cigar).Image Then
                    ShowingItems(counter).Top += 3
                ElseIf ShowingItems(counter).Image Is Items(Bike).Image Then
                    ShowingItems(counter).Top += 6
                ElseIf ShowingItems(counter).Image Is Items(Radio).Image Then
                    ShowingItems(counter).Top += 5
                ElseIf ShowingItems(counter).Image Is Items(Beer).Image Then
                    ShowingItems(counter).Top += 4
                End If
                'if the item is moved off the screen then creates a new item based on random variable...sdg
                'the property of the item are assigned to the new picture box...sdg
                If ShowingItems(counter).Top >= Me.Height Then
                    Dim RandomVariable As Byte
                    If Val(lblLevelValue.Text) >= 4 Then
                        RandomVariable = Math.Round(Rnd() * 3)
                    ElseIf Val(lblLevelValue.Text) >= 3 Then
                        RandomVariable = Math.Round(Rnd() * 2)
                    ElseIf Val(lblLevelValue.Text) >= 2 Then
                        RandomVariable = Math.Round(Rnd() * 1)
                    ElseIf Val(lblLevelValue.Text) >= 1 Then
                        RandomVariable = 0
                    End If
                    ShowingItems(Elements - 1) = New PictureBox()
                    ShowingItems(counter).Width = Items(RandomVariable).Width
                    ShowingItems(counter).Height = Items(RandomVariable).Height
                    ShowingItems(counter).Image = Items(RandomVariable).Image
                    ShowingItems(counter).Top = Math.Round(Rnd() * (Me.Height * 0.2))
                    ShowingItems(counter).Show()
                    ShowingItems(counter).SizeMode = PictureBoxSizeMode.StretchImage
                End If
                'code to check whether item can be picked up by the character the user is controling...sdg
                If ShowingItems(counter).Left >= ptcCatcher.Left And ShowingItems(counter).Left + ShowingItems(counter).Width <= (ptcCatcher.Left + ptcCatcher.Width) And ShowingItems(counter).Top + ShowingItems(counter).Height > ptcCatcher.Top Then
                    If ShowingItems(counter).Image Is Items(Cigar).Image Then
                        lblScoreValue.Text += 100
                    ElseIf ShowingItems(counter).Image Is Items(Bike).Image Then
                        lblScoreValue.Text += 600
                    ElseIf ShowingItems(counter).Image Is Items(Radio).Image Then
                        lblScoreValue.Text += 300
                    ElseIf ShowingItems(counter).Image Is Items(Beer).Image Then
                        lblScoreValue.Text += 200
                    End If
                    'code to check whether the user has reached the mininmum requirement to advance...sdg
                    If lblScoreValue.Text >= Val(lblMinToAdvance.Text) Then
                        'code for debugging...sdg
                        'Debug.WriteLine(lblMinToAdvance.Text)
                        'refreshes the screen...sdg
                        Me.Refresh()
                        'creates a new instance of the form where the minimum score is increased and the level number is increased...sdg
                        Dim frmCatchingGames = New frmCatchingGames
                        frmCatchingGames.lblMinToAdvance.Text = lblMinToAdvance.Text + 200
                        frmCatchingGames.lblLevelValue.Text = lblLevelValue.Text + 1
                        'shows the new instance and closes the old one...sdg
                        frmCatchingGames.Show()
                        Me.Close()

                    End If
                    'gets a random varible to pick which object will be used only certain objects can be created at certain levels...sdg
                    Dim RandomVariable As Byte
                    If Val(lblLevelValue.Text) >= 4 Then
                        RandomVariable = Math.Round(Rnd() * 3)
                    ElseIf Val(lblLevelValue.Text) >= 3 Then
                        RandomVariable = Math.Round(Rnd() * 2)
                    ElseIf Val(lblLevelValue.Text) >= 2 Then
                        RandomVariable = Math.Round(Rnd() * 1)
                    ElseIf Val(lblLevelValue.Text) >= 1 Then
                        RandomVariable = 0
                    End If
                    'assigns the object properties to the new picture box...sdg
                    ShowingItems(Elements - 1) = New PictureBox()
                    ShowingItems(counter).Width = Items(RandomVariable).Width
                    ShowingItems(counter).Height = Items(RandomVariable).Height
                    ShowingItems(counter).Image = Items(RandomVariable).Image
                    ShowingItems(counter).Top = Math.Round(Rnd() * (Me.Height * 0.2))
                    ShowingItems(counter).Show()
                    ShowingItems(counter).SizeMode = PictureBoxSizeMode.StretchImage
                End If

            Next
        End If

    End Sub


    Private Sub tmrGameTimer_Tick(sender As Object, e As EventArgs) Handles tmrGameTimer.Tick
        'subtracts 1 from the time left...sdg
        If (lblTimeLeftValue.Text >= 0) Then
            lblTimeLeftValue.Text -= 1
        End If

        If (Val(lblTimeLeftValue.Text) = 0) Then
            Me.Refresh()
            'declares a variable for user response to exit check...sdg
            Dim Response As Byte
            tmrGameTimer.Stop()
            tmrMoving.Stop()
            tmrMain.Stop()
            'hides the current window and opens the exit form/messagebox...sdg
            Response = MsgBox("Game over." & vbNewLine & vbNewLine & "Congratulations you made it to level: " + lblLevelValue.Text + vbNewLine & vbNewLine & "Do you want to play again?", 20, "Game Over")
            If Response = 6 Then
                Dim frmCatchingGamesform = New frmCatchingGames
                frmCatchingGamesform.Show()
                Me.Close()


            Else
                'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
                frmDiggersShop.Show()
                frmDiggersShop.Opacity = 0
                frmDiggersShop.Refresh()
                For counter As Single = 1 To 0 Step -0.05
                    frmDiggersShop.Opacity += 0.05
                    Me.Opacity = counter
                    Me.Refresh()
                    frmDiggersShop.Refresh()

                Next
                Me.Opacity = 1
                Me.Close()
            End If
        End If
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuInstructions.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmDiggerGameInstructions.Show()
        frmDiggerGameInstructions.Opacity = 0
        frmDiggerGameInstructions.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            frmDiggerGameInstructions.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmDiggerGameInstructions.Refresh()

        Next
        Me.Opacity = 1
        Me.Close()
    End Sub



End Class
