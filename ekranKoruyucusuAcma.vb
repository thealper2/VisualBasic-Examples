Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("RUNDLL32 DESK.CPL, InstallScreenSaver C:sstext3d.scr")
    End Sub
End Class
