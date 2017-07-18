<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKitchen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKitchen))
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdLearnMore = New System.Windows.Forms.Button()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptcBackground = New System.Windows.Forms.PictureBox()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(12, 422)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(266, 74)
        Me.cmdBack.TabIndex = 1
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdLearnMore
        '
        Me.cmdLearnMore.Location = New System.Drawing.Point(570, 422)
        Me.cmdLearnMore.Name = "cmdLearnMore"
        Me.cmdLearnMore.Size = New System.Drawing.Size(266, 74)
        Me.cmdLearnMore.TabIndex = 2
        Me.cmdLearnMore.UseVisualStyleBackColor = True
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(848, 24)
        Me.mnuStrip.TabIndex = 9
        Me.mnuStrip.Text = "MenuStrip1"
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
        'ptcBackground
        '
        Me.ptcBackground.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.KitchenBackground
        Me.ptcBackground.Location = New System.Drawing.Point(0, 27)
        Me.ptcBackground.Name = "ptcBackground"
        Me.ptcBackground.Size = New System.Drawing.Size(848, 489)
        Me.ptcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcBackground.TabIndex = 12
        Me.ptcBackground.TabStop = False
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 27)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(848, 222)
        Me.AxShockwaveFlash1.TabIndex = 13
        Me.AxShockwaveFlash1.TabStop = False
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
        'frmKitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdLearnMore)
        Me.Controls.Add(Me.ptcBackground)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKitchen"
        Me.Text = "Kitchen"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdLearnMore As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptcBackground As System.Windows.Forms.PictureBox
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
End Class
