Public Class menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.chosenDifficulty = 0
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.chosenDifficulty = 1
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.chosenDifficulty = 2
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.chosenDifficulty = 3
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.chosenDifficulty = 4
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.WinsCount
        TextBox2.Text = My.Settings.LossesCount
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
        My.Settings.WinsCount = 0
        My.Settings.LossesCount = 0
        My.Settings.Save()
        TextBox1.Text = My.Settings.WinsCount
        TextBox2.Text = My.Settings.LossesCount
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = My.Settings.WinsCount
        TextBox2.Text = My.Settings.LossesCount
    End Sub

End Class