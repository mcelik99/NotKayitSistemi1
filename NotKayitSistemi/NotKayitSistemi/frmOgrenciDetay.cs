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
using Microsoft.Data.SqlClient;

namespace NotKayitSistemi
{
    public partial class frmOgrenciDetay : Form
    {
        public frmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

       SqlConnection conn = new SqlConnection("Data Source=(localdb)\\IEEE;Initial Catalog=DbNotKayit;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from  tblders where ogrnumara=@p1", conn);

            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }
            conn.Close();
        }
    }
}
