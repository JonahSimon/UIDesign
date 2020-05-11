Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm1


    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        StartupPage.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FivetoThousand.Click
        PriceRange = "500 to 1000"
        ConsumerForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Lessthan500.Click
        PriceRange = "less than 500"
        ConsumerForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles OverAThousand.Click
        PriceRange = "Over 1000"
        ConsumerForm2.Show()
        Me.Hide()
    End Sub

    Private Sub ConsumerForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class