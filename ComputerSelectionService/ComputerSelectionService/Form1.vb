Imports ComputerSelectionService.GamingVariables
Imports ComputerSelectionService.ProfessionalVariables
Public Class StartupPage

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Profesional_Click(sender As Object, e As EventArgs) Handles Profesional.Click
        TypeComputer = "Professional"
        ProfessionalForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Consumer_Click(sender As Object, e As EventArgs) Handles Consumer.Click
        ConsumerForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Gaming_Click(sender As Object, e As EventArgs) Handles Gaming.Click
        TypeOfComputer = "Gaming"
        GamingForm1.Show()
        Me.Hide()
    End Sub

    Private Sub StartupPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class GamingVariables
    Public Shared TypeOfComputer As String
    Public Shared PriceRange As String
    Public Shared DesktopOrLaptop As String
    Public Shared CasualOrCompetitive As String

End Class

Public Class ProfessionalVariables
    Public Shared TypeComputer As String
    Public Shared PriceRange As String
    Public Shared DesktopOrLaptop As String
    Public Shared GraphicOrData As String

End Class