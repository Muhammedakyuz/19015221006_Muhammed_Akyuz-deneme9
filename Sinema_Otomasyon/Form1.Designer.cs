namespace Sinema_Otomasyon
{
    partial class Form1
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
            this.b_biletkes = new System.Windows.Forms.Button();
            this.b_saekle = new System.Windows.Forms.Button();
            this.b_sekle = new System.Windows.Forms.Button();
            this.b_fimekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_biletkes
            // 
            this.b_biletkes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.b_biletkes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_biletkes.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.b_biletkes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(71)))), ((int)(((byte)(188)))));
            this.b_biletkes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_biletkes.Location = new System.Drawing.Point(213, 196);
            this.b_biletkes.Name = "b_biletkes";
            this.b_biletkes.Size = new System.Drawing.Size(178, 91);
            this.b_biletkes.TabIndex = 4;
            this.b_biletkes.Text = "Film Bileti Kes";
            this.b_biletkes.UseVisualStyleBackColor = false;
            this.b_biletkes.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_saekle
            // 
            this.b_saekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.b_saekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_saekle.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_saekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.b_saekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_saekle.Location = new System.Drawing.Point(12, 84);
            this.b_saekle.Name = "b_saekle";
            this.b_saekle.Size = new System.Drawing.Size(178, 91);
            this.b_saekle.TabIndex = 3;
            this.b_saekle.Text = "Salon Ekle";
            this.b_saekle.UseVisualStyleBackColor = false;
            this.b_saekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_sekle
            // 
            this.b_sekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.b_sekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_sekle.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.b_sekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.b_sekle.Location = new System.Drawing.Point(213, 84);
            this.b_sekle.Name = "b_sekle";
            this.b_sekle.Size = new System.Drawing.Size(178, 91);
            this.b_sekle.TabIndex = 2;
            this.b_sekle.Text = "Seans Ekle";
            this.b_sekle.UseVisualStyleBackColor = false;
            this.b_sekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_fimekle
            // 
            this.b_fimekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.b_fimekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_fimekle.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.b_fimekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.b_fimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_fimekle.Location = new System.Drawing.Point(12, 196);
            this.b_fimekle.Name = "b_fimekle";
            this.b_fimekle.Size = new System.Drawing.Size(178, 91);
            this.b_fimekle.TabIndex = 1;
            this.b_fimekle.Text = "Film Ekle";
            this.b_fimekle.UseVisualStyleBackColor = false;
            this.b_fimekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(134, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ANAMENÜ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_biletkes);
            this.Controls.Add(this.b_saekle);
            this.Controls.Add(this.b_sekle);
            this.Controls.Add(this.b_fimekle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "19015221006_Muhammed_Akyüz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_fimekle;
        private System.Windows.Forms.Button b_sekle;
        private System.Windows.Forms.Button b_saekle;
        private System.Windows.Forms.Button b_biletkes;
        private System.Windows.Forms.Label label1;
    }
}

