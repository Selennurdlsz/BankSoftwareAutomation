using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    public class Banka
    {
        public decimal BankaGelir { get;  set; }
        public decimal BankaGider { get; set; }
        private List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri m)
        {
            Random n = new Random();
            m.MusteriNo = n.Next(1000, 9999);
            musteriler.Add(m);
        }

        public List<Musteri> MusteriListeler()
        {
            return musteriler;
        }

        public void BankaGelirGiderRaporu(decimal gelir,decimal gider)
        {
            this.BankaGelir = this.BankaGelir + gelir;
            this.BankaGider = -this.BankaGider - gider;
        }
    }
}
