<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiForm
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
        Me.txtKodeTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNamaPenghuni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbKamar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeriode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cTglKeluar = New System.Windows.Forms.DateTimePicker()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdBatal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'txtKodeTransaksi
        '
        Me.txtKodeTransaksi.Location = New System.Drawing.Point(120, 10)
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.Size = New System.Drawing.Size(177, 20)
        Me.txtKodeTransaksi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Penghuni"
        '
        'cmbNamaPenghuni
        '
        Me.cmbNamaPenghuni.FormattingEnabled = True
        Me.cmbNamaPenghuni.Location = New System.Drawing.Point(120, 36)
        Me.cmbNamaPenghuni.Name = "cmbNamaPenghuni"
        Me.cmbNamaPenghuni.Size = New System.Drawing.Size(177, 21)
        Me.cmbNamaPenghuni.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pilih Kamar"
        '
        'cmbKamar
        '
        Me.cmbKamar.FormattingEnabled = True
        Me.cmbKamar.Location = New System.Drawing.Point(120, 63)
        Me.cmbKamar.Name = "cmbKamar"
        Me.cmbKamar.Size = New System.Drawing.Size(177, 21)
        Me.cmbKamar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Periode"
        '
        'txtPeriode
        '
        Me.txtPeriode.Location = New System.Drawing.Point(120, 90)
        Me.txtPeriode.Name = "txtPeriode"
        Me.txtPeriode.Size = New System.Drawing.Size(117, 20)
        Me.txtPeriode.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "/Bulan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total"
        '
        'cTglMasuk
        '
        Me.cTglMasuk.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cTglMasuk.Location = New System.Drawing.Point(120, 142)
        Me.cTglMasuk.Name = "cTglMasuk"
        Me.cTglMasuk.Size = New System.Drawing.Size(177, 20)
        Me.cTglMasuk.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tanggal Masuk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tanggal Keluar"
        '
        'cTglKeluar
        '
        Me.cTglKeluar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cTglKeluar.Location = New System.Drawing.Point(120, 169)
        Me.cTglKeluar.Name = "cTglKeluar"
        Me.cTglKeluar.Size = New System.Drawing.Size(177, 20)
        Me.cTglKeluar.TabIndex = 14
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(120, 195)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 15
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(201, 195)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 16
        Me.cmdBatal.Text = "&Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(585, 188)
        Me.DataGridView1.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(351, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(351, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(351, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Label13"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(117, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Rp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(135, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Label15"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(511, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 433)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cTglKeluar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cTglMasuk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPeriode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbKamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbNamaPenghuni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TransaksiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransaksiForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeTransaksi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbNamaPenghuni As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbKamar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPeriode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cTglMasuk As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cTglKeluar As DateTimePicker
    Friend WithEvents cmdSimpan As Button
    Friend WithEvents cmdBatal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
End Class
