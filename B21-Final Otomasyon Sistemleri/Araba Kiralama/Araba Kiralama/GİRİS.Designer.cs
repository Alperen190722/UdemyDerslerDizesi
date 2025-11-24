namespace Araba_Kiralama
{
    partial class GİRİS
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnkayit = new System.Windows.Forms.Button();
            this.rdbyonetici = new System.Windows.Forms.RadioButton();
            this.rdbmusteri = new System.Windows.Forms.RadioButton();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(174, 80);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 22);
            this.txtSifre.TabIndex = 6;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGirisYap.Location = new System.Drawing.Point(3, 163);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(125, 65);
            this.btnGirisYap.TabIndex = 8;
            this.btnGirisYap.Text = "GİRİŞ";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnkayit
            // 
            this.btnkayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkayit.Location = new System.Drawing.Point(450, 163);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(130, 65);
            this.btnkayit.TabIndex = 9;
            this.btnkayit.Text = "KAYIT";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // rdbyonetici
            // 
            this.rdbyonetici.AutoSize = true;
            this.rdbyonetici.Location = new System.Drawing.Point(120, 126);
            this.rdbyonetici.Name = "rdbyonetici";
            this.rdbyonetici.Size = new System.Drawing.Size(76, 20);
            this.rdbyonetici.TabIndex = 10;
            this.rdbyonetici.TabStop = true;
            this.rdbyonetici.Text = "Yönetici";
            this.rdbyonetici.UseVisualStyleBackColor = true;
            // 
            // rdbmusteri
            // 
            this.rdbmusteri.AutoSize = true;
            this.rdbmusteri.Location = new System.Drawing.Point(372, 126);
            this.rdbmusteri.Name = "rdbmusteri";
            this.rdbmusteri.Size = new System.Drawing.Size(71, 20);
            this.rdbmusteri.TabIndex = 11;
            this.rdbmusteri.TabStop = true;
            this.rdbmusteri.Text = "Müşteri";
            this.rdbmusteri.UseVisualStyleBackColor = true;
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(211, 163);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(137, 65);
            this.btncikis.TabIndex = 12;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // GİRİS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(581, 233);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.rdbmusteri);
            this.Controls.Add(this.rdbyonetici);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GİRİS";
            this.Text = "GİRİS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.RadioButton rdbyonetici;
        private System.Windows.Forms.RadioButton rdbmusteri;
        private System.Windows.Forms.Button btncikis;
    }
}

