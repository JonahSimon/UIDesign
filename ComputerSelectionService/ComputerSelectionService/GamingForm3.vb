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

    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm = New StartupPage '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New GamingForm2 '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub
End Class