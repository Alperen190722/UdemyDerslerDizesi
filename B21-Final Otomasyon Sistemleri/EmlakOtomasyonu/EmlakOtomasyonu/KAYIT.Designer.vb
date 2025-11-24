<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KAYIT
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.dtDogum = New System.Windows.Forms.DateTimePicker()
        Me.btnKayitol = New System.Windows.Forms.Button()
        Me.btnGeridon = New System.Windows.Forms.Button()
        Me.cmbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Soyad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Şifre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefon:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Doğum Tarihi:"
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(109, 36)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(189, 22)
        Me.txtAd.TabIndex = 8
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(109, 70)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(189, 22)
        Me.txtSoyad.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(109, 108)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 22)
        Me.txtEmail.TabIndex = 10
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(109, 140)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(189, 22)
        Me.txtSifre.TabIndex = 11
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(109, 177)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(189, 22)
        Me.txtTc.TabIndex = 12
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(109, 220)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(189, 22)
        Me.txtTelefon.TabIndex = 13
        '
        'dtDogum
        '
        Me.dtDogum.Location = New System.Drawing.Point(109, 272)
        Me.dtDogum.Name = "dtDogum"
        Me.dtDogum.Size = New System.Drawing.Size(189, 22)
        Me.dtDogum.TabIndex = 15
        '
        'btnKayitol
        '
        Me.btnKayitol.Location = New System.Drawing.Point(15, 394)
        Me.btnKayitol.Name = "btnKayitol"
        Me.btnKayitol.Size = New System.Drawing.Size(141, 44)
        Me.btnKayitol.TabIndex = 16
        Me.btnKayitol.Text = "Kayıt Ol"
        Me.btnKayitol.UseVisualStyleBackColor = True
        '
        'btnGeridon
        '
        Me.btnGeridon.Location = New System.Drawing.Point(650, 394)
        Me.btnGeridon.Name = "btnGeridon"
        Me.btnGeridon.Size = New System.Drawing.Size(138, 44)
        Me.btnGeridon.TabIndex = 17
        Me.btnGeridon.Text = "Geri Dön"
        Me.btnGeridon.UseVisualStyleBackColor = True
        '
        'cmbCinsiyet
        '
        Me.cmbCinsiyet.FormattingEnabled = True
        Me.cmbCinsiyet.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.cmbCinsiyet.Location = New System.Drawing.Point(109, 317)
        Me.cmbCinsiyet.Name = "cmbCinsiyet"
        Me.cmbCinsiyet.Size = New System.Drawing.Size(189, 24)
        Me.cmbCinsiyet.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cinsiyet:"
        '
        'KAYIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbCinsiyet)
        Me.Controls.Add(Me.btnGeridon)
        Me.Controls.Add(Me.btnKayitol)
        Me.Controls.Add(Me.dtDogum)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KAYIT"
        Me.Text = "KAYIT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents txtTc As TextBox
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents dtDogum As DateTimePicker
    Friend WithEvents btnKayitol As Button
    Friend WithEvents btnGeridon As Button
    Friend WithEvents cmbCinsiyet As ComboBox
    Friend WithEvents Label7 As Label
End Class
