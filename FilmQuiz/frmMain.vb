Public Class frmMain


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        playerScore = 0
        playerName = txtName.Text
        frmQuestion1.Show()

        Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
