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
    public partial class frmHavaleYapma : Form
    {
        public static List<Hesap> h;
        public static List<Hesap> hy;
        public frmHavaleYapma()
        {
            InitializeComponent();
        }

        private void btnHavaleYapanHesapGoster_Click(object sender, EventArgs e)
        {

            h = new List<Hesap>();
            long hesapno = Convert.ToInt32(txtHavaleYapanHesapNo.Text);
            bool varmi = false;
            foreach (var m in frmMusteriEkle.m.HesapListesi())
            {
                if (m.hesapKapama)
                {
                    System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
                }
                else if (hesapno == m.HesapNo)
                {
                    varmi = true;
                    h.Add(m);
                }
            }
            if (varmi)
            {
                dataGridViewHavaleYapanHesapGoster.DataSource = null;
                dataGridViewHavaleYapanHesapGoster.DataSource = h;
                lblHavaleYapilanHesapno.Visible = true;
                txtHavaleYapilanHesapNo.Visible = true;
                btnHavaleYapilanHesapGoster.Visible = true;
                dataGridViewHavaleYapilanHesapGoster.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen hesap no bulunamadi!../nTekrar Deneyiniz.");
            }
        }

        private void btnHavaleYapilanHesapGoster_Click(object sender, EventArgs e)
        {
            hy = new List<Hesap>();
            long yapilanhesapno = Convert.ToInt32(txtHavaleYapilanHesapNo.Text);
            bool varmi = false;
            foreach (var m in frmMusteriEkle.m.HesapListesi())
            {
                if (m.hesapKapama)
                {
                    System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
                }
                else if (yapilanhesapno == m.HesapNo)
                {
                    varmi = true;
                    hy.Add(m);
                }
            }
            if (varmi)
            {
                dataGridViewHavaleYapilanHesapGoster.DataSource = null;
                dataGridViewHavaleYapilanHesapGoster.DataSource = hy;
                lblHavaleMiktari.Visible = true;
                txtHavaleMiktari.Visible = true;
                btnHavaleYap.Visible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girilen hesap no bulunamadi!../nTekrar Deneyiniz.");
            }
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            bool varmi2=false;
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
                        varmi2 = true;
                        hesap.HesapBakiye = hesap.HesapBakiye - Convert.ToInt32(txtHavaleMiktari.Text);
                        dataGridViewHavaleYapanHesapGoster.DataSource = null;
                        dataGridViewHavaleYapanHesapGoster.DataSource = h;
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
                        hesap.HesapBakiye = hesap.HesapBakiye - Convert.ToInt32(txtHavaleMiktari.Text);
                        dataGridViewHavaleYapanHesapGoster.DataSource = null;
                        dataGridViewHavaleYapanHesapGoster.DataSource = h;
                    }

                }

            }
            foreach (var hesap in hy)
            {
                if(varmi2)
                {
                    hesap.HesapBakiye = hesap.HesapBakiye + (Convert.ToInt32(txtHavaleMiktari.Text) - ((Convert.ToInt32(txtHavaleMiktari.Text) * 2) / 100));
                    dataGridViewHavaleYapilanHesapGoster.DataSource = null;
                    dataGridViewHavaleYapilanHesapGoster.DataSource = hy;
                }
                
                else
                {
                    hesap.HesapBakiye = hesap.HesapBakiye + Convert.ToInt32(txtHavaleMiktari.Text);
                    dataGridViewHavaleYapilanHesapGoster.DataSource = null;
                    dataGridViewHavaleYapilanHesapGoster.DataSource = hy;
                }
            }
        }
    }
}

