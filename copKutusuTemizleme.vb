Public Class Ders
    Private Declare Function trash Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (byVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Const SHERB_NOCONFIRMATION &H1
    Private Const SHERB_NOPOGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4
    Private Sub Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Cop kutusu temizlensin mi ? ", "Temizleyici", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            trash(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)
            If SHUpdateRecycleBinIcon() Then
                MsgBox("Cop kutusu temizlendi.", MshBoxStyle.Information)
            Else
                MsgBox("Iptal edildi.")
            End If
        End If
    End Sub
End Class
