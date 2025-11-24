<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnKayıt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.rdbYonetici = New System.Windows.Forms.RadioButton()
        Me.rdbMusteri = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnGiris
        '
        Me.btnGiris.Location = New System.Drawing.Point(12, 394)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(194, 45)
        Me.btnGiris.TabIndex = 0
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.UseVisualStyleBackColor = True
        '
        'btnKayıt
        '
        Me.btnKayıt.Location = New System.Drawing.Point(613, 395)
        Me.btnKayıt.Name = "btnKayıt"
        Me.btnKayıt.Size = New System.Drawing.Size(175, 43)
        Me.btnKayıt.TabIndex = 1
        Me.btnKayıt.Text = "Kayit"
        Me.btnKayıt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "E-posta :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Şifre :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(301, 156)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(171, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(301, 195)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(171, 22)
        Me.txtSifre.TabIndex = 5
        '
        'rdbYonetici
        '
        Me.rdbYonetici.AutoSize = True
        Me.rdbYonetici.Location = New System.Drawing.Point(238, 240)
        Me.rdbYonetici.Name = "rdbYonetici"
        Me.rdbYonetici.Size = New System.Drawing.Size(76, 20)
        Me.rdbYonetici.TabIndex = 6
        Me.rdbYonetici.TabStop = True
        Me.rdbYonetici.Text = "Yönetici"
        Me.rdbYonetici.UseVisualStyleBackColor = True
        '
        'rdbMusteri
        '
        Me.rdbMusteri.AutoSize = True
        Me.rdbMusteri.Location = New System.Drawing.Point(401, 240)
        Me.rdbMusteri.Name = "rdbMusteri"
        Me.rdbMusteri.Size = New System.Drawing.Size(71, 20)
        Me.rdbMusteri.TabIndex = 7
        Me.rdbMusteri.TabStop = True
        Me.rdbMusteri.Text = "Müşteri"
        Me.rdbMusteri.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.rdbMusteri)
        Me.Controls.Add(Me.rdbYonetici)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKayıt)
        Me.Controls.Add(Me.btnGiris)
        Me.Name = "Form1"
        Me.Text = "GİRİŞ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiris As Button
    Friend WithEvents btnKayıt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents rdbYonetici As RadioButton
    Friend WithEvents rdbMusteri As RadioButton
End Class
