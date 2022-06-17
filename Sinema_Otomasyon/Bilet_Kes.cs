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
    public partial class Bilet_Kes : Form
    {
        public Bilet_Kes()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLExpress; initial Catalog=sinema; Integrated Security=true");
        int film_id, seans_id, salon_id;
        private void Bilet_Kes_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from filmler";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            data_film.DataSource = dt;
           
            baglanti.Close();
            data_film.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_film.Columns[0].Visible = false;
            data_film.Columns[1].Visible = false;
            data_film.Columns[2].Visible = false;
            data_film.Columns[3].HeaderText = "Film ADI";
            data_film.Columns[4].HeaderText = "Film Türü";
            data_film.Columns[5].HeaderText = "Yönetmen";
            data_film.Columns[6].HeaderText = "Afiş";

           
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_fadi.Text = data_film.CurrentRow.Cells[3].Value.ToString();
            text_fturu.Text = data_film.CurrentRow.Cells[4].Value.ToString();
            text_yonet.Text = data_film.CurrentRow.Cells[5].Value.ToString();
            film_id = int.Parse(data_film.CurrentRow.Cells[0].Value.ToString());
            seans_id = int.Parse(data_film.CurrentRow.Cells[1].Value.ToString());
            salon_id = int.Parse(data_film.CurrentRow.Cells[2].Value.ToString());
            pict_resi.ImageLocation= data_film.CurrentRow.Cells[6].Value.ToString();
            baglanti.Open();
            SqlCommand listeleseans = new SqlCommand("select * from seans where seans_id='" + int.Parse(data_film.CurrentRow.Cells[1].Value.ToString()) + "'", baglanti);
            SqlDataReader drs = listeleseans.ExecuteReader();
            if (drs.Read())
            {
                text_tarih.Text = drs["seans_tarih"].ToString();
                text_saat.Text = drs["seans_saat"].ToString();
                text_seans.Text = drs["seans_adi"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand listele = new SqlCommand("select * from salon where salon_id='"+ int.Parse(data_film.CurrentRow.Cells[2].Value.ToString()) + "'", baglanti);
            SqlDataReader dr = listele.ExecuteReader();
            while (dr.Read())
            {
             
           text_salon.Text= dr["salon_adi"].ToString();
            }
            baglanti.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi) values ('" + film_id + "','" + seans_id + "','" + salon_id + "','" + text_madi.Text + "','" + text_msadi.Text + "')", baglanti);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            MessageBox.Show("Bilet Kesme  İşleminiz Başarıyla Gerçekleşmiştir.");
       
           
            baglanti.Close();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
            }
        }
    }
}
