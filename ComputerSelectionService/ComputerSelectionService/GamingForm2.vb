Imports ComputerSelectionService.GamingVariables
Public Class GamingForm2
    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Desktop.Click
        DesktopOrLaptop = "Desktop"
        GamingForm3.Show()
        Me.Hide()
    End Sub

    Private Sub Laptop_Click(sender As Object, e As EventArgs) Handles Laptop.Click
        DesktopOrLaptop = "Laptop"
        GamingForm3.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub


End Class