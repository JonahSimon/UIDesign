Public Class GamingForm1

    Private Sub GamingForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        StartupPage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FivetoThousand.Click
        GamingVariables.PriceRange = 700
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Lessthan500.Click
        GamingVariables.PriceRange = 500
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles OverAThousand.Click
        GamingVariables.PriceRange = 1000
    End Sub
End Class

Public Class GamingVariables
    Public Shared TypeOfComputer As String = "Gaming"
    Public Shared PriceRange As Integer
    Public Shared DesktopOrLaptop As String
    Public Shared CasualOrCompetitive As String

End Class
