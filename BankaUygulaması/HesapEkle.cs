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
    public partial class frmHesapEkle : Form
    {
        public static Hesap h;
        public frmHesapEkle()
        {
            InitializeComponent();
        }
       

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            long girilenNo;
            string hesapTarihi;
            h = new Hesap();
            girilenNo = Convert.ToInt64(txtgirilenmn.Text);
            hesapTarihi = datetmHesapAcılısTarihi.Value.ToShortDateString();
            /*h.Ad = frmMusteriEkle.m.Ad;
            h.Soyad = frmMusteriEkle.m.Soyad;
            h.TCKimlikNo = frmMusteriEkle.m.TCKimlikNo;
            h.MusteriNo = frmMusteriEkle.m.MusteriNo;
            h.MusteriTipi = frmMusteriEkle.m.MusteriTipi;
            h.IslemTarihi = hesapTarihi;
            h.HesapBakiye = 0;*/
            bool varmi = false;
            foreach (var m in frmMusteriEkle.BankaApp.MusteriListeler())  
            { 
                if (girilenNo == m.MusteriNo)
                {
                    varmi = true;
                    h.Ad = m.Ad;
                    h.Soyad = m.Soyad;
                    h.TCKimlikNo = m.TCKimlikNo;
                    h.MusteriNo = m.MusteriNo;
                    h.MusteriTipi = m.MusteriTipi;
                    h.IslemTarihi = hesapTarihi;
                    h.HesapBakiye = 0;
                    frmMusteriEkle.m.HesapEkle(h);
                }
            }
            if(!varmi)
            {
                System.Windows.Forms.MessageBox.Show("Girilen müşteri no bulunamadi!../nTekrar Deneyiniz.");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = frmMusteriEkle.m.HesapListesi();
            }
        }
        }
    }

