<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiggersShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiggersShop))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdDiggerInfo = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStartGame = New System.Windows.Forms.Button()
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
        Me.mnuStrip.Size = New System.Drawing.Size(864, 24)
        Me.mnuStrip.TabIndex = 7
        Me.mnuStrip.Text = "mnuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
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
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(12, 433)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(266, 74)
        Me.cmdBack.TabIndex = 9
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdDiggerInfo
        '
        Me.cmdDiggerInfo.Location = New System.Drawing.Point(586, 433)
        Me.cmdDiggerInfo.Name = "cmdDiggerInfo"
        Me.cmdDiggerInfo.Size = New System.Drawing.Size(266, 74)
        Me.cmdDiggerInfo.TabIndex = 10
        Me.cmdDiggerInfo.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 27)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(864, 234)
        Me.AxShockwaveFlash1.TabIndex = 15
        Me.AxShockwaveFlash1.Visible = False
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Interval = 1
        '
        'cmdStartGame
        '
        Me.cmdStartGame.Location = New System.Drawing.Point(12, 306)
        Me.cmdStartGame.Name = "cmdStartGame"
        Me.cmdStartGame.Size = New System.Drawing.Size(266, 74)
        Me.cmdStartGame.TabIndex = 1
        Me.cmdStartGame.UseVisualStyleBackColor = True
        Me.cmdStartGame.Visible = False
        '
        'ptcBackground
        '
        Me.ptcBackground.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.DiggersWorkshopBackground
        Me.ptcBackground.Location = New System.Drawing.Point(0, 27)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(864, 526)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 11
        Me.ptcBackground.TabStop = False
        '
        'frmDiggersShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.cmdStartGame)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdDiggerInfo)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.ptcBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiggersShop"
        Me.Text = "frmDiggersShop"
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
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdDiggerInfo As System.Windows.Forms.Button
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
    Friend WithEvents cmdStartGame As System.Windows.Forms.Button
End Class
