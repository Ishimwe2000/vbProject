Public Class WelcomeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "123" And txtPassword.Text = "123" Then
            gpxLogin.Visible = False

        Else
            MessageBox.Show("incorrect username or password")

        End If
        'This is the basis for all the form transitions, remeber that!
        Dim frmMainForm As New MainForm
        frmMainForm.ShowDialog()
        Visible = False
    End Sub
End Class
