Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("RUNDLL32 SHELL32.DLL,Control_RunDLL TIMEDATE.CPL @0,")
    End Sub
End Class
