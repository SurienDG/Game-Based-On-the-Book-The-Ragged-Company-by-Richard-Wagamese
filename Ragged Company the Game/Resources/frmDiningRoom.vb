Option Explicit On
Public Class frmDiningRoom


    'variable for the resizer from a class I got from the internet...sdg
    'it is used to resize all windows so game can be played full screen on any computer..sdg
    Dim ResizerForForm As New Resizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'code to show the current form...sdg
        Me.Show()
        'gets the current size of all controls...sdg
        ResizerForForm.FindAllControls(Me)
        'maximizes the window...sdg
        Me.WindowState = FormWindowState.Maximized
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




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'declares a variable for user response to exit check...sdg
        Dim Response As Byte
        'hides the current window and opens the exit form/messagebox...sdg
        Response = MsgBox("Are you sure you want to exit?", 20, "Exit")
        If Response = 6 Then
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
        Me.Hide()
    End Sub



    Private Sub cmdLearnMore_Click(sender As Object, e As EventArgs) Handles cmdLearnMore.Click

    End Sub
End Class