using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Kiralama
{
    public partial class MÜŞTERİ : Form
    {
        Dictionary<string, List<string>> markaModeller = new Dictionary<string, List<string>>();

        public class Araba
        {
            public int ArabaId { get; set; }
            public string PlakaNo { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public int YoneticiId { get; set; }
            public string ArabaTuru { get; set; }
            public int KoltukSayisi { get; set; }
            public DateTime Yil { get; set; }
            public int Beygir { get; set; }
            public string Renk { get; set; }
            public int Km { get; set; }
            public string YakitTuru { get; set; }
            public int DurumId { get; set; }
            public decimal Fiyat { get; set; }
            public decimal KiraFiyat { get; set; }
        }

        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True");

        private int secilen_id; 


        private List<Araba> arabalar = new List<Araba>();

 

        public MÜŞTERİ(int secilen_id)
        {
            InitializeComponent();
            this.secilen_id = secilen_id;
            VeritabanindanArabaCek();
            BakiyeGoster(secilen_id); 
            SatilikArabalariYukle(); 
            KiralikArabalariYukle(); 
            MarkaVeModelleriYukle();

        }

        private void MarkaVeModelleriYukle()
        {

            markaModeller.Add("Rolls Royce", new List<string> { "Ghost", "Spectre", "Phantom" });
            markaModeller.Add("Ferrari", new List<string> { "Spider", "LaFerrari", "F8" });
            markaModeller.Add("Mercedes", new List<string> { "G20", "Vito", "AMG" });
            markaModeller.Add("Lamborghini", new List<string> { "Urus", "Huracan", "Aventedor" });
            markaModeller.Add("Reanult", new List<string> { "Fluence", "Megan", "Clio" });
            markaModeller.Add("BMW", new List<string> { "F30", "M5 E60", "M3" });
            markaModeller.Add("Volkswagen", new List<string> { "Polo", "Golf", "Tiguan" });
            markaModeller.Add("Toyota", new List<string> { "Corolla", "Cargo", "Yaris" });
            markaModeller.Add("Bugatti", new List<string> { "Chiron", "Veyron" });

            foreach (var marka in markaModeller.Keys)
            {
                cmbmarkaara.Items.Add(marka);
            }

            if (cmbmarkaara.Items.Count > 0)
            {
                cmbmarkaara.SelectedIndex = 0;
            }
        }


        private DataTable VerileriAl()
        {
        DataTable dataTable = new DataTable();
            string connectionString = "Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True";
            string query = "SELECT araba_id, yonetici_id, marka, model, yil, yakit_turu, km, renk, beygir, koltuk_sayisi, araba_turu, plaka_no, durum_id, fiyat, kirafiyati, il_kodu, ilce_kodu FROM arabalar";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        private void SatilikArabalariYukle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
                {
                    string query = @"SELECT 
                   arabalar.araba_id,
                   arabalar.marka, 
                   arabalar.model,
                   arabalar.yil,
                   arabalar.yakit_turu,
                   arabalar.km,
                   arabalar.renk,
                   arabalar.beygir,
                   arabalar.yonetici_id,
                   arabalar.koltuk_sayisi,
                   arabalar.araba_turu,
                   arabalar.plaka_no,
                   arabalar.durum_id,
                   arabalar.fiyat,
                   arabalar.kirafiyati,
                   iller.il_adi, 
                   ilceler.ilce_adi 
                   FROM arabalar
                   INNER JOIN iller ON arabalar.il_kodu = iller.il_kodu
                   INNER JOIN ilceler ON arabalar.ilce_kodu = ilceler.ilce_kodu
                   WHERE arabalar.araba_id NOT IN (SELECT araba_id FROM satis)
                   AND arabalar.durum_id = '1'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dataGridViewMusteri.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

 

        private void KiralikArabalariYukle()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                string query = @"SELECT 
                 arabalar.araba_id,
                 arabalar.marka, 
                 arabalar.model,
                 arabalar.yil,
                 arabalar.yakit_turu,
                 arabalar.km,
                 arabalar.renk,
                 arabalar.beygir,
                 arabalar.yonetici_id,
                 arabalar.koltuk_sayisi,
                 arabalar.araba_turu,
                 arabalar.plaka_no,
                 arabalar.durum_id,
                 arabalar.fiyat,
                 arabalar.kirafiyati,
                 iller.il_adi, 
                 ilceler.ilce_adi 
                
                 FROM arabalar
                 INNER JOIN iller ON arabalar.il_kodu = iller.il_kodu
                 INNER JOIN ilceler ON arabalar.ilce_kodu = ilceler.ilce_kodu
                 WHERE arabalar.durum_id = '1' 
                 AND arabalar.araba_id NOT IN (SELECT araba_id FROM kiralama)";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridViewMusteri.DataSource = table;
            }
        }

        private void VeritabanindanArabaCek()
        {
            string connectionString = "Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM arabalar WHERE   durum_id=1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Araba araba = new Araba()
                    {
                        ArabaId = Convert.ToInt32(reader["araba_id"]),
                        PlakaNo = reader["plaka_no"].ToString(),
                        Marka = reader["marka"].ToString(),
                        Model = reader["model"].ToString(),
                        YoneticiId = Convert.ToInt32(reader["yonetici_id"]),
                        ArabaTuru = reader["araba_turu"].ToString(),
                        KoltukSayisi = Convert.ToInt32(reader["koltuk_sayisi"]),
                        Yil = Convert.ToDateTime(reader["yil"]),
                        Beygir = Convert.ToInt32(reader["beygir"]),
                        Renk = reader["renk"].ToString(),
                        Km = Convert.ToInt32(reader["km"]),
                        YakitTuru = reader["yakit_turu"].ToString(),
                        DurumId = Convert.ToInt32(reader["durum_id"]),
                        Fiyat = Convert.ToDecimal(reader["fiyat"]),
                        KiraFiyat = Convert.ToDecimal(reader["kirafiyati"])
                    };
                    arabalar.Add(araba);
                }
                reader.Close();
            }

        }

        private void BakiyeGoster(int musteriID)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteriID", connection))
                {
                    cmd.Parameters.AddWithValue("@musteriID", musteriID);
                    decimal bakiye = Convert.ToDecimal(cmd.ExecuteScalar());
                    txtbakiye.Text = bakiye.ToString("C");
                }
            }

        }
            private bool BakiyeKontrolSatinAl(int musteriID, decimal arabaFiyati)
        {
            decimal bakiye;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                
                using (SqlCommand cmd = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteriID", connection))
                {
                    cmd.Parameters.AddWithValue("@musteriID", musteriID);
                    bakiye = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

           
            if (bakiye >= arabaFiyati)
            {
                bakiye -= arabaFiyati;
                MessageBox.Show("Araba satın alındı. Yeni bakiye: " + bakiye.ToString("C"));
                txtbakiye.Text = bakiye.ToString("C");
                return true;
            }


            else
            {
                MessageBox.Show("Bakiye yetersiz!");
                return false;
            }
        }

        private bool BakiyeKontrolKirala(int musteriID, decimal arabaKirasi)
        {
            decimal bakiye;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                
                using (SqlCommand cmd = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteriID", connection))
                {
                    cmd.Parameters.AddWithValue("@musteriID", musteriID);
                    bakiye = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            
            if (bakiye >= arabaKirasi)
            {
                bakiye -= arabaKirasi;
                MessageBox.Show("Araba kiralandı. Yeni bakiye: " + bakiye.ToString("C"));
                txtbakiye.Text = bakiye.ToString("C");
                return true;
            }

            else
            {
                MessageBox.Show("Bakiye yetersiz!");
                return false;
            }
        }

        private void MÜŞTERİ_Load(object sender, EventArgs e)
        {
           
            YÖNETİCİ yoneticiFormu = new YÖNETİCİ(secilen_id);
            DataTable dataTable = yoneticiFormu.VerileriAl(); 

            dataGridViewMusteri.DataSource = dataTable; 

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT durum_id ,degisen, hasar_kaydi, kira_durumu, satis_durumu, motor_durumu FROM durum", connection);
            DataTable dataTable1 = new DataTable();
            adapter.Fill(dataTable1);
            dataGridViewDurum.DataSource = dataTable1;

            
            SqlDataAdapter adapterKirala = new SqlDataAdapter("SELECT * FROM kiralama", connection);
            DataTable dataTableKirala = new DataTable();
            adapterKirala.Fill(dataTableKirala);
            dataGridViewKiralaMusteri.DataSource = dataTableKirala;



           
            SqlDataAdapter adapterSatis = new SqlDataAdapter("SELECT * FROM satis", connection);
            DataTable dataTableSatis = new DataTable();
            adapterSatis.Fill(dataTableSatis);
            dataGridViewSatinAlMusteri.DataSource = dataTableSatis;

            SatilikArabalariYukle();
            KiralikArabalariYukle();

        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            BAKİYE bakiye = new BAKİYE(secilen_id);
            bakiye.Show();
            this.Hide();

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsatinal_Click(object sender, EventArgs e)
        {
            int secilenIndex = dataGridViewMusteri.CurrentRow.Index;
            int secilenArabaID = Convert.ToInt32(dataGridViewMusteri.Rows[secilenIndex].Cells["araba_id"].Value);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                // Araba fiyatını al
                using (SqlCommand cmd = new SqlCommand("SELECT fiyat FROM arabalar WHERE araba_id = @arabaID", connection))
                {
                    cmd.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    decimal arabaFiyati = Convert.ToDecimal(cmd.ExecuteScalar());

                    if (!BakiyeKontrolSatinAl(secilen_id, arabaFiyati))
                    {
                        return; // Bakiye yetersizse işlemi durdur
                    }
                }

                // Satış tablosuna ekleme yapma kodu
                using (SqlCommand cmdSatis = new SqlCommand("INSERT INTO satis (araba_id, musteri_id, satis_tarihi, durum_id) VALUES ( @arabaID, @musteriID, @satisTarihi, @durumID)", connection))
                {
                    cmdSatis.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    cmdSatis.Parameters.AddWithValue("@musteriID", secilen_id);
                    cmdSatis.Parameters.AddWithValue("@satisTarihi", DateTime.Now);
                    cmdSatis.Parameters.AddWithValue("@durumID", 2);
                    cmdSatis.ExecuteNonQuery();
                }
            }

            
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                using (SqlDataAdapter adapterSatis = new SqlDataAdapter("SELECT * FROM satis", connection))
                {
                    DataTable dataTableSatis = new DataTable();
                    adapterSatis.Fill(dataTableSatis);
                    dataGridViewSatinAlMusteri.DataSource = dataTableSatis;
                }

                
                using (SqlCommand cmdArabalar = new SqlCommand("UPDATE arabalar SET durum_id = @durum_id WHERE araba_id = @arabaID", connection))
                {
                    cmdArabalar.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    cmdArabalar.Parameters.AddWithValue("@durum_id", 2);
                    cmdArabalar.ExecuteNonQuery();
                }
            }

            
            SatilikArabalariYukle();

        }

        private void btnkirala_Click(object sender, EventArgs e)
        {
            int secilenIndex = dataGridViewMusteri.CurrentRow.Index;
            int secilenArabaID = Convert.ToInt32(dataGridViewMusteri.Rows[secilenIndex].Cells["araba_id"].Value);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();
                decimal arabaKirasi;
                
                using (SqlCommand cmd = new SqlCommand("SELECT kirafiyati FROM arabalar WHERE araba_id = @arabaID", connection))
                {
                    cmd.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    arabaKirasi = Convert.ToDecimal(cmd.ExecuteScalar());

                    if (!BakiyeKontrolKirala(secilen_id, arabaKirasi))
                    {
                        return; 
                    }
                }

                
                using (SqlCommand cmdKira = new SqlCommand("INSERT INTO kiralama (araba_id, musteri_id, kira_tarihi, kira_suresi, kira_ucret, durum_id) VALUES ( @arabaID, @musteriID, @kiraTarihi, @kiraSuresi, @kiraUcreti, @durumID)", connection))
                {
                    cmdKira.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    cmdKira.Parameters.AddWithValue("@musteriID", secilen_id);
                    cmdKira.Parameters.AddWithValue("@kiraTarihi", DateTime.Now);
                    cmdKira.Parameters.AddWithValue("@kiraSuresi", Convert.ToInt32(txtkirasuresi.Text));
                    cmdKira.Parameters.AddWithValue("@kiraUcreti", arabaKirasi * Convert.ToInt32(txtkirasuresi.Text));

                    cmdKira.Parameters.AddWithValue("@durumID", 4);
                    cmdKira.ExecuteNonQuery();
                }
            }

            
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                using (SqlDataAdapter adapterSatis = new SqlDataAdapter("SELECT * FROM kiralama", connection))
                {
                    DataTable dataTableKira = new DataTable();
                    adapterSatis.Fill(dataTableKira);
                    dataGridViewKiralaMusteri.DataSource = dataTableKira;
                }

                
                using (SqlCommand cmdArabalar = new SqlCommand("UPDATE arabalar SET durum_id = @durum_id WHERE araba_id = @arabaID", connection))
                {
                    cmdArabalar.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    cmdArabalar.Parameters.AddWithValue("@durum_id", 4);
                    cmdArabalar.ExecuteNonQuery();
                }
                KiralikArabalariYukle();
            }
        }

        private void btngirissayfasınageridon_Click(object sender, EventArgs e)
        {
            GİRİS giris = new GİRİS();
            giris.Show();
            this.Hide();
        }

        private void btnsatinalmaiptal_Click(object sender, EventArgs e)
        {
            
            int secilenIndex = dataGridViewSatinAlMusteri.CurrentRow.Index;
            int secilenSatisID = Convert.ToInt32(dataGridViewSatinAlMusteri.Rows[secilenIndex].Cells["satis_id"].Value);
            int secilenArabaID = Convert.ToInt32(dataGridViewSatinAlMusteri.Rows[secilenIndex].Cells["araba_id"].Value);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                
                using (SqlCommand cmdFiyat = new SqlCommand("SELECT fiyat FROM arabalar WHERE araba_id = @arabaID", connection))
                {
                    cmdFiyat.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    decimal arabaFiyati = Convert.ToDecimal(cmdFiyat.ExecuteScalar());

                    
                    using (SqlCommand cmdBakiye = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteriID", connection))
                    {
                        cmdBakiye.Parameters.AddWithValue("@musteriID", secilen_id);
                        decimal bakiye = Convert.ToDecimal(cmdBakiye.ExecuteScalar());
                        bakiye += arabaFiyati; 
                        MessageBox.Show("Araba satın alma iptal edildi. Yeni bakiye: " + bakiye.ToString("C"));
                        
                        using (SqlCommand cmdBakiyeUpdate = new SqlCommand("UPDATE musteri SET bakiye = @bakiye WHERE musteri_id = @musteriID", connection))
                        {
                            cmdBakiyeUpdate.Parameters.AddWithValue("@bakiye", bakiye);
                            cmdBakiyeUpdate.Parameters.AddWithValue("@musteriID", secilen_id);
                            cmdBakiyeUpdate.ExecuteNonQuery();
                        }
                    }

                    
                    using (SqlCommand cmdSatisSil = new SqlCommand("DELETE FROM satis WHERE satis_id = @satisID", connection))
                    {
                        cmdSatisSil.Parameters.AddWithValue("@satisID", secilenSatisID);
                        cmdSatisSil.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand cmdArabaDurum = new SqlCommand("UPDATE arabalar SET durum_id = @durumID WHERE araba_id = @arabaID", connection))
                    {
                        cmdArabaDurum.Parameters.AddWithValue("@durumID", 1); 
                        cmdArabaDurum.Parameters.AddWithValue("@arabaID", secilenArabaID);
                        cmdArabaDurum.ExecuteNonQuery();
                    }
                }
            }

            
            SatilikArabalariYukle();
            dataGridViewSatinAlMusteri.Refresh(); 

            
            MÜŞTERİ_Load(sender, e);
        }

        private void btnkiralamaiptal_Click(object sender, EventArgs e)
        {
            
            int secilenIndex = dataGridViewKiralaMusteri.CurrentRow.Index;
            int secilenKiraID = Convert.ToInt32(dataGridViewKiralaMusteri.Rows[secilenIndex].Cells["kira_id"].Value);
            int secilenArabaID = Convert.ToInt32(dataGridViewKiralaMusteri.Rows[secilenIndex].Cells["araba_id"].Value);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                connection.Open();

                
                using (SqlCommand cmdKiraFiyat = new SqlCommand("SELECT kirafiyati FROM arabalar WHERE araba_id = @arabaID", connection))
                {
                    cmdKiraFiyat.Parameters.AddWithValue("@arabaID", secilenArabaID);
                    decimal arabaKirasi = Convert.ToDecimal(cmdKiraFiyat.ExecuteScalar());

                    
                    using (SqlCommand cmdBakiye = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteriID", connection))
                    {
                        cmdBakiye.Parameters.AddWithValue("@musteriID", secilen_id);
                        decimal bakiye = Convert.ToDecimal(cmdBakiye.ExecuteScalar());
                        bakiye += arabaKirasi; 
                        MessageBox.Show("Araba kiralama iptal edildi. Yeni bakiye: " + bakiye.ToString("C"));
                        
                        using (SqlCommand cmdBakiyeUpdate = new SqlCommand("UPDATE musteri SET bakiye = @bakiye WHERE musteri_id = @musteriID", connection))
                        {
                            cmdBakiyeUpdate.Parameters.AddWithValue("@bakiye", bakiye);
                            cmdBakiyeUpdate.Parameters.AddWithValue("@musteriID", secilen_id);
                            cmdBakiyeUpdate.ExecuteNonQuery();
                        }
                    }

                    
                    using (SqlCommand cmdKiraSil = new SqlCommand("DELETE FROM kiralama WHERE kira_id = @kiraID", connection))
                    {
                        cmdKiraSil.Parameters.AddWithValue("@kiraID", secilenKiraID);
                        cmdKiraSil.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand cmdArabaDurum = new SqlCommand("UPDATE arabalar SET durum_id = @durumID WHERE araba_id = @arabaID", connection))
                    {
                        cmdArabaDurum.Parameters.AddWithValue("@durumID", 1); 
                        cmdArabaDurum.Parameters.AddWithValue("@arabaID", secilenArabaID);
                        cmdArabaDurum.ExecuteNonQuery();
                    }
                }
            }

           
            KiralikArabalariYukle();
            dataGridViewKiralaMusteri.Refresh(); 
                                                 
            
            MÜŞTERİ_Load(sender, e);


        }
        private void Filtrele()
        {
            string YoneticiId = txtyoneticiidara.Text.Trim();
            string arabaId = txtarabaidara.Text.Trim();
            string plaka = txtplakaara.Text.Trim();
            string marka = cmbmarkaara.SelectedItem?.ToString();
            string model = cmbmodelara.SelectedItem?.ToString();
            string arabaTuru = cmbarabaturuara.Text.Trim();

            
            string filterQuery = "SELECT araba_id, yonetici_id, marka, model, yil, yakit_turu, km, renk, beygir, koltuk_sayisi, araba_turu, plaka_no, durum_id, fiyat, kirafiyati, il_kodu, ilce_kodu FROM arabalar WHERE 1=1";

            if (!string.IsNullOrEmpty(YoneticiId))
            {
                filterQuery += $" AND yonetici_id = {YoneticiId}";
            }
            if (!string.IsNullOrEmpty(arabaId))
            {
                filterQuery += $" AND araba_id = {arabaId}";
            }
            if (!string.IsNullOrEmpty(plaka))
            {
                filterQuery += $" AND plaka_no LIKE '%{plaka}%'";
            }
            if (!string.IsNullOrEmpty(model))
            {
                filterQuery += $" AND model LIKE '%{model}%'";
            }
            if (!string.IsNullOrEmpty(marka))
            {
                filterQuery += $" AND marka LIKE '%{marka}%'";
            }
            if (!string.IsNullOrEmpty(arabaTuru))
            {
                filterQuery += $" AND araba_turu LIKE '%{arabaTuru}%'";
            }

           
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(filterQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewMusteri.DataSource = dataTable;
            }
        }

        private void txtplakaara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbmarkaara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMarka = cmbmarkaara.Text.Trim();
            List<string> modeller;

            if (markaModeller.TryGetValue(selectedMarka, out modeller))
            {
                cmbmodelara.Items.Clear();
                cmbmodelara.Items.AddRange(modeller.ToArray());
            }

            Filtrele();
        }

        private void cmbarabaturuara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arananArabaTuru = cmbarabaturuara.Text;
            if (!string.IsNullOrEmpty(arananArabaTuru))
            {
                DataTable dt = VerileriAl(); 
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"araba_turu LIKE '%{arananArabaTuru}%'";
                    dataGridViewMusteri.DataSource = dv.ToTable();
                }
            }
            Filtrele();
        }

        private void txtarabaidara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbmodelara_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txtyoneticiidara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void btngirisegeridon_Click(object sender, EventArgs e)
        {
            GİRİS giris = new GİRİS();
            giris.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
