<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumerForm2
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
        Me.Laptop = New System.Windows.Forms.Button()
        Me.Desktop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(75, 391)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 15
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(95, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(733, 36)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Are you looking for a desktop or mobile laptop?"
        '
        'Laptop
        '
        Me.Laptop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Laptop.Location = New System.Drawing.Point(465, 218)
        Me.Laptop.Name = "Laptop"
        Me.Laptop.Size = New System.Drawing.Size(189, 81)
        Me.Laptop.TabIndex = 13
        Me.Laptop.Text = "Laptop"
        Me.Laptop.UseVisualStyleBackColor = True
        '
        'Desktop
        '
        Me.Desktop.AccessibleName = ""
        Me.Desktop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Desktop.Location = New System.Drawing.Point(255, 218)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(189, 81)
        Me.Desktop.TabIndex = 12
        Me.Desktop.Text = "Desktop"
        Me.Desktop.UseVisualStyleBackColor = True
        '
        'ConsumerForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 511)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Laptop)
        Me.Controls.Add(Me.Desktop)
        Me.Name = "ConsumerForm2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Laptop As Button
    Friend WithEvents Desktop As Button
End Class
