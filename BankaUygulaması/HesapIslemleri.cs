using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulaması
{
    public partial class frmHesapIslemleri : Form
    {
        public frmHesapIslemleri()
        {
            InitializeComponent();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            frmParaCekme pc = new frmParaCekme();
            pc.Show();
        }

        private void btnParaYatırma_Click(object sender, EventArgs e)
        {
            frmParaYatirma py = new frmParaYatirma();
            py.Show();
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            frmHesapÖzeti ho = new frmHesapÖzeti();
            ho.Show();
        }

        private void btnHavaleYapma_Click(object sender, EventArgs e)
        {
            frmHavaleYapma hy = new frmHavaleYapma();
            hy.Show();

        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            frmHesapKapatma hk = new frmHesapKapatma();
            hk.Show();
          
        }
    }
}
