using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\IEEE;Initial Catalog=DbNotKayit;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            conn.Open();
            string select = "select * from tblders";
            SqlDataAdapter da = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblders (ogrnumara,ograd,ogrsoyad)  values (@p1,@p2,@p3)", conn);
            cmd.Parameters.AddWithValue("@p1", txtMskNumara.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Eklendi");


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtsinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama,s1,s2,s3;
            string durum;

            s1 = Convert.ToDouble(txtsinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("update tblders set ogrsinav1 = @p1, ogrsinav2 = @p2, ogrsinav3=@p3 ,ortalama=@p4, durum = @p5 where ogrnumara=@p6 ", conn);
            cmd.Parameters.AddWithValue("@p1", txtsinav1.Text);
            cmd.Parameters.AddWithValue("@p2", txtSinav2.Text);
            cmd.Parameters.AddWithValue("@p3", txtSinav3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.Parameters.AddWithValue("@p6", txtMskNumara.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Notlar Guncellendi");

        }
    }
}
