Imports ComputerSelectionService.ProfessionalVariables

Public Class ProfessionalForm2
    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Desktop.Click
        DesktopOrLaptop = "Desktop"
        ProfessionalForm3.Show()
        Me.Hide()
    End Sub

    Private Sub Laptop_Click(sender As Object, e As EventArgs) Handles Laptop.Click
        DesktopOrLaptop = "Laptop"
        ProfessionalForm3.Show()
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