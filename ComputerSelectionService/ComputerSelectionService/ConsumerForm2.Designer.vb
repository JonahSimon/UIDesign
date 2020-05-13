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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Laptop = New System.Windows.Forms.Button()
        Me.Desktop = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(155, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(621, 36)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Are you looking for a desktop or laptop?"
        '
        'Laptop
        '
        Me.Laptop.BackColor = System.Drawing.Color.DarkViolet
        Me.Laptop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Laptop.ForeColor = System.Drawing.Color.White
        Me.Laptop.Location = New System.Drawing.Point(539, 298)
        Me.Laptop.Name = "Laptop"
        Me.Laptop.Size = New System.Drawing.Size(189, 81)
        Me.Laptop.TabIndex = 13
        Me.Laptop.Text = "Laptop"
        Me.Laptop.UseVisualStyleBackColor = False
        '
        'Desktop
        '
        Me.Desktop.AccessibleName = ""
        Me.Desktop.BackColor = System.Drawing.Color.DarkViolet
        Me.Desktop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Desktop.ForeColor = System.Drawing.Color.White
        Me.Desktop.Location = New System.Drawing.Point(188, 298)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(189, 81)
        Me.Desktop.TabIndex = 12
        Me.Desktop.Text = "Desktop"
        Me.Desktop.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(12, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 43)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(804, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Quit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(184, 1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(549, 50)
        Me.Title.TabIndex = 23
        Me.Title.Text = "Computer Selection Sevice"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(12, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 49)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ConsumerForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Laptop)
        Me.Controls.Add(Me.Desktop)
        Me.Name = "ConsumerForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSS Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Laptop As Button
    Friend WithEvents Desktop As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Title As Label
    Friend WithEvents Button2 As Button
End Class
