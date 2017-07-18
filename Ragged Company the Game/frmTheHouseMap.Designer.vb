<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheHouseMap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheHouseMap))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDiningRoom = New System.Windows.Forms.Button()
        Me.cmdDiggersWorkShop = New System.Windows.Forms.Button()
        Me.cmdTimber = New System.Windows.Forms.Button()
        Me.cmdKitchen = New System.Windows.Forms.Button()
        Me.cmdDoubleDick = New System.Windows.Forms.Button()
        Me.ptcMap = New System.Windows.Forms.PictureBox()
        Me.mnuStrip.SuspendLayout()
        CType(Me.ptcMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuContent})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(864, 24)
        Me.mnuStrip.TabIndex = 5
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
        'mnuContent
        '
        Me.mnuContent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuContent.Name = "mnuContent"
        Me.mnuContent.Size = New System.Drawing.Size(62, 20)
        Me.mnuContent.Text = "&Content"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "About"
        '
        'cmdDiningRoom
        '
        Me.cmdDiningRoom.Location = New System.Drawing.Point(251, 128)
        Me.cmdDiningRoom.Name = "cmdDiningRoom"
        Me.cmdDiningRoom.Size = New System.Drawing.Size(81, 49)
        Me.cmdDiningRoom.TabIndex = 1
        Me.cmdDiningRoom.UseVisualStyleBackColor = True
        '
        'cmdDiggersWorkShop
        '
        Me.cmdDiggersWorkShop.Location = New System.Drawing.Point(541, 370)
        Me.cmdDiggersWorkShop.Name = "cmdDiggersWorkShop"
        Me.cmdDiggersWorkShop.Size = New System.Drawing.Size(113, 68)
        Me.cmdDiggersWorkShop.TabIndex = 5
        Me.cmdDiggersWorkShop.UseVisualStyleBackColor = True
        '
        'cmdTimber
        '
        Me.cmdTimber.Location = New System.Drawing.Point(91, 118)
        Me.cmdTimber.Name = "cmdTimber"
        Me.cmdTimber.Size = New System.Drawing.Size(113, 68)
        Me.cmdTimber.TabIndex = 0
        Me.cmdTimber.UseVisualStyleBackColor = True
        '
        'cmdKitchen
        '
        Me.cmdKitchen.Location = New System.Drawing.Point(355, 153)
        Me.cmdKitchen.Name = "cmdKitchen"
        Me.cmdKitchen.Size = New System.Drawing.Size(86, 27)
        Me.cmdKitchen.TabIndex = 2
        Me.cmdKitchen.UseVisualStyleBackColor = True
        '
        'cmdDoubleDick
        '
        Me.cmdDoubleDick.Location = New System.Drawing.Point(91, 370)
        Me.cmdDoubleDick.Name = "cmdDoubleDick"
        Me.cmdDoubleDick.Size = New System.Drawing.Size(113, 68)
        Me.cmdDoubleDick.TabIndex = 4
        Me.cmdDoubleDick.UseVisualStyleBackColor = True
        '
        'ptcMap
        '
        Me.ptcMap.Image = CType(resources.GetObject("ptcMap.Image"), System.Drawing.Image)
        Me.ptcMap.Location = New System.Drawing.Point(0, 28)
        Me.ptcMap.Name = "ptcMap"
        Me.ptcMap.Size = New System.Drawing.Size(864, 531)
        Me.ptcMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcMap.TabIndex = 6
        Me.ptcMap.TabStop = False
        '
        'frmTheHouseMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdKitchen)
        Me.Controls.Add(Me.cmdDoubleDick)
        Me.Controls.Add(Me.cmdTimber)
        Me.Controls.Add(Me.cmdDiggersWorkShop)
        Me.Controls.Add(Me.cmdDiningRoom)
        Me.Controls.Add(Me.mnuStrip)
        Me.Controls.Add(Me.ptcMap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTheHouseMap"
        Me.Text = "TheHouseMap"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.ptcMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDiningRoom As System.Windows.Forms.Button
    Friend WithEvents cmdDiggersWorkShop As System.Windows.Forms.Button
    Friend WithEvents cmdTimber As System.Windows.Forms.Button
    Friend WithEvents cmdKitchen As System.Windows.Forms.Button
    Friend WithEvents cmdDoubleDick As System.Windows.Forms.Button
    Friend WithEvents ptcMap As System.Windows.Forms.PictureBox
    Friend WithEvents mnuContent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
End Class
