﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChosenDevice
        '
        Me.ChosenDevice.Image = CType(resources.GetObject("ChosenDevice.Image"), System.Drawing.Image)
        Me.ChosenDevice.Location = New System.Drawing.Point(290, 263)
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
        Me.DeskOrLap.Location = New System.Drawing.Point(454, 173)
        Me.DeskOrLap.Name = "DeskOrLap"
        Me.DeskOrLap.Size = New System.Drawing.Size(205, 29)
        Me.DeskOrLap.TabIndex = 29
        Me.DeskOrLap.Text = "DesktopOrLaptop"
        '
        'CompCasual
        '
        Me.CompCasual.AutoSize = True
        Me.CompCasual.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.CompCasual.Location = New System.Drawing.Point(714, 173)
        Me.CompCasual.Name = "CompCasual"
        Me.CompCasual.Size = New System.Drawing.Size(151, 29)
        Me.CompCasual.TabIndex = 28
        Me.CompCasual.Text = "EnterOrEdu"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Price.Location = New System.Drawing.Point(218, 173)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(72, 29)
        Me.Price.TabIndex = 27
        Me.Price.Text = "Price"
        '
        'ComputerType
        '
        Me.ComputerType.AutoSize = True
        Me.ComputerType.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.ComputerType.Location = New System.Drawing.Point(7, 173)
        Me.ComputerType.Name = "ComputerType"
        Me.ComputerType.Size = New System.Drawing.Size(65, 29)
        Me.ComputerType.TabIndex = 26
        Me.ComputerType.Text = "Type"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(26, 373)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 25
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(320, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Your Selections"
        '
        'SelectionConsumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 522)
        Me.Controls.Add(Me.ChosenDevice)
        Me.Controls.Add(Me.DeskOrLap)
        Me.Controls.Add(Me.CompCasual)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.ComputerType)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SelectionConsumer"
        Me.Text = "SelectionConsumer"
        CType(Me.ChosenDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChosenDevice As PictureBox
    Friend WithEvents DeskOrLap As Label
    Friend WithEvents CompCasual As Label
    Friend WithEvents Price As Label
    Friend WithEvents ComputerType As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents Label3 As Label
End Class