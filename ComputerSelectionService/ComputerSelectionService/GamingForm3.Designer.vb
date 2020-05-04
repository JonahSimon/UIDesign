<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamingForm3
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
        Me.Competitive = New System.Windows.Forms.Button()
        Me.Casual = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(55, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(696, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Are you playing casual or competitive games?"
        '
        'Competitive
        '
        Me.Competitive.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Competitive.Location = New System.Drawing.Point(395, 237)
        Me.Competitive.Name = "Competitive"
        Me.Competitive.Size = New System.Drawing.Size(189, 81)
        Me.Competitive.TabIndex = 12
        Me.Competitive.Text = "Competitive"
        Me.Competitive.UseVisualStyleBackColor = True
        '
        'Casual
        '
        Me.Casual.AccessibleName = ""
        Me.Casual.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Casual.Location = New System.Drawing.Point(185, 237)
        Me.Casual.Name = "Casual"
        Me.Casual.Size = New System.Drawing.Size(189, 81)
        Me.Casual.TabIndex = 11
        Me.Casual.Text = "Casual"
        Me.Casual.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(12, 415)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 14
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'GamingForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Competitive)
        Me.Controls.Add(Me.Casual)
        Me.Name = "GamingForm3"
        Me.Text = "GamingForm3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Competitive As Button
    Friend WithEvents Casual As Button
    Friend WithEvents HomeButton As Button
End Class
