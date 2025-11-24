Imports System.Data.SqlClient

Public Class KAYIT
    Private Sub Temizle()
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtEmail.Text = ""
        txtSifre.Text = ""
        txtEmail.Text = ""
        txtTc.Text = ""
        txtTelefon.Text = ""
        cmbCinsiyet.SelectedItem.ToString()
        dtDogum.Value = DateTime.Now
    End Sub

    Private Sub btnGeridon_Click(sender As Object, e As EventArgs) Handles btnGeridon.Click
        Dim giris As New Form1()
        giris.Show()
        Me.Hide()
    End Sub

    Private baglanti As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True")

    Private Sub btnKayitol_Click(sender As Object, e As EventArgs) Handles btnKayitol.Click
        baglanti.Open()
        Dim komut As New SqlCommand("INSERT INTO musteri(ad, soyad, tc_kimlik, telefon_no, e_mail, sifre, dogum_tarihi, cinsiyet) VALUES (@ad, @soyad, @tc_kimlik, @sifre, @e_mail, @telefon_no, @dogum_tarihi, @cinsiyet)", baglanti)
        komut.Parameters.AddWithValue("@ad", txtAd.Text)
        komut.Parameters.AddWithValue("@soyad", txtSoyad.Text)
        komut.Parameters.AddWithValue("@e_mail", txtEmail.Text)
        komut.Parameters.AddWithValue("@sifre", txtSifre.Text)
        komut.Parameters.AddWithValue("@tc_kimlik", txtTc.Text)
        komut.Parameters.AddWithValue("@telefon_no", txtTelefon.Text)
        komut.Parameters.AddWithValue("@dogum_tarihi", dtDogum.Value)
        komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text)
        Try
            Dim kontrol As Integer = komut.ExecuteNonQuery()

            If kontrol > 0 Then
                MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Temizle()
            Else
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hata:" & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close()
        End Try
    End Sub
End Class