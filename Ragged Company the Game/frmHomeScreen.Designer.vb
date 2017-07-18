<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeScreen))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEnterHouse = New System.Windows.Forms.Button()
        Me.ptcPressAnyKey = New System.Windows.Forms.PictureBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcPressAnyKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 24)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(864, 532)
        Me.AxShockwaveFlash1.TabIndex = 0
        Me.AxShockwaveFlash1.TabStop = False
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 1
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(864, 24)
        Me.mnuStrip.TabIndex = 4
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
        'cmdEnterHouse
        '
        Me.cmdEnterHouse.Location = New System.Drawing.Point(392, 349)
        Me.cmdEnterHouse.Name = "cmdEnterHouse"
        Me.cmdEnterHouse.Size = New System.Drawing.Size(420, 167)
        Me.cmdEnterHouse.TabIndex = 6
        Me.cmdEnterHouse.UseVisualStyleBackColor = True
        Me.cmdEnterHouse.Visible = False
        '
        'ptcPressAnyKey
        '
        Me.ptcPressAnyKey.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.skip
        Me.ptcPressAnyKey.Location = New System.Drawing.Point(650, 522)
        Me.ptcPressAnyKey.Name = "ptcPressAnyKey"
        Me.ptcPressAnyKey.Size = New System.Drawing.Size(214, 34)
        Me.ptcPressAnyKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcPressAnyKey.TabIndex = 5
        Me.ptcPressAnyKey.TabStop = False
        '
        'frmHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdEnterHouse)
        Me.Controls.Add(Me.ptcPressAnyKey)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmHomeScreen"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcPressAnyKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptcPressAnyKey As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEnterHouse As System.Windows.Forms.Button
End Class
