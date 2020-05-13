Imports ComputerSelectionService.ProfessionalVariables
Public Class ProfessionalSelections

    Private Sub ProfessionalSelections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = ProfessionalVariables.TypeComputer
        Price.Text = ProfessionalVariables.PriceRange
        DeskOrLap.Text = ProfessionalVariables.DesktopOrLaptop
        CompCasual.Text = ProfessionalVariables.GraphicOrData

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500DataDesktop
            YourComputerName.Text = "Office Economy"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500DataLaptop
            YourComputerName.Text = "Hipster Junk"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Office Work" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500DataLaptop
            YourComputerName.Text = "Practical Paper Weight"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Graphic Design" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000GraphicDesktop
            YourComputerName.Text = "Mercury Graphics"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Office Work" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000DataDesktop
            YourComputerName.Text = "Office Master Mk2"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000GraphicsLaptop
            YourComputerName.Text = "Mercury Yogi"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Office Work" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500to1000DataLaptop
            YourComputerName.Text = "Office Master GO"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Graphic Design" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_GraphicDesktop
            YourComputerName.Text = "PineApple IMak"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Office Work" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_DataDesktop
            YourComputerName.Text = "Office Master Mk20"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_GraphicLaptop
            YourComputerName.Text = "PineApple to Gogh"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Office Work" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_DataLaptop
            YourComputerName.Text = "Paper Pusher 5000"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmC1 = New ProfessionalForm3
        frmC1.Show()
        Me.Close()
    End Sub
End Class