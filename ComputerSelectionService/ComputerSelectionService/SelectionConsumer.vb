Imports ComputerSelectionService.ConsumerVariables

Public Class SelectionConsumer
    Private Sub SelectionConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = ConsumerVariables.Typingcomputer
        Price.Text = ConsumerVariables.PriceRange
        DeskOrLap.Text = ConsumerVariables.DesktopOrLaptop
        CompCasual.Text = ConsumerVariables.EntertainmentOrEducation

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500GamingDesktop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CompLaptop
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Entertainment" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500CasualLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Education" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Entertainment" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualDesktop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompLaptop
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Entertainment" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Education" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Entertainment" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualDesktop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompLaptop
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Entertainment" Then ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualLaptop


    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmC3 = New ConsumerForm3
        frmC3.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


End Class