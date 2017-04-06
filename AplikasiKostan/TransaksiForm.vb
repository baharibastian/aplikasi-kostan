Imports System.Data.Odbc

Public Class TransaksiForm

    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getData()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        STR = "select * from transaksi order by kode_transaksi desc"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        Dim myReader As OdbcDataReader = DA.SelectCommand.ExecuteReader()
        If myReader.Read Then
            strSementara = Mid(myReader.Item("kode_transaksi"), 2, 2)
            strIsi = Val(strSementara) + 1
            txtKodeTransaksi.Text = "TR" + Date.Now + Mid("0", 1, 2 - strIsi.Length) & strIsi
        Else
            txtKodeTransaksi.Text = "TR" + DateTime.Now.ToString("yyyyMMdd") + "01"
        End If
        txtKodeTransaksi.Enabled = False
        cmbNamaPenghuni.Focus()

        Call getPenghuni()
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
        txtTotal.Text = ""
        cTglMasuk.Text = ""
        cTglKeluar.Text = ""
    End Sub

    Sub getPenghuni()
        Call KoneksiDB()
        Dim STR As String
        Dim dr As DataRow
        DS.Clear()
        STR = "SELECT * FROM penghuni"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "penghuni")
        Dim i As Integer
        If DS.Tables("penghuni").Rows.Count > 0 Then
            For i = 1 To DS.Tables("penghuni").Rows().Count
                dr = DS.Tables("penghuni").Rows(i)
                cmbNamaPenghuni.Items.Add(dr(1).ToString)
            Next
        End If
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKodeTransaksi.Text = "" Or cmbNamaPenghuni.Text = "" Or cmbKamar.Text = "" Or txtPeriode.Text = "" Or txtTotal.Text = "" Or cTglMasuk.Text = "" Or cTglKeluar.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong" & vbCrLf & "Silahkan Lengkapi Data Transaksi", MsgBoxStyle.Critical)
        Else
            If cmdSimpan.Text = "Simpan" Then
                STR = "INSERT INTO kamar VALUES('" & txtKodeTransaksi.Text & "', '" & cmbNamaPenghuni.Text & "','" & cmbKamar.Text & "','" & txtPeriode.Text & "','" & txtTotal.Text & "','" & cTglMasuk.Text & "','" & cTglKeluar.Text & "')"
            DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                DA.InsertCommand.ExecuteNonQuery()
                MsgBox("Data Berhasil Dimasukkan", MsgBoxStyle.Information)
                Call getData()
                Call Clear()
                cmbNamaPenghuni.Focus()
            Else
                STR = "Update transaksi set kode_penghuni='" & cmbNamaPenghuni.Text & "',kode_kamar='" & cmbKamar.Text & "',periode='" & txtPeriode.Text & "',total_harga='" & txtTotal.Text & "',tanggal_masuk='" & cTglMasuk.Text & "',tanggal_keluar='" & cTglKeluar.Text & "' WHERE kode_transaksi = '" & txtKodeTransaksi.Text & "'"
                DA.InsertCommand = New Odbc.OdbcCommand(STR, KNS)
                DA.InsertCommand.ExecuteNonQuery()
                Call getData()
                Call Clear()
                cmdSimpan.Text = "&Simpan"
                cmbNamaPenghuni.Focus()
            End If
        End If
    End Sub
End Class