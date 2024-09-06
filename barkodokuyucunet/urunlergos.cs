using DevExpress.XtraEditors.Frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace barkodokuyucunet
{
    public partial class urunlergos : Form
    {
        private void aktarbt_Click(object sender, EventArgs e)
        {

        }

        private void urunlergos_Load(object sender, EventArgs e)
        {

        }
        //SqlConnection baglan = new SqlConnection("Server=YUSUF-MONSTER;DATABASE=NEBIMYUSUF;User Id=sa;Password=1;");

        //public urunlergos()
        //{
        //    InitializeComponent();           
        //}
        //private void kayitgoster1()
        //{
        //    string sorgu = "select \r\n" +
        //        "Barcode as BarkodNumarası,\r\n" +
        //        " BarcodeTypeCode as Barkodkodtipi,\r\n" +
        //        " prItemBarcode.ItemCode as ÜrünKodu,\r\n" +
        //        "cdItemDesc.ItemDescription as ÜrünBilgisi,\r\n" +
        //        "UnitOfMeasureCode as Ölçübirimi,\r\n" +
        //        "trInnerLine.Itemofnumber as Ürünsayisi,\r\n" +
        //        "Qty as StokDurumu\r\nfrom \r\n" +
        //        "prItemBarcode \r\ninner join \r\n" +
        //        "cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode\r\ninner join" +
        //        " \r\ntrInnerLine on prItemBarcode.ItemCode = trInnerLine.ItemCode\r\nwhere " +
        //        "\r\ntrInnerLine.Itemofnumber > 0\r\ngroup by \r\n" +
        //        "Barcode,\r\nBarcodeTypeCode,\r\n" +
        //        "prItemBarcode.ItemCode,\r\n" +
        //        "cdItemDesc.ItemDescription,\r\n"+
        //        " UnitOfMeasureCode,\r\n\ttrInnerLine.Itemofnumber,\r\n\tQty;";

        //    baglan.Open();
        //    using (SqlCommand cmd = new SqlCommand(sorgu, baglan))
        //    {
        //        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
        //        {
        //          DataTable data = new DataTable();
        //          da.Fill(data);
        //          tumurungrid.DataSource = data;
        //        }
        //    }
        //    baglan.Close();
        //}

        //private void urunlergos_Load(object sender, EventArgs e)
        //{
        //    if (barkodtxt2.Text == "")
        //    {
        //        kayitgoster1();
        //    }
        //}

        //private void barkodtxt2_TextChanged(object sender, EventArgs e)
        //{
        //    DataTable tablo = new DataTable();
        //    //baglan.Open();
        //    string query = "select top 10 Barcode as BarkodNumarası, " +
        //        "BarcodeTypeCode as Barkodkodtipi, " +
        //        "prItemBarcode.ItemCode as ÜrünKodu, " +
        //        "cdItemDesc.ItemDescription as ÜrünBilgisi, " +
        //        "UnitOfMeasureCode as Ölçübirimi, " +
        //        "Qty as StokDurumu, " +
        //        "Ürünsayisi = (select top 1 Itemofnumber from trInnerLine " +
        //        "inner join prItemBarcode on trInnerLine.ItemCode = prItemBarcode.ItemCode " +
        //        "where Barcode = @barcode1) " +
        //        "from prItemBarcode " +
        //        "inner join cdItemDesc on prItemBarcode.ItemCode = cdItemDesc.ItemCode " +
        //        "where Barcode = @barcode " +
        //        "order by Ürünsayisi desc";

        //    using (SqlCommand cmd = new SqlCommand(query, baglan))
        //    {
        //        cmd.Parameters.AddWithValue("@barcode", barkodtxt2.Text);
        //        cmd.Parameters.AddWithValue("@barcode1", barkodtxt2.Text);

        //        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //        {
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);

        //            // DataGridView'e verileri atıyoruz
        //            tumurungrid.DataSource = dataTable;
        //        }
        //    }
        //    baglan.Close();
        //}

        //private void aktarbt_Click(object sender, EventArgs e)
        //{
        //    // Uyarı mesajını göster
        //    DialogResult soru = MessageBox.Show("Bu işlemi yapmak istediğinizden emin misiniz?",
        //                                          "Onay",
        //                                          MessageBoxButtons.YesNo,
        //                                          MessageBoxIcon.Question);

        //    // Kullanıcı "Evet"e bastıysa işlemi devam ettir
        //    if (soru == DialogResult.Yes)
        //    {
        //        ExportToExcel(tumurungrid); // Verileri Excel'e aktarma işlemi
        //    }
        //    else
        //    {
        //        // Kullanıcı "Hayır"ı seçti, işlem iptal edilir
        //        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }


        //}
        //private void ExportToExcel(DataGridView dgv)
        //{

        // Excel uygulamasını başlat
//        Excel.Application excelApp = new Excel.Application();
//        excelApp.Workbooks.Add();

//            Excel._Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

//            // Sütun başlıklarını ekle
//            for (int i = 1; i<dgv.Columns.Count + 1; i++)
//            {
//                worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
//            }

//            // Verileri ekle
//            for (int i = 0; i<dgv.Rows.Count; i++)
//            {
//                for (int j = 0; j<dgv.Columns.Count; j++)
//                {
//                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
//                }
//            }

//            // Excel dosyasını kaydet
//            var saveFileDialog = new SaveFileDialog
//            {
//                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
//                FilterIndex = 2,
//                FileName = "Ürün Sayımı.xlsx"
//            };

//if (saveFileDialog.ShowDialog() == DialogResult.OK)
//{
//    worksheet.SaveAs(saveFileDialog.FileName);
//    excelApp.Quit();
//    MessageBox.Show("Veriler Excel'e başarıyla aktarıldı!");
//}
        //}

        //private void tumurungrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
