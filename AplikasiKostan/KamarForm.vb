Public Class KamarForm
    Private Sub KamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getData()
    End Sub

    Sub getData()
        Call KoneksiDB()
        Dim STR As String
        STR = "SELECT * FROM kamar"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "kamar")
        DataGridView1.DataSource = DS.Tables("kamar")
    End Sub
End Class