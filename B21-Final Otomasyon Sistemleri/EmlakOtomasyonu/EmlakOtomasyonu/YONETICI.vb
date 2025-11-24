Imports System.Data.SqlClient
Imports System.IO

Public Class YONETICI
    Dim connectionString As String = "Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True"
    Dim dataTable As New DataTable()

    Private Sub YONETICI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmlakData()
        LoadCities()
    End Sub

    Private Sub VerileriDoldur()
        Using connection As New SqlConnection("Server=DESKTOP-5BQNOPU\SQLEXPRESS;Database=EmlakDB;Integrated Security=true;")
            connection.Open()

            Dim sqlQuery As String = "SELECT * FROM emlak" ' Veritabanından veri çekme sorgusu

            Using command As New SqlCommand(sqlQuery, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable ' DataGridView'e verileri aktarma
                End Using
            End Using
        End Using
    End Sub

    Public Function VerileriAl() As DataTable
        Using connection As New SqlConnection("Server=DESKTOP-5BQNOPU\SQLEXPRESS;Database=EmlakDB;Integrated Security=true;")
            connection.Open()

            Dim sqlQuery As String = "SELECT * FROM emlak"

            Using command As New SqlCommand(sqlQuery, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Private Sub LoadCities()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Using cmd As New SqlCommand("SELECT il_kodu, il_adi FROM iller", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbiller.DisplayMember = "il_adi"
                cmbiller.ValueMember = "il_kodu"
                cmbiller.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LoadDistricts(cityCode As Integer)
        Using con As New SqlConnection(connectionString)
            con.Open()
            Using cmd As New SqlCommand("SELECT ilce_kodu, ilce_adi FROM ilceler WHERE il_kodu = @CityCode", con)
                cmd.Parameters.AddWithValue("@CityCode", cityCode)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbilceler.DisplayMember = "ilce_adi"
                cmbilceler.ValueMember = "ilce_kodu"
                cmbilceler.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LoadEmlakData()
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT emlak_id, metrekare, tip, il_kodu, ilce_kodu, adres, fiyat, oda_sayisi, bina_yasi, depozito, yonetici_id, durum_id, emlak_resim, kira_ucret FROM emlak", connection)
            Dim adapter As New SqlDataAdapter(command)
            dataTable.Clear()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub Temizle()
        If cmbTip.SelectedItem IsNot Nothing Then
            cmbTip.SelectedItem.ToString()
        End If
        cmbiller.Text = ""
        cmbilceler.Text = ""
        txtAdres.Text = ""
        txtFiyat.Text = ""
        txtkiraucret.Text = ""
        If cmbOdasayisi.SelectedItem IsNot Nothing Then
            cmbOdasayisi.SelectedItem.ToString()
        End If
        If cmbmetrekare.SelectedItem IsNot Nothing Then
            cmbmetrekare.SelectedItem.ToString()
        End If
        txtBinayasi.Text = ""
        txtDepozito.Text = ""
        txtdurumid.Text = ""
    End Sub

    Private baglanti As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True")
    Private secilen_id As Integer

    Public Sub New(secilen_id As Integer)
        InitializeComponent()
        Me.secilen_id = secilen_id
    End Sub

    Private Sub btnKayitGiris_Click(sender As Object, e As EventArgs) Handles btnKayitGiris.Click
        Dim secilen_il As Integer = Convert.ToInt32(cmbiller.SelectedValue)
        Dim secilen_ilce As Integer = Convert.ToInt32(cmbilceler.SelectedValue)
        baglanti.Open()

        Dim komut As New SqlCommand("INSERT INTO emlak(tip,adres,fiyat,metrekare,oda_sayisi,bina_yasi,depozito,yonetici_id,durum_id,il_kodu,ilce_kodu,kira_ucret) VALUES 
        (@tip,@adres,@fiyat,@metrekare,@oda_sayisi,@bina_yasi,@depozito,@yonetici_id,@durum_id,@il_kodu,@ilce_kodu,@kiraucret)", baglanti)

        komut.Parameters.AddWithValue("@tip", cmbTip.Text)
        komut.Parameters.AddWithValue("@il_kodu", secilen_il)
        komut.Parameters.AddWithValue("@ilce_kodu", secilen_ilce)
        komut.Parameters.AddWithValue("@adres", txtAdres.Text)
        komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text)
        komut.Parameters.AddWithValue("@metrekare", cmbmetrekare.Text)
        komut.Parameters.AddWithValue("@oda_sayisi", cmbOdasayisi.Text)
        komut.Parameters.AddWithValue("@bina_yasi", txtBinayasi.Text)
        komut.Parameters.AddWithValue("@depozito", txtDepozito.Text)
        komut.Parameters.AddWithValue("@yonetici_id", secilen_id)
        komut.Parameters.AddWithValue("@durum_id", txtdurumid.Text)
        komut.Parameters.AddWithValue("@kiraucret", txtkiraucret.Text)
        Try
            Dim kontrol As Integer = komut.ExecuteNonQuery()

            If kontrol > 0 Then
                MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Temizle()
                LoadEmlakData()
            Else
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hata:" & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close()
        End Try
    End Sub



    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If DataGridView1.SelectedRows.Count > 0 AndAlso DataGridView1.SelectedRows(0).Cells("emlak_id").Value IsNot Nothing Then
            Dim selectedId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("emlak_id").Value)
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("DELETE FROM emlak WHERE emlak_id = @emlak_id", connection)
                command.Parameters.AddWithValue("@emlak_id", selectedId)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
            LoadEmlakData()
        Else
            MessageBox.Show("Lütfen silinecek bir emlak seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim emlak_id As Integer = Convert.ToInt32(selectedRow.Cells("emlak_id").Value)

            Dim yeniyonetici_id As Integer = If(IsDBNull(selectedRow.Cells("yonetici_id").Value), 0, Convert.ToInt32(selectedRow.Cells("yonetici_id").Value))
            Dim yenitip As String = If(IsDBNull(selectedRow.Cells("tip").Value), String.Empty, selectedRow.Cells("tip").Value.ToString())
            Dim yeniilkod As String = If(IsDBNull(selectedRow.Cells("il_kodu").Value), 0, Convert.ToInt32(selectedRow.Cells("il_kodu").Value))
            Dim yeniilcekod As String = If(IsDBNull(selectedRow.Cells("ilce_kodu").Value), 0, Convert.ToInt32(selectedRow.Cells("ilce_kodu").Value))
            Dim yeniadres As String = If(IsDBNull(selectedRow.Cells("adres").Value), String.Empty, selectedRow.Cells("adres").Value.ToString())
            Dim yenifiyat As Decimal = If(IsDBNull(selectedRow.Cells("fiyat").Value), 0, Convert.ToDecimal(selectedRow.Cells("fiyat").Value))
            Dim yenimetrekare As String = If(IsDBNull(selectedRow.Cells("metrekare").Value), String.Empty, selectedRow.Cells("metrekare").Value)
            Dim yeniodasayisi As String = If(IsDBNull(selectedRow.Cells("oda_sayisi").Value), String.Empty, selectedRow.Cells("oda_sayisi").Value.ToString())
            Dim yenibinayasi As Integer = If(IsDBNull(selectedRow.Cells("bina_yasi").Value), 0, Convert.ToInt32(selectedRow.Cells("bina_yasi").Value))
            Dim yenidepozito As Decimal = If(IsDBNull(selectedRow.Cells("depozito").Value), 0, Convert.ToDecimal(selectedRow.Cells("depozito").Value))
            Dim yenidurum_id As Integer = If(IsDBNull(selectedRow.Cells("durum_id").Value), 0, Convert.ToInt32(selectedRow.Cells("durum_id").Value))
            Dim yenikirafiyat As Decimal = If(IsDBNull(selectedRow.Cells("kira_ucret").Value), 0, Convert.ToDecimal(selectedRow.Cells("kira_ucret").Value))
            Dim connection As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True;Encrypt=False")
            Dim command As New SqlCommand("UPDATE emlak SET tip = @tip, il_kodu = @il_kodu, yonetici_id = @yonetici_id, ilce_kodu = @ilce_kodu, adres = @adres, fiyat = @fiyat, metrekare = @metrekare, oda_sayisi = @oda_sayisi, bina_yasi = @bina_yasi, depozito = @depozito, durum_id = @durum_id, kira_ucret = @kira_ucret WHERE emlak_id = @emlak_id", connection)
            command.Parameters.AddWithValue("@tip", yenitip)
            command.Parameters.AddWithValue("@il_kodu", yeniilkod)
            command.Parameters.AddWithValue("@yonetici_id", yeniyonetici_id)
            command.Parameters.AddWithValue("@ilce_kodu", yeniilcekod)
            command.Parameters.AddWithValue("@adres", yeniadres)
            command.Parameters.AddWithValue("@fiyat", yenifiyat)
            command.Parameters.AddWithValue("@metrekare", yenimetrekare)
            command.Parameters.AddWithValue("@oda_sayisi", yeniodasayisi)
            command.Parameters.AddWithValue("@bina_yasi", yenibinayasi)
            command.Parameters.AddWithValue("@depozito", yenidepozito)
            command.Parameters.AddWithValue("@durum_id", yenidurum_id)
            command.Parameters.AddWithValue("@emlak_id", emlak_id)
            command.Parameters.AddWithValue("@kira_ucret", yenikirafiyat)
            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Emlak başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmlakData()
            Catch ex As Exception
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Lütfen güncellenecek bir emlak seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub FiltrelemeUygula(sqlKodu As String, parameters As List(Of SqlParameter))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlKodu, connection)
                For Each param As SqlParameter In parameters
                    command.Parameters.Add(param)
                Next

                connection.Open()
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub FiltreUygula()
        Dim sqlKodu As String = "
SELECT 
    emlak.emlak_id, 
    emlak.tip, 
    emlak.durum_id,
    emlak.adres,
    emlak.yonetici_id,
    emlak.fiyat, 
    emlak.metrekare,
    emlak.oda_sayisi,
    emlak.bina_yasi,
    iller.il_adi, 
    ilceler.ilce_adi
FROM emlak
INNER JOIN iller ON emlak.il_kodu = iller.il_kodu
INNER JOIN ilceler ON emlak.ilce_kodu = ilceler.ilce_kodu
"

        Dim conditions As New List(Of String)()
        Dim parameters As New List(Of SqlParameter)()

        If Not String.IsNullOrWhiteSpace(cmbtıp.Text) Then
            Dim tipler() As String = cmbtıp.Text.Split(","c).Select(Function(t) t.Trim()).ToArray()
            Dim tipCondition As String = String.Join(" OR ", tipler.Select(Function(t) $"emlak.tip LIKE '%{t}%'"))
            conditions.Add($"({tipCondition})")
        End If

        If Not String.IsNullOrWhiteSpace(txtıl.Text) Then
            ' İlgili il adı ile eşleşen kayıtları getirmek için parametre ekleyin
            Dim ilAdi As String = txtıl.Text.Trim()
            conditions.Add("iller.il_adi LIKE @il_adi")
            parameters.Add(New SqlParameter("@il_adi", $"%{ilAdi}%"))
        End If

        If Not String.IsNullOrWhiteSpace(txtodasayisi.Text) Then
            Dim odaSayisi As Integer
            If Integer.TryParse(txtodasayisi.Text, odaSayisi) Then
                conditions.Add($"oda_sayisi = {odaSayisi}")
            Else
                MessageBox.Show("Oda Sayısı sayısal olmalı!")
                Return
            End If
        End If

        If Not String.IsNullOrWhiteSpace(txtyas.Text) Then
            Dim binaYasi As Integer
            If Integer.TryParse(txtyas.Text, binaYasi) Then
                conditions.Add($"bina_yasi = {binaYasi}")
            Else
                MessageBox.Show("Bina Yaşı sayısal olmalı!")
                Return
            End If
        End If

        If Not String.IsNullOrWhiteSpace(txtEmlakidsorgu.Text) Then
            Dim emlakId As Integer
            If Integer.TryParse(txtEmlakidsorgu.Text, emlakId) Then
                conditions.Add($"emlak_id = {emlakId}")
            Else
                MessageBox.Show("Id sayısal olmalı!")
                Return
            End If
        End If

        If conditions.Any() Then
            sqlKodu += " WHERE " & String.Join(" AND ", conditions)
        End If

        FiltrelemeUygula(sqlKodu, parameters)
    End Sub


    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Application.Exit()
    End Sub

    Private Sub btnillerigoster_Click(sender As Object, e As EventArgs) Handles btnillerigoster.Click
        Dim selectedCityCode As String = cmbiller.SelectedValue.ToString()
        Dim selectedDistrictCode As String = cmbilceler.SelectedValue.ToString()

        MessageBox.Show("Selected City Code: " & selectedCityCode & vbCrLf & "Selected District Code: " & selectedDistrictCode)
    End Sub

    Private Sub cmbiller_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbiller.SelectedIndexChanged
        Dim selectedCityCode As Integer = Convert.ToInt32(cmbiller.SelectedValue)
        LoadDistricts(selectedCityCode)
    End Sub

    Private Sub txtıl_TextChanged(sender As Object, e As EventArgs) Handles txtıl.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtfıyat_TextChanged(sender As Object, e As EventArgs) Handles txtfıyat.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtodasayisi_TextChanged(sender As Object, e As EventArgs) Handles txtodasayisi.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtMetrekaresorgu_TextChanged(sender As Object, e As EventArgs) Handles txtMetrekaresorgu.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtEmlakidsorgu_TextChanged(sender As Object, e As EventArgs) Handles txtEmlakidsorgu.TextChanged
        FiltreUygula()
    End Sub

    Private Sub cmbtıp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtıp.SelectedIndexChanged
        FiltreUygula()
    End Sub

    Private Sub txtyas_TextChanged(sender As Object, e As EventArgs) Handles txtyas.TextChanged
        FiltreUygula()
    End Sub

    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        Dim girisform As New Form1()
        girisform.Show()
        Me.Hide()
    End Sub
End Class
