Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("RUNDLL32 SHELL32.DLL,Control_RunDll NCPA.CPL,@0,2")
    End Sub
End Class
