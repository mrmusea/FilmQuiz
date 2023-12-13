Public Class frmHighScore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub frmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If playerScore < 1 Then
            lblMessae.Text = Sorry Your Score Was Not Good Enough" Else
        lbl Message.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
 1stHighScore.Items.Add (playerName & vTab & playerScore)
End If
End Sub
End Class