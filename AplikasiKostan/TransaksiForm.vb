Imports System.Data.Odbc

Public Class TransaksiForm

    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getKamar()
        getPenghuni()
        Call getData()
        cmbNamaPenghuni.Focus()
        kodeOtomatis()
        txtKodeTransaksi.Enabled = False
    End Sub

    Sub kodeOtomatis()
        Call KoneksiDB()
        Dim cd As New OdbcCommand("Select * from transaksi where kode_transaksi in (select max(kode_transaksi) from transaksi)", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim urutan As String
        Dim hitung As Long
        myReader.Read()
        If Not myReader.HasRows Then
            urutan = "TR" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(myReader.GetString(0), 3) + 1
            urutan = "TR" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtKodeTransaksi.Text = urutan
    End Sub

    Sub getData()
        Call KoneksiDB()
        Dim STR As String
        DS.Clear()
        STR = "SELECT * FROM transaksi"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "transaksi")
        DataGridView1.DataSource = DS.Tables("transaksi")
    End Sub

    Sub Clear()
        cmbNamaPenghuni.Text = ""
        cmbKamar.Text = ""
        txtPeriode.Text = ""
        Label15.Text = ""
        cTglMasuk.Text = ""
        cTglKeluar.Text = ""
    End Sub

    Sub getPenghuni()
        Call KoneksiDB()
        Dim cd As New OdbcCommand("SELECT * FROM penghuni", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        DS.Clear()
        Try
            myReader.Close()
            KNS.Open()
            myReader = cd.ExecuteReader()
            While myReader.Read()
                cmbNamaPenghuni.Items.Add(myReader("nama_penghuni"))
            End While
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        DS.Clear()
        KNS.Close()
    End Sub

    Sub getKamar()
        Call KoneksiDB()
        Dim cd As New OdbcCommand("SELECT * FROM kamar WHERE status = 'Kosong'", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        DS.Clear()
        Try
            myReader.Close()
            KNS.Open()
            myReader = cd.ExecuteReader()
            While myReader.Read()
                cmbKamar.Items.Add(myReader("nama_kamar"))
            End While
            KNS.Close()
            DS.Clear()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub

    Sub status()
        STR = "UPDATE kamar SET status = 'Berisi' WHERE kode_kamar = '" & Label12.Text & "'"
        DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.InsertCommand.ExecuteNonQuery()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKodeTransaksi.Text = "" Or cmbNamaPenghuni.Text = "" Or cmbKamar.Text = "" Or txtPeriode.Text = "" Or Label15.Text = "" Or cTglMasuk.Text = "" Or cTglKeluar.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Transaksi", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "&Simpan" Then
                STR = "INSERT INTO transaksi VALUES('" & txtKodeTransaksi.Text & "', '" & Label11.Text & "','" & Label12.Text & "','" & txtPeriode.Text & "','" & Label15.Text & "','" & cTglMasuk.Text & "','" & cTglKeluar.Text & "')"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                KNS.Open()
                DA.InsertCommand.ExecuteNonQuery()
                MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                Call status()
                Call getData()
                Call Clear()
                kodeOtomatis()
                cmbNamaPenghuni.Focus()
            Else
                STR = "Update transaksi set kode_penghuni='" & cmbNamaPenghuni.Text & "',kode_kamar='" & cmbKamar.Text & "',periode='" & txtPeriode.Text & "',total_harga='" & Label15.Text & "',tanggal_masuk='" & cTglMasuk.Text & "',tanggal_keluar='" & cTglKeluar.Text & "' WHERE kode_transaksi = '" & txtKodeTransaksi.Text & "'"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                KNS.Open()
                DA.InsertCommand.ExecuteNonQuery()
                Call getData()
                Call Clear()
                cmdSimpan.Text = "&Simpan"
                cmbNamaPenghuni.Focus()
            End If
        End If
    End Sub

    Private Sub cmbNamaPenghuni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaPenghuni.SelectedIndexChanged
        Call KoneksiDB()
        Dim cd As New OdbcCommand("SELECT * FROM penghuni WHERE nama_penghuni = '" & cmbNamaPenghuni.Text & "'", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        DS.Clear()
        Try
            myReader.Close()
            KNS.Open()
            myReader = cd.ExecuteReader()
            While myReader.Read()
                Label11.Text = myReader("kode_penghuni")
            End While
            Call getData()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        KNS.Close()
    End Sub

    Private Sub cmbKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKamar.SelectedIndexChanged
        Call KoneksiDB()
        Dim cd As New OdbcCommand("SELECT * FROM kamar WHERE nama_kamar= '" & cmbKamar.Text & "'", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        DS.Clear()
        Try
            myReader.Close()
            KNS.Open()
            myReader = cd.ExecuteReader()
            While myReader.Read()
                Label12.Text = myReader("kode_kamar")
                Label13.Text = myReader("harga_kamar")
            End While
            Call getData()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        KNS.Close()
    End Sub

    Sub Cari()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM transaksi WHERE kode_transaksi = '" & txtKeyword.Text & "'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "transaksi")
    End Sub

    Private Sub txtPeriode_TextChanged(sender As Object, e As EventArgs) Handles txtPeriode.TextChanged
        If (txtPeriode.Text = "") Then
            Label15.Text = ""
        Else
            Label15.Text = CDbl(txtPeriode.Text * Label13.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call getData()
    End Sub

    Private Sub cTglMasuk_ValueChanged(sender As Object, e As EventArgs) Handles cTglMasuk.ValueChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Cari()
    End Sub

    Private Sub txtKeyword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtKeyword.KeyPress

    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged

    End Sub
End Class