using System;
using System.Collections.Generic;
using System.Text;

namespace hesaplama
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama Islem Sonuç : " + toplam);
        }
        public void Çıkart(int sayı1, int sayı2)
        {
            int toplam1 = sayı1 - sayı2;
            Console.WriteLine("Çıkartma Islem Sonuç :" + toplam1);

        }
        public void Çarp(int sayı1, int sayı2)
        {
            int toplam2 = sayı1 * sayı2;
            Console.WriteLine("Çarpma Islem Sonuç : " + toplam2);
        }
        public void Bölme(int sayı1, int sayı2)
        {
            int toplam3 = sayı1 / sayı2;
            Console.WriteLine("Bölme Islem Sonuç : " + toplam3);

        }
    }
}
