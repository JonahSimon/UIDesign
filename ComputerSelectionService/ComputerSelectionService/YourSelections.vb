Imports ComputerSelectionService.GamingVariables

Public Class YourSelections
    Private Sub YourSelections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerType.Text = GamingVariables.TypeOfComputer
        Price.Text = GamingVariables.PriceRange
        DeskOrLap.Text = GamingVariables.DesktopOrLaptop
        CompCasual.Text = GamingVariables.CasualOrCompetitive

        If Price.Text = "less than 500" And DeskOrLap.Text = "Desktop" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500GamingDesktop
            YourComputerName.Text = "Tada"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500CompLaptop
            YourComputerName.Text = "XSP 200"
        End If
        If Price.Text = "less than 500" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500CasualLaptop
            YourComputerName.Text = "HP G45"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Competitive" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompDesktop
            YourComputerName.Text = "Gspec 4000"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Casual" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualDesktop
            YourComputerName.Text = "TMPK 2.5"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CompLaptop
            YourComputerName.Text = "GSP760"
        End If
        If Price.Text = "500 to 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._500_1000CasualLaptop
            YourComputerName.Text = "TK V4"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Competitive" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompDesktop
            YourComputerName.Text = "EXTERMINATOR 5000"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Desktop" And CompCasual.Text = "Casual" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualDesktop
            YourComputerName.Text = "Galant Compiler"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Competitive" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CompLaptop
            YourComputerName.Text = "MOBILE DOMINATOR"
        End If
        If Price.Text = "Over 1000" And DeskOrLap.Text = "Laptop" And CompCasual.Text = "Casual" Then
            ChosenDevice.Image = ComputerSelectionService.My.Resources._1000_CasualLaptop
            YourComputerName.Text = "YOLO BOI 45"
        End If


        TypeOfComputer = " "
        PriceRange = 0
        DesktopOrLaptop = " "
        CasualOrCompetitive = " "


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

    Private Sub DeskOrLap_Click(sender As Object, e As EventArgs) Handles DeskOrLap.Click

    End Sub

    Private Sub CompCasual_Click(sender As Object, e As EventArgs) Handles CompCasual.Click

    End Sub

    Private Sub Price_Click(sender As Object, e As EventArgs) Handles Price.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmC1 = New GamingForm3
        frmC1.Show()
        Me.Close()
    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComputerType_Click(sender As Object, e As EventArgs) Handles ComputerType.Click

    End Sub

    Private Sub ChosenDevice_Click(sender As Object, e As EventArgs) Handles ChosenDevice.Click

    End Sub

    Private Sub YourComputerName_Click(sender As Object, e As EventArgs) Handles YourComputerName.Click

    End Sub
End Class