namespace Araba_Kiralama
{
    partial class BAKİYE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtekleme = new System.Windows.Forms.TextBox();
            this.txtbakiye = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnbakiye = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmusterisayfasınadon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye Ekleme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // txtekleme
            // 
            this.txtekleme.Location = new System.Drawing.Point(133, 31);
            this.txtekleme.Name = "txtekleme";
            this.txtekleme.Size = new System.Drawing.Size(181, 22);
            this.txtekleme.TabIndex = 2;
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(133, 62);
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.Size = new System.Drawing.Size(181, 22);
            this.txtbakiye.TabIndex = 3;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(342, 34);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(170, 23);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnbakiye
            // 
            this.btnbakiye.Location = new System.Drawing.Point(342, 67);
            this.btnbakiye.Name = "btnbakiye";
            this.btnbakiye.Size = new System.Drawing.Size(170, 23);
            this.btnbakiye.TabIndex = 5;
            this.btnbakiye.Text = "Bakiye";
            this.btnbakiye.UseVisualStyleBackColor = true;
            this.btnbakiye.Click += new System.EventHandler(this.btnbakiye_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Bakiyesi:";
            // 
            // btnmusterisayfasınadon
            // 
            this.btnmusterisayfasınadon.Location = new System.Drawing.Point(5, 115);
            this.btnmusterisayfasınadon.Name = "btnmusterisayfasınadon";
            this.btnmusterisayfasınadon.Size = new System.Drawing.Size(507, 36);
            this.btnmusterisayfasınadon.TabIndex = 7;
            this.btnmusterisayfasınadon.Text = "MÜŞTERİ SAYFASINA GERİ DÖN";
            this.btnmusterisayfasınadon.UseVisualStyleBackColor = true;
            this.btnmusterisayfasınadon.Click += new System.EventHandler(this.btnmusterisayfasınadon_Click);
            // 
            // BAKİYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 163);
            this.Controls.Add(this.btnmusterisayfasınadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbakiye);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtbakiye);
            this.Controls.Add(this.txtekleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BAKİYE";
            this.Text = "BAKİYE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtekleme;
        private System.Windows.Forms.TextBox txtbakiye;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnbakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmusterisayfasınadon;
    }
}