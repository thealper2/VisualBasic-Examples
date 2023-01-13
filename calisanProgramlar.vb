Public Class Ders
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        for Each running As Process In Process.GetProcesses
            ListBox1.Items.Add(running)
        Next
    End Sub
End Class
