Public Class PenghuniForm

    Sub getData()
        Call KoneksiDB()
        Dim STR As String
        DS.Clear()
        STR = "SELECT * FROM penghuni"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "penghuni")
        DataGridView1.DataSource = DS.Tables("penghuni")
    End Sub

    Private Sub PenghuniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getData()
    End Sub

    Sub Clear()
        txtNo.Text = ""
        txtNamaLengkap.Text = ""
        txtAlamatAsal.Text = ""
        txtKota.Text = ""
        txtTelepon.Text = ""
        cmbJK.Text = ""
        txtPekerjaan.Text = ""
        txtAlamatPekerjaan.Text = ""
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKode.Text = "" Or txtNo.Text = "" Or txtNamaLengkap.Text = "" Or txtAlamatAsal.Text = "" Or txtKota.Text = "" Or txtTelepon.Text = "" Or cmbJK.Text = "" Or txtPekerjaan.Text = "" Or txtAlamatPekerjaan.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Kamar", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "Simpan" Then
                If DS.Tables("penghuni").Rows.Count <> 0 Then
                    MsgBox("Kamar Sudah Ada")
                Else
                    STR = "INSERT INTO penghuni VALUES('" & txtKode.Text & "', '" & txtNo.Text & "','" & txtNamaLengkap.Text & "','" & txtAlamatAsal.Text & "','" & txtKota.Text & "','" & txtTelepon.Text & "','" & cmbJK.Text & "','" & tglLahir.Text & "','" & txtPekerjaan.Text & "','" & txtAlamatPekerjaan.Text & "')"
                    DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                    DA.InsertCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                    Call getData()
                    Call Clear()
                    txtNo.Focus()
                End If
            End If
        End If
    End Sub
End Class