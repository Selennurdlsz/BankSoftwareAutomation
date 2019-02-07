using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankaUygulaması
{
    public class Musteri : Banka
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TCKimlikNo { get; set; }
        public long MusteriNo { get; set; }
        public int MusteriTipi { get; set; }
        public bool hesapKapama { get; private set; }

        private List<Hesap> hesaplar = new List<Hesap>();
   

        public List<Hesap> HesapListesi()
        {
            return hesaplar;
        }

        public void HesapEkle(Hesap h)
        {
            hesaplar.Add(h);
        }

        public void HesapKapat(long hNo)
        {
            hesapKapama = true;
        }

     

        public void ParaCekme()
          {

          }

          public void ParaYatırma()
          {

          }

          public void HavaleYapma()
          {

          }



          public void HesapOzet()
          {

          }
    }
}




