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
    public partial class BAKİYE : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True");
        private int secilen_id;
        public BAKİYE(int secilen_id)
        {
            InitializeComponent();
            this.secilen_id = secilen_id;
        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT bakiye FROM musteri WHERE musteri_id = @musteri_id", baglanti);
            cmd.Parameters.AddWithValue("@musteri_id", secilen_id);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbakiye.Text = dr["bakiye"].ToString();
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.");
            }

            dr.Close();
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbakiye.Text) || string.IsNullOrEmpty(txtekleme.Text))
            {
                MessageBox.Show("Bakiye veya ekleme miktarı boş olamaz.");
                return;
            }

            decimal mevcutBakiye = decimal.Parse(txtbakiye.Text);
            decimal eklenecekMiktar = decimal.Parse(txtekleme.Text);
            decimal yeniBakiye = mevcutBakiye + eklenecekMiktar;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE musteri SET bakiye = @yeniBakiye WHERE musteri_id = @musteri_id", baglanti);
            cmd.Parameters.AddWithValue("@yeniBakiye", yeniBakiye);
            cmd.Parameters.AddWithValue("@musteri_id", secilen_id);


            int affectedRows = cmd.ExecuteNonQuery();
            if (affectedRows > 0)
            {
                MessageBox.Show("Bakiye güncellendi.");
                txtbakiye.Text = yeniBakiye.ToString();
            }
            else
            {
                MessageBox.Show("Bakiye güncellenirken bir hata oluştu.");
            }

            baglanti.Close();
        }

        private void btnmusterisayfasınadon_Click(object sender, EventArgs e)
        {
            MÜŞTERİ musteri = new MÜŞTERİ(secilen_id);
            musteri.Show();
            this.Hide();
        }
    }
}
