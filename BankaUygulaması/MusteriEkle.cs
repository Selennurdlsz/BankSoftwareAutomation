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
    public partial class frmMusteriEkle : Form
    {
        public static Banka BankaApp = new Banka();
        public static Musteri m;

        public frmMusteriEkle()
        {
            InitializeComponent();
        }


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            m = new Musteri();
            m.Ad = this.txtAd.Text;
            m.Soyad = this.txtSoyad.Text;
            m.TCKimlikNo = Convert.ToInt32(txtTCKimlikNo.Text);
            m.MusteriTipi = cmboxMusteriTipi.SelectedIndex;

            BankaApp.MusteriEkle(m);
            

            dataGridViewmusteri.DataSource = null;
            dataGridViewmusteri.DataSource = BankaApp.MusteriListeler();

        }
    }
}
