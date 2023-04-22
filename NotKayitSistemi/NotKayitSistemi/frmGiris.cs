using Microsoft.Data.SqlClient;

namespace NotKayitSistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }



        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            frmOgrenciDetay frmOgrenciDetay = new frmOgrenciDetay();
            frmOgrenciDetay.numara = maskedTextBox1.Text;
            frmOgrenciDetay.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
             if(maskedTextBox1.Text == "1111")
            {
                FrmOgretmenDetay frmOgretmenDetay = new FrmOgretmenDetay(); SqlConnection conn = new SqlConnection("Data Source=(localdb)\\IEEE;Initial Catalog=DbNotKayit;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                frmOgretmenDetay.Show();

            }
        }
    }
}