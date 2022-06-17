namespace Sinema_Otomasyon
{
    partial class seanslar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedText_saat = new System.Windows.Forms.MaskedTextBox();
            this.date_tarih = new System.Windows.Forms.DateTimePicker();
            this.text_seadi = new System.Windows.Forms.TextBox();
            this.b_geri = new System.Windows.Forms.Button();
            this.b_seekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "SEANS EKLEME PANELI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seans Adı:";
            // 
            // maskedText_saat
            // 
            this.maskedText_saat.Location = new System.Drawing.Point(101, 150);
            this.maskedText_saat.Mask = "00:00";
            this.maskedText_saat.Name = "maskedText_saat";
            this.maskedText_saat.Size = new System.Drawing.Size(110, 23);
            this.maskedText_saat.TabIndex = 21;
            this.maskedText_saat.ValidatingType = typeof(System.DateTime);
            // 
            // date_tarih
            // 
            this.date_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tarih.Location = new System.Drawing.Point(101, 120);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Size = new System.Drawing.Size(110, 23);
            this.date_tarih.TabIndex = 22;
            // 
            // text_seadi
            // 
            this.text_seadi.Location = new System.Drawing.Point(101, 91);
            this.text_seadi.Name = "text_seadi";
            this.text_seadi.Size = new System.Drawing.Size(110, 23);
            this.text_seadi.TabIndex = 23;
            // 
            // b_geri
            // 
            this.b_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_geri.Location = new System.Drawing.Point(12, 193);
            this.b_geri.Name = "b_geri";
            this.b_geri.Size = new System.Drawing.Size(76, 35);
            this.b_geri.TabIndex = 25;
            this.b_geri.Text = "Geri";
            this.b_geri.UseVisualStyleBackColor = true;
            this.b_geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_seekle
            // 
            this.b_seekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_seekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_seekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_seekle.Location = new System.Drawing.Point(122, 193);
            this.b_seekle.Name = "b_seekle";
            this.b_seekle.Size = new System.Drawing.Size(152, 35);
            this.b_seekle.TabIndex = 24;
            this.b_seekle.Text = "Seans Ekle";
            this.b_seekle.UseVisualStyleBackColor = true;
            this.b_seekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // seanslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 242);
            this.Controls.Add(this.b_geri);
            this.Controls.Add(this.b_seekle);
            this.Controls.Add(this.text_seadi);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.maskedText_saat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "seanslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seanslar";
            this.Load += new System.EventHandler(this.seanslar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedText_saat;
        private System.Windows.Forms.DateTimePicker date_tarih;
        private System.Windows.Forms.TextBox text_seadi;
        private System.Windows.Forms.Button b_geri;
        private System.Windows.Forms.Button b_seekle;
    }
}