using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Araba_Kiralama
{
    public partial class KAYIT : Form
    {
        private const string connectionString = "Server=DESKTOP-5BQNOPU\\SQLEXPRESS;Database=ArabaKiralamaDB;Integrated Security=true;";
        public KAYIT()
        {
            InitializeComponent();
        }
        private void btngeridon_Click(object sender, EventArgs e)
        {
            GİRİS giris = new GİRİS();
            giris.Show();
            this.Hide();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            string bakiye = txtbakiye.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string musteri_tc = txtTc.Text;
            string e_mail = txtEmail.Text;
            string sifre = txtSifre.Text;
            string telefon_no = txtTelefon.Text;
            string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            string ehliyet_no = txtEhliyetNo.Text;
            DateTime dogum_tarih = dtDogumTarihi.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO musteri(ad,soyad,musteri_tc,e_mail,sifre,telefon_no,ehliyet_no,dogum_tarih,cinsiyet,bakiye) " +
                                  "VALUES (@ad, @soyad, @musteri_tc, @e_mail, @sifre, @telefon_no, @ehliyet_no, @dogum_tarih, @Cinsiyet, @bakiye)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    command.Parameters.AddWithValue("@bakiye",bakiye);
                    command.Parameters.AddWithValue("@ad", ad);
                    command.Parameters.AddWithValue("@soyad", soyad);
                    command.Parameters.AddWithValue("@musteri_tc", musteri_tc);
                    command.Parameters.AddWithValue("@e_mail", e_mail);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@telefon_no", telefon_no);
                    command.Parameters.AddWithValue("@ehliyet_no", ehliyet_no);
                    command.Parameters.AddWithValue("@dogum_tarih", dogum_tarih);
                    command.Parameters.AddWithValue("@Cinsiyet",cinsiyet);

                        int rowsAffected = command.ExecuteNonQuery();

                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri kaydedilirken bir hata oluştu.");
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata:  "+ ex.Message);
                }
            }
        }
    }
}
