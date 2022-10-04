Public Class MainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub SleepScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSchedule.Click
        Dim frmSleepSchedule As New DailySleep

        frmSleepSchedule.ShowDialog()
        Visible = False

    End Sub

    Private Sub WorkoutScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutScheduleToolStripMenuItem.Click
        Dim frmWorkOutSchedule As New DailyWorkout
        frmWorkOutSchedule.ShowDialog()
        Dim frmWeeklyTotals As New WeeklyTotals
        frmWeeklyTotals.ShowDialog()
        Dim frmTotals As New TotalsForm
        frmTotals.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click


        MessageBox.Show(" This program aims at calculating a weekly average of the 
number of hours a person sleeps and works out. Based on the information the user puts in
appropriate advice will be provided at the end. The number of days chosen if 5 to indicate
the number of working days or school days of the user without the weekend. This is because 
user might sleep more during the weekend which might provide an innacurate average.")

    End Sub
End Class