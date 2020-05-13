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

    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmC1 = New GamingForm1
        frmC1.Show()
        Me.Close()
    End Sub
End Class