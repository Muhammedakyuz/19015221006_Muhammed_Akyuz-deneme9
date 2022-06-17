using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sinema_Otomasyon
{
    public partial class seanslar : Form
    {
        public seanslar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLExpress; initial Catalog=sinema; Integrated Security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into seans(seans_adi,seans_tarih,seans_saat) values('" + text_seadi.Text + "','" + date_tarih.Text + "','" + maskedText_saat.Text + "')", baglanti);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            baglanti.Close();
            MessageBox.Show("Seans Ekleme İşlemi Başarılı");
            text_seadi.Text = "";
            maskedText_saat.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void seanslar_Load(object sender, EventArgs e)
        {

        }
    }
}
