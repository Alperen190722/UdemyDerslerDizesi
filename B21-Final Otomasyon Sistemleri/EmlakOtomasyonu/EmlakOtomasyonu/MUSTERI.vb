Imports System.Data.SqlClient

Public Class MUSTERI
    Private connectionString As String = "Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True"
    Private secilen_id As Integer
    Private musteriID As Integer
    Public Sub New(musteriID As Integer)
        InitializeComponent()
        Me.musteriID = musteriID
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

    Private Sub SatilikEmlaklariYukle()

        Try

            Using connection As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True")

                Dim query As String = "SELECT " &
                                  "emlak.emlak_id, " &
                                  "emlak.tip, " &
                                  "emlak.fiyat, " &
                                  "emlak.adres, " &
                                  "emlak.yonetici_id, " &
                                  "emlak.metrekare, " &
                                  "emlak.oda_sayisi, " &
                                  "emlak.bina_yasi, " &
                                  "emlak.durum_id, " &
                                  "emlak.kira_ucret," &
                                  "iller.il_adi, " &
                                  "ilceler.ilce_adi " &
                                  "FROM emlak " &
                                  "INNER JOIN iller ON emlak.il_kodu = iller.il_kodu " &
                                  "INNER JOIN ilceler ON emlak.ilce_kodu = ilceler.ilce_kodu " &
                                  "WHERE emlak.emlak_id NOT IN (SELECT emlak_id FROM satis) " &
                                  "AND emlak.durum_id = '1'"


                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table

            End Using

        Catch ex As Exception
            MessageBox.Show("Veriler yüklenirken bir hata oluştu: " & ex.Message)
        End Try

    End Sub

    Private Sub KiralikEmlaklariYukle()

        Try

            Using connection As New SqlConnection("Data Source=DESKTOP-5BQNOPU\SQLEXPRESS;Initial Catalog=EmlakDB;Integrated Security=True")

                Dim query As String = "SELECT " &
                                  "emlak.emlak_id, " &
                                  "emlak.tip, " &
                                  "emlak.fiyat, " &
                                  "emlak.adres, " &
                                  "emlak.yonetici_id, " &
                                  "emlak.metrekare, " &
                                  "emlak.oda_sayisi, " &
                                  "emlak.bina_yasi, " &
                                  "emlak.durum_id, " &
                                  "emlak.kira_ucret," &
                                  "iller.il_adi, " &
                                  "ilceler.ilce_adi " &
                                  "FROM emlak " &
                                  "INNER JOIN iller ON emlak.il_kodu = iller.il_kodu " &
                                  "INNER JOIN ilceler ON emlak.ilce_kodu = ilceler.ilce_kodu " &
                                  "WHERE emlak.emlak_id NOT IN (SELECT emlak_id FROM kiralama) " &
                                  "AND emlak.durum_id = '1'"


                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table

            End Using

        Catch ex As Exception
            MessageBox.Show("Veriler yüklenirken bir hata oluştu: " & ex.Message)
        End Try

    End Sub

    Private Sub MUSTERI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SatilikEmlaklariYukle()
        KiralikEmlaklariYukle()
        VerileriAl()
        VerileriDoldur()
    End Sub

    Private Sub btnsatis_Click(sender As Object, e As EventArgs) Handles btnsatinal.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim emlakID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("Emlak_id").Value)
            Dim satisFiyat As Decimal = CDec(DataGridView1.SelectedRows(0).Cells("fiyat").Value)
            Dim durumID As Integer = 3 ' Satış durumunu belirleyen ID

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO satis (emlak_id, musteri_id, satis_tarihi, satis_fiyat, durum_id) VALUES (@emlakId, @musteriId, @satisTarihi, @satisFiyat, @DurumID)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@emlakId", emlakID)
                    command.Parameters.AddWithValue("@musteriId", musteriID)
                    command.Parameters.AddWithValue("@satisTarihi", DateTime.Now)
                    command.Parameters.AddWithValue("@satisFiyat", satisFiyat)
                    command.Parameters.AddWithValue("@DurumID", durumID)

                    command.ExecuteNonQuery()
                End Using
            End Using


            Dim satinalinanlarform As New SATINALINANLAR(musteriID)
            satinalinanlarform.Show()
            SatilikEmlaklariYukle()
            Me.Hide()
        Else

            MessageBox.Show("Lütfen satın almak istediğiniz emlağı seçin.")

        End If

    End Sub

    Private Sub btnkirala_Click(sender As Object, e As EventArgs) Handles btnkirala.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim emlakID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("Emlak_id").Value)
            Dim kiraFiyat As Decimal = CDec(DataGridView1.SelectedRows(0).Cells("kira_ucret").Value)
            Dim durumID As Integer = 4 ' Satış durumunu belirleyen ID

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO kiralama (emlak_id, musteri_id, kira_tarihi, kira_ucret, durum_id) VALUES (@emlakId, @musteriId, @kiraTarihi, @kiraUcret, @DurumID)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@emlakId", emlakID)
                    command.Parameters.AddWithValue("@musteriId", musteriID)
                    command.Parameters.AddWithValue("@kiraTarihi", DateTime.Now)
                    command.Parameters.AddWithValue("@kiraUcret", kiraFiyat)
                    command.Parameters.AddWithValue("@DurumID", durumID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            Dim kıralananlarform As New KIRALANANLAR(musteriID)
            kıralananlarform.Show()
            KiralikEmlaklariYukle()
            Me.Hide()
        Else
            MessageBox.Show("Lütfen kiralama  istediğiniz emlağı seçin.")
        End If
    End Sub

    Private Sub btnsatisagit_Click(sender As Object, e As EventArgs) Handles btnsatisagit.Click
        Dim satinalinanlarform As New SATINALINANLAR(musteriID)
        satinalinanlarform.Show()
        Me.Hide()
    End Sub

    Private Sub btnkiralamayagit_Click(sender As Object, e As EventArgs) Handles btnkiralamayagit.Click
        Dim kıralananlarform As New KIRALANANLAR(musteriID)
        kıralananlarform.Show()
        Me.Hide()
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Application.Exit()
    End Sub

    Private Sub btngirisegeridon_Click(sender As Object, e As EventArgs) Handles btngirisegeridon.Click
        Dim girisform As New Form1()
        girisform.Show()
        Me.Hide()
    End Sub
End Class