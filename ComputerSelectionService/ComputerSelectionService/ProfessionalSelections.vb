Imports ComputerSelectionService.ProfessionalVariables
Public Class ProfessionalSelections

    Private Sub ProfessionalSelections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = ProfessionalVariables.TypeComputer
        Price.Text = ProfessionalVariables.PriceRange
        DeskOrLap.Text = ProfessionalVariables.DesktopOrLaptop
        CompCasual.Text = ProfessionalVariables.GraphicOrData

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500GamingDesktop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CompLaptop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Data Entry" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CasualLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Graphic Design" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Data Entry" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Data Entry" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Graphic Design" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Data Entry" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Graphic Design" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Data Entry" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualLaptop


        TypeComputer = " "
        PriceRange = 0
        DesktopOrLaptop = " "
        GraphicOrData = " "


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub
End Class