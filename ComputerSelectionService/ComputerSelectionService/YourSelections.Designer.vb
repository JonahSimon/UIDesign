<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YourSelections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YourSelections))
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComputerType = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.CompCasual = New System.Windows.Forms.Label()
        Me.DeskOrLap = New System.Windows.Forms.Label()
        Me.ChosenDevice = New System.Windows.Forms.PictureBox()
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(31, 354)
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
        Me.Label3.Location = New System.Drawing.Point(325, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Your Selections"
        '
        'ComputerType
        '
        Me.ComputerType.AutoSize = True
        Me.ComputerType.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.ComputerType.Location = New System.Drawing.Point(12, 154)
        Me.ComputerType.Name = "ComputerType"
        Me.ComputerType.Size = New System.Drawing.Size(65, 29)
        Me.ComputerType.TabIndex = 19
        Me.ComputerType.Text = "Type"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Price.Location = New System.Drawing.Point(223, 154)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(72, 29)
        Me.Price.TabIndex = 20
        Me.Price.Text = "Price"
        '
        'CompCasual
        '
        Me.CompCasual.AutoSize = True
        Me.CompCasual.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.CompCasual.Location = New System.Drawing.Point(719, 154)
        Me.CompCasual.Name = "CompCasual"
        Me.CompCasual.Size = New System.Drawing.Size(175, 29)
        Me.CompCasual.TabIndex = 21
        Me.CompCasual.Text = "CompOrCasual"
        '
        'DeskOrLap
        '
        Me.DeskOrLap.AutoSize = True
        Me.DeskOrLap.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.DeskOrLap.Location = New System.Drawing.Point(459, 154)
        Me.DeskOrLap.Name = "DeskOrLap"
        Me.DeskOrLap.Size = New System.Drawing.Size(205, 29)
        Me.DeskOrLap.TabIndex = 22
        Me.DeskOrLap.Text = "DesktopOrLaptop"
        '
        'ChosenDevice
        '
        Me.ChosenDevice.Image = CType(resources.GetObject("ChosenDevice.Image"), System.Drawing.Image)
        Me.ChosenDevice.Location = New System.Drawing.Point(295, 244)
        Me.ChosenDevice.Name = "ChosenDevice"
        Me.ChosenDevice.Size = New System.Drawing.Size(281, 189)
        Me.ChosenDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ChosenDevice.TabIndex = 23
        Me.ChosenDevice.TabStop = False
        '
        'YourSelections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 504)
        Me.Controls.Add(Me.ChosenDevice)
        Me.Controls.Add(Me.DeskOrLap)
        Me.Controls.Add(Me.CompCasual)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.ComputerType)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Name = "YourSelections"
        Me.Text = "YourSelections"
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComputerType As Label
    Friend WithEvents Price As Label
    Friend WithEvents CompCasual As Label
    Friend WithEvents DeskOrLap As Label
    Friend WithEvents ChosenDevice As PictureBox
End Class
