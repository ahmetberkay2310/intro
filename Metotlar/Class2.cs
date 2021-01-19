using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class MarketListesi
    {
        public void ekle(Market market) 
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + market.Adi);
        }

        public void ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi  : " + urunAdi);
        }
    }
}
