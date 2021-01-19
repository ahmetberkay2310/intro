using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Kaydınız Oluşturuldu , Hoşgeldin : " + musteri.Adi );
        }

        public void Add2(string Adi, int Yas, string Meslek)
        {
            Console.WriteLine("Tebrikler Müşteri Kaydınız Oluşturuldu, Hoşgeldin: " + Adi );
        }

        



    }
}
