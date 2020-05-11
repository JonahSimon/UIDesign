Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm3

    Private Sub ConsumerForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Casual_Click(sender As Object, e As EventArgs) Handles Casual.Click
        CasualOrCompetitive = "Casual"
        SelectionConsumer.Show()
        Me.Hide()
    End Sub

    Private Sub Competitive_Click(sender As Object, e As EventArgs) Handles Competitive.Click
        CasualOrCompetitive = "Competitive"
        SelectionConsumer.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage
        frm.Show()
        Me.Close()
    End Sub
End Class