Public Class Ders
    Private Declare Function mciExecute Lib "winmm.dll" (ByVal lpstrCommand As String) As Long
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mciExecute("Set CDAudio door open")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mciExecute("Set CDAudio door closed")
    End Sub
End Class
