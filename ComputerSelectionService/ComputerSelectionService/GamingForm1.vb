Imports ComputerSelectionService.GamingVariables
Public Class GamingForm1

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FivetoThousand.Click
        PriceRange = "500 to 1000"
        GamingForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Lessthan500.Click
        PriceRange = "less than 500"
        GamingForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles OverAThousand.Click
        PriceRange = "Over 1000"
        GamingForm2.Show()
        Me.Hide()
    End Sub

    Private Sub GamingForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class