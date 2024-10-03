<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicTails = New System.Windows.Forms.PictureBox()
        Me.Picheads = New System.Windows.Forms.PictureBox()
        Me.lblwinner = New System.Windows.Forms.Label()
        Me.lblplayerwins = New System.Windows.Forms.Label()
        Me.lblcomputerwins = New System.Windows.Forms.Label()
        Me.lblHeadsrolled = New System.Windows.Forms.Label()
        Me.lbltailsrolled = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PicToss = New System.Windows.Forms.PictureBox()
        Me.TmtRestart = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picheads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicToss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicTails
        '
        Me.PicTails.Image = Global.CoinFlip.My.Resources.Resources.tails
        Me.PicTails.Location = New System.Drawing.Point(332, 12)
        Me.PicTails.Name = "PicTails"
        Me.PicTails.Size = New System.Drawing.Size(106, 91)
        Me.PicTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTails.TabIndex = 1
        Me.PicTails.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicTails, "Click for TAILS")
        '
        'Picheads
        '
        Me.Picheads.Image = Global.CoinFlip.My.Resources.Resources.heads
        Me.Picheads.Location = New System.Drawing.Point(103, 12)
        Me.Picheads.Name = "Picheads"
        Me.Picheads.Size = New System.Drawing.Size(100, 91)
        Me.Picheads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picheads.TabIndex = 0
        Me.Picheads.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Picheads, "Click for HEADS")
        '
        'lblwinner
        '
        Me.lblwinner.AutoSize = True
        Me.lblwinner.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwinner.Location = New System.Drawing.Point(201, 123)
        Me.lblwinner.Name = "lblwinner"
        Me.lblwinner.Size = New System.Drawing.Size(115, 30)
        Me.lblwinner.TabIndex = 2
        Me.lblwinner.Text = "Let's  Play"
        '
        'lblplayerwins
        '
        Me.lblplayerwins.AutoSize = True
        Me.lblplayerwins.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayerwins.Location = New System.Drawing.Point(3, 152)
        Me.lblplayerwins.Name = "lblplayerwins"
        Me.lblplayerwins.Size = New System.Drawing.Size(155, 30)
        Me.lblplayerwins.TabIndex = 3
        Me.lblplayerwins.Text = "Player Wins: 0"
        '
        'lblcomputerwins
        '
        Me.lblcomputerwins.AutoSize = True
        Me.lblcomputerwins.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomputerwins.Location = New System.Drawing.Point(3, 205)
        Me.lblcomputerwins.Name = "lblcomputerwins"
        Me.lblcomputerwins.Size = New System.Drawing.Size(193, 30)
        Me.lblcomputerwins.TabIndex = 4
        Me.lblcomputerwins.Text = "Computer Wins: 0"
        '
        'lblHeadsrolled
        '
        Me.lblHeadsrolled.AutoSize = True
        Me.lblHeadsrolled.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadsrolled.Location = New System.Drawing.Point(3, 266)
        Me.lblHeadsrolled.Name = "lblHeadsrolled"
        Me.lblHeadsrolled.Size = New System.Drawing.Size(170, 30)
        Me.lblHeadsrolled.TabIndex = 5
        Me.lblHeadsrolled.Text = "Heads Rolled: 0"
        '
        'lbltailsrolled
        '
        Me.lbltailsrolled.AutoSize = True
        Me.lbltailsrolled.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltailsrolled.Location = New System.Drawing.Point(3, 326)
        Me.lbltailsrolled.Name = "lbltailsrolled"
        Me.lbltailsrolled.Size = New System.Drawing.Size(153, 30)
        Me.lbltailsrolled.TabIndex = 6
        Me.lbltailsrolled.Text = "Tails Rolled: 0"
        '
        'PicToss
        '
        Me.PicToss.Location = New System.Drawing.Point(262, 166)
        Me.PicToss.Name = "PicToss"
        Me.PicToss.Size = New System.Drawing.Size(203, 190)
        Me.PicToss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicToss.TabIndex = 7
        Me.PicToss.TabStop = False
        '
        'TmtRestart
        '
        Me.TmtRestart.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 375)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicToss)
        Me.Controls.Add(Me.lbltailsrolled)
        Me.Controls.Add(Me.lblHeadsrolled)
        Me.Controls.Add(Me.lblcomputerwins)
        Me.Controls.Add(Me.lblplayerwins)
        Me.Controls.Add(Me.lblwinner)
        Me.Controls.Add(Me.PicTails)
        Me.Controls.Add(Me.Picheads)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Heads or Tails"
        CType(Me.PicTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picheads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicToss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picheads As System.Windows.Forms.PictureBox
    Friend WithEvents PicTails As System.Windows.Forms.PictureBox
    Friend WithEvents lblwinner As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblplayerwins As System.Windows.Forms.Label
    Friend WithEvents lblcomputerwins As System.Windows.Forms.Label
    Friend WithEvents lblHeadsrolled As System.Windows.Forms.Label
    Friend WithEvents lbltailsrolled As System.Windows.Forms.Label
    Friend WithEvents PicToss As System.Windows.Forms.PictureBox
    Friend WithEvents TmtRestart As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
