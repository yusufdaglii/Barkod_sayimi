using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace barkodokuyucunet
{
    public partial class Form1 : Form
    {

        SqlConnection baglan = new SqlConnection("Server=YUSUF-MONSTER;DATABASE=NEBIMYUSUF;User Id=sa;Password=1;");
        public Form1()
        {
            InitializeComponent();
        }
        private void kayit_goster()
        {
            baglan.Open();
            string query = @"
                           select 
                           Barcode as BarkodNumarası,
                           BarcodeTypeCode as Barkodkodtipi,
                           prItemBarcode.ItemCode as ÜrünKodu,
                           cdItemDesc.ItemDescription as ÜrünBilgisi,
                           UnitOfMeasureCode as Ölçübirimi,
                           Qty as StokDurumu  
                           from 
                               prItemBarcode 
                           inner join 
                               cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode";

            using (SqlCommand cmd = new SqlCommand(query, baglan))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri atıyoruz
                    barkodgrid.DataSource = dataTable;
                }
            }   
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayit_goster();           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable(); 
            //baglan.Open();
            string query = @"
                           select 
                           Barcode as BarkodNumarası,
                           BarcodeTypeCode as Barkodkodtipi,
                           prItemBarcode.ItemCode as ÜrünKodu,
                           cdItemDesc.ItemDescription as ÜrünBilgisi,
                           UnitOfMeasureCode as Ölçübirimi,
                           Qty as StokDurumu  
                           from 
                               prItemBarcode 
                           inner join 
                               cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode
                           where 
                               Barcode = @barcode";

            using (SqlCommand cmd = new SqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("@barcode", barkodtxt.Text);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri atıyoruz
                    barkodgrid.DataSource = dataTable;
                }
            }         
            baglan.Close();
        }
        private void sayimtekilbt_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Lütfen Depo Seçiniz !");
            }
            else
            {
                if (barkodtxt.Text == "")
                {
                    MessageBox.Show("Lütfen Barkod Numarası Giriniz !");
                }
                else
                {
                    // SQL sorgusu
                    string sorgu1 = "SELECT 1 FROM prItemBarcode WHERE Barcode = @barcode";

                    baglan.Open();
                    // SQL komutunu oluşturun
                    using (SqlCommand command = new SqlCommand(sorgu1, baglan))
                    {
                        // Parametre ekleyin
                        command.Parameters.AddWithValue("@barcode", barkodtxt.Text);
                        // Sorguyu çalıştırın
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Sorgudan sonuç olup olmadığını kontrol edin
                            if (reader.Read())
                            {
                                reader.Dispose();
                                string query = @"
                                           update trInnerLine
                                           set Itemofnumber = Itemofnumber + 1
                                           from trInnerLine 
                                           inner join prItemBarcode on trInnerLine.ItemCode = prItemBarcode.ItemCode
                                           where prItemBarcode.Barcode = @barcode";

                                using (SqlCommand cmd1 = new SqlCommand(query, baglan))
                                {
                                    // Parametreyi ekleyelim
                                    cmd1.Parameters.AddWithValue("@barcode", barkodtxt.Text);
                                    cmd1.ExecuteNonQuery();

                                }
                                baglan.Close();
                                goster();
                                MessageBox.Show("Ürün Sayımı Başarılı !");
                            }
                            else
                            {
                                MessageBox.Show("Barkod numarası veritabanında bulunamadı !");
                                baglan.Close();
                                barkodtxt.Text = "";
                            }
                        }
                    }

                    baglan.Close();
                }

            }
        }
        int urunsayisi = 0;
        private void sayimcglbt_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                MessageBox.Show("Lütfen Depo Seçiniz !");
            }
            else
            {
                if (urunsystxt.Text == "")
                {
                    MessageBox.Show("Birden fazla ürün girmek için sayı giriniz !");
                }
                else
                {
                    // TextBox içeriğini al
                    string input = urunsystxt.Text;

                    // Sayısal değer olup olmadığını kontrol et
                    if (int.TryParse(input, out int result))
                    {
                        urunsayisi = Convert.ToInt16(urunsystxt.Text);
                        baglan.Open();
                        string query = "update trInnerLine " +
                                       "set Itemofnumber = Itemofnumber + @urunsayisi " +
                                       "from trInnerLine inner join prItemBarcode " +
                                       "on trInnerLine.ItemCode = prItemBarcode.ItemCode " +
                                       "where prItemBarcode.Barcode = @barcode";

                        using (SqlCommand cmd = new SqlCommand(query, baglan))
                        {
                            cmd.Parameters.AddWithValue("@urunsayisi", urunsayisi);
                            cmd.Parameters.AddWithValue("@barcode", barkodtxt.Text);
                            cmd.ExecuteNonQuery();
                        }

                        baglan.Close();
                        goster();
                        MessageBox.Show("Ürün Sayımı Başarılı!");
                        urunsystxt.Text = "";
                        //urunsayisi = 0;
                    }
                    else
                    {
                        // Sayı değilse, kullanıcıyı bilgilendir
                        MessageBox.Show("Lütfen geçerli bir sayı girin !");
                        urunsystxt.Text = "";
                    }
                }
            }
           
        }

        private void bitirvegosterbt_Click(object sender, EventArgs e)
        {         
            baglan.Open();
            string query = @"
                           select 
                           Barcode as BarkodNumarası,
                           BarcodeTypeCode as Barkodkodtipi,
                           prItemBarcode.ItemCode as ÜrünKodu,
                           cdItemDesc.ItemDescription as ÜrünBilgisi,
                           UnitOfMeasureCode as Ölçübirimi,
                           Qty as StokDurumu,
                           Ürünsayisi = (
                                         select top 1 Itemofnumber 
                                         from trInnerLine 
                                         inner join prItemBarcode on trInnerLine.ItemCode = prItemBarcode.ItemCode
                                         where Barcode = @innerBarcode
                                                                       )
                           from prItemBarcode inner join
                           cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode
                           where Barcode = @outerBarcode";

            using (SqlCommand cmd = new SqlCommand(query, baglan))
            {
                // Parametreleri ekleyelim
                cmd.Parameters.AddWithValue("@innerBarcode", barkodtxt.Text);
                cmd.Parameters.AddWithValue("@outerBarcode", barkodtxt.Text);
                // DataTable oluştur
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    // DataTable'ı doldur
                    adapter.Fill(dataTable);
                }
                // DataGridView'e DataTable'ı ata
                bitirgrid.DataSource = dataTable;
            }
          
            baglan.Close();
            MessageBox.Show("Ürün Sayımı Başarıyla Tamamlandı!");
            barkodtxt.Text = "";
            urunsystxt.Text = "";
        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Uyarı mesajını göster
            DialogResult soru = MessageBox.Show("Bitir ve Sıfırla işlemi yapmak istediğinizden emin misiniz?",
                                                  "Onay",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Kullanıcı "Evet"e bastıysa işlemi devam ettir
            if (soru == DialogResult.Yes)
            {
                baglan.Open();
                string sorgu = "update trInnerLine \r\nset Itemofnumber=0";
                using (SqlCommand cmd = new SqlCommand(sorgu, baglan))
                {
                    cmd.ExecuteNonQuery();
                    barkodgrid.DataSource = "";
                    bitirgrid.DataSource = "";
                    barkodtxt.Text = "";
                    urunsystxt.Text = "";
                    MessageBox.Show("Başarıyla tamamlandı ve sıfırlandı !");
                }
                baglan.Close();
            }
        }
        private void goster()
        {
            baglan.Open();
            string query = @"
                           select 
                           Barcode as BarkodNumarası,
                           BarcodeTypeCode as Barkodkodtipi,
                           prItemBarcode.ItemCode as ÜrünKodu,
                           cdItemDesc.ItemDescription as ÜrünBilgisi,
                           UnitOfMeasureCode as Ölçübirimi,
                           Qty as StokDurumu,
                           Ürünsayisi = (
                                         select top 1 Itemofnumber 
                                         from trInnerLine 
                                         inner join prItemBarcode on trInnerLine.ItemCode = prItemBarcode.ItemCode
                                         where Barcode = @innerBarcode
                                                                       )
                                         from prItemBarcode inner join
                                         cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode
                                         where Barcode = @outerBarcode";

            using (SqlCommand cmd = new SqlCommand(query, baglan))
            {
                // Parametreleri ekleyelim
                cmd.Parameters.AddWithValue("@innerBarcode", barkodtxt.Text);
                cmd.Parameters.AddWithValue("@outerBarcode", barkodtxt.Text);
                // DataTable oluştur
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    // DataTable'ı doldur
                    adapter.Fill(dataTable);
                }
                // DataGridView'e DataTable'ı ata
                bitirgrid.DataSource = dataTable;
            }

            baglan.Close();
            urunsystxt.Text = "";
        }

        private void sayimtekilbt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında butonun Click olayını tetikler
                sayimtekilbt.PerformClick();
            }
        }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            urunlergos urunlergos = new urunlergos();
           // Visible =false;
            urunlergos.Show();
            this.Hide();
        }
    }
}
