<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YONETICI
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btncikis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTip = New System.Windows.Forms.ComboBox()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtFiyat = New System.Windows.Forms.TextBox()
        Me.cmbOdasayisi = New System.Windows.Forms.ComboBox()
        Me.txtBinayasi = New System.Windows.Forms.TextBox()
        Me.txtDepozito = New System.Windows.Forms.TextBox()
        Me.btnKayitGiris = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmlakidsorgu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMetrekaresorgu = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdurumid = New System.Windows.Forms.TextBox()
        Me.cmbmetrekare = New System.Windows.Forms.ComboBox()
        Me.cmbiller = New System.Windows.Forms.ComboBox()
        Me.cmbilceler = New System.Windows.Forms.ComboBox()
        Me.btnillerigoster = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbtıp = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtfıyat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtkiraucret = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtıl = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtodasayisi = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtyas = New System.Windows.Forms.TextBox()
        Me.btngiris = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncikis
        '
        Me.btncikis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncikis.Location = New System.Drawing.Point(1322, 601)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(142, 43)
        Me.btncikis.TabIndex = 0
        Me.btncikis.Text = "Çıkış"
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tip:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "İl Kodu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "İlçe Kodu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Adres:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fiyat:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MetreKare:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Oda Sayısı:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Bina Yaşı:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 498)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Depozito:"
        '
        'cmbTip
        '
        Me.cmbTip.FormattingEnabled = True
        Me.cmbTip.Items.AddRange(New Object() {"Villa", "Daire", "Köşk", "Semt"})
        Me.cmbTip.Location = New System.Drawing.Point(150, 216)
        Me.cmbTip.Name = "cmbTip"
        Me.cmbTip.Size = New System.Drawing.Size(197, 24)
        Me.cmbTip.TabIndex = 10
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(150, 334)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(197, 22)
        Me.txtAdres.TabIndex = 13
        '
        'txtFiyat
        '
        Me.txtFiyat.Location = New System.Drawing.Point(150, 373)
        Me.txtFiyat.Name = "txtFiyat"
        Me.txtFiyat.Size = New System.Drawing.Size(197, 22)
        Me.txtFiyat.TabIndex = 14
        '
        'cmbOdasayisi
        '
        Me.cmbOdasayisi.FormattingEnabled = True
        Me.cmbOdasayisi.Items.AddRange(New Object() {"1+0", "1+1", "2+1", "3+1", "4+1", "5+1", "6+1", "7+1", "10+1"})
        Me.cmbOdasayisi.Location = New System.Drawing.Point(150, 435)
        Me.cmbOdasayisi.Name = "cmbOdasayisi"
        Me.cmbOdasayisi.Size = New System.Drawing.Size(197, 24)
        Me.cmbOdasayisi.TabIndex = 16
        '
        'txtBinayasi
        '
        Me.txtBinayasi.Location = New System.Drawing.Point(150, 466)
        Me.txtBinayasi.Name = "txtBinayasi"
        Me.txtBinayasi.Size = New System.Drawing.Size(197, 22)
        Me.txtBinayasi.TabIndex = 17
        '
        'txtDepozito
        '
        Me.txtDepozito.Location = New System.Drawing.Point(150, 498)
        Me.txtDepozito.Name = "txtDepozito"
        Me.txtDepozito.Size = New System.Drawing.Size(197, 22)
        Me.txtDepozito.TabIndex = 18
        '
        'btnKayitGiris
        '
        Me.btnKayitGiris.Location = New System.Drawing.Point(262, 601)
        Me.btnKayitGiris.Name = "btnKayitGiris"
        Me.btnKayitGiris.Size = New System.Drawing.Size(163, 54)
        Me.btnKayitGiris.TabIndex = 19
        Me.btnKayitGiris.Text = "Kayıt Girişi"
        Me.btnKayitGiris.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(376, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1075, 306)
        Me.DataGridView1.TabIndex = 20
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Location = New System.Drawing.Point(452, 533)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(139, 56)
        Me.btnGuncelle.TabIndex = 24
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(452, 596)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(134, 52)
        Me.btnSil.TabIndex = 25
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Emlak Id Sorgulama:"
        '
        'txtEmlakidsorgu
        '
        Me.txtEmlakidsorgu.Location = New System.Drawing.Point(155, 31)
        Me.txtEmlakidsorgu.Name = "txtEmlakidsorgu"
        Me.txtEmlakidsorgu.Size = New System.Drawing.Size(192, 22)
        Me.txtEmlakidsorgu.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Metrekare Sorgulama:"
        '
        'txtMetrekaresorgu
        '
        Me.txtMetrekaresorgu.Location = New System.Drawing.Point(376, 31)
        Me.txtMetrekaresorgu.Name = "txtMetrekaresorgu"
        Me.txtMetrekaresorgu.Size = New System.Drawing.Size(210, 22)
        Me.txtMetrekaresorgu.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(68, 531)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Durum Id:"
        '
        'txtdurumid
        '
        Me.txtdurumid.Location = New System.Drawing.Point(150, 531)
        Me.txtdurumid.Name = "txtdurumid"
        Me.txtdurumid.Size = New System.Drawing.Size(197, 22)
        Me.txtdurumid.TabIndex = 33
        '
        'cmbmetrekare
        '
        Me.cmbmetrekare.FormattingEnabled = True
        Me.cmbmetrekare.Items.AddRange(New Object() {"100m^2", "50m^2", "30m^2", "80m^2", "250m^2"})
        Me.cmbmetrekare.Location = New System.Drawing.Point(150, 403)
        Me.cmbmetrekare.Name = "cmbmetrekare"
        Me.cmbmetrekare.Size = New System.Drawing.Size(197, 24)
        Me.cmbmetrekare.TabIndex = 34
        '
        'cmbiller
        '
        Me.cmbiller.FormattingEnabled = True
        Me.cmbiller.Location = New System.Drawing.Point(150, 253)
        Me.cmbiller.Name = "cmbiller"
        Me.cmbiller.Size = New System.Drawing.Size(197, 24)
        Me.cmbiller.TabIndex = 35
        '
        'cmbilceler
        '
        Me.cmbilceler.FormattingEnabled = True
        Me.cmbilceler.Location = New System.Drawing.Point(150, 298)
        Me.cmbilceler.Name = "cmbilceler"
        Me.cmbilceler.Size = New System.Drawing.Size(197, 24)
        Me.cmbilceler.TabIndex = 36
        '
        'btnillerigoster
        '
        Me.btnillerigoster.Location = New System.Drawing.Point(452, 479)
        Me.btnillerigoster.Name = "btnillerigoster"
        Me.btnillerigoster.Size = New System.Drawing.Size(139, 61)
        Me.btnillerigoster.TabIndex = 37
        Me.btnillerigoster.Text = "İlleri Göster"
        Me.btnillerigoster.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Tip Ara:"
        '
        'cmbtıp
        '
        Me.cmbtıp.FormattingEnabled = True
        Me.cmbtıp.Items.AddRange(New Object() {"Villa", "Daire", "Köşk", "Semt"})
        Me.cmbtıp.Location = New System.Drawing.Point(155, 65)
        Me.cmbtıp.Name = "cmbtıp"
        Me.cmbtıp.Size = New System.Drawing.Size(192, 24)
        Me.cmbtıp.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(92, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Fiyat:"
        '
        'txtfıyat
        '
        Me.txtfıyat.Location = New System.Drawing.Point(155, 116)
        Me.txtfıyat.Name = "txtfıyat"
        Me.txtfıyat.Size = New System.Drawing.Size(192, 22)
        Me.txtfıyat.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 561)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Kira Ücret:"
        '
        'txtkiraucret
        '
        Me.txtkiraucret.Location = New System.Drawing.Point(150, 561)
        Me.txtkiraucret.Name = "txtkiraucret"
        Me.txtkiraucret.Size = New System.Drawing.Size(197, 22)
        Me.txtkiraucret.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(353, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "İl:"
        '
        'txtıl
        '
        Me.txtıl.Location = New System.Drawing.Point(376, 65)
        Me.txtıl.Name = "txtıl"
        Me.txtıl.Size = New System.Drawing.Size(219, 22)
        Me.txtıl.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(387, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Oda Sayısı:"
        '
        'txtodasayisi
        '
        Me.txtodasayisi.Location = New System.Drawing.Point(376, 109)
        Me.txtodasayisi.Name = "txtodasayisi"
        Me.txtodasayisi.Size = New System.Drawing.Size(194, 22)
        Me.txtodasayisi.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(92, 165)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 16)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Yaş:"
        '
        'txtyas
        '
        Me.txtyas.Location = New System.Drawing.Point(150, 162)
        Me.txtyas.Name = "txtyas"
        Me.txtyas.Size = New System.Drawing.Size(197, 22)
        Me.txtyas.TabIndex = 49
        '
        'btngiris
        '
        Me.btngiris.Location = New System.Drawing.Point(31, 591)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(178, 53)
        Me.btngiris.TabIndex = 50
        Me.btngiris.Text = "Girişe Dön"
        Me.btngiris.UseVisualStyleBackColor = True
        '
        'YONETICI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1495, 646)
        Me.Controls.Add(Me.btngiris)
        Me.Controls.Add(Me.txtyas)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtodasayisi)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtıl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtkiraucret)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtfıyat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbtıp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnillerigoster)
        Me.Controls.Add(Me.cmbilceler)
        Me.Controls.Add(Me.cmbiller)
        Me.Controls.Add(Me.cmbmetrekare)
        Me.Controls.Add(Me.txtdurumid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMetrekaresorgu)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmlakidsorgu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnKayitGiris)
        Me.Controls.Add(Me.txtDepozito)
        Me.Controls.Add(Me.txtBinayasi)
        Me.Controls.Add(Me.cmbOdasayisi)
        Me.Controls.Add(Me.txtFiyat)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.cmbTip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncikis)
        Me.Name = "YONETICI"
        Me.Text = "YONETICI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncikis As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbTip As ComboBox
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents txtFiyat As TextBox
    Friend WithEvents cmbOdasayisi As ComboBox
    Friend WithEvents txtBinayasi As TextBox
    Friend WithEvents txtDepozito As TextBox
    Friend WithEvents btnKayitGiris As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmlakidsorgu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMetrekaresorgu As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtdurumid As TextBox
    Friend WithEvents cmbmetrekare As ComboBox
    Friend WithEvents cmbiller As ComboBox
    Friend WithEvents cmbilceler As ComboBox
    Friend WithEvents btnillerigoster As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbtıp As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtfıyat As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtkiraucret As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtıl As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtodasayisi As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtyas As TextBox
    Friend WithEvents btngiris As Button
End Class
