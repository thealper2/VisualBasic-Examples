Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("RUNDLL32 SHELL32.DLL,SHHelpShortcuts_RunDLL FontsFolder")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\Windows\System32\eudcedit.exe")
    End Sub
End Class
