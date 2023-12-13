Public Class frmQuestion1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion2.Show()

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    '    Public Sub init()

    '        tmrQuestion1.Enabled = True
    '        ProgressBarQ1.Value = 0
    '        btnAnswer1.Checked = False
    '        btnAnswer2.Checked = False
    '        btnAnswer3.Checked = False
    '        btnAnswer4.Checked = False

    '    End Sub
    '    PrivateSub btnNext_Click(sender As Object, As Even 
    'Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    '    End Sub


End Class
