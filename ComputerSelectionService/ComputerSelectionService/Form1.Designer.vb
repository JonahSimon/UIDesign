<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Title = New System.Windows.Forms.Label()
        Me.Profesional = New System.Windows.Forms.Button()
        Me.Gaming = New System.Windows.Forms.Button()
        Me.Consumer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(184, 1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(549, 50)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Computer Selection Sevice"
        '
        'Profesional
        '
        Me.Profesional.BackColor = System.Drawing.Color.DarkViolet
        Me.Profesional.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profesional.ForeColor = System.Drawing.Color.White
        Me.Profesional.Location = New System.Drawing.Point(143, 298)
        Me.Profesional.Name = "Profesional"
        Me.Profesional.Size = New System.Drawing.Size(189, 81)
        Me.Profesional.TabIndex = 1
        Me.Profesional.Text = "Professional Computer"
        Me.Profesional.UseVisualStyleBackColor = False
        '
        'Gaming
        '
        Me.Gaming.BackColor = System.Drawing.Color.DarkViolet
        Me.Gaming.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gaming.ForeColor = System.Drawing.Color.White
        Me.Gaming.Location = New System.Drawing.Point(581, 298)
        Me.Gaming.Name = "Gaming"
        Me.Gaming.Size = New System.Drawing.Size(189, 81)
        Me.Gaming.TabIndex = 2
        Me.Gaming.Text = "Gaming Computer"
        Me.Gaming.UseVisualStyleBackColor = False
        '
        'Consumer
        '
        Me.Consumer.BackColor = System.Drawing.Color.DarkViolet
        Me.Consumer.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consumer.ForeColor = System.Drawing.Color.White
        Me.Consumer.Location = New System.Drawing.Point(362, 298)
        Me.Consumer.Name = "Consumer"
        Me.Consumer.Size = New System.Drawing.Size(189, 81)
        Me.Consumer.TabIndex = 3
        Me.Consumer.Text = "Casual Computer"
        Me.Consumer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "What kind of computer are you searching for?"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(804, 443)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 49)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StartupPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Consumer)
        Me.Controls.Add(Me.Gaming)
        Me.Controls.Add(Me.Profesional)
        Me.Controls.Add(Me.Title)
        Me.Name = "StartupPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Profesional As Button
    Friend WithEvents Gaming As Button
    Friend WithEvents Consumer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
