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
    public partial class frmParaCekme : Form
    {
        public static List<Hesap> h;
        public frmParaCekme()
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
                if(m.hesapKapama)
                {
                    System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
                }

                else if(musterino == m.MusteriNo && hesapno == m.HesapNo)
                {
                    varmi = true;
                    h.Add(m);
                }
            }
            if(varmi)
            {
                dataGridViewHesapGoster.DataSource = null;
                dataGridViewHesapGoster.DataSource = h;
                lblCekilcekMiktar.Visible = true;
                txtCekilcekMiktar.Visible = true;
                btnParaCek.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
            }
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            decimal gider;
            decimal gelir;
            Banka b2 = new Banka();
            if (Convert.ToInt32(txtCekilcekMiktar.Text) > 750)
            {
                MessageBox.Show("Günlük para çekme limiti 750 tl'dir. Aşmayınız!");
            }
            else
            {
                foreach (var hesap in h)
                {
                    if (hesap.MusteriTipi == 0) //bireysel
                    {
                        if (hesap.HesapBakiye <= -1000)
                        {
                            MessageBox.Show("limit yok");
                        }
                        else
                        {
                           // b2.BankaGider= Convert.ToInt32(txtCekilcekMiktar.Text);
                            gider= Convert.ToInt32(txtCekilcekMiktar.Text);
                            gelir = 0;
                            b2.BankaGelirGiderRaporu(gelir, gider);
                            //b2.BankaGiderRaporu(gider);
                            hesap.HesapBakiye = hesap.HesapBakiye - Convert.ToInt32(txtCekilcekMiktar.Text);
                            dataGridViewHesapGoster.DataSource = null;
                            dataGridViewHesapGoster.DataSource = h;
                        }
                    }
                    else
                    {
                        if (hesap.HesapBakiye <= -3000)
                        {
                            MessageBox.Show("limit yok");
                        }
                        else
                        {
                            hesap.HesapBakiye = hesap.HesapBakiye - Convert.ToInt32(txtCekilcekMiktar.Text);
                            gider = Convert.ToInt32(txtCekilcekMiktar.Text);
                            gelir = 0;
                            b2.BankaGelirGiderRaporu(gelir, gider);
                            dataGridViewHesapGoster.DataSource = null;
                            dataGridViewHesapGoster.DataSource = h;
                        }

                    }
                }
            }
        }
             
    }
}
