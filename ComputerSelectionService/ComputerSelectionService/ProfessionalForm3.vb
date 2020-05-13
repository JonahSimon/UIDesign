Imports ComputerSelectionService.ProfessionalVariables
Public Class ProfessionalForm3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GraphicOrData = "Office Work"
        ProfessionalSelections.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GraphicOrData = "Graphic Design"
        ProfessionalSelections.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frmC1 = New ProfessionalForm2
        frmC1.Show()
        Me.Close()
    End Sub

    Private Sub ProfessionalForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class