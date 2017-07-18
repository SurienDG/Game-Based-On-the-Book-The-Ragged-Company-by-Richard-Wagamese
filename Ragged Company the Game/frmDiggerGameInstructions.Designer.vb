<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiggerGameInstructions
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptcInstructionsBackGround = New System.Windows.Forms.PictureBox()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcInstructionsBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(1022, 24)
        Me.mnuStrip.TabIndex = 7
        Me.mnuStrip.Text = "7"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.mnuBack})
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
        'ptcInstructionsBackGround
        '
        Me.ptcInstructionsBackGround.Image = Global.Ragged_Company_the_Game.My.Resources.Resources.DiggersWorkshopGameInstructions
        Me.ptcInstructionsBackGround.Location = New System.Drawing.Point(0, 25)
        Me.ptcInstructionsBackGround.Name = "ptcInstructionsBackGround"
        Me.ptcInstructionsBackGround.Size = New System.Drawing.Size(1022, 524)
        Me.ptcInstructionsBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcInstructionsBackGround.TabIndex = 0
        Me.ptcInstructionsBackGround.TabStop = False
        '
        'frmDiggerGameInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 546)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.ptcInstructionsBackGround)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiggerGameInstructions"
        Me.Text = "frmDiggerGameInstructions"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcInstructionsBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcInstructionsBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
End Class
