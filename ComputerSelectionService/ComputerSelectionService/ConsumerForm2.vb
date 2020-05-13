Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm2

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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New StartupPage
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmC1 = New ConsumerForm1
        frmC1.Show()
        Me.Close()
    End Sub
End Class