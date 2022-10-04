Public Class WeeklyTotals
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'I want to change the weekly totals and out listboxes
        'that needs the for int count loop thing
        'first declare the loop in the module

       ' For intcount = 1 To g_intNUMBER_OF_DAYS

            g_decWeeklySleep = g_intMondayHours + g_intTuesdayHours + g_intWednesdayHours +
                              g_intThursdayHours + g_intFridayHours
        ' g_strOutput1 = "the number of hours slept on " & "" & "day" & intcount.ToString &
        ' "are" & g_decWeeklySleep.ToString
        lstOutput1.Items.Add(g_strDay1)
            lstOutput1.Items.Add(g_strDay2)
            lstOutput1.Items.Add(g_strDay3)
            lstOutput1.Items.Add(g_strDay4)
        lstOutput1.Items.Add(g_strDay5)

        '
        lstOutput2.Items.Add(g_strWrk1)
        lstOutput2.Items.Add(g_strWrk2)
        lstOutput2.Items.Add(g_strWrk3)
        lstOutput2.Items.Add(g_strWrk4)
        lstOutput2.Items.Add(g_strWrk5)

        'Next




        lblWeek1.Text = g_decWeeklySleep.ToString()
        'include the weekly workout as well because I am just doing one week now. 
        'Sleep was repetitive.

        g_decWeeklyWorkout = g_intWorkout1 + g_intWorkout2 + g_intWorkout3 +
            g_intWorkout4 + g_intWorkout5
        lbl2.Text = g_decWeeklyWorkout.ToString()





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'work more on this form, it looks a bit bland.
        'put the listbox

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TotalsForm.Visible = True
        MainForm.Visible = False
        WelcomeForm.Visible = False
        Visible = False
    End Sub
End Class