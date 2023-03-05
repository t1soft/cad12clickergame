Public Class Form1

    Dim difLevel As Integer = 4
    Dim opponentCooldownA As Integer = 3
    Dim opponentCooldownB As Integer = 7
    Dim opponentCooldownC As Integer = 10
    Dim opponentCooldownRegulator As Integer = 0
    Dim opponentCooldownUsed As Boolean = True

    Function difficultySetter(ByVal coolSelect As Integer)
        If difLevel = 0 Then
            If coolSelect = 1 Then
                opponentCooldownA = 25
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 35
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 45
            End If
        End If
        If difLevel = 1 Then
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
        If difLevel = 2 Then
            If coolSelect = 1 Then
                opponentCooldownA = 10
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 20
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 30
            End If
        End If
        If difLevel = 3 Then
            If coolSelect = 1 Then
                opponentCooldownA = 6
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 12
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 24
            End If
        End If
        If difLevel = 4 Then
            If coolSelect = 1 Then
                opponentCooldownA = 3
            End If
            If coolSelect = 2 Then
                opponentCooldownB = 7
            End If
            If coolSelect = 3 Then
                opponentCooldownC = 9
            End If
        End If
    End Function

    Function winEndProtocall(ByVal gameResult As Integer)
        Timer1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        If gameResult = 1 Then
            MsgBox("You have won this game!")
        ElseIf gameResult = 2 Then
            MsgBox("You have lost. Dont give up, keep trying!")
        ElseIf gameResult = 3 Then
            MsgBox("You have Forfited. You do still lose this game however...")
        End If
    End Function

    Function OpponentLogic()
        opponentCooldownRegulator = opponentCooldownRegulator + 1
        ToolStripMenuItem1.Text = opponentCooldownA
        ToolStripMenuItem2.Text = opponentCooldownB
        ToolStripMenuItem3.Text = opponentCooldownC
        ToolStripMenuItem4.Text = opponentCooldownRegulator

        If opponentCooldownRegulator = 4 Then
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
                winEndProtocall(3)
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
                winEndProtocall(1)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ProgressBar1.Value = 100 Then
            winEndProtocall(2)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        ElseIf ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
            ProgressBar1.Value = 100
            winEndProtocall(1)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        ElseIf ProgressBar1.Value = 85 Or ProgressBar1.Value > 85 Then
            ProgressBar1.Value = 100
            winEndProtocall(1)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 15
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        ElseIf ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
            ProgressBar1.Value = 100
            winEndProtocall(1)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 25
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ProgressBar1.Value = 0
        winEndProtocall(3)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
