Public Class DailySleep
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'global output variables that I will use throughout and make sure that
        'this is the right way to do it. 

        Dim blnInputOk As Boolean = True
        'next step is to include the other textboxes now. 





        'Also remember to include in your about section why you chose five schooldays.

        'make an if statement for when the user does not put in nunbers. 


        If Double.TryParse(txtMondayHours.Text, g_intMondayHours) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If



        If Double.TryParse(txtTuesdayHours.Text, g_intTuesdayHours) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If



        If Double.TryParse(txtWednesdayHours.Text, g_intwednesdayHours) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If



        If Double.TryParse(txtThursdayHours.Text, g_intThursdayHours) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If



        If Double.TryParse(txtFridayHours.Text, g_intFridayHours) = False Then
            MessageBox.Show("hours must be numeric")
            blnInputOk = False
        End If
        'If g_intFridayHours < 1 Then
        'If g_intFridayHours > 10 Then
        'MessageBox.Show("Hours must be in the range 1 to 10 ")
        'blnInputOk = False
        'End If

        'End If


        If blnInputOk = True Then
            g_strDay1 = " number of hours slept on Monday = " & g_intMondayHours.ToString()
            g_strDay2 = "number of hours slept on Tuesday = " & g_intTuesdayHours.ToString()
            g_strDay3 = "number of hours slept on Wednesday = " & g_intWednesdayHours.ToString()
            g_strDay4 = "number of hours slept on Thursday = " & g_intThursdayHours.ToString()
            g_strDay5 = "number of hours slept on Friday = " & g_intFridayHours.ToString()
        End If

        txtMondayHours.Clear()
        txtTuesdayHours.Clear()
        txtWednesdayHours.Clear()
        txtThursdayHours.Clear()
        txtFridayHours.Clear()
        txtMondayHours.Focus()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        DailyWorkout.Visible = True
        MainForm.Visible = False
        WelcomeForm.Visible = False
        Visible = False
    End Sub
End Class