Imports System.Data.SqlClient

Public Class KIRALANANLAR
    Private musteriID As Integer
    Public Sub New(musteriID As Integer)
        InitializeComponent()
        Me.musteriID = musteriID
    End Sub
    Dim connectionString As String = "Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True"

    Private Sub KIRALANANLAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKiralananlar()
    End Sub
    Private Sub LoadKiralananlar()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT k.kira_id, e.emlak_id, k.kira_ucret, k.kira_tarihi, k.durum_id " &
                                      "FROM kiralama k " &
                                      "JOIN emlak e ON k.emlak_id = e.emlak_id " &
                                      "WHERE k.musteri_id = @musteriId"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@musteriId", musteriID)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veriler yüklenirken bir hata oluştu: " & ex.Message)
        End Try
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

    Private Sub txtEmlakidsorgu_TextChanged(sender As Object, e As EventArgs) Handles txtEmlakidsorgu.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtMetrekaresorgu_TextChanged(sender As Object, e As EventArgs) Handles txtMetrekaresorgu.TextChanged
        FiltreUygula()
    End Sub

    Private Sub cmbtıp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtıp.SelectedIndexChanged
        FiltreUygula()
    End Sub

    Private Sub txtfıyat_TextChanged(sender As Object, e As EventArgs) Handles txtfıyat.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtıl_TextChanged(sender As Object, e As EventArgs) Handles txtıl.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtodasayisi_TextChanged(sender As Object, e As EventArgs) Handles txtodasayisi.TextChanged
        FiltreUygula()
    End Sub

    Private Sub txtyas_TextChanged(sender As Object, e As EventArgs) Handles txtyas.TextChanged
        FiltreUygula()
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Application.Exit()
    End Sub

    Private Sub btngeridon_Click(sender As Object, e As EventArgs) Handles btngeridon.Click
        Dim musteriform As New MUSTERI(musteriID)
        musteriform.Show()
        LoadKiralananlar()
        Me.Hide()
    End Sub
End Class