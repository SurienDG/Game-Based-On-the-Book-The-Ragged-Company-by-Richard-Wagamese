<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatchingGames
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatchingGames))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMoving = New System.Windows.Forms.Timer(Me.components)
        Me.lblMinimumScore = New System.Windows.Forms.Label()
        Me.lblMinToAdvance = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblLevelValue = New System.Windows.Forms.Label()
        Me.tmrGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.lblTimeLeftValue = New System.Windows.Forms.Label()
        Me.ptcBike = New System.Windows.Forms.PictureBox()
        Me.ptcRadio = New System.Windows.Forms.PictureBox()
        Me.ptcBeer = New System.Windows.Forms.PictureBox()
        Me.ptcCigar = New System.Windows.Forms.PictureBox()
        Me.ptcCatcher = New System.Windows.Forms.PictureBox()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcBike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBeer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcCigar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcCatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(848, 24)
        Me.mnuStrip.TabIndex = 10
        Me.mnuStrip.Text = "mnuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.mnuBack, Me.mnuInstructions})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(152, 22)
        Me.mnuBack.Text = "Back"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(152, 22)
        Me.mnuInstructions.Text = "Instructions"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Black
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(239, 24)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(163, 46)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score:"
        '
        'lblScoreValue
        '
        Me.lblScoreValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreValue.ForeColor = System.Drawing.Color.White
        Me.lblScoreValue.Location = New System.Drawing.Point(362, 27)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(129, 46)
        Me.lblScoreValue.TabIndex = 11
        Me.lblScoreValue.Text = "0"
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1
        '
        'tmrMoving
        '
        Me.tmrMoving.Enabled = True
        Me.tmrMoving.Interval = 1
        '
        'lblMinimumScore
        '
        Me.lblMinimumScore.BackColor = System.Drawing.Color.Black
        Me.lblMinimumScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimumScore.ForeColor = System.Drawing.Color.White
        Me.lblMinimumScore.Location = New System.Drawing.Point(481, 27)
        Me.lblMinimumScore.Name = "lblMinimumScore"
        Me.lblMinimumScore.Size = New System.Drawing.Size(212, 82)
        Me.lblMinimumScore.TabIndex = 11
        Me.lblMinimumScore.Text = "Minimum:"
        '
        'lblMinToAdvance
        '
        Me.lblMinToAdvance.BackColor = System.Drawing.Color.Black
        Me.lblMinToAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinToAdvance.ForeColor = System.Drawing.Color.White
        Me.lblMinToAdvance.Location = New System.Drawing.Point(687, 27)
        Me.lblMinToAdvance.Name = "lblMinToAdvance"
        Me.lblMinToAdvance.Size = New System.Drawing.Size(161, 55)
        Me.lblMinToAdvance.TabIndex = 11
        Me.lblMinToAdvance.Text = "1000"
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Black
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(5, 82)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(163, 82)
        Me.lblLevel.TabIndex = 11
        Me.lblLevel.Text = "Level:"
        '
        'lblLevelValue
        '
        Me.lblLevelValue.BackColor = System.Drawing.Color.Black
        Me.lblLevelValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelValue.ForeColor = System.Drawing.Color.White
        Me.lblLevelValue.Location = New System.Drawing.Point(160, 82)
        Me.lblLevelValue.Name = "lblLevelValue"
        Me.lblLevelValue.Size = New System.Drawing.Size(162, 55)
        Me.lblLevelValue.TabIndex = 11
        Me.lblLevelValue.Text = "1"
        '
        'tmrGameTimer
        '
        Me.tmrGameTimer.Enabled = True
        Me.tmrGameTimer.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.BackColor = System.Drawing.Color.Black
        Me.lblTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.White
        Me.lblTimeLeft.Location = New System.Drawing.Point(5, 27)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(198, 55)
        Me.lblTimeLeft.TabIndex = 11
        Me.lblTimeLeft.Text = "Time Left:"
        '
        'lblTimeLeftValue
        '
        Me.lblTimeLeftValue.BackColor = System.Drawing.Color.Black
        Me.lblTimeLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeftValue.ForeColor = System.Drawing.Color.White
        Me.lblTimeLeftValue.Location = New System.Drawing.Point(174, 27)
        Me.lblTimeLeftValue.Name = "lblTimeLeftValue"
        Me.lblTimeLeftValue.Size = New System.Drawing.Size(67, 55)
        Me.lblTimeLeftValue.TabIndex = 11
        Me.lblTimeLeftValue.Text = "20"
        '
        'ptcBike
        '
        Me.ptcBike.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.bike
        Me.ptcBike.Location = New System.Drawing.Point(233, 27)
        Me.ptcBike.Name = "ptcBike"
        Me.ptcBike.Size = New System.Drawing.Size(56, 156)
        Me.ptcBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBike.TabIndex = 12
        Me.ptcBike.TabStop = False
        Me.ptcBike.Visible = False
        '
        'ptcRadio
        '
        Me.ptcRadio.Image = CType(resources.GetObject("ptcRadio.Image"), System.Drawing.Image)
        Me.ptcRadio.Location = New System.Drawing.Point(186, 58)
        Me.ptcRadio.Name = "ptcRadio"
        Me.ptcRadio.Size = New System.Drawing.Size(47, 79)
        Me.ptcRadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcRadio.TabIndex = 12
        Me.ptcRadio.TabStop = False
        Me.ptcRadio.Visible = False
        '
        'ptcBeer
        '
        Me.ptcBeer.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.beer
        Me.ptcBeer.Location = New System.Drawing.Point(82, -20)
        Me.ptcBeer.Name = "ptcBeer"
        Me.ptcBeer.Size = New System.Drawing.Size(33, 111)
        Me.ptcBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBeer.TabIndex = 12
        Me.ptcBeer.TabStop = False
        Me.ptcBeer.Visible = False
        '
        'ptcCigar
        '
        Me.ptcCigar.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.CiggarBox
        Me.ptcCigar.Location = New System.Drawing.Point(12, 37)
        Me.ptcCigar.Name = "ptcCigar"
        Me.ptcCigar.Size = New System.Drawing.Size(35, 54)
        Me.ptcCigar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcCigar.TabIndex = 12
        Me.ptcCigar.TabStop = False
        Me.ptcCigar.Visible = False
        '
        'ptcCatcher
        '
        Me.ptcCatcher.Image = CType(resources.GetObject("ptcCatcher.Image"), System.Drawing.Image)
        Me.ptcCatcher.Location = New System.Drawing.Point(0, 349)
        Me.ptcCatcher.Name = "ptcCatcher"
        Me.ptcCatcher.Size = New System.Drawing.Size(80, 168)
        Me.ptcCatcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcCatcher.TabIndex = 0
        Me.ptcCatcher.TabStop = False
        '
        'frmCatchingGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(848, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.ptcBike)
        Me.Controls.Add(Me.ptcRadio)
        Me.Controls.Add(Me.ptcBeer)
        Me.Controls.Add(Me.ptcCigar)
        Me.Controls.Add(Me.lblScoreValue)
        Me.Controls.Add(Me.lblTimeLeftValue)
        Me.Controls.Add(Me.lblLevelValue)
        Me.Controls.Add(Me.lblMinToAdvance)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblMinimumScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.ptcCatcher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCatchingGames"
        Me.Text = "CatchingGamesCatchingGamesCatchingGames"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcBike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcRadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBeer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcCigar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcCatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcCatcher As System.Windows.Forms.PictureBox
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblScoreValue As System.Windows.Forms.Label
    Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptcCigar As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBeer As System.Windows.Forms.PictureBox
    Friend WithEvents ptcRadio As System.Windows.Forms.PictureBox
    Friend WithEvents ptcBike As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrMoving As System.Windows.Forms.Timer
    Friend WithEvents lblMinimumScore As System.Windows.Forms.Label
    Friend WithEvents lblMinToAdvance As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblLevelValue As System.Windows.Forms.Label
    Friend WithEvents tmrGameTimer As System.Windows.Forms.Timer
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeftValue As System.Windows.Forms.Label
    Friend WithEvents mnuInstructions As System.Windows.Forms.ToolStripMenuItem

End Class
