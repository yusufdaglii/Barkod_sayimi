using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace barkodokuyucunet
{
    public partial class Urunsayimi : Form
    {
        public Urunsayimi()
        {
            InitializeComponent();
        }
        Ozet ozet;
        baslik detay;
        detay sayim;
        private void baslikbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (detay==null)
            {
                detay = new baslik();
                detay.MdiParent = this;
                detay.Show();
            }
        }

        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sayim==null)
            {
                sayim = new detay();
                sayim.MdiParent = this; 
                sayim.Show();
            }
        }
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ozet == null)
            {
                ozet = new Ozet();
                ozet.MdiParent = this;
                ozet.Show();
            }          
           
        }

        private void Urunsayimi_Load(object sender, EventArgs e)
        {

        }
    }
}
