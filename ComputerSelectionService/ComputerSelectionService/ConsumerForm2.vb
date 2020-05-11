Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm2
    Private Sub ConsumerForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Desktop.Click
        DesktopOrLaptop = "Desktop"
        ConsumerForm3.Show()
        Me.Hide()
    End Sub

    Private Sub Laptop_Click(sender As Object, e As EventArgs) Handles Laptop.Click
        DesktopOrLaptop = "Laptop"
        ConsumerForm3.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim frm = New StartupPage
        frm.Show()
        Me.Close()
    End Sub
End Class