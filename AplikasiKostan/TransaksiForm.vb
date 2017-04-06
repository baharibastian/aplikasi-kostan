Imports System.Data.Odbc

Public Class TransaksiForm

    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getData()
        autoNumber()
        txtKodeTransaksi.Enabled = False
        cmbNamaPenghuni.Focus()
        getPenghuni()
        getKamar()
        DataGridView1.Columns(5).DefaultCellStyle.Format = "yyyyMMdd"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "yyyyMMdd"
    End Sub

    Sub autoNumber()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        STR = "select * from transaksi order by kode_transaksi desc"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        Dim myReader As OdbcDataReader = DA.SelectCommand.ExecuteReader()
        If myReader.Read Then
            strSementara = Mid(myReader.Item("kode_transaksi"), 2, 2)
            strIsi = Val(strSementara) + 1
            txtKodeTransaksi.Text = "TR" + Date.Now.ToString("yyyyMMdd") + Mid("0", 3, 2 - strIsi.Length) & strIsi
        Else
            txtKodeTransaksi.Text = "TR" + DateTime.Now.ToString("yyyyMMdd") + "01"
        End If
    End Sub

    Sub getData()
        Call KoneksiDB()
        Dim STR As String
        DS.Clear()
        STR = "SELECT * FROM transaksi"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "transaksi")
        DataGridView1.DataSource = DS.Tables("transaksi")
        DataGridView1.Columns(5).DefaultCellStyle.Format = "yyyyMMdd"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "yyyyMMdd"
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
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKodeTransaksi.Text = "" Or cmbNamaPenghuni.Text = "" Or cmbKamar.Text = "" Or txtPeriode.Text = "" Or Label15.Text = "" Or cTglMasuk.Text = "" Or cTglKeluar.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Transaksi", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "Simpan" Then
                STR = "INSERT INTO transaksi VALUES('" & txtKodeTransaksi.Text & "', '" & cmbNamaPenghuni.Text & "','" & cmbKamar.Text & "','" & txtPeriode.Text & "','" & Label15.Text & "','" & cTglMasuk.Text & "','" & cTglKeluar.Text & "')"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                KNS.Open()
                DA.InsertCommand.ExecuteNonQuery()
                MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                Call getData()
                Call Clear()
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
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        KNS.Close()
    End Sub

    Private Sub txtPeriode_TextChanged(sender As Object, e As EventArgs) Handles txtPeriode.TextChanged
        If (txtPeriode.Text = "") Then
            Label15.Text = ""
        Else
            Label15.Text = CDbl(txtPeriode.Text * Label13.Text)
        End If

    End Sub
End Class