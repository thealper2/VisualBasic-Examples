Imports System.Management
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect as New ManagementObjectSearcher("root\CIMV2","SELECT * FROM Win32_VideoController")
        For Each find As ManagementObject In connect.Get()
            Label1,Text = find("Name")
        Next
    End Sub
End Class
