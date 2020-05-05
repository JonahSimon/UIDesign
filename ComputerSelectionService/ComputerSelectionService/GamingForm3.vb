Imports ComputerSelectionService.GamingVariables
Public Class GamingForm3
    Private Sub Casual_Click(sender As Object, e As EventArgs) Handles Casual.Click
        CasualOrCompetitive = "Casual"
        YourSelections.Show()
        Me.Hide()
    End Sub

    Private Sub Competitive_Click(sender As Object, e As EventArgs) Handles Competitive.Click
        CasualOrCompetitive = "Competitive"
        YourSelections.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub GamingForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class