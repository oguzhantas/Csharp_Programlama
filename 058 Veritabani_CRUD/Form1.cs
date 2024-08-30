using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //SQL Server Veritabanı bağlantısı için


namespace _058_Veritabani_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =null;
        SqlCommand komutSQL = null;
        int id=0;
        void VeriDoldur()
        {
            baglanti = new SqlConnection(@"Data Source=AKARELENOVO\SQLEXPRESS; 
                                                Integrated Security=True;
                                        Initial Catalog=sirket;
                        ");

            baglanti.Open(); 
            komutSQL = baglanti.CreateCommand();
            komutSQL.CommandType = CommandType.Text;
            String SQL = "SELECT * FROM musteri";
            komutSQL.CommandText = SQL;
            komutSQL.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter(komutSQL);
            adaptor.Fill(dt);
            
            dataGridView1.DataSource= dt;
            baglanti.Close();
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adi, soyadi, telefon, eposta;
            decimal bakiye;
            adi = txtAdi.Text;
            soyadi = txtSoyadi.Text;
            telefon =txtTelefon.Text;
            eposta= txtEposta.Text;
            bakiye= decimal.Parse(txtBakiye.Text);

            if(adi=="" || soyadi=="" || telefon=="" || eposta == "")
            {
                MessageBox.Show("Lütfen adı, soyadi, telefon, eposta alanlarını doldurunuz");
                return;
            }
            baglanti.Open();
            komutSQL= baglanti.CreateCommand(); ;
            komutSQL.CommandText = " INSERT INTO musteri(ADI, SOYADI, TELEFON, EPOSTA, BAKIYE) VALUES(@adi,@soyadi,@telefon,@eposta,@bakiye)";
            komutSQL.Parameters.AddWithValue("@adi", adi);
            komutSQL.Parameters.AddWithValue("@soyadi", soyadi);
            komutSQL.Parameters.AddWithValue("@telefon", telefon);
            komutSQL.Parameters.AddWithValue("@eposta", eposta);
            komutSQL.Parameters.AddWithValue("@bakiye", bakiye);
            komutSQL.ExecuteNonQuery();
            VeriDoldur();
            baglanti.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           VeriDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Silinsin mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap== DialogResult.Yes)
            {
                if (id == 0)
                {
                    MessageBox.Show("Lütfen ızgaradan slinecek kayda tıklayınız");
                    return;
                }
                baglanti.Open();
                komutSQL = baglanti.CreateCommand(); ;
                komutSQL.CommandText = "DELETE FROM musteri WHERE musteriID= @id";
                komutSQL.Parameters.AddWithValue("@id", id);
       
                komutSQL.ExecuteNonQuery();
                baglanti.Close();
                VeriDoldur();
            }
            
            
            
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            string adi, soyadi, telefon, eposta;
            decimal bakiye;
            adi = txtAdi.Text;
            soyadi = txtSoyadi.Text;
            telefon = txtTelefon.Text;
            eposta = txtEposta.Text;
            bakiye = decimal.Parse(txtBakiye.Text);

            if (adi == "" || soyadi == "" || telefon == "" || eposta == "")
            {
                MessageBox.Show("Lütfen adı, soyadi, telefon, eposta alanlarını doldurunuz");
                return;
            }


            baglanti.Open();
            komutSQL = baglanti.CreateCommand(); ;
            komutSQL.CommandText = "UPDATE musteri SET ADI=@adi, SOYADI=@soyadi, TELEFON=@telefon," +
                "EPOSTA=@eposta, BAKIYE=@bakiye WHERE musteriID= @id";
            komutSQL.Parameters.AddWithValue("@id", id);
            komutSQL.Parameters.AddWithValue("@adi", adi);
            komutSQL.Parameters.AddWithValue("@soyadi", soyadi);
            komutSQL.Parameters.AddWithValue("@telefon", telefon);
            komutSQL.Parameters.AddWithValue("@eposta", eposta);
            komutSQL.Parameters.AddWithValue("@bakiye", bakiye);
            komutSQL.ExecuteNonQuery();
            baglanti.Close();
            VeriDoldur();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtTelefon.Text = "";
            txtEposta.Text = "";
            txtBakiye.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEposta.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();



            // MessageBox.Show(id.ToString());
        }
    }
}
