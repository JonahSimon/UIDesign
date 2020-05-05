Imports ComputerSelectionService.GamingVariables

Public Class YourSelections
    Private Sub YourSelections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = GamingVariables.TypeOfComputer
        Price.Text = GamingVariables.PriceRange
        DeskOrLap.Text = GamingVariables.DesktopOrLaptop
        CompCasual.Text = GamingVariables.CasualOrCompetitive

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500GamingDesktop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CompLaptop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CasualLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Competitive" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Casual" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Competitive" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Casual" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualLaptop


        TypeOfComputer = " "
        PriceRange = 0
        DesktopOrLaptop = " "
        CasualOrCompetitive = " "


    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

End Class