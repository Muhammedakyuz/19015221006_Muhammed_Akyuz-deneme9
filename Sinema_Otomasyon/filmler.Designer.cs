namespace Sinema_Otomasyon
{
    partial class filmler
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.b_afissec = new System.Windows.Forms.Button();
            this.text_fadi = new System.Windows.Forms.TextBox();
            this.text_fturu = new System.Windows.Forms.TextBox();
            this.text_yonet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pict_afis = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_salon = new System.Windows.Forms.ComboBox();
            this.combo_seans = new System.Windows.Forms.ComboBox();
            this.b_filmekle = new System.Windows.Forms.Button();
            this.b_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pict_afis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(37, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yönetmen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Afiş:";
            // 
            // DosyaAc
            // 
            this.DosyaAc.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // b_afissec
            // 
            this.b_afissec.Location = new System.Drawing.Point(130, 171);
            this.b_afissec.Name = "b_afissec";
            this.b_afissec.Size = new System.Drawing.Size(100, 30);
            this.b_afissec.TabIndex = 4;
            this.b_afissec.Text = "Afiş Ekle";
            this.b_afissec.UseVisualStyleBackColor = true;
            this.b_afissec.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_fadi
            // 
            this.text_fadi.Location = new System.Drawing.Point(130, 81);
            this.text_fadi.Name = "text_fadi";
            this.text_fadi.Size = new System.Drawing.Size(100, 23);
            this.text_fadi.TabIndex = 6;
            // 
            // text_fturu
            // 
            this.text_fturu.Location = new System.Drawing.Point(130, 112);
            this.text_fturu.Name = "text_fturu";
            this.text_fturu.Size = new System.Drawing.Size(100, 23);
            this.text_fturu.TabIndex = 7;
            // 
            // text_yonet
            // 
            this.text_yonet.Location = new System.Drawing.Point(130, 142);
            this.text_yonet.Name = "text_yonet";
            this.text_yonet.Size = new System.Drawing.Size(100, 23);
            this.text_yonet.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seans:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label6.Location = new System.Drawing.Point(37, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salon:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(24, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(319, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(24, 23);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pict_afis
            // 
            this.pict_afis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pict_afis.Location = new System.Drawing.Point(248, 80);
            this.pict_afis.Name = "pict_afis";
            this.pict_afis.Size = new System.Drawing.Size(144, 179);
            this.pict_afis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_afis.TabIndex = 5;
            this.pict_afis.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(37, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "FİLM EKLEME PANELI";
            // 
            // combo_salon
            // 
            this.combo_salon.FormattingEnabled = true;
            this.combo_salon.Location = new System.Drawing.Point(130, 207);
            this.combo_salon.Name = "combo_salon";
            this.combo_salon.Size = new System.Drawing.Size(100, 23);
            this.combo_salon.TabIndex = 17;
            this.combo_salon.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // combo_seans
            // 
            this.combo_seans.FormattingEnabled = true;
            this.combo_seans.Location = new System.Drawing.Point(130, 236);
            this.combo_seans.Name = "combo_seans";
            this.combo_seans.Size = new System.Drawing.Size(100, 23);
            this.combo_seans.TabIndex = 18;
            this.combo_seans.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // b_filmekle
            // 
            this.b_filmekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_filmekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_filmekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_filmekle.Location = new System.Drawing.Point(221, 272);
            this.b_filmekle.Name = "b_filmekle";
            this.b_filmekle.Size = new System.Drawing.Size(170, 86);
            this.b_filmekle.TabIndex = 13;
            this.b_filmekle.Text = "Filmi Ekle";
            this.b_filmekle.UseVisualStyleBackColor = true;
            this.b_filmekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_geri
            // 
            this.b_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_geri.Location = new System.Drawing.Point(41, 298);
            this.b_geri.Name = "b_geri";
            this.b_geri.Size = new System.Drawing.Size(108, 35);
            this.b_geri.TabIndex = 14;
            this.b_geri.Text = "Geri";
            this.b_geri.UseVisualStyleBackColor = true;
            this.b_geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // filmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 384);
            this.Controls.Add(this.combo_seans);
            this.Controls.Add(this.combo_salon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.b_geri);
            this.Controls.Add(this.b_filmekle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_yonet);
            this.Controls.Add(this.text_fturu);
            this.Controls.Add(this.text_fadi);
            this.Controls.Add(this.pict_afis);
            this.Controls.Add(this.b_afissec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "filmler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.filmler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_afis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog DosyaAc;
        private System.Windows.Forms.Button b_afissec;
        private System.Windows.Forms.PictureBox pict_afis;
        private System.Windows.Forms.TextBox text_fadi;
        private System.Windows.Forms.TextBox text_fturu;
        private System.Windows.Forms.TextBox text_yonet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_salon;
        private System.Windows.Forms.ComboBox combo_seans;
        private System.Windows.Forms.Button b_filmekle;
        private System.Windows.Forms.Button b_geri;
    }
}