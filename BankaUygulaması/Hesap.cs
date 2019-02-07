using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    public class Hesap:Musteri
    {
        public long  HesapNo { get; private set; }
        public string IslemTarihi { get; set; }
        public Hesap()
        {
            Random r = new Random();
            this.HesapNo = r.Next(100000, 999999);
        }

      
        public decimal HesapBakiye { get; set; }
        

    }
}
