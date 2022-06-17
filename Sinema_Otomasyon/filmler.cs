using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Sinema_Otomasyon
{
    public partial class filmler : Form
    {
        public filmler()
        {
            InitializeComponent();
        }
        string dosyayolu;
        string dosyaAdi;
       
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLExpress; initial Catalog=sinema; Integrated Security=true");
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void filmler_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand listele = new SqlCommand("select * from salon", baglanti);
                SqlDataReader dr = listele.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["salon_id"].ToString());
                    combo_salon.Items.Add(dr["salon_adi"].ToString());
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand listeleseans = new SqlCommand("select * from seans", baglanti);
                SqlDataReader drs = listeleseans.ExecuteReader();
                while (drs.Read())
                {
                    comboBox2.Items.Add(drs["seans_id"].ToString());
                    combo_seans.Items.Add(drs["seans_adi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + text_fadi.Text + "','" + text_fturu.Text + "','" + text_yonet.Text + "','" + dosyaAdi + "')", baglanti);
                ekle.ExecuteNonQuery();
                ekle.Dispose();
                MessageBox.Show("Ekleme İşleminiz Başarıyla Gerçekleşmiştir.");
                if (dosyaAdi != "") File.WriteAllBytes(dosyaAdi, File.ReadAllBytes(DosyaAc.FileName));
                MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                text_fadi.Text = "";
                text_fturu.Text = "";
                text_yonet.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                combo_salon.Text = "";
                combo_seans.Text = "";
                pict_afis.ImageLocation = "AFİSEKLE.png";
            }
            catch (Exception hata)
            {

                MessageBox.Show("hata"+ hata.Message);
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DosyaAc.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in DosyaAc.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { dosyaAdi = i; }
                    else if (i.Contains(".png")) { dosyaAdi = i; }
                    else { dosyayolu += i + "\\"; }
                }
                pict_afis.ImageLocation = DosyaAc.FileName;
            }
            else
            {
                MessageBox.Show("Dosya Girmediniz!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = combo_salon.SelectedIndex; 
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = combo_seans.SelectedIndex;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
