﻿Imports ComputerSelectionService.ConsumerVariables

Public Class ConsumerForm3


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmC2 = New ConsumerForm2
        frmC2.Show()
        Me.Close()

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
        EntertainmentOrEducation = "Education"
        SelectionConsumer.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EntertainmentOrEducation = "Entertainment"
        SelectionConsumer.Show()
        Me.Hide()
    End Sub
End Class