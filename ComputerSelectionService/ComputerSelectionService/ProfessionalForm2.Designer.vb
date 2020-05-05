<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfessionalForm2
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
        Me.Desktop = New System.Windows.Forms.Button()
        Me.Laptop = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(76, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(621, 36)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Are you looking for a desktop or laptop?"
        '
        'Desktop
        '
        Me.Desktop.AccessibleName = ""
        Me.Desktop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Desktop.Location = New System.Drawing.Point(170, 239)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(189, 81)
        Me.Desktop.TabIndex = 12
        Me.Desktop.Text = "Desktop"
        Me.Desktop.UseVisualStyleBackColor = True
        '
        'Laptop
        '
        Me.Laptop.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Laptop.Location = New System.Drawing.Point(404, 239)
        Me.Laptop.Name = "Laptop"
        Me.Laptop.Size = New System.Drawing.Size(189, 81)
        Me.Laptop.TabIndex = 13
        Me.Laptop.Text = "Laptop"
        Me.Laptop.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(127, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(549, 50)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Computer Selection Sevice"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(698, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 43)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(12, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProfessionalForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Laptop)
        Me.Controls.Add(Me.Desktop)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ProfessionalForm2"
        Me.Text = "ProfessionalForm2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Desktop As Button
    Friend WithEvents Laptop As Button
    Friend WithEvents Title As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
