Imports ComputerSelectionService.GamingVariables

Public Class YourSelections
    Private Sub YourSelections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = GamingVariables.TypeOfComputer
        Price.Text = GamingVariables.PriceRange
        DeskOrLap.Text = GamingVariables.DesktopOrLaptop
        CompCasual.Text = GamingVariables.CasualOrCompetitive

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