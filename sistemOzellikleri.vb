Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("rundll32.exe shell32.dll,Control_RunDLL sysdm.cpl,,1")
    End Sub
End Class
