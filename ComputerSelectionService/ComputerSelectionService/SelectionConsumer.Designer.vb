<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionConsumer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectionConsumer))
        Me.ChosenDevice = New System.Windows.Forms.PictureBox()
        Me.DeskOrLap = New System.Windows.Forms.Label()
        Me.CompCasual = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.ComputerType = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.YourComputerName = New System.Windows.Forms.Label()
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChosenDevice
        '
        Me.ChosenDevice.Image = CType(resources.GetObject("ChosenDevice.Image"), System.Drawing.Image)
        Me.ChosenDevice.Location = New System.Drawing.Point(310, 274)
        Me.ChosenDevice.Name = "ChosenDevice"
        Me.ChosenDevice.Size = New System.Drawing.Size(281, 189)
        Me.ChosenDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ChosenDevice.TabIndex = 30
        Me.ChosenDevice.TabStop = False
        '
        'DeskOrLap
        '
        Me.DeskOrLap.AutoSize = True
        Me.DeskOrLap.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.DeskOrLap.Location = New System.Drawing.Point(336, 220)
        Me.DeskOrLap.Name = "DeskOrLap"
        Me.DeskOrLap.Size = New System.Drawing.Size(205, 29)
        Me.DeskOrLap.TabIndex = 29
        Me.DeskOrLap.Text = "DesktopOrLaptop"
        '
        'CompCasual
        '
        Me.CompCasual.AutoSize = True
        Me.CompCasual.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.CompCasual.Location = New System.Drawing.Point(621, 220)
        Me.CompCasual.Name = "CompCasual"
        Me.CompCasual.Size = New System.Drawing.Size(264, 29)
        Me.CompCasual.TabIndex = 28
        Me.CompCasual.Text = "RecrationOrEducation"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Price.Location = New System.Drawing.Point(175, 220)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(72, 29)
        Me.Price.TabIndex = 27
        Me.Price.Text = "Price"
        '
        'ComputerType
        '
        Me.ComputerType.AutoSize = True
        Me.ComputerType.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.ComputerType.Location = New System.Drawing.Point(12, 220)
        Me.ComputerType.Name = "ComputerType"
        Me.ComputerType.Size = New System.Drawing.Size(65, 29)
        Me.ComputerType.TabIndex = 26
        Me.ComputerType.Text = "Type"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(184, 1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(549, 50)
        Me.Title.TabIndex = 33
        Me.Title.Text = "Computer Selection Sevice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(310, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 36)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Our Recommendations"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SlateBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(12, 388)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 49)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(12, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 49)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'YourComputerName
        '
        Me.YourComputerName.AutoSize = True
        Me.YourComputerName.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.YourComputerName.Location = New System.Drawing.Point(366, 466)
        Me.YourComputerName.Name = "YourComputerName"
        Me.YourComputerName.Size = New System.Drawing.Size(175, 29)
        Me.YourComputerName.TabIndex = 38
        Me.YourComputerName.Text = "YourComputer"
        '
        'SelectionConsumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.YourComputerName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ChosenDevice)
        Me.Controls.Add(Me.DeskOrLap)
        Me.Controls.Add(Me.CompCasual)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.ComputerType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectionConsumer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSS Selections"
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChosenDevice As PictureBox
    Friend WithEvents DeskOrLap As Label
    Friend WithEvents CompCasual As Label
    Friend WithEvents Price As Label
    Friend WithEvents ComputerType As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents YourComputerName As Label
End Class
