Public Class Form1

#Region "Variables"

    Dim GameStarted As Boolean = False
    Dim Countdown As Integer = 5

    Dim difLevel As Integer = My.Settings.chosenDifficulty

    Dim opponentCooldownA As Integer = 5
    Dim opponentCooldownB As Integer = 10
    Dim opponentCooldownC As Integer = 15
    Dim opponentCooldownRegulator As Integer = 0
    Dim opponentCooldownUsed As Boolean = True

    Dim UserA As Integer = 15
    Dim UserB As Integer = 25
    Dim UserC As Integer = 35
    Dim AStatus As Boolean = False
    Dim BStatus As Boolean = False
    Dim CStatus As Boolean = False

#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button2.Enabled = False
        Button2.Text = "15"
        UserA = 15
        AStatus = True

        Button3.Enabled = False
        Button3.Text = "25"
        UserB = 25
        BStatus = True

        Button4.Enabled = False
        Button4.Text = "35"
        UserC = 35
        CStatus = True

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Countdown > 0 Then
            Countdown = Countdown - 1
            Label4.Text = Countdown
        ElseIf Countdown = 0 Then
            Label4.Text = "Begin!"
            Timer1.Enabled = True
            Button1.Enabled = True
            RunAwayForefitToolStripMenuItem.Enabled = True
            Timer3.Enabled = False
            GameStarted = True
        End If

    End Sub

    Function difficultySetter(ByVal coolSelect As Integer)
        If difLevel = 0 Then
            If coolSelect = 1 Then
                opponentCooldownA = 15
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 25
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 35
            End If
        End If
        If difLevel = 1 Then
            If coolSelect = 1 Then
                opponentCooldownA = 11
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 18
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 27
            End If
        End If
        If difLevel = 2 Then
            If coolSelect = 1 Then
                opponentCooldownA = 9
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 15
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 24
            End If
        End If
        If difLevel = 3 Then
            If coolSelect = 1 Then
                opponentCooldownA = 6
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 11
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 20
            End If
        End If
        If difLevel = 4 Then
            If coolSelect = 1 Then
                opponentCooldownA = 1
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 8
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 15
            End If
        End If
    End Function

    Function winEndProtocall(ByVal gameResult As Integer)
        Timer1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        RunAwayForefitToolStripMenuItem.Enabled = False
        GameStarted = False
        If gameResult = 1 Then
            Label4.Text = "You have Won the game! (Game has ended, Close this window.)"
            My.Settings.WinsCount = My.Settings.WinsCount + 1
            My.Settings.Save()
        ElseIf gameResult = 2 Then
            Label4.Text = "You have Lost. Dont give up, keep trying! (Game has ended, Close this window.)"
            My.Settings.LossesCount = My.Settings.LossesCount + 1
            My.Settings.Save()
        ElseIf gameResult = 3 Then
            Label4.Text = "You have Forfited and lost. (Game has ended, Close this window.)"
            My.Settings.LossesCount = My.Settings.LossesCount + 1
            My.Settings.Save()
        End If
    End Function

    Function OpponentLogic()
        opponentCooldownRegulator = opponentCooldownRegulator + 1
        ToolStripMenuItem1.Text = opponentCooldownA
        ToolStripMenuItem2.Text = opponentCooldownB
        ToolStripMenuItem3.Text = opponentCooldownC
        ToolStripMenuItem4.Text = opponentCooldownRegulator

        If opponentCooldownRegulator = 5 Then
            opponentCooldownA = opponentCooldownA - 1
            opponentCooldownB = opponentCooldownB - 1
            opponentCooldownC = opponentCooldownC - 1
            opponentCooldownRegulator = 0
        End If


        If opponentCooldownC = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 25 Then
                ProgressBar1.Value = ProgressBar1.Value - 25
            End If
            If ProgressBar1.Value = 25 Or ProgressBar1.Value < 25 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(3)
        End If

        If opponentCooldownB = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 15 Then
                ProgressBar1.Value = ProgressBar1.Value - 15
            End If
            If ProgressBar1.Value = 15 Or ProgressBar1.Value < 15 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(2)
        End If

        If opponentCooldownA = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 5 Then
                ProgressBar1.Value = ProgressBar1.Value - 5
            End If
            If ProgressBar1.Value = 5 Or ProgressBar1.Value < 5 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(1)
        End If

        opponentCooldownUsed = True



    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value > 0 Then
            ProgressBar1.Value = ProgressBar1.Value - 1
            OpponentLogic()
        End If
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        End If
        If ProgressBar1.Value = 0 Then
            winEndProtocall(2)
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If AStatus = True Then
            UserA = UserA - 1
            Button2.Text = UserA
        End If

        If BStatus = True Then
            UserB = UserB - 1
            Button3.Text = UserB
        End If

        If CStatus = True Then
            UserC = UserC - 1
            Button4.Text = UserC
        End If


        If UserA = 0 Then
            Button2.Enabled = True
            Button2.Text = "Blunt Attack (-5)"
            AStatus = False
        End If

        If UserB = 0 Then
            Button3.Enabled = True
            Button3.Text = "Flaming Fire (-15)"
            BStatus = False
        End If

        If UserC = 0 Then
            Button4.Enabled = True
            Button4.Text = "Electricution (-25)"
            CStatus = False
        End If

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "a"c Or e.KeyChar = "s"c Then
            If GameStarted = True Then
                If ProgressBar1.Value = 100 Then
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If
            End If
        End If
        If e.KeyChar = "j"c Then
            If GameStarted = True Then
                If ProgressBar1.Value = 95 Or ProgressBar1.Value > 95 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 5
                    Button2.Enabled = False
                    Button2.Text = "15"
                    UserA = 15
                    AStatus = True
                End If
            End If

        End If
        If e.KeyChar = "k"c Then
            If GameStarted = True Then
                If ProgressBar1.Value = 85 Or ProgressBar1.Value > 85 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 15
                    Button3.Enabled = False
                    Button3.Text = "25"
                    UserB = 25
                    BStatus = True
                End If
            End If

        End If
        If e.KeyChar = "l"c Then
            If GameStarted = True Then
                If ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 25
                    Button4.Enabled = False
                    Button4.Text = "35"
                    UserC = 35
                    CStatus = True
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 100 Then
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 95 Or ProgressBar1.Value > 95 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 5
                Button2.Enabled = False
                Button2.Text = "15"
                UserA = 15
                AStatus = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 85 Or ProgressBar1.Value > 85 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 15
                Button3.Enabled = False
                Button3.Text = "25"
                UserB = 25
                BStatus = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 25
                Button4.Enabled = False
                Button4.Text = "35"
                UserC = 35
                CStatus = True
            End If
        End If
    End Sub

    Private Sub RunAwayForefitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAwayForefitToolStripMenuItem.Click
        If GameStarted = True Then
            ProgressBar1.Value = 0
            winEndProtocall(3)
        End If
    End Sub


End Class
