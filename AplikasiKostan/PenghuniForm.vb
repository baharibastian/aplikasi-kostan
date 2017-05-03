Imports System.Data.Odbc

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
        kodeOtomatis()
        txtKode.Enabled = False
        txtNo.Focus()
    End Sub

    Sub kodeOtomatis()
        Call KoneksiDB()
        Dim cd As New OdbcCommand("Select * from penghuni where kode_penghuni in (select max(kode_penghuni) from penghuni)", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim urutan As String
        Dim hitung As Long
        myReader.Read()
        If Not myReader.HasRows Then
            urutan = "P" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(myReader.GetString(0), 3) + 1
            urutan = "P" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtKode.Text = urutan
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
        txtCariNama.Text = ""
    End Sub

    Sub Check()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM penghuni WHERE kode_penghuni= '" & txtKode.Text & "'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "kamar")
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKode.Text = "" Or txtNo.Text = "" Or txtNamaLengkap.Text = "" Or txtAlamatAsal.Text = "" Or txtKota.Text = "" Or txtTelepon.Text = "" Or cmbJK.Text = "" Or txtPekerjaan.Text = "" Or txtAlamatPekerjaan.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Kamar", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "&Simpan" Then
                Call Check()
                If DS.Tables("penghuni").Rows.Count <> 0 Then
                    MsgBox("Kamar Sudah Ada")
                Else
                    STR = "INSERT INTO penghuni VALUES('" & txtKode.Text & "','" & txtNo.Text & "','" & txtNamaLengkap.Text & "','" & txtAlamatAsal.Text & "','" & txtKota.Text & "','" & txtTelepon.Text & "','" & cmbJK.Text & "','" & tglLahir.Text & "','" & txtPekerjaan.Text & "','" & txtAlamatPekerjaan.Text & "')"
                    DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                    DA.InsertCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                    Call getData()
                    Call Clear()
                    kodeOtomatis()
                    txtNo.Focus()
                End If
            Else
                STR = "Update penghuni set nomor_identitas='" & txtNo.Text & "',nama_penghuni='" & txtNamaLengkap.Text & "',alamat_asal='" & txtAlamatAsal.Text & "',asal_kota='" & txtKota.Text & "',no_telepon='" & txtTelepon.Text & "',jenis_kelamin='" & cmbJK.Text & "',tanggal_lahir='" & tglLahir.Text & "',pekerjaan='" & txtPekerjaan.Text & "',alamat_pekerjaan='" & txtAlamatPekerjaan.Text & "' WHERE kode_penghuni = '" & txtKode.Text & "'"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                DA.InsertCommand.ExecuteNonQuery()
                Call getData()
                Call Clear()
                cmdSimpan.Text = "&Simpan"
                txtKode.Focus()
            End If
        End If
    End Sub

    Sub Cari()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM penghuni WHERE nama_penghuni LIKE '%" & txtCariNama.Text & "%'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "penghuni")
    End Sub

    Private Sub txtCariNama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCariNama.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Cari()
            If DS.Tables("penghuni").Rows.Count <> 0 Then
                txtKode.Text = DS.Tables("penghuni").Rows(0)(0)
                txtNo.Text = DS.Tables("penghuni").Rows(0)(1)
                txtNamaLengkap.Text = DS.Tables("penghuni").Rows(0)(2)
                txtAlamatAsal.Text = DS.Tables("penghuni").Rows(0)(3)
                txtKota.Text = DS.Tables("penghuni").Rows(0)(4)
                txtTelepon.Text = DS.Tables("penghuni").Rows(0)(5)
                cmbJK.Text = DS.Tables("penghuni").Rows(0)(6)
                tglLahir.Text = DS.Tables("penghuni").Rows(0)(7)
                txtPekerjaan.Text = DS.Tables("penghuni").Rows(0)(8)
                txtAlamatPekerjaan.Text = DS.Tables("penghuni").Rows(0)(9)
                cmdSimpan.Text = "Update"
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub
End Class