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
    public partial class frmHesapKapatma : Form
    {
        public static List<Hesap> h;
        public static List<Musteri> mkapat;
        public frmHesapKapatma()
        {
            InitializeComponent();
        }

        private void btnHesapGoster_Click(object sender, EventArgs e)
        {
            h = new List<Hesap>();
            long musterino = Convert.ToInt32(txtMusteriNo.Text);
            long hesapno = Convert.ToInt32(txtHesapNo.Text);
            bool varmi = false;
            foreach (var m in frmMusteriEkle.m.HesapListesi())
            {
                if (musterino == m.MusteriNo && hesapno == m.HesapNo)
                {
                    varmi = true;
                    h.Add(m);
                }
            }
            if (varmi)
            {
                 dataGridViewKapatılacakHesabıGörüntüle.DataSource = null;
                 dataGridViewKapatılacakHesabıGörüntüle.DataSource = h;
                 lblKapat.Visible = true;
                 btnHesabıKapat.Visible = true;
                 dataGridViewKapatildi.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
            }
        }

        private void btnHesabıKapat_Click(object sender, EventArgs e)
        {
            long hesapNo = Convert.ToInt32(txtHesapNo.Text);

            foreach (var hesap in h)
            {
                if (hesap.HesapBakiye < 0 || hesap.HesapBakiye > 0)
                {
                    MessageBox.Show("Hesabınızı kapatmak için bakiyeniz 0 olmalıdır.Sıfırladıktan sonra tekrar deneyiniz.");
                }
                else
                {
                    foreach (var m in frmMusteriEkle.m.HesapListesi())
                    {
                        if (hesapNo == m.HesapNo)
                        {
                            m.HesapKapat(hesapNo);
                            dataGridViewKapatildi.DataSource = null;
                            dataGridViewKapatildi.DataSource = h;
                            System.Windows.Forms.MessageBox.Show("HESAP KAPATILDI.");
                        }
                    }
                }
            }  
        }
    }
}
