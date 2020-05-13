Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm1


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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub
End Class