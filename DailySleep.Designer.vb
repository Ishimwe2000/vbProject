<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailySleep
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
        Me.txtMondayHours = New System.Windows.Forms.TextBox()
        Me.txtTuesdayHours = New System.Windows.Forms.TextBox()
        Me.txtWednesdayHours = New System.Windows.Forms.TextBox()
        Me.txtThursdayHours = New System.Windows.Forms.TextBox()
        Me.txtFridayHours = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMondayHours
        '
        Me.txtMondayHours.Location = New System.Drawing.Point(98, 30)
        Me.txtMondayHours.Name = "txtMondayHours"
        Me.txtMondayHours.Size = New System.Drawing.Size(100, 20)
        Me.txtMondayHours.TabIndex = 0
        '
        'txtTuesdayHours
        '
        Me.txtTuesdayHours.Location = New System.Drawing.Point(98, 67)
        Me.txtTuesdayHours.Name = "txtTuesdayHours"
        Me.txtTuesdayHours.Size = New System.Drawing.Size(100, 20)
        Me.txtTuesdayHours.TabIndex = 1
        '
        'txtWednesdayHours
        '
        Me.txtWednesdayHours.Location = New System.Drawing.Point(98, 107)
        Me.txtWednesdayHours.Name = "txtWednesdayHours"
        Me.txtWednesdayHours.Size = New System.Drawing.Size(100, 20)
        Me.txtWednesdayHours.TabIndex = 2
        '
        'txtThursdayHours
        '
        Me.txtThursdayHours.Location = New System.Drawing.Point(98, 148)
        Me.txtThursdayHours.Name = "txtThursdayHours"
        Me.txtThursdayHours.Size = New System.Drawing.Size(100, 20)
        Me.txtThursdayHours.TabIndex = 3
        '
        'txtFridayHours
        '
        Me.txtFridayHours.Location = New System.Drawing.Point(98, 189)
        Me.txtFridayHours.Name = "txtFridayHours"
        Me.txtFridayHours.Size = New System.Drawing.Size(100, 20)
        Me.txtFridayHours.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Monday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tuesday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wednesday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Thursday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Friday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Enter the number of hours slept for the following days"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(315, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtFridayHours)
        Me.GroupBox4.Controls.Add(Me.txtThursdayHours)
        Me.GroupBox4.Controls.Add(Me.txtWednesdayHours)
        Me.GroupBox4.Controls.Add(Me.txtTuesdayHours)
        Me.GroupBox4.Controls.Add(Me.txtMondayHours)
        Me.GroupBox4.Location = New System.Drawing.Point(145, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 253)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(235, 418)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 19)
        Me.btnNext.TabIndex = 48
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'DailySleep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "DailySleep"
        Me.Text = "DailySleep"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMondayHours As TextBox
    Friend WithEvents txtTuesdayHours As TextBox
    Friend WithEvents txtWednesdayHours As TextBox
    Friend WithEvents txtThursdayHours As TextBox
    Friend WithEvents txtFridayHours As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNext As Button
End Class
