
using DevExpress.XtraBars.Navigation;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace barkodokuyucunet
{
    public partial class detay : Form
    {
        SqlConnection baglan = new SqlConnection("Server=YUSUF-MONSTER;DATABASE=NEBIMYUSUF;User Id=sa;Password=1;");
        
        public detay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        baslik bslk = new baslik();
        private void detay_Load(object sender, EventArgs e)
        {
            
                // dataGridView2'de sütunları manuel olarak ekleyin
                data2.Columns.Add("BarkodNo", "BarkodNo");
                data2.Columns.Add("Ürünkod", "Ürünkod");
                data2.Columns.Add("Ürünadı", "Ürünadı");
                data2.Columns.Add("Stok", "Stok");
                data2.Columns.Add("SayılanAdet", "SayılanAdet");
                // Diğer gerekli sütunları ekleyin
                data2.Rows.Clear();
                kayitgoster();
              

        }
        public void kayitgoster()
        {
            string query = "SELECT Barcode as BarkodNo, " +
               "cdItemDesc.ItemCode as Ürünkod, " +
               "cdItemDesc.ItemDescription as Ürünadı, " +
               "Qty as Stok " +
               "FROM cdItemDesc INNER JOIN prItemBarcode " +
               "ON cdItemDesc.ItemCode = prItemBarcode.ItemCode " +
               "AND cdItemDesc.ItemTypeCode = prItemBarcode.ItemTypeCode " +
               "WHERE cdItemDesc.ItemCode IN (SELECT ItemCode FROM cdWarehouse " +
               "INNER JOIN trStock ON cdWarehouse.WarehouseCode = trStock.WarehouseCode " +
               "WHERE cdWarehouse.WarehouseCode =@warehousecode) " +
               "GROUP BY Barcode, cdItemDesc.ItemCode, cdItemDesc.ItemDescription, Qty";

            baglan.Open();
            using (SqlCommand cmd = new SqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("@warehousecode",baslik.warhousecode);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    data1.DataSource = dataTable;
                }
            }
            baglan.Close();

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            kayitgoster();
            data2.Rows.Clear();
            label1.Visible=false;
            data2.Visible=false;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                string barkod = textBox1.Text.Trim();

                //if (string.IsNullOrEmpty(barkod))
                //{
                //    return; // Barkod boşsa hiçbir işlem yapma
                //}
                bool barkodBulundu = false;
                // 'data2' içinde aynı barkod numarası olup olmadığını kontrol et
                foreach (DataGridViewRow row1 in data2.Rows)
                {
                    if (row1.Cells["BarkodNo"].Value != null && row1.Cells["BarkodNo"].Value.ToString() == barkod)
                    {
                        int sayilanAdet = 0;
                        sayilanAdet = Convert.ToInt32(row1.Cells["SayılanAdet"].Value);
                        row1.Cells["SayılanAdet"].Value = sayilanAdet + 1;
                        textBox1.Text = "";
                        barkodBulundu = true;
                        return;
                        // Barkod bulundu, döngüden çık
                    }
                }

                // Eğer barkod 'data2' içinde bulunamadıysa yeni bir satır ekle
                if (!barkodBulundu)
                {
                    foreach (DataGridViewRow row in data1.Rows)
                    {
                        if (row.Cells["BarkodNo"].Value != null && row.Cells["BarkodNo"].Value.ToString() == barkod)
                        {
                            int rowIndex = data2.Rows.Add();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                data2.Rows[rowIndex].Cells[cell.ColumnIndex].Value = cell.Value;
                                textBox1.Text = "";
                                //if (data2.Rows[rowIndex].Cells["SayılanAdet"].Value==null)
                                //{
                                    data2.Rows[rowIndex].Cells["SayılanAdet"].Value = 1;
                                //}

                                // textEdit2.Text="";
                            }
                            break; // Satır eklendi, döngüden çık
                        }
                    }
                }

                // Barkodun eklendiğini göstermek için TextBox'ı temizle (isteğe bağlı)


                label1.Visible = true;
                data2.Visible = true;
            }
            else
            {
                if (textEdit3.Text!="")
                {                   
                    string barkod = textBox1.Text.Trim();
                    bool barkodBulundu = false;
                    // 'data2' içinde aynı barkod numarası olup olmadığını kontrol et
                    foreach (DataGridViewRow row1 in data2.Rows)
                    {
                        if (row1.Cells["BarkodNo"].Value != null && row1.Cells["BarkodNo"].Value.ToString() == barkod)
                        {
                            int sayilanAdet = 0;
                            sayilanAdet = Convert.ToInt32(row1.Cells["SayılanAdet"].Value);
                            row1.Cells["SayılanAdet"].Value = sayilanAdet + Convert.ToInt16(textEdit3.Text);
                            textBox1.Text = "";      
                            barkodBulundu = true;
                            return;
                            // Barkod bulundu, döngüden çık
                        }                      
                    }
                    // Eğer barkod 'data2' içinde bulunamadıysa yeni bir satır ekle
                    if (!barkodBulundu)
                    {
                        foreach (DataGridViewRow row in data1.Rows)
                        {
                            if (row.Cells["BarkodNo"].Value != null && row.Cells["BarkodNo"].Value.ToString() == barkod)
                            {
                                int rowIndex = data2.Rows.Add();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    data2.Rows[rowIndex].Cells[cell.ColumnIndex].Value = cell.Value;
                                    data2.Rows[rowIndex].Cells["SayılanAdet"].Value = Convert.ToInt32(textEdit3.Text);
                                    textBox1.Text = "";
                                }
                                
                                break; // Satır eklendi, döngüden çık
                            }
                        }
                    }

                    // Barkodun eklendiğini göstermek için TextBox'ı temizle (isteğe bağlı)


                    label1.Visible = true;
                    data2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lütfen Sayı Adedi Giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {      
            if (checkBox1.Checked)
            {
                label3.Visible = true;
                textEdit3.Visible = true;
        
                textEdit3.Text = "";
            }
            else
            {
                label3.Visible = false;
                textEdit3.Visible = false;
              
                textEdit3.Text = "";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ExportToExcel(data2);
        }
        private void ExportToExcel(DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            Excel._Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            // Sütun başlıklarını ekle
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            // Verileri ekle
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    worksheet.Cells[i + 2, dgv.Columns.Count + 1] = DateTime.Now.ToString("dd/MM/yyyy");
                }
            }

            // Excel dosyasını kaydet
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = "Ürün Sayımı.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog.FileName);
                excelApp.Quit();
                MessageBox.Show("Veriler Excel'e başarıyla aktarıldı!");
                kayitgoster();
                data2.Rows.Clear();
                label1.Visible = false;
                data2.Visible = false;
                textBox1.Clear();
                textEdit3.Clear();
            }
        }
    }
}
