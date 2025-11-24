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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Araba_Kiralama
{
    public partial class GİRİS : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public GİRİS()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-5BQNOPU\\SQLEXPRESS;Initial Catalog=ArabaKiralamaDB;Integrated Security=True");
        }
        private void btnkayit_Click(object sender, EventArgs e)
        {
            KAYIT kayit = new KAYIT();
            kayit.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            con.Open();
            string kullaniciTipi = rdbyonetici.Checked ? "yonetici" : "musteri";
            string kullaniciId = rdbyonetici.Checked ? "yonetici_id" : "musteri_id";
            string query = $"SELECT {kullaniciId},e_mail, sifre FROM ";
            if (rdbyonetici.Checked)
                query += $"{kullaniciTipi} WHERE e_mail=@e_mail AND Sifre=@sifre";
            else if (rdbmusteri.Checked)
                query += $"{kullaniciTipi} WHERE e_mail=@e_mail AND Sifre=@sifre";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@e_mail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int secilen_id = dr.GetInt32(0);
                MessageBox.Show("Giriş başarılı!");

                if (rdbyonetici.Checked)
                {
                    
                    YÖNETİCİ yoneticiForm = new YÖNETİCİ(secilen_id);
                    yoneticiForm.Show();
                    this.Hide();
                }
                else if (rdbmusteri.Checked)
                {
                    
                    MÜŞTERİ musteriForm = new MÜŞTERİ(secilen_id);
                    musteriForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

      
            con.Close();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
