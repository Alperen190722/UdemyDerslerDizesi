using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araba_Kiralama
{
    public partial class YÖNETİCİ : Form
    {
        Dictionary<string, List<string>> markaModeller = new Dictionary<string, List<string>>();
        private const string connectionString = "Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;";
        private int secilen_id;
        public YÖNETİCİ(int secilen_id)
        {
            InitializeComponent();

            LoadCities();

            MarkaVeModelleriYukle();

            ComboBoxlariDoldur();

            this.secilen_id = secilen_id;

        }


        private void VerileriDoldur()
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;"))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM arabalar"; // Veritabanından veri çekme sorgusu

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewYonetici.DataSource = dataTable; // DataGridView'e verileri aktarma
                }
            }

        }
        private void LoadCities()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT il_kodu, il_adi FROM iller", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbiller.DisplayMember = "il_adi";
                    cmbiller.ValueMember = "il_kodu";
                    cmbiller.DataSource = dt;
                }
            }
        }

       
        public DataTable VerileriAl()
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;"))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM arabalar"; 

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable; 
                }
            }
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
        private void ComboBoxlariDoldur()
        {
            
            foreach (var marka in markaModeller.Keys)
            {
                cmbmarka.Items.Add(marka);
            }
            
            if (cmbmarka.Items.Count > 0)
            {
                cmbmarka.SelectedIndex = 0;
            }
        }
        

    private void btnarackayit_Click(object sender, EventArgs e)
    {
         
            decimal fiyat = decimal.Parse(txtfiyat.Text);
            string marka = cmbmarka.Text;
            string model = cmbmodel.Text;
            DateTime yil = dtyil.Value;
            string yakit_turu = cmbyakit.SelectedItem.ToString();
            string km = txtkm.Text;
            string renk = cmbrenk.SelectedItem.ToString();
            string beygir = txtbeygir.Text;
            string koltuk_sayisi = txtkoltuk.Text;
            string araba_turu = cmbarabatur.SelectedItem.ToString();
            string plaka_no = txtPlaka.Text;
            string durum_id = txtdurumid.Text;
            decimal kirafiyatı = decimal.Parse(txtkirafiyati.Text);
            int secilen_il = Convert.ToInt32(cmbiller.SelectedValue);
            int secilen_ilce = Convert.ToInt32(cmbilceler.SelectedValue);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO arabalar(yonetici_id, marka, model, yil, yakit_turu, km, renk, beygir, koltuk_sayisi, araba_turu, plaka_no, fiyat, durum_id, kirafiyati, il_kodu, ilce_kodu) " +
                                  "VALUES (@yonetici_id, @marka, @model, @yil, @yakit_turu, @km, @renk, @beygir, @koltuk_sayisi, @araba_turu, @plaka_no, @fiyat , @durum_id, @kirafiyati, @il_kodu, @ilce_kodu)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yonetici_id", secilen_id);
                        command.Parameters.AddWithValue("@marka", marka);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@yil", yil);
                        command.Parameters.AddWithValue("@yakit_turu", yakit_turu);
                        command.Parameters.AddWithValue("@km", km);
                        command.Parameters.AddWithValue("@renk", renk);
                        command.Parameters.AddWithValue("@beygir", beygir);
                        command.Parameters.AddWithValue("@koltuk_sayisi", koltuk_sayisi);
                        command.Parameters.AddWithValue("@araba_turu", araba_turu);
                        command.Parameters.AddWithValue("@plaka_no", plaka_no);
                        command.Parameters.AddWithValue("@durum_id", durum_id);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        command.Parameters.AddWithValue("@kirafiyati", kirafiyatı);
                        command.Parameters.AddWithValue("@il_kodu", secilen_il);
                        command.Parameters.AddWithValue("@ilce_kodu", secilen_ilce);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Araba başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Araba kaydedilirken bir hata oluştu.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata:  " + ex.Message);
                }
            }
    }
        



    private void LoadCarData()
    {
             SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;");
            SqlCommand command = new SqlCommand("SELECT araba_id, yonetici_id, marka, model, yil, yakit_turu, km, renk, beygir, koltuk_sayisi, araba_turu, plaka_no, durum_id, fiyat, kirafiyati, il_kodu, ilce_kodu FROM arabalar ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewYonetici.DataSource = dataTable;
     }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int araba_id = Convert.ToInt32(dataGridViewYonetici.SelectedRows[0].Cells["araba_id"].Value);
            SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;");
            SqlCommand command = new SqlCommand("DELETE FROM arabalar WHERE araba_id = @araba_id",connection);
            command.Parameters.AddWithValue("@araba_id", araba_id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            LoadCarData();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(dataGridViewYonetici.SelectedRows.Count > 0)
            {
                int araba_id = Convert.ToInt32(dataGridViewYonetici.SelectedRows[0].Cells["araba_id"].Value);
                string yenifiyat = txtfiyat.Text;
                int yeniyonetici_id = secilen_id;
                string yenimarka = cmbmarka.Text;
                string yenimodel = cmbmodel.Text;
                DateTime yeniyil = dtyil.Value;
                string yeniyakit_turu = cmbyakit.Text;
                string yenikm = txtkm.Text;
                string yenirenk = cmbrenk.Text;
                string yenibeygir = txtbeygir.Text;
                string yenikoltuk_sayisi = txtkoltuk.Text;
                string yeniaraba_turu = cmbarabatur.Text;
                string yeniplaka_no = txtPlaka.Text;
                string yenidurum_id = txtdurumid.Text;
                string yenikirafiyatı = txtkirafiyati.Text;
                int yeniilkodu = Convert.ToInt32(cmbiller.SelectedValue);
                int yeniilcekodu = Convert.ToInt32(cmbilceler.SelectedValue);

                SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;");
                SqlCommand command = new SqlCommand("UPDATE arabalar SET marka = @marka, model = @model, yonetici_id = @yonetici_id, yil = @yil, yakit_turu = @yakit_turu, km = @km, renk = @renk, beygir = @beygir, koltuk_sayisi = @koltuk_sayisi, araba_turu = @araba_turu, plaka_no = @plaka_no, durum_id = @durum_id, fiyat = @fiyat, kirafiyati = @kirafiyati, il_kodu = @il_kodu, ilce_kodu = @ilce_kodu WHERE araba_id = @araba_id", connection);
                command.Parameters.AddWithValue("@marka", yenimarka);
                command.Parameters.AddWithValue("@model", yenimodel);
                command.Parameters.AddWithValue("@araba_id", araba_id);
                command.Parameters.AddWithValue("@yil", yeniyil);
                command.Parameters.AddWithValue("@yakit_turu",yeniyakit_turu);
                command.Parameters.AddWithValue("@km", yenikm);
                command.Parameters.AddWithValue("@renk", yenirenk);
                command.Parameters.AddWithValue("@beygir", yenibeygir);
                command.Parameters.AddWithValue("@koltuk_sayisi", yenikoltuk_sayisi);
                command.Parameters.AddWithValue("@araba_turu", yeniaraba_turu);
                command.Parameters.AddWithValue("@plaka_no", yeniplaka_no);
                command.Parameters.AddWithValue("@yonetici_id", yeniyonetici_id);
                command.Parameters.AddWithValue("@durum_id", yenidurum_id);
                command.Parameters.AddWithValue("@fiyat", yenifiyat);
                command.Parameters.AddWithValue("@kirafiyati", yenikirafiyatı);
                command.Parameters.AddWithValue("@il_kodu", yeniilkodu);
                command.Parameters.AddWithValue("@ilce_kodu", yeniilcekodu);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadCarData();
            }
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dataTable = (DataTable)dataGridViewYonetici.DataSource;

                
                SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT araba_id, plaka_no, marka, model, yonetici_id, araba_turu, koltuk_sayisi, yil, beygir, renk, km, yakit_turu, durum_id, fiyat, kirafiyati, il_kodu, ilce_kodu  FROM arabalar", connection);

                
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

               
                adapter.Update(dataTable);

              
                MessageBox.Show("Değişiklikler kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void YÖNETİCİ_Load(object sender, EventArgs e)
        {
            LoadCarData();
            ComboBoxlariDoldur();

            SqlConnection connection = new SqlConnection("Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT araba_id, plaka_no, marka, model, yonetici_id, araba_turu, koltuk_sayisi, yil, beygir, renk, km, yakit_turu, durum_id, fiyat, kirafiyati, il_kodu, ilce_kodu  FROM arabalar", connection);
            DataTable dataTable = new DataTable();
            

            adapter.Fill(dataTable);

            
            dataGridViewYonetici.DataSource = dataTable;

           
            VerileriDoldur();

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string secilenMarka = cmbmarka.SelectedItem.ToString();
            List<string> modeller;
            if (markaModeller.TryGetValue(secilenMarka, out modeller))
            {
                cmbmodel.Items.Clear();
                foreach (var model in modeller)
                {
                    cmbmodel.Items.Add(model);
                }
               
                if (cmbmodel.Items.Count > 0)
                {
                    cmbmodel.SelectedIndex = 0;
                }
            }
        }

        private void cmbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCityCode = Convert.ToInt32(cmbiller.SelectedValue);
            LoadDistricts(selectedCityCode);
        }

        private void LoadDistricts(int cityCode)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ilce_kodu, ilce_adi FROM ilceler WHERE il_kodu = @CityCode", con))
                {
                    cmd.Parameters.AddWithValue("@CityCode", cityCode);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbilceler.DisplayMember = "ilce_adi";
                    cmbilceler.ValueMember = "ilce_kodu";
                    cmbilceler.DataSource = dt;
                }
            }
        }

        private void btnillerigoster_Click(object sender, EventArgs e)
        {
            string selectedCityCode = cmbiller.SelectedValue.ToString();
            string selectedDistrictCode = cmbilceler.SelectedValue.ToString();

            MessageBox.Show($"Selected City Code: {selectedCityCode}\nSelected District Code: {selectedDistrictCode}");
        }

        private void btngirisegeridon_Click(object sender, EventArgs e)
        {
            GİRİS giris = new GİRİS();
            giris.Show();
            this.Hide();
        }

        private void Filtrele()
        {
            string YoneticiId = txtyoneticiidara.Text.Trim();
            string arabaId = txtarabaidara.Text.Trim();
            string plaka = txtplakaara.Text.Trim();
            string marka = cmbmarkaara.SelectedItem?.ToString();
            string model = cmbmodelara.SelectedItem?.ToString();
            string arabaTuru = cmbarabaturuara.Text.Trim();
            string DurumId = txtdurumidara.Text.Trim();

           
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
            if (!string.IsNullOrEmpty(DurumId))
            {
                filterQuery += $" AND durum_id LIKE '%{DurumId}%'";
            }

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(filterQuery, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewYonetici.DataSource = dataTable;
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

        private void txtarabaidara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txtplakaara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbmodelara_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbarabaturuara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arananArabaTuru = cmbarabaturuara.Text;
            if (!string.IsNullOrEmpty(arananArabaTuru))
            {
                DataTable dt = VerileriAl(); // Verileri çeken metodunuzu buraya yazmalısınız
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"araba_turu LIKE '%{arananArabaTuru}%'";
                    dataGridViewYonetici.DataSource = dv.ToTable();
                }
            }
            Filtrele();
        }

        private void txtdurumidara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txtyoneticiidara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
       



