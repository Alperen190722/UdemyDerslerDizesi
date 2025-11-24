Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form1
    Private con As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True")

    Private Sub btnKayıt_Click(sender As Object, e As EventArgs) Handles btnKayıt.Click
        Dim kayit As New KAYIT()
        kayit.Show()
        Me.Hide()
    End Sub

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        con.Open()
        Dim kullaniciTipi As String = If(rdbYonetici.Checked, "yonetici", "musteri")
        Dim kullaniciId As String = If(rdbYonetici.Checked, "yonetici_id", "musteri_id")
        Dim query As String = $"SELECT {kullaniciId}, e_mail, sifre FROM "

        If rdbYonetici.Checked Then
            query &= $"{kullaniciTipi} WHERE e_mail=@e_mail AND Sifre=@sifre"
        ElseIf rdbMusteri.Checked Then
            query &= $"{kullaniciTipi} WHERE e_mail=@e_mail AND Sifre=@sifre"
        End If

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@e_mail", txtEmail.Text)
        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text)
        Dim dr As SqlDataReader = cmd.ExecuteReader()


        If dr.Read() Then
            Dim secilen_id As Integer = dr.GetInt32(0)
            MessageBox.Show("Giriş başarılı!")

            If rdbYonetici.Checked Then
                ' Yönetici paneline yönlendirme kodu
                Dim yoneticiForm As New YONETICI(secilen_id)
                yoneticiForm.Show()
                Me.Hide()
            ElseIf rdbMusteri.Checked Then
                ' Müşteri paneline yönlendirme kodu
                Dim musteriForm As New MUSTERI(secilen_id)
                musteriForm.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Giriş başarısız. E-posta veya şifre hatalı.")
        End If

        con.Close()
    End Sub
End Class
