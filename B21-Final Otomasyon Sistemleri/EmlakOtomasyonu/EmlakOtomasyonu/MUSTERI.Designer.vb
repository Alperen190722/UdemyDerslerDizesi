<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MUSTERI
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
        Me.btnsatinal = New System.Windows.Forms.Button()
        Me.btnkirala = New System.Windows.Forms.Button()
        Me.btnsatisagit = New System.Windows.Forms.Button()
        Me.btnkiralamayagit = New System.Windows.Forms.Button()
        Me.btngirisegeridon = New System.Windows.Forms.Button()
        Me.btncikis = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'btnsatinal
        '
        Me.btnsatinal.Location = New System.Drawing.Point(312, 374)
        Me.btnsatinal.Name = "btnsatinal"
        Me.btnsatinal.Size = New System.Drawing.Size(183, 69)
        Me.btnsatinal.TabIndex = 2
        Me.btnsatinal.Text = "SATIN AL"
        Me.btnsatinal.UseVisualStyleBackColor = True
        '
        'btnkirala
        '
        Me.btnkirala.Location = New System.Drawing.Point(640, 374)
        Me.btnkirala.Name = "btnkirala"
        Me.btnkirala.Size = New System.Drawing.Size(168, 69)
        Me.btnkirala.TabIndex = 3
        Me.btnkirala.Text = "KİRALA"
        Me.btnkirala.UseVisualStyleBackColor = True
        '
        'btnsatisagit
        '
        Me.btnsatisagit.Location = New System.Drawing.Point(12, 373)
        Me.btnsatisagit.Name = "btnsatisagit"
        Me.btnsatisagit.Size = New System.Drawing.Size(181, 70)
        Me.btnsatisagit.TabIndex = 4
        Me.btnsatisagit.Text = "SATIŞA GİT"
        Me.btnsatisagit.UseVisualStyleBackColor = True
        '
        'btnkiralamayagit
        '
        Me.btnkiralamayagit.Location = New System.Drawing.Point(918, 374)
        Me.btnkiralamayagit.Name = "btnkiralamayagit"
        Me.btnkiralamayagit.Size = New System.Drawing.Size(160, 69)
        Me.btnkiralamayagit.TabIndex = 5
        Me.btnkiralamayagit.Text = "KİRALAMAYA GİT"
        Me.btnkiralamayagit.UseVisualStyleBackColor = True
        '
        'btngirisegeridon
        '
        Me.btngirisegeridon.Location = New System.Drawing.Point(12, 520)
        Me.btngirisegeridon.Name = "btngirisegeridon"
        Me.btngirisegeridon.Size = New System.Drawing.Size(162, 64)
        Me.btngirisegeridon.TabIndex = 6
        Me.btngirisegeridon.Text = "Giriş Geri Dön"
        Me.btngirisegeridon.UseVisualStyleBackColor = True
        '
        'btncikis
        '
        Me.btncikis.Location = New System.Drawing.Point(918, 520)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(156, 64)
        Me.btncikis.TabIndex = 7
        Me.btncikis.Text = "Çıkış"
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'MUSTERI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1090, 596)
        Me.Controls.Add(Me.btncikis)
        Me.Controls.Add(Me.btngirisegeridon)
        Me.Controls.Add(Me.btnkiralamayagit)
        Me.Controls.Add(Me.btnsatisagit)
        Me.Controls.Add(Me.btnkirala)
        Me.Controls.Add(Me.btnsatinal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MUSTERI"
        Me.Text = "MUSTERI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsatinal As Button
    Friend WithEvents btnkirala As Button
    Friend WithEvents btnsatisagit As Button
    Friend WithEvents btnkiralamayagit As Button
    Friend WithEvents btngirisegeridon As Button
    Friend WithEvents btncikis As Button
End Class
