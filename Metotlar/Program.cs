using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "amasya elması ";

            //string[] meyveler = new string[] { };

            Market market1 = new Market();
            market1.Adi = "Elma";
            market1.Fiyat = 12;
            market1.Aciklama = "amasya elması leziz";

            Market market2 = new Market();
            market2.Adi = "karpuz";
            market2.Fiyat = 9;
            market2.Aciklama = "dıyarbakır karpuzu";

            Market market3 = new Market();
            market3.Adi = "armut";
            market3.Fiyat = 23;
            market3.Aciklama = "sarı armut";

            Market[] marketler = new Market[] { market1, market2, market3 };
            foreach (var market in marketler)
            {
               Console.WriteLine(market.Adi);
               Console.WriteLine(market.Fiyat);
               Console.WriteLine(market.Aciklama);
            }

            //for (int i = 0; i <marketler.Length; i++)
            //{
            //    Console.WriteLine(marketler[i].Adi);
            //    Console.WriteLine(marketler[i].Fiyat);
            //    Console.WriteLine(marketler[i].Aciklama);
            //}

            Console.WriteLine("-----------metot-------------");

            MarketListesi marketListesi = new MarketListesi();

            marketListesi.ekle(market1);
            marketListesi.ekle(market2);

            marketListesi.ekle2("armut", "sarı armut", 23);
            marketListesi.ekle2("karpuz", "diyarbakır karpuzu", 9);
            marketListesi.ekle2("elma", "amasya elması", 12);



        }
    }
}

