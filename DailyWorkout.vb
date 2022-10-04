Public Class DailyWorkout

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim blnInputOk As Boolean = True
        'remember that the workout variables were declared in the global module variables. 

        If Double.TryParse(txtWorkout1.Text, g_intWorkout1) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If
        ' If g_intWorkout1 < 1 Then
        ' If g_intTuesdayHours > 5 Then
        'MessageBox.Show(" workout hours must be in the range 1 to 5")
        'blnInputOk = False
        'End If




        If Double.TryParse(txtWorkout2.Text, g_intWorkout2) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If



        If Double.TryParse(txtWorkout3.Text, g_intWorkout3) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If


        If Double.TryParse(txtWorkout4.Text, g_intWorkout4) = False Then
                MessageBox.Show("Hours must be numeric")
                blnInputOk = False
            End If

        If Double.TryParse(txtWorkout5.Text, g_intWorkout5) = False Then
                MessageBox.Show("hours must be numeric")
                blnInputOk = False
            End If




        If blnInputOk = True Then
            g_strWrk1 = "Workout Monday = " & g_intWorkout1.ToString()
            g_strWrk2 = "Workout Tuesday = " & g_intWorkout2.ToString()
            g_strWrk3 = "Workout Wednesday = " & g_intWorkout3.ToString()
            g_strWrk4 = "Workout Thursday = " & g_intWorkout4.ToString()
            g_strWrk5 = "Workout Friday = " & g_intWorkout5.ToString()
        End If

        'clear the buttons to give the save effect
        txtWorkout1.Clear()
        txtWorkout2.Clear()
        txtWorkout3.Clear()
        txtWorkout4.Clear()
        txtWorkout5.Clear()





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        WeeklyTotals.Visible = True
        MainForm.Visible = False
        WelcomeForm.Visible = False
        Visible = False
    End Sub
End Class