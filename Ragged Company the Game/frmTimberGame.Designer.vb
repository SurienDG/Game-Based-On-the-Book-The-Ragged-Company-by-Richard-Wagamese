<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimberGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimberGame))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.lblStartsWith = New System.Windows.Forms.Label()
        Me.lblStartsWithValue = New System.Windows.Forms.Label()
        Me.ptcBackground = New System.Windows.Forms.PictureBox()
        Me.mnuStrip.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(1038, 24)
        Me.mnuStrip.TabIndex = 6
        Me.mnuStrip.Text = "MenuStrip1"
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
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(141, 262)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(419, 299)
        Me.AxShockwaveFlash1.TabIndex = 8
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Enabled = False
        Me.cmdConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(694, 506)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(201, 42)
        Me.cmdConfirm.TabIndex = 9
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(670, 460)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(247, 40)
        Me.txtInput.TabIndex = 10
        '
        'cmdStart
        '
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(694, 382)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(201, 42)
        Me.cmdStart.TabIndex = 9
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Enabled = True
        Me.tmrAnimation.Interval = 1
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(648, 221)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(182, 55)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score:"
        '
        'lblScoreValue
        '
        Me.lblScoreValue.BackColor = System.Drawing.Color.White
        Me.lblScoreValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreValue.Location = New System.Drawing.Point(873, 224)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(153, 55)
        Me.lblScoreValue.TabIndex = 11
        Me.lblScoreValue.Text = "0"
        '
        'lblStartsWith
        '
        Me.lblStartsWith.BackColor = System.Drawing.Color.White
        Me.lblStartsWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartsWith.Location = New System.Drawing.Point(566, 276)
        Me.lblStartsWith.Name = "lblStartsWith"
        Me.lblStartsWith.Size = New System.Drawing.Size(301, 55)
        Me.lblStartsWith.TabIndex = 11
        Me.lblStartsWith.Text = "Starts With:"
        '
        'lblStartsWithValue
        '
        Me.lblStartsWithValue.BackColor = System.Drawing.Color.White
        Me.lblStartsWithValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartsWithValue.Location = New System.Drawing.Point(873, 276)
        Me.lblStartsWithValue.Name = "lblStartsWithValue"
        Me.lblStartsWithValue.Size = New System.Drawing.Size(78, 55)
        Me.lblStartsWithValue.TabIndex = 11
        Me.lblStartsWithValue.Text = "0"
        '
        'ptcBackground
        '
        Me.ptcBackground.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.TimbersWorkshopGameBackground
        Me.ptcBackground.Location = New System.Drawing.Point(0, 27)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(1038, 562)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 7
        Me.ptcBackground.TabStop = False
        '
        'frmTimberGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 585)
        Me.Controls.Add(Me.lblScoreValue)
        Me.Controls.Add(Me.lblStartsWithValue)
        Me.Controls.Add(Me.lblStartsWith)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.ptcBackground)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTimberGame"
        Me.Text = "frmTimberGame"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblScoreValue As System.Windows.Forms.Label
    Friend WithEvents lblStartsWith As System.Windows.Forms.Label
    Friend WithEvents lblStartsWithValue As System.Windows.Forms.Label
    Friend WithEvents mnuInstructions As System.Windows.Forms.ToolStripMenuItem
End Class
