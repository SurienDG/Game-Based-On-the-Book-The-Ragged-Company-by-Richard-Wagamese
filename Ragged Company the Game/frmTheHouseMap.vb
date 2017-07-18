Option Explicit On
Public Class frmTheHouseMap
    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim WindowResizer As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        'gets the value of all the controls positions and sizes...sdg
        WindowResizer.FindAllControls(Me)
        'maximizes the screen, it is done this way as not to distract from opacity animations I included...sdg 
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(0, 0)
        'scales all the controls according to the window resizer
        WindowResizer.ResizeAllControls(Me)
        'pictures are put into variables and scaled for the new screen then they are applied to the buttons that they are assigned to...sdg
        Dim DiggerWork As New Bitmap(My.Resources.DiggersWorkshop, cmdDiggersWorkShop.Width, cmdDiggersWorkShop.Height)
        Dim Dining As New Bitmap(My.Resources.DiningRoom, cmdDiningRoom.Width, cmdDiningRoom.Height)
        Dim Timber As New Bitmap(My.Resources.TimbersWorkshop, cmdTimber.Width, cmdTimber.Height)
        Dim Kitchen As New Bitmap(My.Resources.Kitchen, cmdKitchen.Width, cmdKitchen.Height)
        Dim Theatre As New Bitmap(My.Resources.DoubleDicksTheatre, cmdDoubleDick.Width, cmdDoubleDick.Height)
        cmdDiningRoom.Image = Dining
        cmdDiggersWorkShop.Image = DiggerWork
        cmdTimber.Image = Timber
        cmdKitchen.Image = Kitchen
        cmdDoubleDick.Image = Theatre
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'detects if the window was resized and resizes all controls accordly...sdg
        WindowResizer.ResizeAllControls(Me)
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
            'code to exit the application. This is better then using end as it closes all the forms first to prevent errors that may occur when using end...sdg
            Application.Exit()
        End If
    End Sub


    Private Sub cmdTimber_Click(sender As Object, e As EventArgs) Handles cmdTimber.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmTimberWorkshop.Show()
        frmTimberWorkshop.Opacity = 0
        frmTimberWorkshop.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmTimberWorkshop.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmTimberWorkshop.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub




    Private Sub cmdDoubleDick_Click(sender As Object, e As EventArgs) Handles cmdDoubleDick.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmDicksTheatre.Show()
        frmDicksTheatre.Opacity = 0
        frmDicksTheatre.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmDicksTheatre.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmDicksTheatre.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    Private Sub cmdDiggersWorkShop_Click(sender As Object, e As EventArgs) Handles cmdDiggersWorkShop.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmDiggersShop.Show()
        frmDiggersShop.Opacity = 0
        frmDiggersShop.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmDiggersShop.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmDiggersShop.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    Private Sub cmdDiningRoom_Click(sender As Object, e As EventArgs) Handles cmdDiningRoom.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmDiningRoom.Show()
        frmDiningRoom.Opacity = 0
        frmDiningRoom.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmDiningRoom.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmDiningRoom.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    Private Sub cmdKitchen_Click(sender As Object, e As EventArgs) Handles cmdKitchen.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other window...sdg
        frmKitchen.Show()
        frmKitchen.Opacity = 0
        frmKitchen.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmKitchen.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmKitchen.Refresh()

        Next
        Me.Opacity = 1
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'code to transition from one window to the next smoothly by reducing opacity of current window and increasing opacity of the other windor...sdg
        frmAbout.Show()
        frmAbout.Opacity = 0
        frmAbout.Refresh()
        For counter As Single = 1 To 0 Step -0.05
            'line of code used for debugging
            'Debug.WriteLine(counter)
            frmAbout.Opacity += 0.05
            Me.Opacity = counter
            Me.Refresh()
            frmAbout.Refresh()
        Next
        Me.Opacity = 1
        Me.Close()
    End Sub
End Class