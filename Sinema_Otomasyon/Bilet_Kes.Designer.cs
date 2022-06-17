namespace Sinema_Otomasyon
{
    partial class Bilet_Kes
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
            this.label7 = new System.Windows.Forms.Label();
            this.data_film = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.text_fadi = new System.Windows.Forms.TextBox();
            this.text_fturu = new System.Windows.Forms.TextBox();
            this.text_yonet = new System.Windows.Forms.TextBox();
            this.pict_resi = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_tarih = new System.Windows.Forms.TextBox();
            this.text_saat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_seans = new System.Windows.Forms.TextBox();
            this.text_salon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_madi = new System.Windows.Forms.TextBox();
            this.text_msadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.b_bkes = new System.Windows.Forms.Button();
            this.b_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_film)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_resi)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Film Seç";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // data_film
            // 
            this.data_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_film.Location = new System.Drawing.Point(27, 58);
            this.data_film.Name = "data_film";
            this.data_film.Size = new System.Drawing.Size(288, 73);
            this.data_film.TabIndex = 19;
            this.data_film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seçilen Film";
            // 
            // text_fadi
            // 
            this.text_fadi.Enabled = false;
            this.text_fadi.Location = new System.Drawing.Point(27, 208);
            this.text_fadi.Name = "text_fadi";
            this.text_fadi.Size = new System.Drawing.Size(100, 20);
            this.text_fadi.TabIndex = 21;
            // 
            // text_fturu
            // 
            this.text_fturu.Enabled = false;
            this.text_fturu.Location = new System.Drawing.Point(26, 253);
            this.text_fturu.Name = "text_fturu";
            this.text_fturu.Size = new System.Drawing.Size(100, 20);
            this.text_fturu.TabIndex = 22;
            // 
            // text_yonet
            // 
            this.text_yonet.Enabled = false;
            this.text_yonet.Location = new System.Drawing.Point(27, 304);
            this.text_yonet.Name = "text_yonet";
            this.text_yonet.Size = new System.Drawing.Size(100, 20);
            this.text_yonet.TabIndex = 23;
            // 
            // pict_resi
            // 
            this.pict_resi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pict_resi.Location = new System.Drawing.Point(215, 168);
            this.pict_resi.Name = "pict_resi";
            this.pict_resi.Size = new System.Drawing.Size(104, 124);
            this.pict_resi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_resi.TabIndex = 24;
            this.pict_resi.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label5.Location = new System.Drawing.Point(23, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seans";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label3.Location = new System.Drawing.Point(23, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tarih";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_tarih
            // 
            this.text_tarih.Enabled = false;
            this.text_tarih.Location = new System.Drawing.Point(27, 455);
            this.text_tarih.Name = "text_tarih";
            this.text_tarih.Size = new System.Drawing.Size(100, 20);
            this.text_tarih.TabIndex = 29;
            this.text_tarih.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // text_saat
            // 
            this.text_saat.Enabled = false;
            this.text_saat.Location = new System.Drawing.Point(215, 328);
            this.text_saat.Name = "text_saat";
            this.text_saat.Size = new System.Drawing.Size(100, 20);
            this.text_saat.TabIndex = 31;
            this.text_saat.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label4.Location = new System.Drawing.Point(211, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Saati";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label6.Location = new System.Drawing.Point(23, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Film Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label8.Location = new System.Drawing.Point(23, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Film Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label9.Location = new System.Drawing.Point(23, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Yönetmen";
            // 
            // text_seans
            // 
            this.text_seans.Enabled = false;
            this.text_seans.Location = new System.Drawing.Point(27, 410);
            this.text_seans.Name = "text_seans";
            this.text_seans.Size = new System.Drawing.Size(100, 20);
            this.text_seans.TabIndex = 35;
            // 
            // text_salon
            // 
            this.text_salon.Enabled = false;
            this.text_salon.Location = new System.Drawing.Point(27, 352);
            this.text_salon.Name = "text_salon";
            this.text_salon.Size = new System.Drawing.Size(100, 20);
            this.text_salon.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(23, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Salon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label10.Location = new System.Drawing.Point(211, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "Müşteri Adı";
            // 
            // text_madi
            // 
            this.text_madi.Location = new System.Drawing.Point(215, 386);
            this.text_madi.Name = "text_madi";
            this.text_madi.Size = new System.Drawing.Size(100, 20);
            this.text_madi.TabIndex = 39;
            // 
            // text_msadi
            // 
            this.text_msadi.Location = new System.Drawing.Point(215, 431);
            this.text_msadi.Name = "text_msadi";
            this.text_msadi.Size = new System.Drawing.Size(100, 20);
            this.text_msadi.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label11.Location = new System.Drawing.Point(211, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Müşteri Soyadı";
            // 
            // b_bkes
            // 
            this.b_bkes.BackColor = System.Drawing.SystemColors.Control;
            this.b_bkes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_bkes.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.b_bkes.ForeColor = System.Drawing.Color.Black;
            this.b_bkes.Location = new System.Drawing.Point(215, 457);
            this.b_bkes.Name = "b_bkes";
            this.b_bkes.Size = new System.Drawing.Size(100, 62);
            this.b_bkes.TabIndex = 42;
            this.b_bkes.Text = "Bilet Kes";
            this.b_bkes.UseVisualStyleBackColor = false;
            this.b_bkes.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_geri
            // 
            this.b_geri.BackColor = System.Drawing.SystemColors.Control;
            this.b_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_geri.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.b_geri.ForeColor = System.Drawing.Color.Black;
            this.b_geri.Location = new System.Drawing.Point(27, 493);
            this.b_geri.Name = "b_geri";
            this.b_geri.Size = new System.Drawing.Size(100, 26);
            this.b_geri.TabIndex = 43;
            this.b_geri.Text = "Geri";
            this.b_geri.UseVisualStyleBackColor = false;
            this.b_geri.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bilet_Kes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 531);
            this.Controls.Add(this.b_geri);
            this.Controls.Add(this.b_bkes);
            this.Controls.Add(this.text_msadi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_madi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_salon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_seans);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_saat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pict_resi);
            this.Controls.Add(this.text_yonet);
            this.Controls.Add(this.text_fturu);
            this.Controls.Add(this.text_fadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_film);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bilet_Kes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Kes";
            this.Load += new System.EventHandler(this.Bilet_Kes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_film)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_resi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_fadi;
        private System.Windows.Forms.TextBox text_fturu;
        private System.Windows.Forms.TextBox text_yonet;
        private System.Windows.Forms.PictureBox pict_resi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_tarih;
        private System.Windows.Forms.TextBox text_saat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_seans;
        private System.Windows.Forms.TextBox text_salon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_madi;
        private System.Windows.Forms.TextBox text_msadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_bkes;
        private System.Windows.Forms.Button b_geri;
    }
}