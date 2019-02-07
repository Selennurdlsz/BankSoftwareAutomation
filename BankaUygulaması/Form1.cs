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
    public partial class frmMSBank : Form
    {
        public Banka BankaApp;
        public frmMSBank()
        {
            InitializeComponent();
            BankaApp = new Banka();
        }

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriBilgileri mb = new frmMusteriBilgileri();
            mb.MdiParent = this;
            mb.Show();
        }

        private void hesapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapIslemleri hi = new frmHesapIslemleri();
            hi.MdiParent = this;
            hi.Show();
        }

        private void müşteriEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle me2 = new frmMusteriEkle();
            me2.MdiParent = this;
            me2.Show();
        }

        private void hesapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapEkle he2 = new frmHesapEkle();
            he2.MdiParent = this;
            he2.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaCekme pc = new frmParaCekme();
            pc.MdiParent = this;
            pc.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatirma py = new frmParaYatirma();
            py.MdiParent = this;
            py.Show();
        }

        private void hesapOzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapÖzeti ho = new frmHesapÖzeti();
            ho.MdiParent = this;
            ho.Show();
        }

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavaleYapma hy = new frmHavaleYapma();
            hy.MdiParent = this;
            hy.Show();

        }

        private void hesabıKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHesapKapatma hk = new frmHesapKapatma();
            hk.MdiParent = this;
            hk.Show();
        }

        private void bankaGelirGiderleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaGelirGiderRaporu bggr= new frmBankaGelirGiderRaporu();
            bggr.MdiParent = this;
            bggr.Show();
        }
    }
}
