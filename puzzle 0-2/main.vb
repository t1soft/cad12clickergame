﻿Public Class main

    Function StartQuick(ByVal OppClick As Integer, ByVal OppA As Integer, ByVal OppB As Integer, ByVal OppC As Integer, ByVal XPAmt As Integer)
        My.Settings.OppClickSpeed = OppClick
        My.Settings.OppCooldownA = OppA
        My.Settings.OppCooldownB = OppB
        My.Settings.OppCooldownC = OppC
        My.Settings.gameXP = XPAmt
        My.Settings.Save()
        Form1.Show()
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartQuick(1, 15, 25, 35, 25)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartQuick(1, 9, 15, 25, 50)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StartQuick(1, 5, 10, 15, 100)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StartQuick(1, 1, 3, 5, 400)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        StartQuick(5, 5, 10, 15, 600)
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.userXP
        nameLabel.Text = My.Settings.userUsernane
        catchphraseLabel.Text = My.Settings.userCatchphrase
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.userUsernane = TextBox3.Text
        My.Settings.Save()
        nameLabel.Text = My.Settings.userUsernane
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.userCatchphrase = TextBox4.Text
        My.Settings.Save()
        catchphraseLabel.Text = My.Settings.userCatchphrase

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.userXP = 0
        My.Settings.Save()
        TextBox1.Text = My.Settings.userXP
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = My.Settings.userXP
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        StartQuick(OppClickPicker.Value, OppAPicker.Value, OppBPicker.Value, OppCPicker.Value, 0)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        StartQuick(2, 3, 6, 9, 200)
    End Sub
End Class