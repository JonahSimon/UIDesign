Public Class StartupPage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Profesional_Click(sender As Object, e As EventArgs) Handles Profesional.Click
        ProfessionalForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Consumer_Click(sender As Object, e As EventArgs) Handles Consumer.Click
        ConsumerForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Gaming_Click(sender As Object, e As EventArgs) Handles Gaming.Click
        GamingForm1.Show()
        Me.Hide()
    End Sub
End Class
