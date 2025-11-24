<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KIRALANANLAR
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtyas = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtodasayisi = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtıl = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtfıyat = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbtıp = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMetrekaresorgu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmlakidsorgu = New System.Windows.Forms.TextBox()
        Me.btngeridon = New System.Windows.Forms.Button()
        Me.btncikis = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(777, 314)
        Me.DataGridView1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 16)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Emlak Id Sorgulama:"
        '
        'txtyas
        '
        Me.txtyas.Location = New System.Drawing.Point(56, 149)
        Me.txtyas.Name = "txtyas"
        Me.txtyas.Size = New System.Drawing.Size(197, 22)
        Me.txtyas.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-2, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 16)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Yaş:"
        '
        'txtodasayisi
        '
        Me.txtodasayisi.Location = New System.Drawing.Point(589, 109)
        Me.txtodasayisi.Name = "txtodasayisi"
        Me.txtodasayisi.Size = New System.Drawing.Size(194, 22)
        Me.txtodasayisi.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(506, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 16)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Oda Sayısı:"
        '
        'txtıl
        '
        Me.txtıl.Location = New System.Drawing.Point(564, 58)
        Me.txtıl.Name = "txtıl"
        Me.txtıl.Size = New System.Drawing.Size(219, 22)
        Me.txtıl.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(531, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 16)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "İl:"
        '
        'txtfıyat
        '
        Me.txtfıyat.Location = New System.Drawing.Point(61, 103)
        Me.txtfıyat.Name = "txtfıyat"
        Me.txtfıyat.Size = New System.Drawing.Size(192, 22)
        Me.txtfıyat.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-2, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Fiyat:"
        '
        'cmbtıp
        '
        Me.cmbtıp.FormattingEnabled = True
        Me.cmbtıp.Items.AddRange(New Object() {"Villa", "Daire", "Köşk", "Semt"})
        Me.cmbtıp.Location = New System.Drawing.Point(61, 51)
        Me.cmbtıp.Name = "cmbtıp"
        Me.cmbtıp.Size = New System.Drawing.Size(192, 24)
        Me.cmbtıp.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-5, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Tip Ara:"
        '
        'txtMetrekaresorgu
        '
        Me.txtMetrekaresorgu.Location = New System.Drawing.Point(573, 6)
        Me.txtMetrekaresorgu.Name = "txtMetrekaresorgu"
        Me.txtMetrekaresorgu.Size = New System.Drawing.Size(210, 22)
        Me.txtMetrekaresorgu.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(407, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 16)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Metrekare Sorgulama:"
        '
        'txtEmlakidsorgu
        '
        Me.txtEmlakidsorgu.Location = New System.Drawing.Point(135, 0)
        Me.txtEmlakidsorgu.Name = "txtEmlakidsorgu"
        Me.txtEmlakidsorgu.Size = New System.Drawing.Size(192, 22)
        Me.txtEmlakidsorgu.TabIndex = 64
        '
        'btngeridon
        '
        Me.btngeridon.Location = New System.Drawing.Point(1, 590)
        Me.btngeridon.Name = "btngeridon"
        Me.btngeridon.Size = New System.Drawing.Size(151, 57)
        Me.btngeridon.TabIndex = 78
        Me.btngeridon.Text = "Geri Dön"
        Me.btngeridon.UseVisualStyleBackColor = True
        '
        'btncikis
        '
        Me.btncikis.Location = New System.Drawing.Point(687, 590)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(160, 57)
        Me.btncikis.TabIndex = 79
        Me.btncikis.Text = "Çıkış"
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'KIRALANANLAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 659)
        Me.Controls.Add(Me.btncikis)
        Me.Controls.Add(Me.btngeridon)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtyas)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtodasayisi)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtıl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtfıyat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbtıp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMetrekaresorgu)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmlakidsorgu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "KIRALANANLAR"
        Me.Text = "KIRALANANLAR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtyas As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtodasayisi As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtıl As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtfıyat As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbtıp As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMetrekaresorgu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmlakidsorgu As TextBox
    Friend WithEvents btngeridon As Button
    Friend WithEvents btncikis As Button
End Class
