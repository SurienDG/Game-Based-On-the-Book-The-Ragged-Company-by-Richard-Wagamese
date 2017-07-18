<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lbName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.lblActualDate = New System.Windows.Forms.Label()
        Me.lblActualProgramName = New System.Windows.Forms.Label()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.Aquamarine
        Me.lbName.Location = New System.Drawing.Point(62, 56)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(446, 32)
        Me.lbName.TabIndex = 1
        Me.lbName.Text = "Creator:"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblDate.Location = New System.Drawing.Point(62, 142)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(690, 25)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProgramName
        '
        Me.lblProgramName.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramName.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblProgramName.Location = New System.Drawing.Point(62, 226)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(690, 25)
        Me.lblProgramName.TabIndex = 1
        Me.lblProgramName.Text = "Name of Program:"
        '
        'lblMyName
        '
        Me.lblMyName.BackColor = System.Drawing.Color.Transparent
        Me.lblMyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyName.ForeColor = System.Drawing.Color.Azure
        Me.lblMyName.Location = New System.Drawing.Point(62, 101)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(628, 25)
        Me.lblMyName.TabIndex = 1
        Me.lblMyName.Text = "Surien Das-Giwojno"
        '
        'lblActualDate
        '
        Me.lblActualDate.BackColor = System.Drawing.Color.Transparent
        Me.lblActualDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualDate.ForeColor = System.Drawing.Color.Azure
        Me.lblActualDate.Location = New System.Drawing.Point(62, 187)
        Me.lblActualDate.Name = "lblActualDate"
        Me.lblActualDate.Size = New System.Drawing.Size(602, 25)
        Me.lblActualDate.TabIndex = 1
        Me.lblActualDate.Text = "Jan 15, 2017"
        Me.lblActualDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActualProgramName
        '
        Me.lblActualProgramName.BackColor = System.Drawing.Color.Transparent
        Me.lblActualProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualProgramName.ForeColor = System.Drawing.Color.Azure
        Me.lblActualProgramName.Location = New System.Drawing.Point(62, 263)
        Me.lblActualProgramName.Name = "lblActualProgramName"
        Me.lblActualProgramName.Size = New System.Drawing.Size(655, 25)
        Me.lblActualProgramName.TabIndex = 1
        Me.lblActualProgramName.Text = "Ragged Company The Game"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(135, 395)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(159, 43)
        Me.cmdBack.TabIndex = 1
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(450, 395)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(159, 43)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(840, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblActualProgramName)
        Me.Controls.Add(Me.lblActualDate)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.lbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblProgramName As System.Windows.Forms.Label
    Friend WithEvents lblMyName As System.Windows.Forms.Label
    Friend WithEvents lblActualDate As System.Windows.Forms.Label
    Friend WithEvents lblActualProgramName As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
