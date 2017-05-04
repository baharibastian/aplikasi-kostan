Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiDB()
        Dim firstDate, msg As String
        Dim secondDate As Date
        firstDate = InputBox("Enter a date")
        Try
            secondDate = CDate(firstDate)
            msg = "Days from today: " & DateDiff(DateInterval.Day, Now, secondDate)
            MsgBox(msg)
        Catch
            MsgBox("Not a valid date value.")
        End Try
    End Sub

    Private Sub DataKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKamarToolStripMenuItem.Click
        KamarForm.Show()
    End Sub

    Private Sub DataPenghuniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenghuniToolStripMenuItem.Click
        PenghuniForm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TransaksiForm.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
