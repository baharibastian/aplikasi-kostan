Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiDB()
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
End Class
