using DevExpress.Xpo.DB.Helpers;
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
    public partial class baslik : Form
    {
        string connectionString = "Server=YUSUF-MONSTER;DATABASE=NEBIMYUSUF;User Id=sa;Password=1;";
        public baslik()
        {
            InitializeComponent();         
        }
        
        private void müsteriisimbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectmagazaad=müsteriisimbox.SelectedItem.ToString();
            getmagazacode(selectmagazaad);
        }

        private void ofisbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            müsteriisimbox.Text = "";
            depobox.Text = "";
            string selectofficead = ofisbox.SelectedItem.ToString();
            getofiskode(selectofficead);
            // Gerekli işlem burada gerçekleştirilecek.
        }
        public void LoadDataToComboBoxOfis()
        {
            string query = @"
                           SELECT OfficeDescription,OfficeCode
                           FROM cdOfficeDesc 
                           WHERE OfficeCode IN (
                           SELECT OfficeCode 
                           FROM cdWarehouse 
                           INNER JOIN cdCurrAccDesc
                           ON cdWarehouse.CurrAccCode = cdCurrAccDesc.CurrAccCode
                           WHERE cdCurrAccDesc.CurrAccDescription = 'K.Saat Mağaza'
                                                                                   )";
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);           

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();                 

                    //ofisbox.Properties.Items.Clear(); // ComboBox'ı temizle
                    while (reader.Read())
                    {
                        ofisbox.Properties.Items.Add(reader["OfficeDescription"].ToString());
                    }               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public static string officecode1;
        public void getofiskode(string selectofficead)
        { 
            string query = @"
                           SELECT OfficeCode
                           FROM cdOfficeDesc 
                           WHERE OfficeDescription =@officedescription ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@officedescription", selectofficead);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                   // ofisbox.Properties.Items.Clear(); // ComboBox'ı temizle           
                    if (reader.HasRows)
                    {
                        reader.Close(); // Bu noktada SqlDataReader'ı kapatıyoruz
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                             officecode1 = reader["OfficeCode"].ToString();
                            LoadDataToComboBoxMagaza(officecode1);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }


        public void LoadDataToComboBoxMagaza(string officecode)
        {
            string query = @"
                           SELECT cdCurrAccDesc.CurrAccDescription,
                           cdCurrAcc.CurrAccCode
                           FROM cdCurrAcc 
                           INNER JOIN cdCurrAccDesc
                           ON cdCurrAcc.CurrAccCode = cdCurrAccDesc.CurrAccCode
                           AND cdCurrAcc.CurrAccTypeCode = cdCurrAccDesc.CurrAccTypeCode
                           WHERE cdCurrAcc.CurrAccTypeCode = '5' 
                           AND cdCurrAcc.OfficeCode = @officecode";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@officecode", officecode);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                  //  müsteriisimbox.Properties.Items.Clear(); // ComboBox'ı temizle
                    while (reader.Read())
                    {
                        müsteriisimbox.Properties.Items.Add(reader["CurrAccDescription"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void getmagazacode(string selecetmagazaad)
        {
            string query = @"
                           SELECT cdCurrAccDesc.CurrAccDescription,
                           cdCurrAcc.CurrAccCode
                           FROM cdCurrAcc 
                           INNER JOIN cdCurrAccDesc
                           ON cdCurrAcc.CurrAccCode = cdCurrAccDesc.CurrAccCode
                           AND cdCurrAcc.CurrAccTypeCode = cdCurrAccDesc.CurrAccTypeCode
                           WHERE cdCurrAcc.CurrAccTypeCode = '5' 
                           AND cdCurrAccDesc.CurrAccDescription = @curaccdesc";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@curaccdesc", selecetmagazaad);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //müsteriisimbox.Properties.Items.Clear(); // ComboBox'ı temizle                 
                    if (reader.HasRows)
                    {
                        reader.Close(); // Bu noktada SqlDataReader'ı kapatıyoruz
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string CurrAccCode = reader["CurrAccCode"].ToString();
                            
                            LoadDataToComboBoxDepo(CurrAccCode, officecode1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void LoadDataToComboBoxDepo(string CurrAccCode, string officeCode)
        {
            string query = @"
                           SELECT WarehouseDescription, WarehouseCode 
                           FROM cdWarehouseDesc 
                           WHERE WarehouseCode IN (
                           SELECT cdWarehouse.WarehouseCode 
                           FROM cdWarehouse 
                           INNER JOIN cdOfficeDesc
                           ON cdWarehouse.OfficeCode = cdOfficeDesc.OfficeCode
                           WHERE cdOfficeDesc.OfficeCode IN (
                           SELECT OfficeCode 
                           FROM cdWarehouse 
                           INNER JOIN cdCurrAccDesc
                           ON cdWarehouse.CurrAccCode = cdCurrAccDesc.CurrAccCode
                           WHERE cdCurrAccDesc.CurrAccCode = @CurrAccCode 
                           AND cdWarehouse.OfficeCode = @OfficeCode
                                                                    )
                                                                        )";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrAccCode", CurrAccCode);
                command.Parameters.AddWithValue("@OfficeCode", officeCode);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                   // depobox.Properties.Items.Clear(); // ComboBox'ı temizle
                    while (reader.Read())
                    {
                        depobox.Properties.Items.Add(reader["WarehouseDescription"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public static string warhousecode;
        public void getdepokod(string selecteddepoad)
        {
            string query = @"
                           SELECT cdWarehouse.WarehouseCode 
                           FROM cdWarehouse 
                           INNER JOIN cdWarehouseDesc
                           ON cdWarehouse.WarehouseCode = cdWarehouseDesc.WarehouseCode
                           WHERE cdWarehouseDesc.WarehouseDescription =@Waredesc 
                           AND cdWarehouse.OfficeCode =@OfficeCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Waredesc", selecteddepoad);
                command.Parameters.AddWithValue("@OfficeCode", officecode1);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //depobox.Properties.Items.Clear(); // ComboBox'ı temizle               
                    if (reader.HasRows)
                    {
                        reader.Close(); // Bu noktada SqlDataReader'ı kapatıyoruz
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            warhousecode = reader["WarehouseCode"].ToString();
                           MessageBox.Show(depobox.Text+"'yu Seçtiniz");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
       
        
        private void baslik_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxOfis();
        }    
        private void depobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string depoad=depobox.SelectedItem.ToString();
            getdepokod(depoad);  
        }
    }
}
