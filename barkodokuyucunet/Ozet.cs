using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodokuyucunet
{
    public partial class Ozet : Form
    {
        public Ozet()
        {
            InitializeComponent();
        }

        private void aktarbt_Click(object sender, EventArgs e)
        {

        }

        private void Ozet_Load(object sender, EventArgs e)
        {
           this.Refresh();

        }
        // Form2.cs
        public void DataGridViewVerileriniEkle(DataGridViewRow veriSatiri)
        {
            data3.Rows.Add(veriSatiri.Cells[0].Value, veriSatiri.Cells[1].Value, veriSatiri.Cells[2].Value);
        }

    }
}
