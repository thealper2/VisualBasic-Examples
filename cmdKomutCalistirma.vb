Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(My.Resources.cmd)
    End Sub
End Class
//Yeni bir .bat uzantili dosya olusturup icine kod yazip onu projenin kaynaklar kısmına ekle
