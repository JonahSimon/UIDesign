<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumerForm3
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Competitive = New System.Windows.Forms.Button()
        Me.Casual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(72, 386)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 18
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(53, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(761, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Are you looking for entertainment or educaction?"
        '
        'Competitive
        '
        Me.Competitive.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Competitive.Location = New System.Drawing.Point(455, 208)
        Me.Competitive.Name = "Competitive"
        Me.Competitive.Size = New System.Drawing.Size(189, 81)
        Me.Competitive.TabIndex = 16
        Me.Competitive.Text = "Education"
        Me.Competitive.UseVisualStyleBackColor = True
        '
        'Casual
        '
        Me.Casual.AccessibleName = ""
        Me.Casual.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Casual.Location = New System.Drawing.Point(245, 208)
        Me.Casual.Name = "Casual"
        Me.Casual.Size = New System.Drawing.Size(189, 81)
        Me.Casual.TabIndex = 15
        Me.Casual.Text = "Entertainment"
        Me.Casual.UseVisualStyleBackColor = True
        '
        'ConsumerForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 514)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Competitive)
        Me.Controls.Add(Me.Casual)
        Me.Name = "ConsumerForm3"
        Me.Text = "ConsumerForm3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Competitive As Button
    Friend WithEvents Casual As Button
End Class
