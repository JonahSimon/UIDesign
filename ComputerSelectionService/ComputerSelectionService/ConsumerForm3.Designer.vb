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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsumerForm3))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(84, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(761, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Are you looking for entertainment or educaction?"
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkViolet
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(539, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 81)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Education"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AccessibleName = ""
        Me.Button5.BackColor = System.Drawing.Color.DarkViolet
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(188, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(189, 81)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Recreation"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(184, 1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(549, 50)
        Me.Title.TabIndex = 25
        Me.Title.Text = "Computer Selection Sevice"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SlateBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(12, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 49)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ConsumerForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsumerForm3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSS Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Title As Label
    Friend WithEvents Button3 As Button
End Class
