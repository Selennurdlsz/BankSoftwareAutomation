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
    public partial class frmMusteriBilgileri : Form
    {
        public frmMusteriBilgileri()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle me = new frmMusteriEkle();
            me.Show();
        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            frmHesapEkle he = new frmHesapEkle();
            he.Show();
        }
    }
}
