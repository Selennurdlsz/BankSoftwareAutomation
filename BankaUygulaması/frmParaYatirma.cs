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
    public partial class frmParaYatirma : Form
    {
        public static List<Hesap> h;
        public frmParaYatirma()
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
                if (m.hesapKapama)
                {
                    System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
                }
                else  if (musterino == m.MusteriNo && hesapno == m.HesapNo)
                {
                    varmi = true;
                    h.Add(m);
                }
            }
            if (varmi)
            {
                dataGridViewHesapGoster.DataSource = null;
                dataGridViewHesapGoster.DataSource = h;
                lblYatirilacakMiktar.Visible = true;
                txtYatirilacakMiktar.Visible = true;
                btnParaYatir.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
                foreach (var hesap in h)
                {
                    if (hesap.MusteriTipi == 0) //bireysel
                    {
                            hesap.HesapBakiye = hesap.HesapBakiye + Convert.ToInt32(txtYatirilacakMiktar.Text);
                            MessageBox.Show("Kalan Bakiye: " + hesap.HesapBakiye);
                            dataGridViewHesapGoster.DataSource = null;
                            dataGridViewHesapGoster.DataSource = h;
                    }
                    else
                    {
                            hesap.HesapBakiye = hesap.HesapBakiye + Convert.ToInt32(txtYatirilacakMiktar.Text);
                            dataGridViewHesapGoster.DataSource = null;
                            dataGridViewHesapGoster.DataSource = h;

                    }
                }
        }
    }
}
