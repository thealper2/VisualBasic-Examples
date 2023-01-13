Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Ders
        Label1.Text = My.Computer.Info.OSFullName
        Label2.Text = My.Computer.Info.OSVersion
        Label3.Text = My.Computer.Info.OSPlatform
    End Sub
End Class
