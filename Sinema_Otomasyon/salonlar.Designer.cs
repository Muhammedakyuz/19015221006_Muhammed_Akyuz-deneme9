namespace Sinema_Otomasyon
{
    partial class salonlar
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
            this.text_soadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_geri = new System.Windows.Forms.Button();
            this.b_sekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(82, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salon Ekleme Paneli";
            // 
            // text_soadi
            // 
            this.text_soadi.Location = new System.Drawing.Point(177, 83);
            this.text_soadi.Name = "text_soadi";
            this.text_soadi.Size = new System.Drawing.Size(100, 20);
            this.text_soadi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salon Adı:";
            // 
            // b_geri
            // 
            this.b_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_geri.Location = new System.Drawing.Point(12, 158);
            this.b_geri.Name = "b_geri";
            this.b_geri.Size = new System.Drawing.Size(95, 35);
            this.b_geri.TabIndex = 21;
            this.b_geri.Text = "Geri";
            this.b_geri.UseVisualStyleBackColor = true;
            this.b_geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_sekle
            // 
            this.b_sekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_sekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sekle.Location = new System.Drawing.Point(128, 158);
            this.b_sekle.Name = "b_sekle";
            this.b_sekle.Size = new System.Drawing.Size(235, 35);
            this.b_sekle.TabIndex = 20;
            this.b_sekle.Text = "Salon Ekle";
            this.b_sekle.UseVisualStyleBackColor = true;
            this.b_sekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // salonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 219);
            this.Controls.Add(this.b_geri);
            this.Controls.Add(this.b_sekle);
            this.Controls.Add(this.text_soadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "salonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salonlar";
            this.Load += new System.EventHandler(this.salonlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_soadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_geri;
        private System.Windows.Forms.Button b_sekle;
    }
}