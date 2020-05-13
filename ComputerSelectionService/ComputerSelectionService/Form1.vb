Imports ComputerSelectionService.GamingVariables
Imports ComputerSelectionService.ProfessionalVariables
Imports ComputerSelectionService.ConsumerVariables

Public Class StartupPage


    Private Sub Profesional_Click(sender As Object, e As EventArgs) Handles Profesional.Click
        TypeComputer = "Professional"
        ProfessionalForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Consumer_Click(sender As Object, e As EventArgs) Handles Consumer.Click
        Typingcomputer = "Casual"
        ConsumerForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Gaming_Click(sender As Object, e As EventArgs) Handles Gaming.Click
        TypeOfComputer = "Gaming"
        GamingForm1.Show()
        Me.Hide()
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
Public Class ConsumerVariables
    Public Shared Typingcomputer As String
    Public Shared PriceRange As String
    Public Shared DesktopOrLaptop As String
    Public Shared EntertainmentOrEducation As String

End Class