Public Class TotalsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declare the average variables in the global module
        'declare the set constants to compare with
        'put If statements

        Dim dblAverageSleep As Double
        Dim dblAverageWorkout As Double
        Const dblAVERAGE_SLEEP As Double = 6
        Const dblAVERAGE_WORKOUT As Double = 1.5

        dblAverageSleep = g_decWeeklySleep / 5
        dblAverageWorkout = g_decWeeklyWorkout / 5
        'how to display the chekcboxes? 'maybe not?
        'have a total number of activities done?
        'add the messages for work out more or less
        'so I will make the average sleeping time 6.5 hours per day
        lblSleep.Text = dblAverageSleep.ToString()
        lblWorkout.Text = dblAverageWorkout.ToString()

        'create all four scenarios for the averages

        If dblAverageSleep < dblAVERAGE_SLEEP And dblAverageWorkout < dblAVERAGE_WORKOUT Then

            lblMessage.Text = "Your average sleep time per day is low. Sleep some more" & "" &
                ControlChars.CrLf & "You need to work out more"

            'remember how to make the information lined
        End If
        'I will make the average workout ime 1.5 hours per day
        If dblAverageWorkout < dblAVERAGE_WORKOUT And dblAverageSleep > dblAVERAGE_SLEEP Then
            lblMessage.Text = "Your sleep schedule is consistent" & "" & ControlChars.CrLf &
                               "You need to work out more"

        End If
        If dblAverageWorkout > dblAVERAGE_WORKOUT And dblAverageSleep < dblAVERAGE_SLEEP Then
            lblMessage.Text = " sleep some more" & "" & ControlChars.CrLf & " Your workout schedule is consistent"

        End If
        If dblAverageSleep > dblAVERAGE_SLEEP And dblAverageWorkout > dblAVERAGE_WORKOUT Then
            lblMessage.Text = "Congratulations! your sleep and workout schedule is consistent"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'bring the user to the logout button on the main form
        Dim frmMain As New MainForm
        frmMain.ShowDialog()
    End Sub
End Class