<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyWorkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtWorkout1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWorkout2 = New System.Windows.Forms.TextBox()
        Me.txtWorkout3 = New System.Windows.Forms.TextBox()
        Me.txtWorkout4 = New System.Windows.Forms.TextBox()
        Me.txtWorkout5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWorkout1
        '
        Me.txtWorkout1.Location = New System.Drawing.Point(136, 85)
        Me.txtWorkout1.Name = "txtWorkout1"
        Me.txtWorkout1.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkout1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "how many hours do you work out on the following days"
        '
        'txtWorkout2
        '
        Me.txtWorkout2.Location = New System.Drawing.Point(138, 116)
        Me.txtWorkout2.Name = "txtWorkout2"
        Me.txtWorkout2.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkout2.TabIndex = 8
        '
        'txtWorkout3
        '
        Me.txtWorkout3.Location = New System.Drawing.Point(138, 154)
        Me.txtWorkout3.Name = "txtWorkout3"
        Me.txtWorkout3.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkout3.TabIndex = 9
        '
        'txtWorkout4
        '
        Me.txtWorkout4.Location = New System.Drawing.Point(138, 193)
        Me.txtWorkout4.Name = "txtWorkout4"
        Me.txtWorkout4.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkout4.TabIndex = 10
        '
        'txtWorkout5
        '
        Me.txtWorkout5.Location = New System.Drawing.Point(136, 225)
        Me.txtWorkout5.Name = "txtWorkout5"
        Me.txtWorkout5.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkout5.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Monday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tuesday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Wednesday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Thursday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Friday"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(258, 313)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 21)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'DailyWorkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWorkout5)
        Me.Controls.Add(Me.txtWorkout4)
        Me.Controls.Add(Me.txtWorkout3)
        Me.Controls.Add(Me.txtWorkout2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWorkout1)
        Me.Name = "DailyWorkout"
        Me.Text = "DailyWorkout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWorkout1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWorkout2 As TextBox
    Friend WithEvents txtWorkout3 As TextBox
    Friend WithEvents txtWorkout4 As TextBox
    Friend WithEvents txtWorkout5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnNext As Button
End Class
