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
        Me.components = New System.ComponentModel.Container
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.World1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NowHeresAChallengeOpponentsUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 172)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(573, 40)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Normal Attack (-1)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Blunt Attack (-5)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 70)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Flaming Fire (-15)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(405, 319)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 70)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Electricution (-25)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(31, 37)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 24)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Run Away (Forefit)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "cad12ishappy (YOU)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.DifficultyToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateGameToolStripMenuItem, Me.World1ToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.GameToolStripMenuItem.Text = "  Game Map"
        '
        'CreateGameToolStripMenuItem
        '
        Me.CreateGameToolStripMenuItem.Name = "CreateGameToolStripMenuItem"
        Me.CreateGameToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CreateGameToolStripMenuItem.Text = "Tutorial"
        '
        'World1ToolStripMenuItem
        '
        Me.World1ToolStripMenuItem.Name = "World1ToolStripMenuItem"
        Me.World1ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.World1ToolStripMenuItem.Text = "World 1"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem, Me.NowHeresAChallengeOpponentsUseToolStripMenuItem, Me.DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem, Me.WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem, Me.HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem
        '
        Me.JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem.Name = "JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem"
        Me.JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem.Text = "Just Under MY Level (Easy)"
        '
        'NowHeresAChallengeOpponentsUseToolStripMenuItem
        '
        Me.NowHeresAChallengeOpponentsUseToolStripMenuItem.Name = "NowHeresAChallengeOpponentsUseToolStripMenuItem"
        Me.NowHeresAChallengeOpponentsUseToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.NowHeresAChallengeOpponentsUseToolStripMenuItem.Text = "Now here's a Challenge (Normal)"
        '
        'DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem
        '
        Me.DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem.Name = "DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem"
        Me.DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem.Text = "Damn, that was a little hard (Medium)"
        '
        'WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem
        '
        Me.WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem.Name = "WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem"
        Me.WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem.Text = "Well, I might actually lose (Hard)"
        '
        'HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem
        '
        Me.HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem.Name = "HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem"
        Me.HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem.Text = "hanako: on my way to murder everyone (Hardcore)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(25, 20)
        Me.ToolStripMenuItem1.Text = "0"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(25, 20)
        Me.ToolStripMenuItem2.Text = "0"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(25, 20)
        Me.ToolStripMenuItem3.Text = "0"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(25, 20)
        Me.ToolStripMenuItem4.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Your Opponent (Hard Level)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "discord.gg/thepile"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "cad12ishappy's Clicker Game!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreateGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JustUnderMYLevelOpponentsUseNormalBluntAttacksAndFlamingFireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NowHeresAChallengeOpponentsUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamnThatWasALittleHardOpponentsUseAllAtacksMoreOftenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WellIMightActuallyLoseOpponentsUseAllAttacksWithLESSCOOLDOWNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents World1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HanakoOnMyWayToMurderEveryoneHardcoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem

End Class
