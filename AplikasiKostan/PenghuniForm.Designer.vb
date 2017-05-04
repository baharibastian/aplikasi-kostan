<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenghuniForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.txtAlamatAsal = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.tglLahir = New System.Windows.Forms.DateTimePicker()
        Me.txtPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtAlamatPekerjaan = New System.Windows.Forms.TextBox()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdCari = New System.Windows.Forms.Button()
        Me.txtCariNama = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Identitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat Asal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kota"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tanggal Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Pekerjaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Alamat Pekerjaan"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(124, 10)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(198, 20)
        Me.txtKode.TabIndex = 10
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(124, 36)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(198, 20)
        Me.txtNo.TabIndex = 11
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.Location = New System.Drawing.Point(124, 62)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.Size = New System.Drawing.Size(198, 20)
        Me.txtNamaLengkap.TabIndex = 12
        '
        'txtAlamatAsal
        '
        Me.txtAlamatAsal.Location = New System.Drawing.Point(124, 89)
        Me.txtAlamatAsal.Multiline = True
        Me.txtAlamatAsal.Name = "txtAlamatAsal"
        Me.txtAlamatAsal.Size = New System.Drawing.Size(198, 63)
        Me.txtAlamatAsal.TabIndex = 13
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(124, 159)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(198, 20)
        Me.txtKota.TabIndex = 14
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(124, 185)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(198, 20)
        Me.txtTelepon.TabIndex = 15
        '
        'cmbJK
        '
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJK.Location = New System.Drawing.Point(124, 212)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(198, 21)
        Me.cmbJK.TabIndex = 16
        '
        'tglLahir
        '
        Me.tglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglLahir.Location = New System.Drawing.Point(124, 240)
        Me.tglLahir.Name = "tglLahir"
        Me.tglLahir.Size = New System.Drawing.Size(198, 20)
        Me.tglLahir.TabIndex = 17
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.Location = New System.Drawing.Point(124, 267)
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(198, 20)
        Me.txtPekerjaan.TabIndex = 18
        '
        'txtAlamatPekerjaan
        '
        Me.txtAlamatPekerjaan.Location = New System.Drawing.Point(124, 294)
        Me.txtAlamatPekerjaan.Multiline = True
        Me.txtAlamatPekerjaan.Name = "txtAlamatPekerjaan"
        Me.txtAlamatPekerjaan.Size = New System.Drawing.Size(198, 62)
        Me.txtAlamatPekerjaan.TabIndex = 19
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(124, 363)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 20
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(205, 363)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 21
        Me.cmdBatal.Text = "&Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbFilter)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmdCari)
        Me.GroupBox1.Controls.Add(Me.txtCariNama)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 118)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data Penghuni"
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Nama Penghuni", "Alamat Penghuni"})
        Me.cmbFilter.Location = New System.Drawing.Point(122, 28)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(157, 21)
        Me.cmbFilter.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Filter Berdasarkan"
        '
        'cmdCari
        '
        Me.cmdCari.Location = New System.Drawing.Point(122, 83)
        Me.cmdCari.Name = "cmdCari"
        Me.cmdCari.Size = New System.Drawing.Size(75, 23)
        Me.cmdCari.TabIndex = 2
        Me.cmdCari.Text = "&Cari"
        Me.cmdCari.UseVisualStyleBackColor = True
        '
        'txtCariNama
        '
        Me.txtCariNama.Location = New System.Drawing.Point(122, 57)
        Me.txtCariNama.Name = "txtCariNama"
        Me.txtCariNama.Size = New System.Drawing.Size(157, 20)
        Me.txtCariNama.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nama Penghuni "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 403)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 159)
        Me.DataGridView1.TabIndex = 24
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(286, 363)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 25
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        Me.btnHapus.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(355, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Status :"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(441, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Label14"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(441, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Label15"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(440, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(463, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Hari Lagi"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(355, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Tanggal Keluar :"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(355, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Sisa :"
        Me.Label19.Visible = False
        '
        'PenghuniForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 574)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.txtAlamatPekerjaan)
        Me.Controls.Add(Me.txtPekerjaan)
        Me.Controls.Add(Me.tglLahir)
        Me.Controls.Add(Me.cmbJK)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamatAsal)
        Me.Controls.Add(Me.txtNamaLengkap)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "PenghuniForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Penghuni"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNamaLengkap As TextBox
    Friend WithEvents txtAlamatAsal As TextBox
    Friend WithEvents txtKota As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents tglLahir As DateTimePicker
    Friend WithEvents txtPekerjaan As TextBox
    Friend WithEvents txtAlamatPekerjaan As TextBox
    Friend WithEvents cmdSimpan As Button
    Friend WithEvents cmdBatal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdCari As Button
    Friend WithEvents txtCariNama As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
