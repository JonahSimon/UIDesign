Imports ComputerSelectionService.ConsumerVariables

Public Class SelectionConsumer
    Private Sub SelectionConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = ConsumerVariables.Typingcomputer
        Price.Text = ConsumerVariables.PriceRange
        DeskOrLap.Text = ConsumerVariables.DesktopOrLaptop
        CompCasual.Text = ConsumerVariables.RecreationOrEducation

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources.Less500EduDesk
            YourComputerName.Text = "Surely"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources.Less500RecDesk
            YourComputerName.Text = "ASP 400"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources.Less500EduLap
            YourComputerName.Text = "That'll Do"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources.Less500RecLap
            YourComputerName.Text = "Economy Mobile"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000EduDesk
            YourComputerName.Text = "Hspec 3000"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000RecDesk
            YourComputerName.Text = "Acer Pro"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000EduLap
            YourComputerName.Text = "For the Win"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000RecLap
            YourComputerName.Text = "Acer Spacer"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000UpEduDesk
            YourComputerName.Text = "Everything Included"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000UpRecDesk
            YourComputerName.Text = "Great Fun"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Education" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000UpEduLap
            YourComputerName.Text = "Going Pro"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Recreation" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000UpRecLap
            YourComputerName.Text = "Everything Anywhere"
        End If

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm = New StartupPage               '' Change the class name if necessary
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmC3 = New ConsumerForm3
        frmC3.Show()
        Me.Close()
    End Sub

End Class