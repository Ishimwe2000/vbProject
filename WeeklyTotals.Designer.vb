<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyTotals
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWeek1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstOutput1 = New System.Windows.Forms.ListBox()
        Me.lstOutput2 = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weekly Sleep"
        '
        'lblWeek1
        '
        Me.lblWeek1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek1.Location = New System.Drawing.Point(112, 389)
        Me.lblWeek1.Name = "lblWeek1"
        Me.lblWeek1.Size = New System.Drawing.Size(100, 23)
        Me.lblWeek1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(109, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(373, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "These are the following hours of sleep and workout obtained in the past week"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Display results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Weekly workout"
        '
        'lbl2
        '
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2.Location = New System.Drawing.Point(489, 392)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(100, 24)
        Me.lbl2.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(421, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstOutput1
        '
        Me.lstOutput1.FormattingEnabled = True
        Me.lstOutput1.Location = New System.Drawing.Point(36, 174)
        Me.lstOutput1.Name = "lstOutput1"
        Me.lstOutput1.Size = New System.Drawing.Size(296, 212)
        Me.lstOutput1.TabIndex = 13
        '
        'lstOutput2
        '
        Me.lstOutput2.FormattingEnabled = True
        Me.lstOutput2.Location = New System.Drawing.Point(390, 178)
        Me.lstOutput2.Name = "lstOutput2"
        Me.lstOutput2.Size = New System.Drawing.Size(294, 212)
        Me.lstOutput2.TabIndex = 14
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(298, 465)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(70, 21)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'WeeklyTotals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstOutput2)
        Me.Controls.Add(Me.lstOutput1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblWeek1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WeeklyTotals"
        Me.Text = "WeeklySleep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblWeek1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lstOutput1 As ListBox
    Friend WithEvents lstOutput2 As ListBox
    Friend WithEvents btnNext As Button
End Class
