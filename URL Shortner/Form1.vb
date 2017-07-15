Imports System.Net

Public Class Form1
    Dim wclient As New System.Net.WebClient
    Dim site As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtShort.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rbtnAdfly.Checked = True Then
            site = "adfly"
        ElseIf rbtnGoogle.Checked = True Then
            site = "google"
        Else
            MessageBox.Show("Please select a site to use")

        End If

        Dim r As String = wclient.DownloadString("https://tcwapihandler.download/shortner.php?site=" + site + "&url=" + txtUrl.Text)
        txtShort.Show()
        txtShort.Text = r


    End Sub
End Class
