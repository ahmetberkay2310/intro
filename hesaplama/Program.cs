using System;

namespace hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Çıkart(22, 6);
            dortIslem.Çarp(111, 6);
            dortIslem.Bölme(112, 6);
        }
    }
}
