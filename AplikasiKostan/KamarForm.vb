Public Class KamarForm
    Private Sub KamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getData()
    End Sub

    Sub getData()
        Call KoneksiDB()
        Dim STR As String
        DS.Clear()
        STR = "SELECT * FROM kamar"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "kamar")
        DataGridView1.DataSource = DS.Tables("kamar")
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtNoKamar.Text = "" Or txtNamaKamar.Text = "" Or txtHargaKamar.Text = "" Or cmbStatus.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Kamar", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "Simpan" Then
                Call Check()
                If DS.Tables("kamar").Rows.Count <> 0 Then
                    MsgBox("Kamar Sudah Ada")
                Else
                    STR = "INSERT INTO kamar VALUES('" & txtNoKamar.Text & "', '" & txtNamaKamar.Text & "','" & txtHargaKamar.Text & "','" & cmbStatus.Text & "')"
                    DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                    DA.InsertCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                    Call getData()
                    Call Clear()
                    txtNoKamar.Focus()
                End If
            Else
                STR = "Update kamar set nama_kamar='" & txtNamaKamar.Text & "',harga_kamar='" & txtHargaKamar.Text & "',status='" & cmbStatus.Text & "' WHERE kode_kamar = '" & txtNoKamar.Text & "'"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                DA.InsertCommand.ExecuteNonQuery()
                Call getData()
                Call Clear()
                cmdSimpan.Text = "&Simpan"
                txtNoKamar.Focus()
            End If
        End If
    End Sub

    Private Sub cmdBatal_Click(sender As Object, e As EventArgs) Handles cmdBatal.Click
        Call Clear()
    End Sub

    Sub Clear()
        txtNoKamar.Text = ""
        txtNamaKamar.Text = ""
        txtHargaKamar.Text = ""
        cmbStatus.Text = ""
        txtCariKamar.Text = ""
    End Sub

    Sub Check()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM kamar WHERE kode_kamar = '" & txtNoKamar.Text & "'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "kamar")
    End Sub

    Sub Cari()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM kamar WHERE nama_kamar = '" & txtCariKamar.Text & "'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "kamar")
    End Sub

    Private Sub txtCariKamar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCariKamar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Cari()
            If DS.Tables("kamar").Rows.Count <> 0 Then
                txtNoKamar.Text = DS.Tables("kamar").Rows(0)(0)
                txtNamaKamar.Text = DS.Tables("kamar").Rows(0)(1)
                txtHargaKamar.Text = DS.Tables("kamar").Rows(0)(2)
                cmbStatus.Text = DS.Tables("kamar").Rows(0)(3)
                cmdSimpan.Text = "Update"
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call getData()
    End Sub
End Class