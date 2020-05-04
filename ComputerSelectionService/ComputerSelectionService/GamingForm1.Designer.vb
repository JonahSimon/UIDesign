<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamingForm1
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Lessthan500 = New System.Windows.Forms.Button()
        Me.FivetoThousand = New System.Windows.Forms.Button()
        Me.OverAThousand = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(12, 415)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Lessthan500
        '
        Me.Lessthan500.AccessibleName = ""
        Me.Lessthan500.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Lessthan500.Location = New System.Drawing.Point(87, 250)
        Me.Lessthan500.Name = "Lessthan500"
        Me.Lessthan500.Size = New System.Drawing.Size(189, 81)
        Me.Lessthan500.TabIndex = 1
        Me.Lessthan500.Text = "Less than 500"
        Me.Lessthan500.UseVisualStyleBackColor = True
        '
        'FivetoThousand
        '
        Me.FivetoThousand.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.FivetoThousand.Location = New System.Drawing.Point(326, 250)
        Me.FivetoThousand.Name = "FivetoThousand"
        Me.FivetoThousand.Size = New System.Drawing.Size(189, 81)
        Me.FivetoThousand.TabIndex = 2
        Me.FivetoThousand.Text = "500 to 1000"
        Me.FivetoThousand.UseVisualStyleBackColor = True
        '
        'OverAThousand
        '
        Me.OverAThousand.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.OverAThousand.Location = New System.Drawing.Point(562, 250)
        Me.OverAThousand.Name = "OverAThousand"
        Me.OverAThousand.Size = New System.Drawing.Size(189, 81)
        Me.OverAThousand.TabIndex = 3
        Me.OverAThousand.Text = "Over a thousand"
        Me.OverAThousand.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(205, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "What is your price range?"
        '
        'GamingForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OverAThousand)
        Me.Controls.Add(Me.FivetoThousand)
        Me.Controls.Add(Me.Lessthan500)
        Me.Controls.Add(Me.HomeButton)
        Me.Name = "GamingForm1"
        Me.Text = "GamingForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents Lessthan500 As Button
    Friend WithEvents FivetoThousand As Button
    Friend WithEvents OverAThousand As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
