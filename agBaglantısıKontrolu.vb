Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Ny.Computer.Network.IsAvailable = True Then
            Label1.Text = "online"
        Else
            Label1.Text = "offline"
        End If
    End Sub
End Class
