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
    public partial class frmHesapÖzeti : Form
    {
        public static List<Hesap> h;
        public frmHesapÖzeti()
        {
            InitializeComponent();
        }

       
        private void btnHesapBul_Click(object sender, EventArgs e)
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
                dataGridViewHesapOzetiGoster.DataSource = null;
                dataGridViewHesapOzetiGoster.DataSource = h;
                lbl1.Visible = true;
                lblBaslangıçTarihi.Visible = true;
                lblBitisTarihi.Visible = true;
                dtmBaslangıçTarihi.Visible = true;
                dtmBitişTarihi.Visible = true;
                btnHesapOzetiGoster.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
            }

        }
        private void btnHesapOzetiGoster_Click(object sender, EventArgs e)
        {
            string BaslangıcTarihi = dtmBaslangıçTarihi.Value.ToShortDateString();
            string BitişTarihi = dtmBitişTarihi.Value.ToShortDateString();
             long musterino = Convert.ToInt32(txtMusteriNo.Text);
            long hesapno = Convert.ToInt32(txtHesapNo.Text);

            foreach (var hesap in h)
            {
                if (BaslangıcTarihi == hesap.IslemTarihi)
                {
                    dataGridViewHesapOzetiGoster.DataSource = null;
                    dataGridViewHesapOzetiGoster.DataSource = h;

                }
            }
        }

    }
  }
