<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumerForm1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OverAThousand = New System.Windows.Forms.Button()
        Me.FivetoThousand = New System.Windows.Forms.Button()
        Me.Lessthan500 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(230, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "What is your price range?"
        '
        'OverAThousand
        '
        Me.OverAThousand.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.OverAThousand.Location = New System.Drawing.Point(587, 256)
        Me.OverAThousand.Name = "OverAThousand"
        Me.OverAThousand.Size = New System.Drawing.Size(189, 81)
        Me.OverAThousand.TabIndex = 10
        Me.OverAThousand.Text = "Over 1000"
        Me.OverAThousand.UseVisualStyleBackColor = True
        '
        'FivetoThousand
        '
        Me.FivetoThousand.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.FivetoThousand.Location = New System.Drawing.Point(351, 256)
        Me.FivetoThousand.Name = "FivetoThousand"
        Me.FivetoThousand.Size = New System.Drawing.Size(189, 81)
        Me.FivetoThousand.TabIndex = 9
        Me.FivetoThousand.Text = "500 to 1000"
        Me.FivetoThousand.UseVisualStyleBackColor = True
        '
        'Lessthan500
        '
        Me.Lessthan500.AccessibleName = ""
        Me.Lessthan500.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Lessthan500.Location = New System.Drawing.Point(112, 256)
        Me.Lessthan500.Name = "Lessthan500"
        Me.Lessthan500.Size = New System.Drawing.Size(189, 81)
        Me.Lessthan500.TabIndex = 8
        Me.Lessthan500.Text = "Less than 500"
        Me.Lessthan500.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConsumerForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 493)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OverAThousand)
        Me.Controls.Add(Me.FivetoThousand)
        Me.Controls.Add(Me.Lessthan500)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ConsumerForm1"
        Me.Text = "ConsumerForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents OverAThousand As Button
    Friend WithEvents FivetoThousand As Button
    Friend WithEvents Lessthan500 As Button
    Friend WithEvents Button1 As Button
End Class
