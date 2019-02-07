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
    public partial class frmBankaGelirGiderRaporu : Form
    {
        public frmBankaGelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void btnBankaGelirGiderRaporu_Click(object sender, EventArgs e)
        {
            Banka b = new Banka();
        
            dataGridViewBankaGiderRaporu.DataSource = null;
            dataGridViewBankaGiderRaporu.DataSource = b.BankaGider;
            dataGridViewBankaGelirRaporu.DataSource = null;
            dataGridViewBankaGelirRaporu.DataSource = b.BankaGelir;
            dataGridViewBankaGelirRaporu.DataSource = null;
            dataGridViewBankaGelirRaporu.DataSource = b;
           MessageBox.Show("gelir=" + b.BankaGelir + "\ngider=" + b.BankaGider);
        }
    }
}
