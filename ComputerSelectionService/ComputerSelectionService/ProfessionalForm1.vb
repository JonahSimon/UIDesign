Imports ComputerSelectionService.ProfessionalVariables

Public Class ProfessionalForm1
    Private Sub Lessthan500_Click(sender As Object, e As EventArgs) Handles Lessthan500.Click
        PriceRange = "less than 500"
        ProfessionalForm2.Show()
        Me.Hide()
    End Sub

    Private Sub FivetoThousand_Click(sender As Object, e As EventArgs) Handles FivetoThousand.Click
        PriceRange = "500 to 1000"
        ProfessionalForm2.Show()
        Me.Hide()
    End Sub

    Private Sub OverAThousand_Click(sender As Object, e As EventArgs) Handles OverAThousand.Click
        PriceRange = "Over 1000"
        ProfessionalForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub
End Class